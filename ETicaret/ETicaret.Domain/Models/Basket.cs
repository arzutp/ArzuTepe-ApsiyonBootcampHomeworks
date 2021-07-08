using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Domain.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public virtual ICollection<BasketItem> Items { get; set; }
    }

    public class BasketItem
    {
        public int Id { get; set; }
        public virtual Basket Basket { get; set; }
        public virtual Product Product { get; set; }
        public int Piece { get; set; }
    }
}
