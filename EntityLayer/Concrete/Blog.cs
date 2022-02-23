namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Status { get; set; }
        public string Image { get; set; }

        public virtual int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        
        public virtual int? WriterId { get; set; }
        public virtual Writer Writer { get; set; }

        public virtual List<Comment> Comments { get; set; }
    }
}
