﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payments_API.Models
{
    public class CardPayment
    {
        public decimal Amount { get; set; }
        public string CardNumber { get; set; }
        public string Name { get; set; }
    }
}
