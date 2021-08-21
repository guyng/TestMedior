using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class newuserheroesaddition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "32205d0b-cd03-4148-9027-dd353fb8af82");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: "32205d0b-cd03-4148-9027-dd353fb8af82");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: "32205d0b-cd03-4148-9027-dd353fb8af82");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserId",
                value: "32205d0b-cd03-4148-9027-dd353fb8af82");

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "Id", "Ability", "CurrentPower", "Name", "StartedTrainDate", "StartingPower", "SuitColors", "UserId" },
                values: new object[,]
                {
                    { 5, 0, null, "Ninja", null, 56m, "Red,Blue", "a59359c6-a2ba-47f8-ae37-7868733ea1f4" },
                    { 6, 1, null, "Shroud", null, 44m, "Red,Green", "a59359c6-a2ba-47f8-ae37-7868733ea1f4" },
                    { 7, 0, null, "Tfue", null, 33m, "Yellow,Green", "a59359c6-a2ba-47f8-ae37-7868733ea1f4" },
                    { 8, 1, null, "Nadeshot", null, 115m, "Green,Blue", "a59359c6-a2ba-47f8-ae37-7868733ea1f4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "bbabc617-3685-449a-a051-ff6308f40c54");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: "bbabc617-3685-449a-a051-ff6308f40c54");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: "bbabc617-3685-449a-a051-ff6308f40c54");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserId",
                value: "bbabc617-3685-449a-a051-ff6308f40c54");
        }
    }
}
