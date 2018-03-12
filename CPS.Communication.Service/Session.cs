﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using CPS.Communication.Service.DataPackets;

namespace CPS.Communication.Service
{
    public delegate bool SessionCompletedCallback(Client client, object result, bool state);

    internal class Session
    {
        public string Id { get; private set; }
        public Client MyClient { get; set; }
        public OperPacketBase MyPacket { get; set; }
        public bool IsCompleted { get; set; }
        public object Result { get; set; }
        public DateTime StartDate { get; set; }
        public int Timeout { get; set; } = 10 * 1000;

        public Session(string id, Client client, OperPacketBase packet)
        {
            Id = id;
            MyClient = client;
            MyPacket = packet;
        }

        public bool IsMatch(Client client, OperPacketBase packet)
        {
            if (client == null || packet == null)
                return false;

            if (!MyClient.Equals(client))
                return false;

            if (packet.SerialNumber != MyPacket.SerialNumber)
                return false;

            switch (MyPacket.Command)
            {
                case PacketTypeEnum.Login:
                    break;
                case PacketTypeEnum.LoginResult:
                    break;
                case PacketTypeEnum.Reboot:
                    {
                        if (packet.Command == PacketTypeEnum.RebootResult && packet.OperType == MyPacket.OperType)
                            return true;
                    }
                    break;
                case PacketTypeEnum.SetElecPrice:
                case PacketTypeEnum.SetServicePrice:
                case PacketTypeEnum.SetReportInterval:
                case PacketTypeEnum.SetTimePeriod:
                case PacketTypeEnum.SetSecretKey:
                case PacketTypeEnum.SetQRcode:
                    {
                        if (packet.Command == PacketTypeEnum.Confirm || packet.Command == PacketTypeEnum.Deny)
                            if (packet.OperType == MyPacket.OperType)
                                return true;
                    }
                    break;
                case PacketTypeEnum.GetElecPrice:
                    {
                        if (packet.Command == PacketTypeEnum.GetElecPriceResult)
                            if (packet.OperType == MyPacket.OperType)
                                return true;
                    }
                    break;
                case PacketTypeEnum.GetServicePrice:
                    {
                        if (packet.Command == PacketTypeEnum.GetServicePriceResult)
                            if (packet.OperType == MyPacket.OperType)
                                return true;
                    }
                    break;
                case PacketTypeEnum.GetReportInterval:
                    {
                        if (packet.Command == PacketTypeEnum.GetReportIntervalResult)
                            if (packet.OperType == MyPacket.OperType)
                                return true;
                    }
                    break;
                case PacketTypeEnum.GetTimePeriod:
                    {
                        if (packet.Command == PacketTypeEnum.GetTimePeriodResult)
                            if (packet.OperType == MyPacket.OperType)
                                return true;
                    }
                    break;
                case PacketTypeEnum.GetSecretKey:
                    {
                        if (packet.Command == PacketTypeEnum.GetSecretKeyResult)
                            if (packet.OperType == MyPacket.OperType)
                                return true;
                    }
                    break;
                case PacketTypeEnum.GetSoftwareVer:
                    {
                        if (packet.Command == PacketTypeEnum.GetSoftwareVerResult)
                            if (packet.OperType == MyPacket.OperType)
                                return true;
                    }
                    break;
                case PacketTypeEnum.GetQRcode:
                    {
                        if (packet.Command == PacketTypeEnum.GetQRcodeResult)
                            if (packet.OperType == MyPacket.OperType)
                                return true;
                    }
                    break;
                case PacketTypeEnum.ChargingPileState:
                    break;
                case PacketTypeEnum.GetChargingPileState:
                    {
                        if (packet.Command == PacketTypeEnum.ChargingPileState)
                            if (packet.OperType == MyPacket.OperType)
                                return true;
                    }
                    break;
                case PacketTypeEnum.SetCharging:
                    {
                        // 无卡启停充电，需要操作ID、交易流水号、接口和操作都匹配。
                        // 避免不同接口、不同操作、不同交易间相互干扰。
                        if (packet.Command == PacketTypeEnum.SetChargingResult)
                            if (packet.OperType == MyPacket.OperType)
                            {
                                var packet1 = MyPacket as SetChargingPacket;
                                var packet2 = packet as SetChargingResultPacket;
                                if (packet1 != null
                                    && packet2 != null 
                                    && packet1.TransactionSN == packet2.TransactionSN
                                    && packet1.Action == packet2.Action
                                    && packet1.QPort == packet2.QPort)
                                    return true;
                            }
                    }
                    break;
                case PacketTypeEnum.RealDataOfCharging:
                    break;
                case PacketTypeEnum.RecordOfCharging:
                    break;
                case PacketTypeEnum.ConfirmRecordOfCharging:
                    break;
                case PacketTypeEnum.GetRecordOfCharging:
                    {
                        if (packet.Command == PacketTypeEnum.RecordOfCharging)
                        {
                            var packet1 = MyPacket as GetRecordOfChargingPacket;
                            var packet2 = packet as RecordOfChargingPacket;
                            if (packet1 != null
                                && packet2 != null
                                && packet1.TransactionSN == packet2.TransactionSN)
                                return true;
                        }
                    }
                    break;
                case PacketTypeEnum.FaultMessage:
                    break;
                case PacketTypeEnum.FaultMessageReply:
                    break;
                case PacketTypeEnum.WarnMessage:
                    break;
                case PacketTypeEnum.WarnMessageReply:
                    break;
                case PacketTypeEnum.StartChargingWithCard:
                    break;
                case PacketTypeEnum.StartChargingWithCardReply:
                    break;
                case PacketTypeEnum.StartChargingWithCardResult:
                    break;
                case PacketTypeEnum.StartChargingWithCardResultReply:
                    break;
                case PacketTypeEnum.RealDataOfChargingWithCard:
                    break;
                case PacketTypeEnum.StopChargingWithCard:
                    break;
                case PacketTypeEnum.StopChargingWithCardReply:
                    break;
                case PacketTypeEnum.SetBlacklist:
                    break;
                case PacketTypeEnum.SetBlacklistResult:
                    break;
                case PacketTypeEnum.SetWhitelist:
                    break;
                case PacketTypeEnum.SetWhitelistResult:
                    break;
                case PacketTypeEnum.GetBlacklist:
                    break;
                case PacketTypeEnum.GetBlacklistResult:
                    break;
                case PacketTypeEnum.GetWhitelist:
                    break;
                case PacketTypeEnum.GetWhitelistResult:
                    break;
                case PacketTypeEnum.UpgradeSoftware:
                    break;
                case PacketTypeEnum.UpgradeSoftwareReply:
                    break;
                case PacketTypeEnum.DownloadFinished:
                    break;
                case PacketTypeEnum.DownloadFinishedReply:
                    break;
                case PacketTypeEnum.InUpgradeState:
                    break;
                case PacketTypeEnum.InUpgradeStateReply:
                    break;
                case PacketTypeEnum.UpgradeResult:
                    break;
                case PacketTypeEnum.UpgradeResultReply:
                    break;
                default:
                    break;
            }
            return false;
        }
    }

    internal class SessionCollection : IEnumerable<Session>
    {
        private List<Session> _sessions;
        public List<Session> Sessions
        {
            get { return _sessions; }
            set { _sessions = value; }
        }

        private AutoResetEvent _arEvent = new AutoResetEvent(true);

        private Timer _timer = null;
        public SessionCollection()
        {
            _sessions = new List<Session>();

            _timer = new Timer((state)=>
            {
                var now = DateTime.Now;
                _arEvent.Reset();
                this._sessions.RemoveAll(_ => (now - _.StartDate).TotalMilliseconds > _.Timeout);
                _arEvent.Set();
            }, null, 5000, 300*1000);
        }

        public int Count
        {
            get
            {
                return this._sessions.Count;
            }
        }

        public void AddSession(Session session)
        {
            _arEvent.Reset();

            this._sessions.Add(session);

            _arEvent.Set();
        }

        public void RemoveSession(Session session)
        {
            _arEvent.Reset();

            this._sessions.Remove(session);

            _arEvent.Set();
        }

        public Session MatchSession(Client client, OperPacketBase packet)
        {
            List<Session> list = new List<Session>();
            for (int i = 0; i < _sessions.Count; i++)
            {
                var item = this._sessions[i];
                if (item.IsMatch(client, packet))
                    list.Add(item);
            }
            if (list.Count <= 0)
                return null;
            else
                return list[list.Count - 1];
        }

        public void Clear()
        {
            this._sessions.Clear();
        }

        public IEnumerator<Session> GetEnumerator()
        {
            return _sessions.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _sessions.GetEnumerator();
        }
    }
}
