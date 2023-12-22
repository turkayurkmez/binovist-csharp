using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Domains.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }

        public DateTime CreatedDste { get; set; }
        public DateTime UpdatedDste { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }

    }
}
