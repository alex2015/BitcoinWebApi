using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Responses.SharedComponents
{
    public class Vin
    {
        public string TxId { get; set; }
        public string Vout { get; set; }
        public ScriptSig ScriptSig { get; set; }
        public string CoinBase { get; set; }
        public string Sequence { get; set; }
    }

    public class ScriptSig
    {
        public string Asm { get; set; }
        public string Hex { get; set; }
    }
}
