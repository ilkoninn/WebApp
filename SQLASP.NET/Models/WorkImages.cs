namespace SQLASP.NET.Models
{
    public class WorkImages
    {
        public int Id { get; set; }
        public string ImgUrl { get; set; }
        public int WorkId { get; set; }
        public Works Work { get; set; }
    }
}
