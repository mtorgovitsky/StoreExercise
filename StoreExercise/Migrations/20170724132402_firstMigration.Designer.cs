using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using StoreExercise.Models;

namespace StoreExercise.Migrations
{
    [DbContext(typeof(CarsContext))]
    [Migration("20170724132402_firstMigration")]
    partial class firstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("StoreExercise.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Firm");

                    b.Property<string>("ImageURI");

                    b.Property<string>("Model");

                    b.Property<int>("Price");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Car");
                });

            modelBuilder.Entity("StoreExercise.Models.ShoppingItem", b =>
                {
                    b.HasBaseType("StoreExercise.Models.Car");


                    b.ToTable("ShoppingItem");

                    b.HasDiscriminator().HasValue("ShoppingItem");
                });
        }
    }
}
