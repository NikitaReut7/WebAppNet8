using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class a3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseEntities",
                columns: table => new
                {
                    BaseNumber = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseEntities", x => x.BaseNumber);
                });

            migrationBuilder.CreateTable(
                name: "DerivedEntitiesA",
                columns: table => new
                {
                    BaseNumber = table.Column<string>(type: "text", nullable: false),
                    PropertyA = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: true),
                    Value = table.Column<string>(type: "text", nullable: true),
                    Count = table.Column<string>(type: "text", nullable: false),
                    MoneyString = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DerivedEntitiesA", x => x.BaseNumber);
                    table.ForeignKey(
                        name: "FK_DerivedEntitiesA_BaseEntities_BaseNumber",
                        column: x => x.BaseNumber,
                        principalTable: "BaseEntities",
                        principalColumn: "BaseNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DerivedEntitiesC",
                columns: table => new
                {
                    BaseNumber = table.Column<string>(type: "text", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: true),
                    Value = table.Column<string>(type: "text", nullable: true),
                    PropertyC = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    Count = table.Column<string>(type: "text", nullable: false),
                    MoneyString = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DerivedEntitiesC", x => x.BaseNumber);
                    table.ForeignKey(
                        name: "FK_DerivedEntitiesC_BaseEntities_BaseNumber",
                        column: x => x.BaseNumber,
                        principalTable: "BaseEntities",
                        principalColumn: "BaseNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DerivedEntitiesB",
                columns: table => new
                {
                    BaseNumber = table.Column<string>(type: "text", nullable: false),
                    PropertyB = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DerivedEntitiesB", x => x.BaseNumber);
                    table.ForeignKey(
                        name: "FK_DerivedEntitiesB_DerivedEntitiesA_BaseNumber",
                        column: x => x.BaseNumber,
                        principalTable: "DerivedEntitiesA",
                        principalColumn: "BaseNumber",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DerivedEntitiesB");

            migrationBuilder.DropTable(
                name: "DerivedEntitiesC");

            migrationBuilder.DropTable(
                name: "DerivedEntitiesA");

            migrationBuilder.DropTable(
                name: "BaseEntities");
        }
    }
}
