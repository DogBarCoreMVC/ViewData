using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ViewData.Models
{
    public class Product
    {
        [Key]
        [Display(Name = "ลำดับสินค้า")]
        public int ID { get; set; }

        [Display(Name = "ชื่อสินค้า")]
        public string Name { get; set; }

        [Display(Name = "ราคาสินค้า")]
        public decimal Price { get; set; }
    }
}
