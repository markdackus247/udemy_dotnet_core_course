namespace Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string secret { get; set; }
        public bool active { get; set; }
        public DateTime created { get; set; }
        public DateTime updated { get; set; }
    }
}