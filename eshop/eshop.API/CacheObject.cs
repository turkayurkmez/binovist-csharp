using eshop.Domains.Entities;

namespace eshop.API
{
    public class CacheObject
    {
        public DateTime CacheDate { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
