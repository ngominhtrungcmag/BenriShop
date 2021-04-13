﻿// <auto-generated />
using BenriShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BenriShop.Migrations
{
    [DbContext(typeof(BenriShopContext))]
    partial class BenriShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BenriShop.Models.Account", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnName("USERNAME")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Address")
                        .HasColumnName("ADDRESS")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("FullName")
                        .HasColumnName("FULLNAME")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("PASSWORD")
                        .HasColumnType("varchar(40)")
                        .HasMaxLength(40)
                        .IsUnicode(false);

                    b.Property<string>("PhoneNumber")
                        .HasColumnName("PHONENUMBER")
                        .HasColumnType("varchar(12)")
                        .HasMaxLength(12)
                        .IsUnicode(false);

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnName("ROLE")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("UserName");

                    b.ToTable("ACCOUNT");
                });

            modelBuilder.Entity("BenriShop.Models.CartItem", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnName("PRODUCTID")
                        .HasColumnType("int")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("UserName")
                        .HasColumnName("USERNAME")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<int>("QuantityInCart")
                        .HasColumnName("QUANTITYINCART")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "UserName");

                    b.HasIndex("ProductId")
                        .HasName("ADDED_FK");

                    b.HasIndex("UserName");

                    b.ToTable("CARTITEM");
                });

            modelBuilder.Entity("BenriShop.Models.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnName("CATEGORYID")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.HasKey("CategoryId");

                    b.ToTable("CATEGORY");
                });

            modelBuilder.Entity("BenriShop.Models.Color", b =>
                {
                    b.Property<string>("ColorId")
                        .HasColumnName("COLORID")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.HasKey("ColorId");

                    b.ToTable("COLOR");
                });

            modelBuilder.Entity("BenriShop.Models.HaveTag", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnName("PRODUCTID")
                        .HasColumnType("int")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("TagId")
                        .HasColumnName("TAGID")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("ProductId", "TagId");

                    b.HasIndex("ProductId")
                        .HasName("HAVE_TAG_FK");

                    b.HasIndex("TagId")
                        .HasName("HAVE_TAG2_FK");

                    b.ToTable("HAVE_TAG");
                });

            modelBuilder.Entity("BenriShop.Models.Image", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnName("PRODUCTID")
                        .HasColumnType("int")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Imageid")
                        .HasColumnName("IMAGEID")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnName("LINK")
                        .HasColumnType("varchar(300)")
                        .HasMaxLength(300)
                        .IsUnicode(false);

                    b.HasKey("ProductId", "Imageid");

                    b.HasIndex("ProductId")
                        .HasName("HAVE_IMAGE_FK");

                    b.ToTable("IMAGE");
                });

            modelBuilder.Entity("BenriShop.Models.Order", b =>
                {
                    b.Property<string>("OrderId")
                        .HasColumnName("ORDERID")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<bool>("Payment")
                        .HasColumnName("PAYMENT")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnName("USERNAME")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("OrderId");

                    b.HasIndex("UserName")
                        .HasName("ORDER_FK");

                    b.ToTable("ORDER");
                });

            modelBuilder.Entity("BenriShop.Models.OrderItem", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnName("PRODUCTID")
                        .HasColumnType("int")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("OrderId")
                        .HasColumnName("ORDERID")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("QuantityInOrder")
                        .HasColumnName("QUANTITYINORDER")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "OrderId");

                    b.HasIndex("OrderId")
                        .HasName("HAVE_ITEM_FK");

                    b.HasIndex("ProductId")
                        .HasName("ORDERED_FK");

                    b.ToTable("ORDERITEM");
                });

            modelBuilder.Entity("BenriShop.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PRODUCTID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasColumnName("CATEGORYID")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<int>("Price")
                        .HasColumnName("PRICE")
                        .HasColumnType("int");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnName("PRODUCTDESCRIPTION")
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnName("PRODUCTNAME")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("StorageQuantity")
                        .HasColumnName("STORAGEQUANTITY")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId")
                        .HasName("HAVE_CATEGORY_FK");

                    b.ToTable("PRODUCT");
                });

            modelBuilder.Entity("BenriShop.Models.Shipping", b =>
                {
                    b.Property<string>("OrderId")
                        .HasColumnName("ORDERID")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("ShippingId")
                        .HasColumnName("SHIPPINGID")
                        .HasColumnType("varchar(60)")
                        .HasMaxLength(60)
                        .IsUnicode(false);

                    b.Property<int>("Cost")
                        .HasColumnName("COST")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnName("NOTE")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<int>("Status")
                        .HasColumnName("STATUS")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "ShippingId");

                    b.HasIndex("OrderId")
                        .HasName("HAVE_SHIPMENT_FK");

                    b.ToTable("SHIPPING");
                });

            modelBuilder.Entity("BenriShop.Models.Size", b =>
                {
                    b.Property<string>("SizeId")
                        .HasColumnName("SIZEID")
                        .HasColumnType("varchar(3)")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    b.HasKey("SizeId");

                    b.ToTable("SIZE");
                });

            modelBuilder.Entity("BenriShop.Models.SizeOfProductHadColor", b =>
                {
                    b.Property<string>("SizeId")
                        .HasColumnName("SIZEID")
                        .HasColumnType("varchar(3)")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    b.Property<string>("ColorId")
                        .HasColumnName("COLORID")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<int>("ProductId")
                        .HasColumnName("PRODUCTID")
                        .HasColumnType("int")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<int>("QuantityInSizeOfColor")
                        .HasColumnName("QUANTITYINSIZEOFCOLOR")
                        .HasColumnType("int");

                    b.HasKey("SizeId", "ColorId", "ProductId");

                    b.HasIndex("ColorId")
                        .HasName("COLOR_HAVE_SIZE_FK");

                    b.HasIndex("ProductId")
                        .HasName("PRODUCT_HAVE_SIZE_AND_COLOR_FK");

                    b.HasIndex("SizeId")
                        .HasName("SIZE_HAVE_COLOR_FK");

                    b.ToTable("SIZEOFPRODUCTHADCOLOR");
                });

            modelBuilder.Entity("BenriShop.Models.Tag", b =>
                {
                    b.Property<string>("TagId")
                        .HasColumnName("TAGID")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("TagId");

                    b.ToTable("TAG");
                });

            modelBuilder.Entity("BenriShop.Models.CartItem", b =>
                {
                    b.HasOne("BenriShop.Models.Product", "Product")
                        .WithMany("CartItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BenriShop.Models.Account", "Account")
                        .WithMany("CartItems")
                        .HasForeignKey("UserName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BenriShop.Models.HaveTag", b =>
                {
                    b.HasOne("BenriShop.Models.Product", null)
                        .WithMany("HaveTags")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BenriShop.Models.Tag", null)
                        .WithMany("HaveTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BenriShop.Models.Image", b =>
                {
                    b.HasOne("BenriShop.Models.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BenriShop.Models.Order", b =>
                {
                    b.HasOne("BenriShop.Models.Account", "Account")
                        .WithMany("Orders")
                        .HasForeignKey("UserName")
                        .HasConstraintName("fk_order_order_account");
                });

            modelBuilder.Entity("BenriShop.Models.OrderItem", b =>
                {
                    b.HasOne("BenriShop.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK_ORDERITE_HAVE_ITEM_ORDER")
                        .IsRequired();

                    b.HasOne("BenriShop.Models.Product", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_ORDERITE_ORDERED_PRODUCT")
                        .IsRequired();
                });

            modelBuilder.Entity("BenriShop.Models.Product", b =>
                {
                    b.HasOne("BenriShop.Models.Category", null)
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BenriShop.Models.Shipping", b =>
                {
                    b.HasOne("BenriShop.Models.Order", "Order")
                        .WithMany("Shippings")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK_SHIPPING_HAVE_SHIP_ORDER")
                        .IsRequired();
                });

            modelBuilder.Entity("BenriShop.Models.SizeOfProductHadColor", b =>
                {
                    b.HasOne("BenriShop.Models.Color", "Color")
                        .WithMany("SizeOfProductHadColors")
                        .HasForeignKey("ColorId")
                        .HasConstraintName("FK_SIZEOFPR_COLOR_HAV_COLOR")
                        .IsRequired();

                    b.HasOne("BenriShop.Models.Product", "Product")
                        .WithMany("SizeOfProductHadColors")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_SIZEOFPR_PRODUCT_H_PRODUCT")
                        .IsRequired();

                    b.HasOne("BenriShop.Models.Size", "Size")
                        .WithMany("SizeOfProductHadColors")
                        .HasForeignKey("SizeId")
                        .HasConstraintName("FK_SIZEOFPR_SIZE_HAVE_SIZE")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
