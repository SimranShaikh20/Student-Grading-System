using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class Link : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileContent",
                table: "Submission");

            migrationBuilder.RenameColumn(
                name: "UploadedAt",
                table: "Submission",
                newName: "SubmittedAt");

            migrationBuilder.RenameColumn(
                name: "FileName",
                table: "Submission",
                newName: "SubmissionLink");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SubmittedAt",
                table: "Submission",
                newName: "UploadedAt");

            migrationBuilder.RenameColumn(
                name: "SubmissionLink",
                table: "Submission",
                newName: "FileName");

            migrationBuilder.AddColumn<byte[]>(
                name: "FileContent",
                table: "Submission",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }
    }
}
