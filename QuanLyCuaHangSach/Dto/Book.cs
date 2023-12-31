﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyCuaHangSach.Dto
{
    public class Book
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public DateTime PublicationDate { get; set; }
        public int TotalPage { get; set; }
        public string Format { get; set; }
        public string Quantity { get; set; }
        public string Language { get; set; }
        public Category Category { get; set; }
        public Publisher Publisher { get; set; }
        public string AuthorId { get; set; }

        public Discount Discount { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
