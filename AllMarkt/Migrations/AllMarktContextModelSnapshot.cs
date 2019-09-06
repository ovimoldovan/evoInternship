﻿// <auto-generated />
using System;
using AllMarkt.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AllMarkt.Migrations
{
    [DbContext(typeof(AllMarktContext))]
    partial class AllMarktContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AllMarkt.Entities.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("AllMarkt.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("AllMarkt.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(255);

                    b.Property<string>("PhoneNumber");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("AllMarkt.Entities.Moderator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Moderators");
                });

            modelBuilder.Entity("AllMarkt.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AWB")
                        .IsRequired();

                    b.Property<string>("AdditionalNotes")
                        .HasMaxLength(255);

                    b.Property<int?>("BuyerId");

                    b.Property<string>("DeliveryAddress")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeliveryPhoneNumber");

                    b.Property<int>("OrderStatus");

                    b.Property<int?>("SellerId");

                    b.Property<DateTime>("TimeOfOrder");

                    b.Property<float>("TotalPrice");

                    b.HasKey("Id");

                    b.HasIndex("BuyerId");

                    b.HasIndex("SellerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("AllMarkt.Entities.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("OrderId");

                    b.Property<float>("Price");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("AllMarkt.Entities.PrivateMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateRead");

                    b.Property<DateTime>("DateSent");

                    b.Property<int?>("DeletedBy");

                    b.Property<int>("ReceiverId");

                    b.Property<int>("SenderId");

                    b.Property<string>("Text")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("PrivateMessages");
                });

            modelBuilder.Entity("AllMarkt.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("ImageURI");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<double>("Price");

                    b.Property<int?>("ProductCategoryId");

                    b.Property<bool>("State");

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("AllMarkt.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("ShopId");

                    b.HasKey("Id");

                    b.HasIndex("ShopId");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("AllMarkt.Entities.ProductComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedById");

                    b.Property<DateTime>("DateAdded");

                    b.Property<int>("ProductId");

                    b.Property<int>("Rating");

                    b.Property<string>("Text")
                        .HasMaxLength(1023);

                    b.HasKey("Id");

                    b.HasIndex("AddedById");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductComments");
                });

            modelBuilder.Entity("AllMarkt.Entities.Shop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(255);

                    b.Property<string>("CUI");

                    b.Property<string>("IBAN")
                        .HasMaxLength(24);

                    b.Property<string>("PhoneNumber");

                    b.Property<double>("SocialCapital");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("AllMarkt.Entities.ShopCategory", b =>
                {
                    b.Property<int>("ShopId");

                    b.Property<int>("CategoryId");

                    b.HasKey("ShopId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ShopCategories");
                });

            modelBuilder.Entity("AllMarkt.Entities.ShopComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedById");

                    b.Property<DateTime>("DateAdded");

                    b.Property<int>("Rating");

                    b.Property<int>("ShopId");

                    b.Property<string>("Text")
                        .HasMaxLength(1023);

                    b.HasKey("Id");

                    b.HasIndex("AddedById");

                    b.HasIndex("ShopId");

                    b.ToTable("ShopComments");
                });

            modelBuilder.Entity("AllMarkt.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<bool>("IsEnabled");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("UserRole");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AllMarkt.Entities.Admin", b =>
                {
                    b.HasOne("AllMarkt.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AllMarkt.Entities.Customer", b =>
                {
                    b.HasOne("AllMarkt.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AllMarkt.Entities.Moderator", b =>
                {
                    b.HasOne("AllMarkt.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AllMarkt.Entities.Order", b =>
                {
                    b.HasOne("AllMarkt.Entities.Customer", "Buyer")
                        .WithMany("Orders")
                        .HasForeignKey("BuyerId");

                    b.HasOne("AllMarkt.Entities.Shop", "Seller")
                        .WithMany("Orders")
                        .HasForeignKey("SellerId");
                });

            modelBuilder.Entity("AllMarkt.Entities.OrderItem", b =>
                {
                    b.HasOne("AllMarkt.Entities.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AllMarkt.Entities.PrivateMessage", b =>
                {
                    b.HasOne("AllMarkt.Entities.User", "Receiver")
                        .WithMany("ReceivedMessages")
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("AllMarkt.Entities.User", "Sender")
                        .WithMany("SentMessages")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("AllMarkt.Entities.Product", b =>
                {
                    b.HasOne("AllMarkt.Entities.ProductCategory", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("ProductCategoryId");
                });

            modelBuilder.Entity("AllMarkt.Entities.ProductCategory", b =>
                {
                    b.HasOne("AllMarkt.Entities.Shop", "Shop")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ShopId");
                });

            modelBuilder.Entity("AllMarkt.Entities.ProductComment", b =>
                {
                    b.HasOne("AllMarkt.Entities.User", "AddedBy")
                        .WithMany()
                        .HasForeignKey("AddedById")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AllMarkt.Entities.Product", "Product")
                        .WithMany("Comments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AllMarkt.Entities.Shop", b =>
                {
                    b.HasOne("AllMarkt.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AllMarkt.Entities.ShopCategory", b =>
                {
                    b.HasOne("AllMarkt.Entities.Category", "Category")
                        .WithMany("ShopCategoryLink")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AllMarkt.Entities.Shop", "Shop")
                        .WithMany("ShopCategoryLink")
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AllMarkt.Entities.ShopComment", b =>
                {
                    b.HasOne("AllMarkt.Entities.User", "AddedBy")
                        .WithMany()
                        .HasForeignKey("AddedById")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AllMarkt.Entities.Shop", "Shop")
                        .WithMany("Comments")
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
