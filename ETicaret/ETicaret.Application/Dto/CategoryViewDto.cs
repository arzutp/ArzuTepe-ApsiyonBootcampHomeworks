using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Dto
{
    public class CategoryViewDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Ana kategori
        /// </summary>
        public CategoryViewDto ParentCategory { get; set; }
        /// <summary>
        /// Alt kategoriler
        /// </summary>
        public ICollection<CategoryViewDto> SubCategories { get; set; }
    }
}
