﻿// <auto-generated />
using System;
using ArvidsonFoto.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArvidsonFoto.Migrations
{
    [DbContext(typeof(ArvidsonFotoDbContext))]
    [Migration("20210204094738_SkaparTabeller")]
    partial class SkaparTabeller
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:Collation", "Finnish_Swedish_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("ArvidsonFoto.Models.TblGb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

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
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("GB_IP");

                    b.Property<string>("GbName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("GB_name");

                    b.Property<string>("GbText")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("GB_text");

                    b.HasKey("Id");

                    b.ToTable("tbl_gb");
                });

            modelBuilder.Entity("ArvidsonFoto.Models.TblImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

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

                    b.ToTable("tbl_images");
                });

            modelBuilder.Entity("ArvidsonFoto.Models.TblMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<int>("MenuId")
                        .HasColumnType("int")
                        .HasColumnName("menu_ID");

                    b.Property<DateTime?>("MenuLastshowdate")
                        .HasColumnType("datetime")
                        .HasColumnName("menu_lastshowdate");

                    b.Property<int?>("MenuMainId")
                        .HasColumnType("int")
                        .HasColumnName("menu_mainID");

                    b.Property<int?>("MenuPagecounter")
                        .HasColumnType("int")
                        .HasColumnName("menu_pagecounter");

                    b.Property<string>("MenuText")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("menu_text");

                    b.Property<string>("MenuUrltext")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("menu_URLtext");

                    b.HasKey("Id");

                    b.ToTable("tbl_menu");
                });

            modelBuilder.Entity("ArvidsonFoto.Models.TblPageCounter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PageCounter_ID")
                        .UseIdentityColumn();

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

                    b.HasKey("Id");

                    b.ToTable("tbl_PageCounter");
                });
#pragma warning restore 612, 618
        }
    }
}