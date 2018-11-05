namespace Lib.Responses
{
    public class ListReceivedByAccountResponse
    {
        public string Account { get; set; }
        public double Amount { get; set; }
        public int Confirmations { get; set; }
        public string Label { get; set; }
    }
}