﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS.Entities
{
    public class Wallet : EntityBase
    {
        private string userId;
        private double remaining=0.0;

        [Required]
        [StringLength(50)]
        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        /// <summary>
        /// 余额
        /// </summary>
        public double Remaining
        {
            get { return remaining; }
            set { remaining = value; }
        }
    }
}
