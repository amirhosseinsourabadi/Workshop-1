namespace Workshop_1.Models
{

    public class Transaction
    {
        public int reciverId { get; set; }
        public int giverId { get; set; }
        public int id { get; set; }
        public bool status { get; set; }
        public TransactionType type { get; set; }

    }
}
