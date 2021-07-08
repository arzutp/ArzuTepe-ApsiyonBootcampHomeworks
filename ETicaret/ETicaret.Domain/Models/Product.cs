using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public virtual Category Category { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }

        public string Brand { get; set; }
        public string ImageUrl { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
