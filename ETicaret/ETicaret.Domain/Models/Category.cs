using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Domain.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Ana kategori
        /// </summary>
        public virtual Category ParentCategory { get; set; }
        /// <summary>
        /// Alt kategoriler
        /// </summary>
        public virtual ICollection<Category> SubCategories { get; set; }
    }

   // ----kadın giyim
   //     ---dış giyim
   //        --etek
   //          --koton
   //---erkek giiym
   //---çocuk giyim
}
