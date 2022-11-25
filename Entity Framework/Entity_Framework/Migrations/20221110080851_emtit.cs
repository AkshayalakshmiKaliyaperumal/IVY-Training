using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class emtit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    departmentname = table.Column<string>(name: "department_name", type: "nvarchar(450)", nullable: false),
                    departmentid = table.Column<int>(name: "department_id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.departmentname);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Employeeid = table.Column<int>(name: "Employee_id", type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Departmentid = table.Column<string>(name: "Department_id", type: "nvarchar(max)", nullable: false),
                    salary = table.Column<int>(type: "int", nullable: false),
                    departmentsdepartmentname = table.Column<string>(name: "departmentsdepartment_name", type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.Name);
                    table.ForeignKey(
                        name: "FK_employees_departments_departmentsdepartment_name",
                        column: x => x.departmentsdepartmentname,
                        principalTable: "departments",
                        principalColumn: "department_name");
                });

            migrationBuilder.CreateIndex(
                name: "IX_employees_departmentsdepartment_name",
                table: "employees",
                column: "departmentsdepartment_name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "departments");
        }
    }
}
