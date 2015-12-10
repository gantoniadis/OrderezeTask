using System.Data.Entity;
namespace WingtipToys.Models
{
    public class ImageContext : DbContext
    {
        public ImageContext(): base("WingtipToys")
        {
        }
        
        public DbSet<Image> Images { get; set; }
    }
}