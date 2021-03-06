// <auto-generated />
using EntityEXP02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityEXP02.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    [Migration("20220219193427_tird")]
    partial class tird
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityEXP02.Models.Shop", b =>
                {
                    b.Property<string>("item")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("rate")
                        .HasColumnType("int");

                    b.HasKey("item");

                    b.ToTable("Shops");
                });
#pragma warning restore 612, 618
        }
    }
}
