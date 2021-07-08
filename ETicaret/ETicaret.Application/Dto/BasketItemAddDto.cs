using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Dto
{
    public class BasketItemAddDto
    {
        public int ProductId { get; set; }
        public int Piece { get; set; }
    }

    public class BasketItemUpdateDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Piece { get; set; }
    }

    public class BasketItemViewDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }
        public int Piece { get; set; }

        public float Total => Price * Piece;

    }
}
