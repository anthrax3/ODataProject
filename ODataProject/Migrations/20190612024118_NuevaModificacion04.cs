using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ODataProject.Migrations
{
    public partial class NuevaModificacion04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "StudentId",
                table: "students",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldDefaultValue: new Guid("30fe9f77-c4f5-40e3-b6ec-2f7934ac6831"));

            migrationBuilder.AlterColumn<Guid>(
                name: "SchoolId",
                table: "schools",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldDefaultValue: new Guid("ca253b7f-3a2a-413c-944c-59d45a148edd"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "StudentId",
                table: "students",
                nullable: false,
                defaultValue: new Guid("30fe9f77-c4f5-40e3-b6ec-2f7934ac6831"),
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.AlterColumn<Guid>(
                name: "SchoolId",
                table: "schools",
                nullable: false,
                defaultValue: new Guid("ca253b7f-3a2a-413c-944c-59d45a148edd"),
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "NEWID()");
        }
    }
}
