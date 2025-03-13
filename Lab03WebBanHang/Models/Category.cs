﻿using System.ComponentModel.DataAnnotations;

namespace TranTrungDung_2280600423_Lab03WebBanHang.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        public List<Product>? Products { get; set; }
    }
}
