﻿using System.Collections.Generic;
using Lib.Responses.Bridges;
using Lib.Responses.SharedComponents;

namespace Lib.Responses
{
    public class GetRawTransactionResponse : ITransactionResponse
    {
        public string Hex { get; set; }
        public long Version { get; set; }
        public uint LockTime { get; set; }
        public List<Vin> Vin { get; set; }
        public List<Vout> Vout { get; set; }
        public string BlockHash { get; set; }
        public int Confirmations { get; set; }
        public uint Time { get; set; }
        public uint BlockTime { get; set; }
        public string TxId { get; set; }
    }
}