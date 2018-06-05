using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AsteriskBook.Migrations
{
    public partial class UpdBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cdr",
                columns: table => new
                {
                    calldate = table.Column<DateTime>(nullable: false),
                    accountcode = table.Column<string>(nullable: true),
                    amaflags = table.Column<int>(nullable: false),
                    answer = table.Column<DateTime>(nullable: false),
                    billsec = table.Column<int>(nullable: false),
                    channel = table.Column<string>(nullable: true),
                    clid = table.Column<string>(nullable: true),
                    dcontext = table.Column<string>(nullable: true),
                    disposition = table.Column<string>(nullable: true),
                    dst = table.Column<string>(nullable: true),
                    dstchannel = table.Column<string>(nullable: true),
                    duration = table.Column<int>(nullable: false),
                    end = table.Column<DateTime>(nullable: false),
                    lastapp = table.Column<string>(nullable: true),
                    lastdata = table.Column<string>(nullable: true),
                    src = table.Column<string>(nullable: true),
                    start = table.Column<DateTime>(nullable: false),
                    uniqueid = table.Column<string>(nullable: true),
                    userfield = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cdr", x => x.calldate);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cdr");
        }
    }
}
