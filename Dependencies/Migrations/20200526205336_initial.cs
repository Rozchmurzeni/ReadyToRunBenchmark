using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dependencies.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreationDateTime = table.Column<DateTime>(nullable: false),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 1, new DateTime(2020, 5, 26, 22, 53, 35, 747, DateTimeKind.Local).AddTicks(8616), "e66a4ec9-e6cd-4185-8504-d71a42abed39" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 73, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9420), "99c4105c-46a8-400d-84c9-208de74896b0" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 72, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9411), "5f52e98a-bf9a-4a9d-9df0-0a142e48707f" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 71, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9402), "eaf070cf-e343-4d75-af45-48e4551d8eb3" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 70, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9393), "fbcdd9a5-3f9a-400a-9737-37a9f63e19ca" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 69, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9380), "8b540863-5a9a-4380-973c-72fcf7c3f189" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 68, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9371), "c912ad56-92fd-4ba0-8ea1-aaef5f446cb2" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 67, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9362), "a5f35439-5d50-47e3-9ad5-b61448c56796" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 66, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9353), "5ad17031-556d-4dc6-b684-0545c6ca20ed" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 65, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9342), "b3d88450-f73b-4794-ac0d-df9e91c90d1c" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 64, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9333), "4d59d887-16fb-414f-b21b-a6424e652a3d" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 63, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9323), "d5960a00-7ba8-458b-893b-3e79ea1a78ed" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 62, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9314), "b561649a-f761-44e5-a552-49b3b612a469" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 61, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9301), "56cb1ec7-55ce-454f-857d-c14bf543ef1d" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 60, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9292), "dc4d5bd5-6559-4dcc-8fdc-be7d17f5bcaf" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 59, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9282), "01b25561-1301-4dc5-aaab-fdc312690a00" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 58, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9271), "532090bb-0f5f-4c98-969e-d99e1393d81b" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 57, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9177), "863685b2-3e52-4633-b08c-2c024070b591" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 56, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9168), "d4310055-d620-4484-bc35-e5eddf33f322" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 55, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9159), "396fed2d-cbe7-44a0-b410-4f0cc8236f6a" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 54, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9150), "3c4c30bd-2567-4eee-b400-2db4e76cf839" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 53, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9137), "3b1c367f-c138-478e-94e5-225b50036ca6" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 74, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9429), "eaaed143-b945-450b-a9fa-c37e1e78d93d" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 52, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9129), "b82596f9-5149-40b3-bf37-fc6f50ad93da" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 75, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9439), "3c5b47f9-cdc6-428a-a5e9-088861589118" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 77, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9457), "6f968715-c895-4249-a3a6-2ba771c38c9c" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 98, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9661), "47b36453-7426-45fd-8444-978c5b7027c8" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 97, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9652), "d30bd263-2365-463c-90ac-4fa4bf396edc" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 96, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9643), "de591267-1b1f-4abd-9c74-d4196bd81064" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 95, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9634), "aea0f916-10fb-4612-add0-8b5723fa2a9c" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 94, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9625), "4ced5994-5989-4d72-94f2-0755a2da4a31" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 93, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9612), "6f738f0a-5750-482e-a4d8-6360b852eceb" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 92, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9604), "8e10e074-f2e6-4201-96d6-9dfc4506ab52" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 91, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9594), "645c08ce-c642-43ca-b19f-e5c0073d7855" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 90, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9584), "7feae9b3-ad61-4375-94e5-8ee28d4ef18b" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 89, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9575), "88f16c43-ee92-4cab-911e-8c2c12057e4d" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 88, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9566), "74fddc3f-0ea4-4aa2-b71d-d609b727a848" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 87, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9556), "f97eac76-b0c0-49b6-96ef-e89a3d188e7b" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 86, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9547), "f1a60c85-f456-4e69-89a8-1d50e42ed650" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 85, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9534), "ad49dea4-711d-47a4-91bc-302dca442ca3" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 84, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9524), "7443d39b-61e5-4a7b-af1b-46149aed9fe1" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 83, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9515), "4067bbe1-be1e-42bf-a092-362bbb57410c" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 82, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9505), "e9ab64ac-2ce3-4cf9-9bac-6d5ebbef48ad" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 81, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9496), "8d448fec-fba4-401d-b6a8-af234df86048" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 80, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9487), "8d126409-c0a1-425e-a58b-1fad9782a5c0" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 79, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9478), "02589742-39c3-4134-82ee-bc73e0db47df" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 78, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9469), "2c9be1e0-2aea-481c-8e60-97696a06bcd0" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 76, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9448), "edfce33b-245b-4124-a7e9-b0e7698855ac" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 51, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9120), "da4e02c7-6891-43e5-8262-aa572f765261" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 50, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9111), "10933be7-7ff2-4c56-8deb-b761f08fc47c" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 49, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9101), "77f6fe65-32bf-4f39-9176-3ab0ced108cc" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 22, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8839), "0cd13b46-c605-4108-b304-e355b308a66b" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 21, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8827), "b50be6eb-2e58-4a53-8118-c4a274290eb1" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 20, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8818), "ab9b52b9-a918-43c6-a9d2-0d67689566e4" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 19, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8809), "63ba2c03-e2fb-43f4-a211-d06e7036e055" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 18, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8799), "2dfd7da4-fd1e-450e-b000-8bed56c6e284" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 17, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8787), "0c475777-a089-4093-ba46-c7043e0b2154" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 16, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8778), "56527c25-88e5-47f6-aa70-4f263e614205" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 15, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8770), "97b1e3ea-6d30-4811-a55f-8c8ace196964" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 14, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8760), "1a21f28f-6449-4476-ad8a-107492bfd00c" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 13, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8746), "7b7848ca-f547-40ce-862f-634d94e025f4" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 12, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8737), "c2f8866b-b4b9-499b-92cb-f9594116c143" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 11, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8729), "4f1a31f5-7566-49c1-9e10-9abf63c38ce0" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 10, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8720), "b5104edf-ca0f-4b0d-b94b-33940bc8d03f" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 9, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8707), "c988dd50-2ed0-4971-9d2e-696e3df4cdf7" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 8, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8698), "19857f7e-5f0d-472a-b86f-3950e7cdb1dd" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 7, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8689), "09e7760a-5c40-4ad9-838b-34e331bbb1ef" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 6, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8678), "8149e89c-6860-42ff-abe4-299752a23f05" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 5, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8548), "beafd327-9554-449b-8883-6ccd820f38a4" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 4, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8539), "e8c3abbb-5dce-42ba-8b29-88cb8a2bbf96" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 3, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8525), "27c23abd-ec37-4e77-a0a5-39de47ce19d8" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 2, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8463), "d9d3a9f2-e2f5-484c-b532-015faad19aaf" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 23, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8849), "0a4ad61b-a308-4aec-adc3-5cefbe582be2" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 24, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8858), "e22945ea-fd5e-4dd6-8a06-bde01bb814f2" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 25, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8867), "a76fa5e0-77a8-45f1-aaca-f131cb82f695" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 26, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8876), "dff8ffa8-43bf-4afd-bddc-254a05e719c9" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 48, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9092), "c4b691b3-8b7d-4108-8e2b-9816442fd6fa" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 47, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9083), "7786dadf-273c-48ab-ac15-d519d1bd14e7" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 46, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9073), "9759bda1-9a68-4ab6-8f32-d5ed1e42805e" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 45, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9060), "6a152869-701b-4097-8c52-54ac637d039a" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 44, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9051), "1a178923-213e-4dcf-9b36-c1c7d5ca037f" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 43, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9042), "1f09a02b-e9af-4548-82b3-5060d707a2aa" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 42, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9033), "4bfcc5a1-74e9-40d2-b799-e079c4d42645" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 41, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9023), "06c2c60e-71cd-488e-90fc-05d48715c7db" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 40, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9014), "ee7d11b5-94a0-4995-ae18-17389509e108" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 39, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9005), "6cdeb2ae-5a75-4ef3-aae4-8e15cf6a81e4" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 99, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9670), "99ebfa7c-0b4e-4f08-8904-5b92de488734" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 38, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8995), "3d8ff153-7ca3-4c62-a300-9f56ce86e64d" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 36, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8973), "f2d1f0fb-8ea3-4a55-9c5a-22780f8ff0f2" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 35, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8964), "b881d73d-3c05-4004-a25b-45d10c670da0" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 34, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8956), "1f2ef9a2-bd39-4060-b013-3c6161430338" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 33, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8944), "51654ffe-ccac-40a0-acc3-eb6ce53afd96" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 32, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8935), "1ee79d0c-6022-491d-8d42-675c960f3586" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 31, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8925), "5c5c7e0b-8377-4411-9a9e-36a347e550c8" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 30, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8916), "0008415e-3887-42d1-bce5-6f4ef6a61aaf" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 29, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8903), "e0a698fb-f39b-4818-b1c4-d3718b7a60c6" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 28, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8894), "c45c2b02-52dd-40f3-955f-915969f5f0a2" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 27, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8885), "43ecf48e-f10f-4140-a257-fa179ba66466" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 37, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(8982), "af89c042-321e-4fbe-876d-1856184fd1a8" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDateTime", "Text" },
                values: new object[] { 100, new DateTime(2020, 5, 26, 22, 53, 35, 751, DateTimeKind.Local).AddTicks(9679), "03d70eb4-611d-4292-b27a-fa96cdc373a7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
