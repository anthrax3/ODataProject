﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ODataProject.Migrations
{
    public partial class NuevaModificacion02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "StudentId",
                table: "students",
                nullable: false,
                defaultValue: new Guid("d57f44db-68e3-47f8-a71d-2747c54f13f9"),
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "SchoolId",
                table: "schools",
                nullable: false,
                defaultValue: new Guid("e78ca90c-d218-48bb-bdd4-9f1b23bba92f"),
                oldClrType: typeof(Guid));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "StudentId",
                table: "students",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValue: new Guid("d57f44db-68e3-47f8-a71d-2747c54f13f9"));

            migrationBuilder.AlterColumn<Guid>(
                name: "SchoolId",
                table: "schools",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValue: new Guid("e78ca90c-d218-48bb-bdd4-9f1b23bba92f"));
        }
    }
}
