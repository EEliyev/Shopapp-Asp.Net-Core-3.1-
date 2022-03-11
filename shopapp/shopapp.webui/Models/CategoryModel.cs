using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using shopapp.entity;

namespace shopapp.webui.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="Name zorunludur")]
        [StringLength(100,MinimumLength =5,ErrorMessage ="Kategori icin 5-100 arasi bir karrakter girin")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Url zorunludur")]
        [StringLength(100,MinimumLength =5,ErrorMessage ="Url icin 5-100 arasi bir karrakter girin")]
        public string Url { get; set; }
        public List<Product> Products { get; set; }
    }
}