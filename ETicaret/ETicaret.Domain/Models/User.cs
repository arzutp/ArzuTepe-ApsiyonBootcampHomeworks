
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Domain.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Favorite> Favorites { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public int BasketId { get; set; }
        [ForeignKey("BasketId")]
        public virtual Basket Basket { get; set; }
    }
}
