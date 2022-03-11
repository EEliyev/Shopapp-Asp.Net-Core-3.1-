﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using shopapp.data.Concrete.EfCore;

namespace shopapp.data.Migrations
{
    [DbContext(typeof(ShopContext))]
    partial class ShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.20");

            modelBuilder.Entity("shopapp.entity.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("shopapp.entity.CardItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("ProductId");

                    b.ToTable("CardItems");
                });

            modelBuilder.Entity("shopapp.entity.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Phone",
                            Url = "phone"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Computer",
                            Url = "computer"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Console",
                            Url = "console"
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "Electronics",
                            Url = "electronic"
                        },
                        new
                        {
                            CategoryId = 5,
                            Name = "Household equipments",
                            Url = "household-equipment"
                        });
                });

            modelBuilder.Entity("shopapp.entity.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConversationId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Note")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrderNumber")
                        .HasColumnType("TEXT");

                    b.Property<int>("OrderState")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PaymentId")
                        .HasColumnType("TEXT");

                    b.Property<int>("PaymentType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("shopapp.entity.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("shopapp.entity.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateAdded")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("date('now')");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsHome")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<double?>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "New",
                            ImageUrl = "Iphone7.png",
                            IsApproved = true,
                            IsHome = false,
                            Name = "Iphone 7",
                            Price = 1000.0,
                            Url = "iphone-7"
                        },
                        new
                        {
                            ProductId = 2,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "New",
                            ImageUrl = "Iphone8.jpg",
                            IsApproved = true,
                            IsHome = false,
                            Name = "Iphone 8",
                            Price = 1500.0,
                            Url = "iphone-8"
                        },
                        new
                        {
                            ProductId = 3,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "New",
                            ImageUrl = "IphoneX.jpg",
                            IsApproved = true,
                            IsHome = false,
                            Name = "Iphone X",
                            Price = 2000.0,
                            Url = "iphone-X"
                        },
                        new
                        {
                            ProductId = 4,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "New",
                            ImageUrl = "Iphone13.jpg",
                            IsApproved = true,
                            IsHome = false,
                            Name = "Iphone 13",
                            Price = 2500.0,
                            Url = "iphone-13"
                        },
                        new
                        {
                            ProductId = 5,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "New",
                            ImageUrl = "Iphone13blue.jpg",
                            IsApproved = true,
                            IsHome = false,
                            Name = "Iphone 13 Blue",
                            Price = 2500.0,
                            Url = "iphone-13blue"
                        },
                        new
                        {
                            ProductId = 6,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "New",
                            ImageUrl = "SamsungNote.jpg",
                            IsApproved = true,
                            IsHome = false,
                            Name = "Samsung Note 10",
                            Price = 3000.0,
                            Url = "samsung-note10"
                        },
                        new
                        {
                            ProductId = 7,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "New",
                            ImageUrl = "Xperia.jpg",
                            IsApproved = true,
                            IsHome = false,
                            Name = "Xperia",
                            Price = 1500.0,
                            Url = "xperia"
                        },
                        new
                        {
                            ProductId = 8,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "New",
                            ImageUrl = "Asus Rog.jpg",
                            IsApproved = true,
                            IsHome = false,
                            Name = "Asus Rog",
                            Price = 5000.0,
                            Url = "asus-rog"
                        },
                        new
                        {
                            ProductId = 9,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "New",
                            ImageUrl = "Asus Strix.jpg",
                            IsApproved = true,
                            IsHome = false,
                            Name = "Asus Strix",
                            Price = 1500.0,
                            Url = "asus-strix"
                        },
                        new
                        {
                            ProductId = 10,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "New",
                            ImageUrl = "Ps4.jpg",
                            IsApproved = true,
                            IsHome = false,
                            Name = "Ps4 Pro",
                            Price = 1500.0,
                            Url = "ps4"
                        },
                        new
                        {
                            ProductId = 11,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "New",
                            ImageUrl = "Ps5.jpg",
                            IsApproved = true,
                            IsHome = false,
                            Name = "Ps5",
                            Price = 2000.0,
                            Url = "ps5"
                        });
                });

            modelBuilder.Entity("shopapp.entity.ProductCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoryId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductCategory");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            ProductId = 1
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 2
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 3
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 4
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 5
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 6
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 7
                        },
                        new
                        {
                            CategoryId = 2,
                            ProductId = 8
                        },
                        new
                        {
                            CategoryId = 2,
                            ProductId = 9
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 10
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 11
                        });
                });

            modelBuilder.Entity("shopapp.entity.CardItem", b =>
                {
                    b.HasOne("shopapp.entity.Card", "Card")
                        .WithMany("CardItems")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("shopapp.entity.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("shopapp.entity.OrderItem", b =>
                {
                    b.HasOne("shopapp.entity.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("shopapp.entity.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("shopapp.entity.ProductCategory", b =>
                {
                    b.HasOne("shopapp.entity.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("shopapp.entity.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
