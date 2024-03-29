﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PentaPizza.Data.Context;

#nullable disable

namespace PentaPizza.Data.Migrations
{
    [DbContext(typeof(PentaPizzaDbContext))]
    partial class PentaPizzaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PentaPizza.Data.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ingredients")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Pizzas", "Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ingredients = "Tomato , Mozarella",
                            Name = "Margherita",
                            Price = 5.0
                        },
                        new
                        {
                            Id = 2,
                            Ingredients = "Tomato , Mozarella, Di Bufala",
                            Name = "Bufala",
                            Price = 6.0
                        },
                        new
                        {
                            Id = 3,
                            Ingredients = "Tomato , Mozarella, Anchovies, Oregano, Oil",
                            Name = "Romana",
                            Price = 5.0
                        },
                        new
                        {
                            Id = 4,
                            Ingredients = "Tomato , Mozarella, Spicy Salami",
                            Name = "Diavola",
                            Price = 7.5
                        },
                        new
                        {
                            Id = 5,
                            Ingredients = "Mozarella, Oregano",
                            Name = "Mozarella",
                            Price = 5.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
