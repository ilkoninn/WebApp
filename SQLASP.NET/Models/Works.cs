namespace SQLASP.NET.Models
{
    public class Works
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDesc { get; set; }
        public string LongDesc { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<WorkImages> WorkImages { get; set; } 
    }
}
