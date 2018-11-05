﻿using System.Collections.Generic;

namespace Lib.Responses
{
    public class EstimateSmartFeeResponse
    {
        public decimal? FeeRate { get; set; }
        public uint? Blocks { get; set; }
        public IList<string> Errors { get; set; }
    }
}
