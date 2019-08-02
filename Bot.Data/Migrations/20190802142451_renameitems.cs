using Microsoft.EntityFrameworkCore.Migrations;

namespace Bot.Data.Migrations
{
    public partial class renameitems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersItems_Tasks_TaskId",
                table: "UsersItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks");

            migrationBuilder.RenameTable(
                name: "Tasks",
                newName: "Items");

            migrationBuilder.RenameColumn(
                name: "TaskId",
                table: "UsersItems",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_UsersItems_TaskId",
                table: "UsersItems",
                newName: "IX_UsersItems_ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersItems_Items_ItemId",
                table: "UsersItems",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersItems_Items_ItemId",
                table: "UsersItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "Tasks");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "UsersItems",
                newName: "TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_UsersItems_ItemId",
                table: "UsersItems",
                newName: "IX_UsersItems_TaskId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersItems_Tasks_TaskId",
                table: "UsersItems",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
