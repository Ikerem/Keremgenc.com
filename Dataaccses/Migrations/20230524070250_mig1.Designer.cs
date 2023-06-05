﻿// <auto-generated />
using Dataaccses.Conrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dataaccses.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230524070250_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.About", b =>
                {
                    b.Property<int>("Aboutid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactMe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactaMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactaPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectDowlandUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title1")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Aboutid");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Home", b =>
                {
                    b.Property<int>("Homdeid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SocialMedia1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SocialMedia2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SocialMedia3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SocialMedia4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SocialMedia5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Homdeid");

                    b.ToTable("Homes");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Projects", b =>
                {
                    b.Property<int>("Projectid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Imge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Projectid");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Skill", b =>
                {
                    b.Property<int>("skillid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("skill1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("skill2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("skill3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("skill4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("skillid");

                    b.ToTable("Skills");
                });
#pragma warning restore 612, 618
        }
    }
}