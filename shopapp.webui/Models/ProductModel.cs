
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using shopapp.entity;

namespace shopapp.webui.Models{

    public class ProductModel{
        public int ProductId { get; set; }
        // [Display(Name ="Name",Prompt ="Enter product name")]
        // [Required(ErrorMessage ="Name zorunlu bir alan.")]
        // [StringLength(60,MinimumLength =5,ErrorMessage ="Urun ismi 5-10 karakter olmalidir.")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Name zorunlu bir alan.")]
        public string Url { get; set; }
        // [Required(ErrorMessage ="Url zorunlu bir alan.")]
        // [Range(1,100000,ErrorMessage ="Price icin 1-100000 arasinda bir deger girmelisiniz.")]
        public double? Price { get; set; }
        [Required(ErrorMessage ="Price zorunlu bir alan.")]
        public string Description { get; set; }
        [Required(ErrorMessage ="Description zorunlu bir alan.")]
        [StringLength(100,MinimumLength =5,ErrorMessage ="Urun ismi 5-100 karakter olmalidir.")]
        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public List<Category> SelectedCategories { get; set; }

    }

}