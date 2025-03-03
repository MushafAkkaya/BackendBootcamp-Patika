namespace PatikaBlog.Models
{
    public class Post
    {
        public int Id { get; set; } // 1
        public string Title { get; set; } // Süt ürünleri zararlı mı ?
        public string Content { get; set; } // .........

        public int CategoryId { get; set; } // 4
    }
}
