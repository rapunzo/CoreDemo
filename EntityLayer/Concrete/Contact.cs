namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
