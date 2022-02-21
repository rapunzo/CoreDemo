namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Status { get; set; }

        public virtual int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
