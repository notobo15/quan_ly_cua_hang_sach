using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangSach.Dto
{
    public class BookDetail
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public double Price { get; set; }
        public Book Book { get; set; }
       
        public Supplier Supplier { get; set; }
        public bool IsdDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
