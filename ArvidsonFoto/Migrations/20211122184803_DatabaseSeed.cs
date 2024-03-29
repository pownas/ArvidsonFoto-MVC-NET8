﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArvidsonFoto.Migrations
{
    public partial class DatabaseSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "menu_lastshowdate",
                table: "tbl_menu");

            migrationBuilder.DropColumn(
                name: "menu_pagecounter",
                table: "tbl_menu");

            migrationBuilder.AddColumn<int>(
                name: "PageCounter_CategoryId",
                table: "tbl_PageCounter",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "PageCounter_PicturePage",
                table: "tbl_PageCounter",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "tbl_PageCounter",
                columns: new[] { "PageCounter_ID", "PageCounter_CategoryId", "PageCounter_LastShowDate", "PageCounter_MonthViewed", "PageCounter_Name", "PageCounter_Views", "PageCounter_PicturePage" },
                values: new object[] { 1, 1, new DateTime(2021, 11, 22, 16, 16, 0, 0, DateTimeKind.Unspecified), "2021-11", "Fåglar", 0, true });

            migrationBuilder.InsertData(
                table: "tbl_gb",
                columns: new[] { "ID", "GB_date", "GB_email", "GB_homepage", "GB_ID", "GB_IP", "GB_name", "GB_ReadPost", "GB_text" },
                values: new object[] { 1, new DateTime(2021, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "pownas@outlook.com", "github.com/pownas", 1, null, "pownas", false, "Ett första test inlägg i databasen..." });

            migrationBuilder.InsertData(
                table: "tbl_images",
                columns: new[] { "ID", "image_art", "image_date", "image_description", "image_familj", "image_huvudfamilj", "image_ID", "image_update", "image_URL" },
                values: new object[,]
                {
                    { 1, 11, new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified), "En fjällabbs beskrivning...", 9, null, 1, new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified), "08TA3696" },
                    { 2, 13, new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified), "Hane, beskrivning av blåmes....", 12, 10, 2, new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified), "B57W4725" },
                    { 3, 14, new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified), "i Sverige", 2, null, 3, new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified), "B59W4837" },
                    { 4, 15, new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified), "", 3, null, 4, new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified), "13TA5142" },
                    { 5, 16, new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified), "Ekoxe, hane", 4, null, 5, new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified), "B60W1277" },
                    { 6, 17, new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified), "Fjällviol", 5, null, 6, new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified), "09TA8491" },
                    { 7, 18, new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified), "Rauk", 6, null, 7, new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified), "B57W8697" },
                    { 8, 19, new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified), "Jordgubbar", 7, null, 8, new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified), "IMG_1496" },
                    { 9, 20, new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified), "Hane, beskrivning av Costa rica....", 8, null, 9, new DateTime(2021, 11, 22, 16, 21, 0, 0, DateTimeKind.Unspecified), "_N0Q8690" }
                });

            migrationBuilder.InsertData(
                table: "tbl_menu",
                columns: new[] { "ID", "menu_ID", "menu_mainID", "menu_text", "menu_URLtext" },
                values: new object[,]
                {
                    { 1, 1, 0, "Fåglar", "Faglar" },
                    { 2, 2, 0, "Däggdjur", "Daggdjur" },
                    { 3, 3, 0, "Kräldjur", "Kraldjur" },
                    { 4, 4, 0, "Insekter", "Insekter" },
                    { 5, 5, 0, "Växter", "Vaxter" },
                    { 6, 6, 0, "Landskap", "Landskap" },
                    { 7, 7, 0, "Årstider", "Arstider" },
                    { 8, 8, 0, "Resor", "Resor" },
                    { 9, 9, 1, "Alkor och labbar", "Alkor-och-labbar" },
                    { 10, 10, 1, "Tättingar", "Tattingar" },
                    { 11, 11, 9, "Fjällabb", "Fjallabb" },
                    { 12, 12, 10, "Mesar", "Mesar" },
                    { 13, 13, 12, "Blåmes", "Blames" },
                    { 14, 14, 2, "Björn", "Bjorn" },
                    { 15, 15, 3, "Hasselsnok", "Hasselsnok" },
                    { 16, 16, 4, "Skalbaggar", "Skalbaggar" },
                    { 17, 17, 5, "Blommor", "Blommor" },
                    { 18, 18, 6, "Gotland", "Gotland" },
                    { 19, 19, 7, "Sommar", "Sommar" },
                    { 20, 20, 8, "2008 Costa Rica", "2008-Costa-Rica" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_PageCounter",
                keyColumn: "PageCounter_ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tbl_gb",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tbl_images",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tbl_images",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tbl_images",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tbl_images",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "tbl_images",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "tbl_images",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "tbl_images",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "tbl_images",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "tbl_images",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "tbl_menu",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tbl_menu",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tbl_menu",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tbl_menu",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "tbl_menu",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "tbl_menu",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "tbl_menu",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "tbl_menu",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "tbl_menu",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "tbl_menu",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "tbl_menu",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "tbl_menu",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "tbl_menu",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "tbl_menu",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "tbl_menu",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "tbl_menu",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "tbl_menu",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "tbl_menu",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "tbl_menu",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "tbl_menu",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DropColumn(
                name: "PageCounter_CategoryId",
                table: "tbl_PageCounter");

            migrationBuilder.DropColumn(
                name: "PageCounter_PicturePage",
                table: "tbl_PageCounter");

            migrationBuilder.AddColumn<DateTime>(
                name: "menu_lastshowdate",
                table: "tbl_menu",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "menu_pagecounter",
                table: "tbl_menu",
                type: "int",
                nullable: true);
        }
    }
}
