using Microsoft.EntityFrameworkCore;
using shopapp.entity;

namespace shopapp.data.Configurations
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product(){ProductId=1, Name="Iphone 7",Url="iphone-7", Price=1000,ImageUrl="Iphone7.png",Description="New",IsApproved=true},
                new Product(){ProductId=2,Name="Iphone 8",Url="iphone-8", Price=1500,ImageUrl="Iphone8.jpg",Description="New",IsApproved=true},
                new Product(){ProductId=3,Name="Iphone X",Url="iphone-X", Price=2000,ImageUrl="IphoneX.jpg",Description="New",IsApproved=true},
                new Product(){ProductId=4,Name="Iphone 13",Url="iphone-13", Price=2500,ImageUrl="Iphone13.jpg",Description="New",IsApproved=true},
                new Product(){ProductId=5,Name="Iphone 13 Blue",Url="iphone-13blue", Price=2500,ImageUrl="Iphone13blue.jpg",Description="New",IsApproved=true},
                new Product(){ProductId=6,Name="Samsung Note 10",Url="samsung-note10", Price=3000,ImageUrl="SamsungNote.jpg",Description="New",IsApproved=true},
                new Product(){ProductId=7,Name="Xperia",Url="xperia", Price=1500,ImageUrl="Xperia.jpg",Description="New",IsApproved=true},
                new Product(){ProductId=8,Name="Asus Rog",Url="asus-rog", Price=5000,ImageUrl="Asus Rog.jpg",Description="New",IsApproved=true},
                new Product(){ProductId=9,Name="Asus Strix",Url="asus-strix", Price=1500,ImageUrl="Asus Strix.jpg",Description="New",IsApproved=true},
                new Product(){ProductId=10,Name="Ps4 Pro",Url="ps4", Price=1500,ImageUrl="Ps4.jpg",Description="New",IsApproved=true},
                new Product(){ProductId=11,Name="Ps5",Url="ps5", Price=2000,ImageUrl="Ps5.jpg",Description="New",IsApproved=true}
                
            );
            modelBuilder.Entity<Category>().HasData(
                new Category(){CategoryId=1, Name="Phone",Url="phone"},
                new Category(){CategoryId=2,Name="Computer",Url="computer"},
                new Category(){CategoryId=3,Name="Console",Url="console"},
                new Category(){CategoryId=4,Name="Electronics",Url="electronic"},
                new Category(){CategoryId=5,Name="Household equipments",Url="household-equipment"}
            );
            modelBuilder.Entity<ProductCategory>().HasData(
                new ProductCategory(){ProductId=1,CategoryId=1},
                new ProductCategory(){ProductId=2,CategoryId=1},
                new ProductCategory(){ProductId=3,CategoryId=1},
                new ProductCategory(){ProductId=4,CategoryId=1},
                new ProductCategory(){ProductId=5,CategoryId=1},
                new ProductCategory(){ProductId=6,CategoryId=1},
                new ProductCategory(){ProductId=7,CategoryId=1},
                new ProductCategory(){ProductId=8,CategoryId=2},
                new ProductCategory(){ProductId=9,CategoryId=2},
                new ProductCategory(){ProductId=10,CategoryId=3},
                new ProductCategory(){ProductId=11,CategoryId=3}
            

            );
            
        }
    }
}