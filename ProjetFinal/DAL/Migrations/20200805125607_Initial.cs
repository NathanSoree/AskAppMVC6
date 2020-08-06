using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AttackEF",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiceMultiplicator = table.Column<int>(nullable: false),
                    AttackDie = table.Column<int>(nullable: false),
                    Modifier = table.Column<int>(nullable: false),
                    DamageType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttackEF", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HealthEF",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Multiplicator = table.Column<int>(nullable: false),
                    HitDie = table.Column<int>(nullable: false),
                    ConModifier = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthEF", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Monsters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    IsWide = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Size = table.Column<int>(nullable: false),
                    Alignment = table.Column<int>(nullable: false),
                    ArmorClass = table.Column<int>(nullable: false),
                    HealthId = table.Column<int>(nullable: true),
                    OtherVulnerabilities = table.Column<string>(nullable: true),
                    OtherResistences = table.Column<string>(nullable: true),
                    OtherImmunities = table.Column<string>(nullable: true),
                    DifficultyRating = table.Column<int>(nullable: false),
                    NbrLegendaryActionPerTurn = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monsters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Monsters_HealthEF_HealthId",
                        column: x => x.HealthId,
                        principalTable: "HealthEF",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ActionEF",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsAttack = table.Column<bool>(nullable: false),
                    AttackId = table.Column<int>(nullable: true),
                    MonsterEFId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionEF", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActionEF_AttackEF_AttackId",
                        column: x => x.AttackId,
                        principalTable: "AttackEF",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ActionEF_Monsters_MonsterEFId",
                        column: x => x.MonsterEFId,
                        principalTable: "Monsters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LegendaryActionEF",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Cost = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    MonsterEFId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LegendaryActionEF", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LegendaryActionEF_Monsters_MonsterEFId",
                        column: x => x.MonsterEFId,
                        principalTable: "Monsters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MonsterCondImmuEF",
                columns: table => new
                {
                    MonsterId = table.Column<int>(nullable: false),
                    IdEnum = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterCondImmuEF", x => new { x.MonsterId, x.IdEnum });
                    table.ForeignKey(
                        name: "FK_MonsterCondImmuEF_Monsters_MonsterId",
                        column: x => x.MonsterId,
                        principalTable: "Monsters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonsterImmunitiesEF",
                columns: table => new
                {
                    MonsterId = table.Column<int>(nullable: false),
                    IdEnum = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterImmunitiesEF", x => new { x.MonsterId, x.IdEnum });
                    table.ForeignKey(
                        name: "FK_MonsterImmunitiesEF_Monsters_MonsterId",
                        column: x => x.MonsterId,
                        principalTable: "Monsters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonsterLanguageEF",
                columns: table => new
                {
                    MonsterId = table.Column<int>(nullable: false),
                    Language = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterLanguageEF", x => new { x.MonsterId, x.Language });
                    table.ForeignKey(
                        name: "FK_MonsterLanguageEF_Monsters_MonsterId",
                        column: x => x.MonsterId,
                        principalTable: "Monsters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonsterResistanceEF",
                columns: table => new
                {
                    MonsterId = table.Column<int>(nullable: false),
                    IdEnum = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterResistanceEF", x => new { x.MonsterId, x.IdEnum });
                    table.ForeignKey(
                        name: "FK_MonsterResistanceEF_Monsters_MonsterId",
                        column: x => x.MonsterId,
                        principalTable: "Monsters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonsterSenseEF",
                columns: table => new
                {
                    MonsterId = table.Column<int>(nullable: false),
                    IdEnum = table.Column<int>(nullable: false),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterSenseEF", x => new { x.MonsterId, x.IdEnum });
                    table.ForeignKey(
                        name: "FK_MonsterSenseEF_Monsters_MonsterId",
                        column: x => x.MonsterId,
                        principalTable: "Monsters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonsterSkillEF",
                columns: table => new
                {
                    MonsterId = table.Column<int>(nullable: false),
                    IdEnumSkill = table.Column<int>(nullable: false),
                    IdEnumProf = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterSkillEF", x => new { x.MonsterId, x.IdEnumSkill });
                    table.ForeignKey(
                        name: "FK_MonsterSkillEF_Monsters_MonsterId",
                        column: x => x.MonsterId,
                        principalTable: "Monsters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonsterSpeedEF",
                columns: table => new
                {
                    MonsterId = table.Column<int>(nullable: false),
                    IdEnum = table.Column<int>(nullable: false),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterSpeedEF", x => new { x.MonsterId, x.IdEnum });
                    table.ForeignKey(
                        name: "FK_MonsterSpeedEF_Monsters_MonsterId",
                        column: x => x.MonsterId,
                        principalTable: "Monsters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonsterStatsEF",
                columns: table => new
                {
                    MonsterId = table.Column<int>(nullable: false),
                    IdEnum = table.Column<int>(nullable: false),
                    Value = table.Column<int>(nullable: false),
                    Saving = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterStatsEF", x => new { x.MonsterId, x.IdEnum });
                    table.ForeignKey(
                        name: "FK_MonsterStatsEF_Monsters_MonsterId",
                        column: x => x.MonsterId,
                        principalTable: "Monsters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonsterVulnerabilitiesEF",
                columns: table => new
                {
                    MonsterId = table.Column<int>(nullable: false),
                    IdEnum = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterVulnerabilitiesEF", x => new { x.MonsterId, x.IdEnum });
                    table.ForeignKey(
                        name: "FK_MonsterVulnerabilitiesEF_Monsters_MonsterId",
                        column: x => x.MonsterId,
                        principalTable: "Monsters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReactionEF",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    MonsterEFId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReactionEF", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReactionEF_Monsters_MonsterEFId",
                        column: x => x.MonsterEFId,
                        principalTable: "Monsters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TraitsEF",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    MonsterEFId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraitsEF", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TraitsEF_Monsters_MonsterEFId",
                        column: x => x.MonsterEFId,
                        principalTable: "Monsters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActionEF_AttackId",
                table: "ActionEF",
                column: "AttackId");

            migrationBuilder.CreateIndex(
                name: "IX_ActionEF_MonsterEFId",
                table: "ActionEF",
                column: "MonsterEFId");

            migrationBuilder.CreateIndex(
                name: "IX_LegendaryActionEF_MonsterEFId",
                table: "LegendaryActionEF",
                column: "MonsterEFId");

            migrationBuilder.CreateIndex(
                name: "IX_Monsters_HealthId",
                table: "Monsters",
                column: "HealthId");

            migrationBuilder.CreateIndex(
                name: "IX_ReactionEF_MonsterEFId",
                table: "ReactionEF",
                column: "MonsterEFId");

            migrationBuilder.CreateIndex(
                name: "IX_TraitsEF_MonsterEFId",
                table: "TraitsEF",
                column: "MonsterEFId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActionEF");

            migrationBuilder.DropTable(
                name: "LegendaryActionEF");

            migrationBuilder.DropTable(
                name: "MonsterCondImmuEF");

            migrationBuilder.DropTable(
                name: "MonsterImmunitiesEF");

            migrationBuilder.DropTable(
                name: "MonsterLanguageEF");

            migrationBuilder.DropTable(
                name: "MonsterResistanceEF");

            migrationBuilder.DropTable(
                name: "MonsterSenseEF");

            migrationBuilder.DropTable(
                name: "MonsterSkillEF");

            migrationBuilder.DropTable(
                name: "MonsterSpeedEF");

            migrationBuilder.DropTable(
                name: "MonsterStatsEF");

            migrationBuilder.DropTable(
                name: "MonsterVulnerabilitiesEF");

            migrationBuilder.DropTable(
                name: "ReactionEF");

            migrationBuilder.DropTable(
                name: "TraitsEF");

            migrationBuilder.DropTable(
                name: "AttackEF");

            migrationBuilder.DropTable(
                name: "Monsters");

            migrationBuilder.DropTable(
                name: "HealthEF");
        }
    }
}
