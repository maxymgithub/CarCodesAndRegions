using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarNumberCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarNumberCodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarNumberCodes_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "RegionName" },
                values: new object[,]
                {
                    { 1, "Київ" },
                    { 2, "Вінницька" },
                    { 3, "Волинська" },
                    { 4, "Дніпропетровська" },
                    { 5, "Донецька" },
                    { 6, "Київська" },
                    { 7, "Житомирська" },
                    { 8, "Закарпатська" },
                    { 9, "Запорізька" },
                    { 10, "Івано-Франківська" },
                    { 11, "Харківська" },
                    { 12, "Кіровоградська" },
                    { 13, "Луганська" },
                    { 14, "Львівська" },
                    { 15, "Миколаївська" },
                    { 16, "Одеська" },
                    { 17, "Полтавська" },
                    { 18, "Рівненська" },
                    { 19, "Сумська" },
                    { 20, "Тернопільська" },
                    { 21, "Херсонська" },
                    { 22, "Хмельницька" },
                    { 23, "Черкаська" },
                    { 24, "Чернігівська" },
                    { 25, "Чернівецька" },
                    { 26, "Загальнодержавна серія" }
                });

            migrationBuilder.InsertData(
                table: "CarNumberCodes",
                columns: new[] { "Id", "RegionCode", "RegionId" },
                values: new object[,]
                {
                    { 1, "AA", 1 },
                    { 2, "KA", 1 },
                    { 3, "AB", 2 },
                    { 4, "KB", 2 },
                    { 5, "AC", 3 },
                    { 6, "KC", 3 },
                    { 7, "AE", 4 },
                    { 8, "KE", 4 },
                    { 9, "AH", 5 },
                    { 10, "KH", 5 },
                    { 11, "AI", 6 },
                    { 12, "KI", 6 },
                    { 13, "AM", 7 },
                    { 14, "KM", 7 },
                    { 15, "AO", 8 },
                    { 16, "KO", 8 },
                    { 17, "AP", 9 },
                    { 18, "KP", 9 },
                    { 19, "AT", 10 },
                    { 20, "KT", 10 },
                    { 21, "AX", 11 },
                    { 22, "KX", 11 },
                    { 23, "BA", 12 },
                    { 24, "HA", 12 },
                    { 25, "BB", 13 },
                    { 26, "HB", 13 },
                    { 27, "BC", 14 },
                    { 28, "HC", 14 },
                    { 29, "BE", 15 },
                    { 30, "HE", 15 },
                    { 31, "BH", 16 },
                    { 32, "HH", 16 },
                    { 33, "BI", 17 },
                    { 34, "HI", 17 },
                    { 35, "BK", 18 },
                    { 36, "HK", 18 },
                    { 37, "BM", 19 },
                    { 38, "HM", 19 },
                    { 39, "BO", 20 },
                    { 40, "HO", 20 },
                    { 41, "BT", 21 },
                    { 42, "HT", 21 }
                });

            migrationBuilder.InsertData(
                table: "CarNumberCodes",
                columns: new[] { "Id", "RegionCode", "RegionId" },
                values: new object[,]
                {
                    { 43, "BX", 22 },
                    { 44, "HX", 22 },
                    { 45, "CA", 23 },
                    { 46, "IA", 23 },
                    { 47, "CB", 24 },
                    { 48, "IB", 24 },
                    { 49, "CE", 25 },
                    { 50, "IE", 25 },
                    { 51, "II", 26 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarNumberCodes_RegionId",
                table: "CarNumberCodes",
                column: "RegionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarNumberCodes");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
