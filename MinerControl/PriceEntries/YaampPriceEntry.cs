﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinerControl.PriceEntries
{
    public class YaampPriceEntry : PriceEntryBase
    {
        public decimal FeePercent { get; set; }

        public override decimal Fees
        {
            get { return Earn * (FeePercent / 100); }
            set { base.Fees = value; }
        }
    }
}
