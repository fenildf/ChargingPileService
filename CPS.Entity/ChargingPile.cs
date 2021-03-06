﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS.Entities
{
    /// <summary>
    /// 充电桩
    /// </summary>
    [Serializable]
    public class ChargingPile : EntityBase
    {
        private string stationId;
        private string name;
        private string serialNumber;
        private string category;
        private double power;
        private string status = "在线";
        private double price;

        /// <summary>
        /// 电站Id
        /// </summary>
        [StringLength(50)]
        [Required]
        public string StationId
        {
            get { return stationId; }
            set { stationId = value; }
        }
        /// <summary>
        /// 名称
        /// </summary>
        [StringLength(50)]
        [Required]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// 序列号
        /// </summary>
        [StringLength(50)]
        [Required]
        public string SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }
        /// <summary>
        /// 类型
        /// </summary>
        [StringLength(20)]
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        /// <summary>
        /// 功率
        /// </summary>
        public double Power
        {
            get { return power; }
            set { power = value; }
        }
        /// <summary>
        /// 状态（在线、离线、空闲、忙时等）
        /// </summary>
        [StringLength(20)]
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        /// <summary>
        /// 电价
        /// </summary>
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
