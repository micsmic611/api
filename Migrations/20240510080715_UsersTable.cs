using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace core.Migrations
{
    /// <inheritdoc />
    public partial class UsersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ITEM_LOCATION_ASSIGNMENT",
                columns: table => new
                {
                    INTERNAL_ITEM_LOC_NUM = table.Column<decimal>(type: "numeric(9,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENANT_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    warehouse = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    ITEM = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    COMPANY = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    QUANTITY_UM = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    ALLOCATION_LOC = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    USER_DEF1 = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    USER_DEF2 = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    USER_DEF3 = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    USER_DEF4 = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    USER_DEF5 = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    USER_DEF6 = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    USER_DEF7 = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    USER_DEF8 = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    USER_STAMP = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    PROCESS_STAMP = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DATE_TIME_STAMP = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITEM_LOCATION_ASSIGNMENT", x => x.INTERNAL_ITEM_LOC_NUM);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ITEM_LOCATION_ASSIGNMENT");
        }
    }
}
