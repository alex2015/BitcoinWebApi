using System.Collections.Generic;

namespace Lib.Responses
{
    public class GetAddedNodeInfoResponse
    {
        public string AddedNode { get; set; }
        public bool Connected { get; set; }
        public List<NodeAddress> Addresses { get; set; }
    }

    public class NodeAddress
    {
        public string Address { get; set; }
        public bool Connected { get; set; }
    }
}