using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Responses.SharedComponents
{
    public class Vout
    {
        public decimal Value { get; set; }
        public int N { get; set; }
        public ScriptPubKey ScriptPubKey { get; set; }
    }

    public class ScriptPubKey
    {
        public string Asm { get; set; }
        public string Hex { get; set; }
        public int ReqSigs { get; set; }
        public string Type { get; set; }
        public List<string> Addresses { get; set; }
    }
}
