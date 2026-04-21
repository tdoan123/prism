using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prism.Api.Migrations
{
    /// <inheritdoc />
    public partial class EnablePgVector : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("CREATE EXTENSION IF NOT EXISTS vector;");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP EXTENSION vector;");
        }
    }
}
