namespace Lib.Responses
{
    public class GetNetTotalsResponse
    {
        public ulong TotalBytesRecv { get; set; }
        public ulong TotalBytesSent { get; set; }
        public ulong TimeMillis { get; set; }
    }
}