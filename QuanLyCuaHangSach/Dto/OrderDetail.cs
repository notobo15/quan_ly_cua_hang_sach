using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangSach.Dto
{
    internal class OrderDetail
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public BookDetail BookDetail { get; set; }
        public double Price { get; set; }
        public int BuyQuantity { get; set; }
        public bool IsdDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
