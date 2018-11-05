using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Lib
{
    public class JsonRpcResponse<T>
    {
        [JsonProperty(PropertyName = "result", Order = 0)]
        public T Result { get; set; }

        [JsonProperty(PropertyName = "id", Order = 1)]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "error", Order = 2)]
        public JsonRpcError Error { get; set; }
    }
}
