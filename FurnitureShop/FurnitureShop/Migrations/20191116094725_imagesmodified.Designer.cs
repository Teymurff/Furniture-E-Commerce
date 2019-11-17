﻿// <auto-generated />
using FurnitureShop.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FurnitureShop.Migrations
{
    [DbContext(typeof(FurnitureContext))]
    [Migration("20191116094725_imagesmodified")]
    partial class imagesmodified
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FurnitureShop.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryImage")
                        .HasMaxLength(300);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = 1, CategoryImage = "bathroom.png", Name = "Bathroom" },
                        new { Id = 2, CategoryImage = "livingroom.png", Name = "Livingroom" },
                        new { Id = 3, CategoryImage = "bedroom.png", Name = "Bedroom" },
                        new { Id = 4, CategoryImage = "kitchen.png", Name = "Kitchen" }
                    );
                });

            modelBuilder.Entity("FurnitureShop.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MainImage")
                        .HasMaxLength(300);

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Images");

                    b.HasData(
                        new { Id = 1, MainImage = "product_1.png", ProductId = 1 },
                        new { Id = 2, MainImage = "product_1.png", ProductId = 1 },
                        new { Id = 3, MainImage = "product_1.png", ProductId = 1 },
                        new { Id = 4, MainImage = "product_1.png", ProductId = 1 },
                        new { Id = 5, MainImage = "product_2.png", ProductId = 2 },
                        new { Id = 6, MainImage = "product_2.png", ProductId = 2 },
                        new { Id = 7, MainImage = "product_2.png", ProductId = 2 },
                        new { Id = 8, MainImage = "product_2.png", ProductId = 2 },
                        new { Id = 9, MainImage = "product_3.png", ProductId = 3 },
                        new { Id = 10, MainImage = "product_3.png", ProductId = 3 },
                        new { Id = 11, MainImage = "product_3.png", ProductId = 3 },
                        new { Id = 12, MainImage = "product_3.png", ProductId = 3 },
                        new { Id = 13, MainImage = "product_4.png", ProductId = 4 },
                        new { Id = 14, MainImage = "product_4.png", ProductId = 4 },
                        new { Id = 15, MainImage = "product_4.png", ProductId = 4 },
                        new { Id = 16, MainImage = "product_4.png", ProductId = 4 },
                        new { Id = 17, MainImage = "product_5.png", ProductId = 5 },
                        new { Id = 18, MainImage = "product_5.png", ProductId = 5 },
                        new { Id = 19, MainImage = "product_5.png", ProductId = 5 },
                        new { Id = 20, MainImage = "product_5.png", ProductId = 5 },
                        new { Id = 21, MainImage = "product_6.png", ProductId = 6 },
                        new { Id = 22, MainImage = "product_6.png", ProductId = 6 },
                        new { Id = 23, MainImage = "product_6.png", ProductId = 6 },
                        new { Id = 24, MainImage = "product_6.png", ProductId = 6 },
                        new { Id = 25, MainImage = "product_7.png", ProductId = 7 },
                        new { Id = 26, MainImage = "product_7.png", ProductId = 7 },
                        new { Id = 27, MainImage = "product_7.png", ProductId = 7 },
                        new { Id = 28, MainImage = "product_7.png", ProductId = 7 },
                        new { Id = 29, MainImage = "product_8.png", ProductId = 8 },
                        new { Id = 30, MainImage = "product_8.png", ProductId = 8 },
                        new { Id = 31, MainImage = "product_8.png", ProductId = 8 },
                        new { Id = 32, MainImage = "product_8.png", ProductId = 8 }
                    );
                });

            modelBuilder.Entity("FurnitureShop.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<decimal>("DiscountedPrice");

                    b.Property<bool>("HasDiscount");

                    b.Property<int>("Height");

                    b.Property<int>("Length");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<decimal>("Price");

                    b.Property<int>("Width");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new { Id = 1, CategoryId = 4, DiscountedPrice = 100m, HasDiscount = true, Height = 508, Length = 58, Name = "Green Kitchen Chair", Price = 150m, Width = 128 },
                        new { Id = 2, CategoryId = 4, DiscountedPrice = 90m, HasDiscount = true, Height = 408, Length = 40, Name = "Orange Kitchen Chair", Price = 130m, Width = 118 },
                        new { Id = 3, CategoryId = 4, DiscountedPrice = 80m, HasDiscount = true, Height = 510, Length = 30, Name = "Yellow Kitchen Chair", Price = 100m, Width = 111 },
                        new { Id = 4, CategoryId = 2, DiscountedPrice = 0m, HasDiscount = false, Height = 500, Length = 58, Name = "Livingroom Chair", Price = 250m, Width = 128 },
                        new { Id = 5, CategoryId = 1, DiscountedPrice = 180m, HasDiscount = true, Height = 508, Length = 58, Name = "Comfortable Bathroom Chair", Price = 200m, Width = 128 },
                        new { Id = 6, CategoryId = 3, DiscountedPrice = 0m, HasDiscount = false, Height = 508, Length = 58, Name = "Green Bedroom Chair", Price = 160m, Width = 128 },
                        new { Id = 7, CategoryId = 1, DiscountedPrice = 0m, HasDiscount = false, Height = 508, Length = 58, Name = "Bathroom Chair", Price = 70m, Width = 128 },
                        new { Id = 8, CategoryId = 4, DiscountedPrice = 140m, HasDiscount = true, Height = 508, Length = 58, Name = "Red Kitchen Chair", Price = 170m, Width = 128 }
                    );
                });

            modelBuilder.Entity("FurnitureShop.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId");

                    b.Property<decimal>("Score");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("FurnitureShop.Models.Image", b =>
                {
                    b.HasOne("FurnitureShop.Models.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FurnitureShop.Models.Product", b =>
                {
                    b.HasOne("FurnitureShop.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FurnitureShop.Models.Rating", b =>
                {
                    b.HasOne("FurnitureShop.Models.Product", "Product")
                        .WithMany("Ratings")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}