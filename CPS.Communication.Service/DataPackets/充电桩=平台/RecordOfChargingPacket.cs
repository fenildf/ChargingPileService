﻿using CPS.Infrastructure.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS.Communication.Service.DataPackets
{
    public class RecordOfChargingPacket : PacketBase
    {
        public RecordOfChargingPacket() : base(PacketTypeEnum.RecordOfCharging)
        {
            BodyLen = 1 + 8 + 1 + 16 + 4 + 4 + 4 + 4 + 4 + 4 + 4 + 4 + 4 + 2 + 4 + 4 + 4 + 4 + 4 + 2 + 4 + 4 + 4 + 4 + 4 + 2 + 4 + 4 + 4 + 4 + 4 + 2 + 4 + 2 + 1 + 1 + 1 + 4;
        }

        private byte _hasCard;

        public byte HasCard
        {
            get { return _hasCard; }
            set { _hasCard = value; }
        }

        private long _transactionSN;
        /// <summary>
        /// 交易流水号
        /// </summary>
        public long TransactionSN
        {
            get { return _transactionSN; }
            set { _transactionSN = value; }
        }

        private byte _qport;

        public byte QPort
        {
            get { return _qport; }
            set { _qport = value; }
        }

        private string _cardNo;

        public string CardNo
        {
            get { return _cardNo; }
            set { _cardNo = value; }
        }

        private int _beforeElec;

        public int BeforeElec
        {
            get { return _beforeElec; }
            set { _beforeElec = value; }
        }

        private int _afterElec;

        public int AfterElec
        {
            get { return _afterElec; }
            set { _afterElec = value; }
        }

        private int _costMoney;

        public int CostMoney
        {
            get { return _costMoney; }
            set { _costMoney = value; }
        }

        private int _serviceMoney;

        public int ServiceMoney
        {
            get { return _serviceMoney; }
            set { _serviceMoney = value; }
        }

        private int _sharpElecUnitPrice;

        public int SharpElecUnitPrice
        {
            get { return _sharpElecUnitPrice; }
            set { _sharpElecUnitPrice = value; }
        }

        private int _sharpServiceUnitPrice;

        public int SharpServiceUnitPrice
        {
            get { return _sharpServiceUnitPrice; }
            set { _sharpServiceUnitPrice = value; }
        }

        private int _sharpElec;

        public int SharpElec
        {
            get { return _sharpElec; }
            set { _sharpElec = value; }
        }

        private int _sharpCostMoney;

        public int SharpCostMoney
        {
            get { return _sharpCostMoney; }
            set { _sharpCostMoney = value; }
        }

        private int _sharpServiceMoney;

        public int SharpServiceMoney
        {
            get { return _sharpServiceMoney; }
            set { _sharpServiceMoney = value; }
        }

        private short _sharpTime;

        public short SharpTime
        {
            get { return _sharpTime; }
            set { _sharpTime = value; }
        }

        private int _peakElecUnitPrice;

        public int PeakElecUnitPrice
        {
            get { return _peakElecUnitPrice; }
            set { _peakElecUnitPrice = value; }
        }

        private int _peakServiceUnitPrice;

        public int PeakServiceUnitPrice
        {
            get { return _peakServiceUnitPrice; }
            set { _peakServiceUnitPrice = value; }
        }

        private int _peakElec;

        public int PeakElec
        {
            get { return _peakElec; }
            set { _peakElec = value; }
        }

        private int _peakCostMoney;

        public int PeakCostMoney
        {
            get { return _peakCostMoney; }
            set { _peakCostMoney = value; }
        }

        private int _peakServiceMoney;

        public int PeakServiceMoney
        {
            get { return _peakServiceMoney; }
            set { _peakServiceMoney = value; }
        }

        private short _peakTime;

        public short PeakTime
        {
            get { return _peakTime; }
            set { _peakTime = value; }
        }

        private int _flatElecUnitPrice;

        public int FlatElecUnitPrice
        {
            get { return _flatElecUnitPrice; }
            set { _flatElecUnitPrice = value; }
        }

        private int _flatServiceUnitPrice;

        public int FlatServiceUnitPrice
        {
            get { return _flatServiceUnitPrice; }
            set { _flatServiceUnitPrice = value; }
        }

        private int _flatElec;

        public int FlatElec
        {
            get { return _flatElec; }
            set { _flatElec = value; }
        }

        private int _flatCostMoney;

        public int FlatCostMoney
        {
            get { return _flatCostMoney; }
            set { _flatCostMoney = value; }
        }

        private int _flatServiceMoney;

        public int FlatServiceMoney
        {
            get { return _flatServiceMoney; }
            set { _flatServiceMoney = value; }
        }

        private int _flatTime;

        public int FlatTime
        {
            get { return _flatTime; }
            set { _flatTime = value; }
        }

        private int _valleyElecUnitPrice;

        public int ValleyElecUnitPrice
        {
            get { return _valleyElecUnitPrice; }
            set { _valleyElecUnitPrice = value; }
        }

        private int _valleyServiceUnitPrice;

        public int ValleyServiceUnitPrice
        {
            get { return _valleyServiceUnitPrice; }
            set { _valleyServiceUnitPrice = value; }
        }

        private int _valleyElec;

        public int ValleyElec
        {
            get { return _valleyElec; }
            set { _valleyElec = value; }
        }

        private int _valleyCostMoney;

        public int ValleyCostMoney
        {
            get { return _valleyCostMoney; }
            set { _valleyCostMoney = value; }
        }

        private int _valleyServiceMoney;

        public int ValleyServiceMoney
        {
            get { return _valleyServiceMoney; }
            set { _valleyServiceMoney = value; }
        }

        private short _valleyTime;

        public short ValleyTime
        {
            get { return _valleyTime; }
            set { _valleyTime = value; }
        }

        private int _startTime;

        public int StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }

        private short _costTime;

        public short CostTime
        {
            get { return _costTime; }
            set { _costTime = value; }
        }

        private byte _stopReason;

        public byte StopReason
        {
            get { return _stopReason; }
            set { _stopReason = value; }
        }

        private byte _soc;

        public byte SOC
        {
            get { return _soc; }
            set { _soc = value; }
        }

        private byte _state;

        public byte State
        {
            get { return _state; }
            set { _state = value; }
        }

        private int _stopTime;

        public int StopTime
        {
            get { return _stopTime; }
            set { _stopTime = value; }
        }

        public override byte[] EncodeBody()
        {
            byte[] body = base.EncodeBody();
            int start = SerialNumberLen;
            body[start] = this._hasCard;
            start += 1;
            byte[] temp = BitConverter.GetBytes(this._transactionSN);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 8;
            body[start] = this._qport;
            start += 1;
            temp = EncodeHelper.GetBytes(this._cardNo);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 16;
            temp = BitConverter.GetBytes(this._beforeElec);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 4;
            temp = BitConverter.GetBytes(this._afterElec);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 4;
            temp = BitConverter.GetBytes(this._costMoney);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 4;
            temp = BitConverter.GetBytes(this._serviceMoney);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 4;
            temp = BitConverter.GetBytes(this._sharpElecUnitPrice);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 4;
            temp = BitConverter.GetBytes(this._sharpServiceUnitPrice);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 4;
            temp = BitConverter.GetBytes(this._sharpElec);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 4;
            temp = BitConverter.GetBytes(this._sharpCostMoney);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 4;
            temp = BitConverter.GetBytes(this._sharpServiceMoney);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 4;
            temp = BitConverter.GetBytes(this._sharpTime);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 2;
            temp = BitConverter.GetBytes(this._peakElecUnitPrice);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 4;
            temp = BitConverter.GetBytes(this._peakServiceUnitPrice);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 4;
            temp = BitConverter.GetBytes(this._peakElec);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 4;
            temp = BitConverter.GetBytes(this._peakCostMoney);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 4;
            temp = BitConverter.GetBytes(this._peakServiceMoney);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 4;
            temp = BitConverter.GetBytes(this._peakTime);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 2;
            temp = BitConverter.GetBytes(this._flatElecUnitPrice);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 4;
            temp = BitConverter.GetBytes(this._flatServiceUnitPrice);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 4;
            temp = BitConverter.GetBytes(this._flatElec);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 4;
            temp = BitConverter.GetBytes(this._flatCostMoney);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 4;
            temp = BitConverter.GetBytes(this._flatServiceMoney);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 4;
            temp = BitConverter.GetBytes(this._flatTime);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 2;
            temp = BitConverter.GetBytes(this._valleyElecUnitPrice);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 4;
            temp = BitConverter.GetBytes(this._valleyServiceUnitPrice);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 4;
            temp = BitConverter.GetBytes(this._valleyElec);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 4;
            temp = BitConverter.GetBytes(this._valleyCostMoney);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 4;
            temp = BitConverter.GetBytes(this._valleyServiceMoney);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 4;
            temp = BitConverter.GetBytes(this._valleyTime);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 2;
            temp = BitConverter.GetBytes(this._startTime);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 4;
            temp = BitConverter.GetBytes(this._costTime);
            Array.Copy(temp, 0, body, start, temp.Length);
            start += 2;
            body[start] = this._stopReason;
            start += 1;
            body[start] = this._soc;
            start += 1;
            body[start] = this._state;
            start += 1;
            temp = BitConverter.GetBytes(this._stopTime);
            Array.Copy(temp, 0, body, start, temp.Length);
            return body;
        }

        public override PacketBase DecodeBody(byte[] buffer)
        {
            base.DecodeBody(buffer);
            int start = SerialNumberLen;
            this._hasCard = buffer[start];
            start += 1;
            this._transactionSN = BitConverter.ToInt64(buffer, start);
            start += 8;
            this._qport = buffer[start];
            start += 1;
            this._cardNo = EncodeHelper.GetString(buffer, start, 16);
            start += 16;
            this._beforeElec = BitConverter.ToInt32(buffer, start);
            start += 4;
            this._afterElec = BitConverter.ToInt32(buffer, start);
            start += 4;
            this._costMoney = BitConverter.ToInt32(buffer, start);
            start += 4;
            this._serviceMoney = BitConverter.ToInt32(buffer, start);
            start += 4;

            this._sharpElecUnitPrice = BitConverter.ToInt32(buffer, start);
            start += 4;
            this._sharpServiceUnitPrice = BitConverter.ToInt32(buffer, start);
            start += 4;
            this._sharpElec = BitConverter.ToInt32(buffer, start);
            start += 4;
            this._sharpCostMoney = BitConverter.ToInt32(buffer, start);
            start += 4;
            this._sharpServiceMoney = BitConverter.ToInt32(buffer, start);
            start += 4;
            this._sharpTime = BitConverter.ToInt16(buffer, start);
            start += 2;

            this._peakElecUnitPrice = BitConverter.ToInt32(buffer, start);
            start += 4;
            this._peakServiceMoney = BitConverter.ToInt32(buffer, start);
            start += 4;
            this._peakElec = BitConverter.ToInt32(buffer, start);
            start += 4;
            this._peakCostMoney = BitConverter.ToInt32(buffer, start);
            start += 4;
            this._peakServiceMoney = BitConverter.ToInt32(buffer, start);
            start += 4;
            this._peakTime = BitConverter.ToInt16(buffer, start);
            start += 2;

            this._flatElecUnitPrice = BitConverter.ToInt32(buffer, start);
            start += 4;
            this._flatServiceUnitPrice = BitConverter.ToInt32(buffer, start);
            start += 4;
            this._flatElec = BitConverter.ToInt32(buffer, start);
            start += 4;
            this._flatCostMoney = BitConverter.ToInt32(buffer, start);
            start += 4;
            this._flatServiceMoney = BitConverter.ToInt32(buffer, start);
            start += 4;
            this._flatTime = BitConverter.ToInt16(buffer, start);
            start += 2;

            this._valleyElecUnitPrice = BitConverter.ToInt32(buffer, start);
            start += 4;
            this._valleyServiceUnitPrice = BitConverter.ToInt32(buffer, start);
            start += 4;
            this._valleyElec = BitConverter.ToInt32(buffer, start);
            start += 4;
            this._valleyCostMoney = BitConverter.ToInt32(buffer, start);
            start += 4;
            this._valleyServiceMoney = BitConverter.ToInt32(buffer, start);
            start += 4;
            this._valleyTime = BitConverter.ToInt16(buffer, start);
            start += 2;
            this._startTime = BitConverter.ToInt32(buffer, start);
            start += 4;
            this._costTime = BitConverter.ToInt16(buffer, start);
            start += 2;
            this._stopReason = buffer[start];
            start += 1;
            this._soc = buffer[start];
            start += 1;
            this._state = buffer[start];
            start += 1;
            this._stopTime = BitConverter.ToInt32(buffer, start);

            return this;
        }
    }
}
