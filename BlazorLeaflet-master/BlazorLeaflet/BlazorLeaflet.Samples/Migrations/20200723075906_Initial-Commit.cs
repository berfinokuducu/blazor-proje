using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorLeaflet.Samples.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    district = table.Column<string>(nullable: true),
                    street = table.Column<string>(nullable: true),
                    No = table.Column<int>(nullable: false),
                    activity_area = table.Column<string>(nullable: true),
                    image = table.Column<string>(nullable: true),
                    Longitude = table.Column<double>(nullable: false),
                    Latitude = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "ID", "Latitude", "Longitude", "No", "activity_area", "city", "district", "image", "name", "phone", "street" },
                values: new object[] { 1, 40.112758999999997, 26.406562999999998, 2, "Açık ve Kapalı Havuz,Spa,Restoran", "Çanakkale", "Merkez", "https://imagessl.etstur.com/files/images/hotelImages/integration/TR/94131/l/s5cu25fseia0a4ruyzif.jpg", "Kolin Hotel", "+902862180808", "Atatürk Caddesi" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "ID", "Latitude", "Longitude", "No", "activity_area", "city", "district", "image", "name", "phone", "street" },
                values: new object[] { 2, 40.153368, 26.407924999999999, 2, "Restoran", "Çanakkale", "Merkez", "https://imagessl.etstur.com/files/images/hotelImages/integration/TR/51416/l/lu0axr1mij2jnljgrqzt.jpg", "Büyük Truva Hotel", "+902862171024", "Mehmet Akif Ersoy Cd." });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "ID", "Latitude", "Longitude", "No", "activity_area", "city", "district", "image", "name", "phone", "street" },
                values: new object[] { 3, 40.149659999999997, 26.404779999999999, 4, "", "Çanakkale", "Merkez", "https://imagessl.etstur.com/files/images/hotelImages/integration/TR/91088/l/mfih5nuhidb7r7ifn4ow.jpg", "Grand Ece Hotel", "+902862139345", "Değirmenlik 1.Çıkmazı Sk." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hotel");
        }
    }
}
