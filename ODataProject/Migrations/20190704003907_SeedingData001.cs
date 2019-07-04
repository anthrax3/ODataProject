using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ODataProject.Migrations
{
    public partial class SeedingData001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "SchoolId", "City", "Name", "State" },
                values: new object[,]
                {
                    { new Guid("3bb81861-97df-4bd7-8d61-827734fcd808"), "Mexicali", "UABC - Mexicali", "Baja California" },
                    { new Guid("b86554c5-6789-411f-ab51-1e01da7ba33d"), "Mexicali", "TECNOLOGICO UNIVERSIDAD - Mexicali", "Baja California" },
                    { new Guid("833c3346-fa7b-40a7-a6e0-745cf6006ed7"), "Ensenada", "UABC - Ensenada", "Baja California" },
                    { new Guid("f1a55daa-8417-47ea-9b83-04f63c4cf8d8"), "Mexicali", "XOCHICALCO UNIVERSIDAD - Mexicali", "Baja California" },
                    { new Guid("3aea756e-5203-4811-b290-746d392ade83"), "Mexicali", "CETYS UNIVERSIDAD - Mexicali", "Baja California" },
                    { new Guid("39cf30b9-ddc1-48de-a24a-f408ca7c5179"), "Tijuana", "CETYS UNIVERSIDAD - Tijuana", "Baja California" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Name", "SchoolId", "Score" },
                values: new object[,]
                {
                    { new Guid("dbda2ce8-5611-4273-a64f-be6d6c4c1f10"), "Jorge Apodaca", new Guid("3bb81861-97df-4bd7-8d61-827734fcd808"), 100 },
                    { new Guid("97dedf40-0ea1-46b1-95ca-51d1c923262a"), "Jose Osuna", new Guid("39cf30b9-ddc1-48de-a24a-f408ca7c5179"), 88 },
                    { new Guid("e2b702bb-5ce4-4c32-9d47-200ea3a6c0d7"), "Omar Reyes", new Guid("3aea756e-5203-4811-b290-746d392ade83"), 67 },
                    { new Guid("2f428cd4-4799-409f-98d2-256e8e669138"), "Cristina Gutierrez", new Guid("3aea756e-5203-4811-b290-746d392ade83"), 96 },
                    { new Guid("4a424406-82b3-49d1-8c18-e4effb717c9a"), "Guadalupe Ortiz", new Guid("3aea756e-5203-4811-b290-746d392ade83"), 70 },
                    { new Guid("3380e0a1-1d3b-4dc8-a429-9ad5471c8ba0"), "Manuel Lopez", new Guid("f1a55daa-8417-47ea-9b83-04f63c4cf8d8"), 80 },
                    { new Guid("5baca2fc-f61e-43b0-b934-27c39d5f4642"), "Raul Farias", new Guid("f1a55daa-8417-47ea-9b83-04f63c4cf8d8"), 86 },
                    { new Guid("582b4746-3ad2-42c4-b408-de1692e1cc2c"), "Santiago Ojeda", new Guid("f1a55daa-8417-47ea-9b83-04f63c4cf8d8"), 90 },
                    { new Guid("6d2eefec-d6dd-453c-b100-92668496cac8"), "Francisco Mendoza", new Guid("833c3346-fa7b-40a7-a6e0-745cf6006ed7"), 54 },
                    { new Guid("e3fc4cd8-d773-48d9-85d4-f2f8c93cc345"), "Samanta Lopez", new Guid("833c3346-fa7b-40a7-a6e0-745cf6006ed7"), 75 },
                    { new Guid("77739b69-cabd-4275-9bbc-d770add33272"), "Pedro Jimenez", new Guid("833c3346-fa7b-40a7-a6e0-745cf6006ed7"), 87 },
                    { new Guid("e742406e-6e5f-495f-b375-587234b3302f"), "Alberto Medina", new Guid("b86554c5-6789-411f-ab51-1e01da7ba33d"), 77 },
                    { new Guid("d659adc7-2b2e-41d9-b783-f86e27ca2540"), "Felipe Gonzalez", new Guid("b86554c5-6789-411f-ab51-1e01da7ba33d"), 92 },
                    { new Guid("2f8053cb-e6fb-4400-a575-79136994f942"), "Saul Rodriguez", new Guid("b86554c5-6789-411f-ab51-1e01da7ba33d"), 95 },
                    { new Guid("5d8979de-44f0-41f5-8dc1-e3aad107f682"), "Ricardo Beltran", new Guid("3bb81861-97df-4bd7-8d61-827734fcd808"), 89 },
                    { new Guid("04f4a022-04c9-42a4-973a-755d0c0b767d"), "Claudia Rosales", new Guid("3bb81861-97df-4bd7-8d61-827734fcd808"), 85 },
                    { new Guid("a3d563cd-a358-408c-aa73-238917489bae"), "Patricia Acosta", new Guid("39cf30b9-ddc1-48de-a24a-f408ca7c5179"), 87 },
                    { new Guid("244ddff1-22b2-414c-800a-621543d5794d"), "Alma Lopez", new Guid("39cf30b9-ddc1-48de-a24a-f408ca7c5179"), 94 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("04f4a022-04c9-42a4-973a-755d0c0b767d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("244ddff1-22b2-414c-800a-621543d5794d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("2f428cd4-4799-409f-98d2-256e8e669138"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("2f8053cb-e6fb-4400-a575-79136994f942"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("3380e0a1-1d3b-4dc8-a429-9ad5471c8ba0"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("4a424406-82b3-49d1-8c18-e4effb717c9a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("582b4746-3ad2-42c4-b408-de1692e1cc2c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("5baca2fc-f61e-43b0-b934-27c39d5f4642"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("5d8979de-44f0-41f5-8dc1-e3aad107f682"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("6d2eefec-d6dd-453c-b100-92668496cac8"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("77739b69-cabd-4275-9bbc-d770add33272"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("97dedf40-0ea1-46b1-95ca-51d1c923262a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("a3d563cd-a358-408c-aa73-238917489bae"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("d659adc7-2b2e-41d9-b783-f86e27ca2540"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("dbda2ce8-5611-4273-a64f-be6d6c4c1f10"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("e2b702bb-5ce4-4c32-9d47-200ea3a6c0d7"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("e3fc4cd8-d773-48d9-85d4-f2f8c93cc345"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("e742406e-6e5f-495f-b375-587234b3302f"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: new Guid("39cf30b9-ddc1-48de-a24a-f408ca7c5179"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: new Guid("3aea756e-5203-4811-b290-746d392ade83"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: new Guid("3bb81861-97df-4bd7-8d61-827734fcd808"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: new Guid("833c3346-fa7b-40a7-a6e0-745cf6006ed7"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: new Guid("b86554c5-6789-411f-ab51-1e01da7ba33d"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: new Guid("f1a55daa-8417-47ea-9b83-04f63c4cf8d8"));
        }
    }
}
