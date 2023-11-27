using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lastonebd.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_iWorkersTab_iSections_iSectionId",
                table: "iWorkersTab");

            migrationBuilder.DropPrimaryKey(
                name: "PK_iWorkersTab",
                table: "iWorkersTab");

            migrationBuilder.DropPrimaryKey(
                name: "PK_iSections",
                table: "iSections");

            migrationBuilder.RenameTable(
                name: "iWorkersTab",
                newName: "IWorkersTab");

            migrationBuilder.RenameTable(
                name: "iSections",
                newName: "ISections");

            migrationBuilder.RenameColumn(
                name: "iSectionId",
                table: "IWorkersTab",
                newName: "ISectionId");

            migrationBuilder.RenameIndex(
                name: "IX_iWorkersTab_iSectionId",
                table: "IWorkersTab",
                newName: "IX_IWorkersTab_ISectionId");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "IWorkersTab",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IWorkersTab",
                table: "IWorkersTab",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ISections",
                table: "ISections",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IWorkersTab_ISections_ISectionId",
                table: "IWorkersTab",
                column: "ISectionId",
                principalTable: "ISections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IWorkersTab_ISections_ISectionId",
                table: "IWorkersTab");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IWorkersTab",
                table: "IWorkersTab");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ISections",
                table: "ISections");

            migrationBuilder.RenameTable(
                name: "IWorkersTab",
                newName: "iWorkersTab");

            migrationBuilder.RenameTable(
                name: "ISections",
                newName: "iSections");

            migrationBuilder.RenameColumn(
                name: "ISectionId",
                table: "iWorkersTab",
                newName: "iSectionId");

            migrationBuilder.RenameIndex(
                name: "IX_IWorkersTab_ISectionId",
                table: "iWorkersTab",
                newName: "IX_iWorkersTab_iSectionId");

            migrationBuilder.AlterColumn<int>(
                name: "Surname",
                table: "iWorkersTab",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_iWorkersTab",
                table: "iWorkersTab",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_iSections",
                table: "iSections",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_iWorkersTab_iSections_iSectionId",
                table: "iWorkersTab",
                column: "iSectionId",
                principalTable: "iSections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
