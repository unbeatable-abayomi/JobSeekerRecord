using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSeekerRecord.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobSeekerTable",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 20, nullable: false),
                    LastName = table.Column<string>(maxLength: 20, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    DOB = table.Column<string>(nullable: false),
                    GraduationYear = table.Column<int>(nullable: false),
                    CourseStudied = table.Column<string>(nullable: false),
                    GraduatedWith = table.Column<string>(nullable: false),
                    Speclization = table.Column<string>(nullable: false),
                    Hobbies = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSeekerTable", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobSeekerTable");
        }
    }
}
