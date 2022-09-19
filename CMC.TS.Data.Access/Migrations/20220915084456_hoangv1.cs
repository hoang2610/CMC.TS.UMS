using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CMC.TS.UMS.Data.Access.Migrations
{
    public partial class hoangv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false),
                    TYPE = table.Column<int>(nullable: false),
                    PARENT_ID = table.Column<int>(nullable: false),
                    PATH = table.Column<string>(maxLength: 100, nullable: true),
                    CODE = table.Column<string>(maxLength: 100, nullable: true),
                    E_CODE = table.Column<string>(maxLength: 100, nullable: true),
                    NAME = table.Column<string>(maxLength: 100, nullable: true),
                    INTERNATIONAL_NAME = table.Column<string>(maxLength: 100, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 200, nullable: true),
                    EDOC = table.Column<int>(nullable: false),
                    AREA_CODE = table.Column<string>(maxLength: 100, nullable: true),
                    TAX_CODE = table.Column<string>(maxLength: 100, nullable: true),
                    STATUS = table.Column<int>(nullable: false),
                    ADDRESS = table.Column<string>(maxLength: 200, nullable: true),
                    PHONE = table.Column<string>(maxLength: 20, nullable: true),
                    EMAIL = table.Column<string>(maxLength: 50, nullable: true),
                    FAX = table.Column<string>(maxLength: 100, nullable: true),
                    WEBSITE = table.Column<string>(maxLength: 100, nullable: true),
                    STAMP = table.Column<byte>(nullable: false),
                    LOGO = table.Column<byte>(nullable: false),
                    SEQ_NO = table.Column<int>(nullable: false),
                    ADMINISTRATOR = table.Column<int>(nullable: false),
                    MEMBERS = table.Column<int>(nullable: false),
                    MANAGERS = table.Column<int>(nullable: false),
                    ASSISTANCE = table.Column<int>(nullable: false),
                    INPUT_CODE = table.Column<string>(maxLength: 100, nullable: true),
                    ORG_CODE = table.Column<string>(maxLength: 100, nullable: true),
                    ORG_PATH = table.Column<string>(maxLength: 100, nullable: true),
                    IS_LEGAL = table.Column<int>(nullable: false),
                    PRIVATE_REGISTER = table.Column<int>(nullable: false),
                    CREATED = table.Column<DateTime>(nullable: false),
                    CREATED_BY = table.Column<string>(maxLength: 100, nullable: true),
                    CREATED_BY_NAME = table.Column<string>(maxLength: 100, nullable: true),
                    MODIFIED = table.Column<DateTime>(nullable: false),
                    MODIFIED_BY = table.Column<string>(maxLength: 100, nullable: true),
                    MODIFIED_BY_NAME = table.Column<string>(maxLength: 100, nullable: true),
                    END_DATE = table.Column<DateTime>(nullable: false),
                    START_DATE = table.Column<DateTime>(nullable: false),
                    STAMP_HEIGHT = table.Column<int>(nullable: false),
                    STAMP_WIDTH = table.Column<int>(nullable: false),
                    BIZ_CODE = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false),
                    CREATE_BY = table.Column<string>(maxLength: 100, nullable: true),
                    CREATE_BY_NAME = table.Column<string>(maxLength: 100, nullable: true),
                    CREATED = table.Column<DateTime>(nullable: false),
                    MODIFIED_BY = table.Column<string>(maxLength: 100, nullable: true),
                    MODIFIED_BY_NAME = table.Column<string>(maxLength: 100, nullable: true),
                    MODIFIED = table.Column<DateTime>(nullable: false),
                    CODE = table.Column<string>(maxLength: 100, nullable: true),
                    NAME = table.Column<string>(maxLength: 100, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 500, nullable: true),
                    STATUS = table.Column<int>(nullable: false),
                    SEQ_NO = table.Column<int>(nullable: false),
                    IS_SYSTEM = table.Column<int>(nullable: false),
                    SIGN_METHODS = table.Column<string>(maxLength: 100, nullable: true),
                    ORG_CODE = table.Column<string>(maxLength: 100, nullable: true),
                    ORG_PATH = table.Column<string>(maxLength: 100, nullable: true),
                    TYPE = table.Column<string>(maxLength: 100, nullable: true),
                    ROLE_TYPE_ID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false),
                    LOGIN_NAME = table.Column<string>(maxLength: 50, nullable: true),
                    PASSWORD = table.Column<string>(nullable: true),
                    FULL_NAME = table.Column<string>(maxLength: 200, nullable: true),
                    BIRTH_OF_DATE = table.Column<DateTime>(nullable: false),
                    AVATAR = table.Column<byte>(nullable: false),
                    STATUS = table.Column<int>(nullable: false),
                    EMAIL = table.Column<string>(maxLength: 200, nullable: true),
                    PHONE = table.Column<string>(maxLength: 13, nullable: true),
                    SEQ_NO = table.Column<int>(nullable: false),
                    MANAGER = table.Column<int>(nullable: false),
                    IS_ADMIN = table.Column<int>(nullable: false),
                    IS_SYSTEM = table.Column<int>(nullable: false),
                    IS_LOCKED = table.Column<int>(nullable: false),
                    IS_MOBILE = table.Column<int>(nullable: false),
                    OFF_DATE = table.Column<DateTime>(nullable: false),
                    PROVIDER_TYPE = table.Column<int>(nullable: false),
                    PROVIDER_CODE = table.Column<string>(maxLength: 200, nullable: true),
                    ORG_CODE = table.Column<string>(maxLength: 100, nullable: true),
                    ORG_PATH = table.Column<string>(maxLength: 100, nullable: true),
                    CREATED = table.Column<DateTime>(nullable: false),
                    CREATED_BY = table.Column<string>(maxLength: 100, nullable: true),
                    CREATED_BY_NAME = table.Column<string>(maxLength: 100, nullable: true),
                    MODIFIED = table.Column<DateTime>(nullable: false),
                    MODIFIED_BY = table.Column<string>(maxLength: 50, nullable: true),
                    MODIFIED_BY_NAME = table.Column<string>(maxLength: 100, nullable: true),
                    JOB_TITLE = table.Column<string>(maxLength: 100, nullable: true),
                    FAILED_LOGIN_COUNT = table.Column<int>(nullable: false),
                    LAST_FAILED_LOGIN = table.Column<DateTime>(nullable: false),
                    LAST_FAILED_LOGIN_MSG = table.Column<string>(maxLength: 100, nullable: true),
                    LAST_PWD_CHANGED = table.Column<DateTime>(nullable: false),
                    IS_NOTI = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User_Roles",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false),
                    USER_ID = table.Column<long>(nullable: false),
                    ROLE_ID = table.Column<long>(nullable: false),
                    DEPARTMENT_ID = table.Column<long>(nullable: false),
                    IS_DEFAULT = table.Column<int>(nullable: false),
                    SEQ_NO = table.Column<int>(nullable: false),
                    IS_ACTIVE = table.Column<int>(nullable: false),
                    ORG_CODE = table.Column<string>(maxLength: 100, nullable: true),
                    ORG_PATH = table.Column<string>(maxLength: 100, nullable: true),
                    CREATED = table.Column<DateTime>(nullable: false),
                    CREATED_BY = table.Column<string>(maxLength: 100, nullable: true),
                    CREATED_BY_NAME = table.Column<string>(maxLength: 100, nullable: true),
                    MODIFIED = table.Column<DateTime>(nullable: false),
                    MODIFIED_BY = table.Column<string>(maxLength: 100, nullable: true),
                    MODIFIED_BY_NAME = table.Column<string>(maxLength: 100, nullable: true),
                    ORGANIZATIONsID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Roles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_User_Roles_Organizations_ORGANIZATIONsID",
                        column: x => x.ORGANIZATIONsID,
                        principalTable: "Organizations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Roles_Roles_ROLE_ID",
                        column: x => x.ROLE_ID,
                        principalTable: "Roles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Roles_Users_ROLE_ID",
                        column: x => x.ROLE_ID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_CODE",
                table: "Organizations",
                column: "CODE",
                unique: true,
                filter: "[CODE] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_User_Roles_ORGANIZATIONsID",
                table: "User_Roles",
                column: "ORGANIZATIONsID");

            migrationBuilder.CreateIndex(
                name: "IX_User_Roles_ROLE_ID",
                table: "User_Roles",
                column: "ROLE_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User_Roles");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
