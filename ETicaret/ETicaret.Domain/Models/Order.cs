using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        public DateTime CreatedAt { get; set; }
        public int TotalPrice { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public string Address { get; set; }
    }

    public class OrderItem
    {
        public int Id { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
        public int Piece { get; set; }
    }
}
