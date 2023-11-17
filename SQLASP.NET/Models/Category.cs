namespace SQLASP.NET.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Works> Works { get; set; }
    }
}
