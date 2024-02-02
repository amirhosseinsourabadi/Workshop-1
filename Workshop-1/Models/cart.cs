namespace Workshop_1.Models
{
    public class cart
    {
        public string number { get; set; }
        public string cvv2 { get; set; }
        public string exMonth { get; set; }
        public string exYear { get; set; }
        public int cash { get; set; }
        public int idOfOwner { get; set; }

        //must have Id every entity
        public int id { get; set; }
    }
}
