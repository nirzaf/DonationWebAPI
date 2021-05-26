using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "mobile",
                table: "DCandidates",
                newName: "Mobile");

            migrationBuilder.RenameColumn(
                name: "fullName",
                table: "DCandidates",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "DCandidates",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "bloodGroup",
                table: "DCandidates",
                newName: "BloodGroup");

            migrationBuilder.RenameColumn(
                name: "age",
                table: "DCandidates",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "DCandidates",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "DCandidates",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Mobile",
                table: "DCandidates",
                newName: "mobile");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "DCandidates",
                newName: "fullName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "DCandidates",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "BloodGroup",
                table: "DCandidates",
                newName: "bloodGroup");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "DCandidates",
                newName: "age");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "DCandidates",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DCandidates",
                newName: "id");
        }
    }
}
