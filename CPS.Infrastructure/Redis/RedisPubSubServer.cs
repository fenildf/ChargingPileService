﻿using CSRedis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CPS.Infrastructure.Redis
{
    public class RedisPubSubServer : IDisposable
    {
        private bool _disposed = false;
        private RedisClient _redisClient;
        private string[] _channel;
        private Action<string, string> _onMessage;

        public RedisPubSubServer(RedisClient client, string[] channel, Action<string, string> onMessage)
        {
            _redisClient = client;
            _channel = channel;
            this._onMessage = onMessage;
        }

        public void Start()
        {
            _redisClient.SubscriptionChanged += (sender, args) => Console.WriteLine($"Channel name:{args.Response.Channel}, Active subscriptions:{args.Response.Count}");
            _redisClient.SubscriptionReceived += _redisClient_SubscriptionReceived;
            Task.Run(() => _redisClient.Subscribe(_channel));
        }

        private void _redisClient_SubscriptionReceived(object sender, RedisSubscriptionReceivedEventArgs e)
        {
            this._onMessage?.Invoke(e.Message.Channel, e.Message.Body);
        }

        public void Stop()
        {
            if (_redisClient != null)
            {
                Task.Run(() =>
                {
                    _redisClient.Unsubscribe(_channel);
                    _redisClient.SubscriptionReceived -= _redisClient_SubscriptionReceived;
                });
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
            GC.Collect();
        }

        private void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    Stop();
                    _redisClient?.Dispose(); 
                }
                _redisClient = null;
                _disposed = true;
            }
        }
    }
}
