using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class empdept : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"create or alter procedure emp_dept(@dept_id int) as Select * from employees where Department_id = @dept_id";
            migrationBuilder.Sql(procedure);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"drop procedure emp_dept";
            migrationBuilder.Sql(procedure);
        }
    }
}
