﻿// <auto-generated />
using System;
using ArvidsonFoto.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ArvidsonFoto.Migrations
{
    [DbContext(typeof(ArvidsonFotoDbContext))]
    partial class ArvidsonFotoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("Finnish_Swedish_CI_AS")
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ArvidsonFoto.Models.TblGb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("GbDate")
                        .HasColumnType("smalldatetime")
                        .HasColumnName("GB_date");

                    b.Property<string>("GbEmail")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("GB_email");

                    b.Property<string>("GbHomepage")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("GB_homepage");

                    b.Property<int>("GbId")
                        .HasColumnType("int")
                        .HasColumnName("GB_ID");

                    b.Property<string>("GbIp")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("GB_IP");

                    b.Property<string>("GbName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("GB_name");

                    b.Property<bool?>("GbReadPost")
                        .HasColumnType("bit")
                        .HasColumnName("GB_ReadPost");

                    b.Property<string>("GbText")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("GB_text");

                    b.HasKey("Id");

                    b.ToTable("tbl_gb", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GbDate = new DateTime(2021, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GbEmail = "pownas@outlook.com",
                            GbHomepage = "github.com/pownas",
                            GbId = 1,
                            GbName = "pownas",
                            GbReadPost = false,
                            GbText = "Ett första test inlägg i databasen..."
                        });
                });

            modelBuilder.Entity("ArvidsonFoto.Models.TblImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ImageArt")
                        .HasColumnType("int")
                        .HasColumnName("image_art");

                    b.Property<DateTime?>("ImageDate")
                        .HasColumnType("smalldatetime")
                        .HasColumnName("image_date");

                    b.Property<string>("ImageDescription")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("image_description");

                    b.Property<int?>("ImageFamilj")
                        .HasColumnType("int")
                        .HasColumnName("image_familj");

                    b.Property<int?>("ImageHuvudfamilj")
                        .HasColumnType("int")
                        .HasColumnName("image_huvudfamilj");

                    b.Property<int>("ImageId")
                        .HasColumnType("int")
                        .HasColumnName("image_ID");

                    b.Property<DateTime>("ImageUpdate")
                        .HasColumnType("datetime")
                        .HasColumnName("image_update");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("image_URL");

                    b.HasKey("Id");

                    b.ToTable("tbl_images", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageArt = 11,
                            ImageDate = new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified),
                            ImageDescription = "En fjällabbs beskrivning...",
                            ImageFamilj = 9,
                            ImageId = 1,
                            ImageUpdate = new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "08TA3696"
                        },
                        new
                        {
                            Id = 2,
                            ImageArt = 13,
                            ImageDate = new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified),
                            ImageDescription = "Hane, beskrivning av blåmes....",
                            ImageFamilj = 12,
                            ImageHuvudfamilj = 10,
                            ImageId = 2,
                            ImageUpdate = new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "B57W4725"
                        },
                        new
                        {
                            Id = 3,
                            ImageArt = 14,
                            ImageDate = new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified),
                            ImageDescription = "i Sverige",
                            ImageFamilj = 2,
                            ImageId = 3,
                            ImageUpdate = new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "B59W4837"
                        },
                        new
                        {
                            Id = 4,
                            ImageArt = 15,
                            ImageDate = new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified),
                            ImageDescription = "",
                            ImageFamilj = 3,
                            ImageId = 4,
                            ImageUpdate = new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "13TA5142"
                        },
                        new
                        {
                            Id = 5,
                            ImageArt = 16,
                            ImageDate = new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified),
                            ImageDescription = "Ekoxe, hane",
                            ImageFamilj = 4,
                            ImageId = 5,
                            ImageUpdate = new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "B60W1277"
                        },
                        new
                        {
                            Id = 6,
                            ImageArt = 17,
                            ImageDate = new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified),
                            ImageDescription = "Fjällviol",
                            ImageFamilj = 5,
                            ImageId = 6,
                            ImageUpdate = new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "09TA8491"
                        },
                        new
                        {
                            Id = 7,
                            ImageArt = 18,
                            ImageDate = new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified),
                            ImageDescription = "Rauk",
                            ImageFamilj = 6,
                            ImageId = 7,
                            ImageUpdate = new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "B57W8697"
                        },
                        new
                        {
                            Id = 8,
                            ImageArt = 19,
                            ImageDate = new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified),
                            ImageDescription = "Jordgubbar",
                            ImageFamilj = 7,
                            ImageId = 8,
                            ImageUpdate = new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "IMG_1496"
                        },
                        new
                        {
                            Id = 9,
                            ImageArt = 20,
                            ImageDate = new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified),
                            ImageDescription = "Hane, beskrivning av Costa rica....",
                            ImageFamilj = 8,
                            ImageId = 9,
                            ImageUpdate = new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "_N0Q8690"
                        });
                });

            modelBuilder.Entity("ArvidsonFoto.Models.TblMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MenuId")
                        .HasColumnType("int")
                        .HasColumnName("menu_ID");

                    b.Property<int?>("MenuMainId")
                        .HasColumnType("int")
                        .HasColumnName("menu_mainID");

                    b.Property<string>("MenuText")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("menu_text");

                    b.Property<string>("MenuUrltext")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("menu_URLtext");

                    b.HasKey("Id");

                    b.ToTable("tbl_menu", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MenuId = 1,
                            MenuMainId = 0,
                            MenuText = "Fåglar",
                            MenuUrltext = "Faglar"
                        },
                        new
                        {
                            Id = 2,
                            MenuId = 2,
                            MenuMainId = 0,
                            MenuText = "Däggdjur",
                            MenuUrltext = "Daggdjur"
                        },
                        new
                        {
                            Id = 3,
                            MenuId = 3,
                            MenuMainId = 0,
                            MenuText = "Kräldjur",
                            MenuUrltext = "Kraldjur"
                        },
                        new
                        {
                            Id = 4,
                            MenuId = 4,
                            MenuMainId = 0,
                            MenuText = "Insekter",
                            MenuUrltext = "Insekter"
                        },
                        new
                        {
                            Id = 5,
                            MenuId = 5,
                            MenuMainId = 0,
                            MenuText = "Växter",
                            MenuUrltext = "Vaxter"
                        },
                        new
                        {
                            Id = 6,
                            MenuId = 6,
                            MenuMainId = 0,
                            MenuText = "Landskap",
                            MenuUrltext = "Landskap"
                        },
                        new
                        {
                            Id = 7,
                            MenuId = 7,
                            MenuMainId = 0,
                            MenuText = "Årstider",
                            MenuUrltext = "Arstider"
                        },
                        new
                        {
                            Id = 8,
                            MenuId = 8,
                            MenuMainId = 0,
                            MenuText = "Resor",
                            MenuUrltext = "Resor"
                        },
                        new
                        {
                            Id = 9,
                            MenuId = 9,
                            MenuMainId = 1,
                            MenuText = "Alkor och labbar",
                            MenuUrltext = "Alkor-och-labbar"
                        },
                        new
                        {
                            Id = 10,
                            MenuId = 10,
                            MenuMainId = 1,
                            MenuText = "Tättingar",
                            MenuUrltext = "Tattingar"
                        },
                        new
                        {
                            Id = 11,
                            MenuId = 11,
                            MenuMainId = 9,
                            MenuText = "Fjällabb",
                            MenuUrltext = "Fjallabb"
                        },
                        new
                        {
                            Id = 12,
                            MenuId = 12,
                            MenuMainId = 10,
                            MenuText = "Mesar",
                            MenuUrltext = "Mesar"
                        },
                        new
                        {
                            Id = 13,
                            MenuId = 13,
                            MenuMainId = 12,
                            MenuText = "Blåmes",
                            MenuUrltext = "Blames"
                        },
                        new
                        {
                            Id = 14,
                            MenuId = 14,
                            MenuMainId = 2,
                            MenuText = "Björn",
                            MenuUrltext = "Bjorn"
                        },
                        new
                        {
                            Id = 15,
                            MenuId = 15,
                            MenuMainId = 3,
                            MenuText = "Hasselsnok",
                            MenuUrltext = "Hasselsnok"
                        },
                        new
                        {
                            Id = 16,
                            MenuId = 16,
                            MenuMainId = 4,
                            MenuText = "Skalbaggar",
                            MenuUrltext = "Skalbaggar"
                        },
                        new
                        {
                            Id = 17,
                            MenuId = 17,
                            MenuMainId = 5,
                            MenuText = "Blommor",
                            MenuUrltext = "Blommor"
                        },
                        new
                        {
                            Id = 18,
                            MenuId = 18,
                            MenuMainId = 6,
                            MenuText = "Gotland",
                            MenuUrltext = "Gotland"
                        },
                        new
                        {
                            Id = 19,
                            MenuId = 19,
                            MenuMainId = 7,
                            MenuText = "Sommar",
                            MenuUrltext = "Sommar"
                        },
                        new
                        {
                            Id = 20,
                            MenuId = 20,
                            MenuMainId = 8,
                            MenuText = "2008 Costa Rica",
                            MenuUrltext = "2008-Costa-Rica"
                        });
                });

            modelBuilder.Entity("ArvidsonFoto.Models.TblPageCounter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PageCounter_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("PageCounter_CategoryId");

                    b.Property<DateTime>("LastShowDate")
                        .HasColumnType("datetime")
                        .HasColumnName("PageCounter_LastShowDate");

                    b.Property<string>("MonthViewed")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("PageCounter_MonthViewed");

                    b.Property<string>("PageName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("PageCounter_Name");

                    b.Property<int>("PageViews")
                        .HasColumnType("int")
                        .HasColumnName("PageCounter_Views");

                    b.Property<bool>("PicturePage")
                        .HasColumnType("bit")
                        .HasColumnName("PageCounter_PicturePage");

                    b.HasKey("Id");

                    b.ToTable("tbl_PageCounter", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            LastShowDate = new DateTime(2021, 11, 22, 16, 16, 0, 0, DateTimeKind.Unspecified),
                            MonthViewed = "2021-11",
                            PageName = "Fåglar",
                            PageViews = 0,
                            PicturePage = true
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
