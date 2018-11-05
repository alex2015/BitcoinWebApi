using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class BitcoinService : IBitcoinService
    {
        public bool UseTestnet { get; set; }
        public BitcoinParameters Parameters { get; }

        public BitcoinService(bool useTestnet)
        {
            Parameters = new BitcoinParameters(null, null, null, null, 0)
            {
                UseTestnet = useTestnet
            };
        }
    }
}
