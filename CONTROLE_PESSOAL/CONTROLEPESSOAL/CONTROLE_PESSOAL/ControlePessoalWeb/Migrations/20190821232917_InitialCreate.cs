using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControlePessoalWeb.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "__MigrationHistory",
                columns: table => new
                {
                    MigrationId = table.Column<string>(maxLength: 150, nullable: false),
                    ContextKey = table.Column<string>(maxLength: 300, nullable: false),
                    Model = table.Column<byte[]>(nullable: false),
                    ProductVersion = table.Column<string>(maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.__MigrationHistory", x => new { x.MigrationId, x.ContextKey });
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 128, nullable: false),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEndDateUtc = table.Column<DateTime>(type: "datetime", nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AUTOR",
                columns: table => new
                {
                    Idautor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AUTOR__9C1E582EDDA98922", x => x.Idautor);
                });

            migrationBuilder.CreateTable(
                name: "GENERO",
                columns: table => new
                {
                    Idgenero = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GENERO__EFE568FA82346E69", x => x.Idgenero);
                });

            migrationBuilder.CreateTable(
                name: "PESSOA",
                columns: table => new
                {
                    Idpessoa = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(unicode: false, maxLength: 80, nullable: true),
                    datanasc = table.Column<DateTime>(type: "datetime", nullable: true),
                    estadocivil = table.Column<int>(nullable: true),
                    telefone = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    celular = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    email = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    endereco = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    numero = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    cidade = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    uf = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    complmento = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    cep = table.Column<string>(unicode: false, maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PESSOA__4B7C35F6C956C8D2", x => x.Idpessoa);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(maxLength: 128, nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    UserId = table.Column<string>(maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey, x.UserId });
                    table.ForeignKey(
                        name: "FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(maxLength: 128, nullable: false),
                    RoleId = table.Column<string>(maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LIVRO",
                columns: table => new
                {
                    idlivro = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Idgenero = table.Column<int>(nullable: true),
                    Idautor = table.Column<int>(nullable: true),
                    titulo = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    idioma = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    qtd_paginas = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LIVRO__C2F51079CEA58EE9", x => x.idlivro);
                    table.ForeignKey(
                        name: "S#LIVRO002",
                        column: x => x.Idautor,
                        principalTable: "AUTOR",
                        principalColumn: "Idautor",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "S#LIVRO001",
                        column: x => x.Idgenero,
                        principalTable: "GENERO",
                        principalColumn: "Idgenero",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CONTA_PAGAR",
                columns: table => new
                {
                    Idconta_pagar = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    idpessoa = table.Column<int>(nullable: true),
                    valor = table.Column<decimal>(type: "money", nullable: true),
                    vencimento = table.Column<DateTime>(type: "datetime", nullable: true),
                    descricao = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    formapagamento = table.Column<int>(nullable: true),
                    mesreferencia = table.Column<int>(nullable: true),
                    anoreferencia = table.Column<int>(nullable: true),
                    parcelamento = table.Column<bool>(nullable: true),
                    totalparcelas = table.Column<int>(nullable: true),
                    parcelaspagas = table.Column<int>(nullable: true),
                    parcelasapagar = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CONTA_PA__BE52FA94FEE7E5D3", x => x.Idconta_pagar);
                    table.ForeignKey(
                        name: "S#CONTA_PAGAR001",
                        column: x => x.idpessoa,
                        principalTable: "PESSOA",
                        principalColumn: "Idpessoa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CONTA_RECEBER",
                columns: table => new
                {
                    Idconta_receber = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    idpessoa = table.Column<int>(nullable: true),
                    valor = table.Column<decimal>(type: "money", nullable: true),
                    vencimento = table.Column<DateTime>(type: "datetime", nullable: true),
                    descricao = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    formapagamento = table.Column<int>(nullable: true),
                    mesreferencia = table.Column<int>(nullable: true),
                    anoreferencia = table.Column<int>(nullable: true),
                    parcelamento = table.Column<bool>(nullable: true),
                    totalparcelas = table.Column<int>(nullable: true),
                    parcelasrecebidas = table.Column<int>(nullable: true),
                    parcelasreceber = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CONTA_RE__DFAFF2D26E287AA0", x => x.Idconta_receber);
                    table.ForeignKey(
                        name: "S#CONTA_RECEBER001",
                        column: x => x.idpessoa,
                        principalTable: "PESSOA",
                        principalColumn: "Idpessoa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "META",
                columns: table => new
                {
                    Idmeta = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    idpessoa = table.Column<int>(nullable: true),
                    tipometa = table.Column<int>(nullable: true),
                    nomemeta = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    descricao = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    prazo = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__META__2779D57AF78809AC", x => x.Idmeta);
                    table.ForeignKey(
                        name: "S#META001",
                        column: x => x.idpessoa,
                        principalTable: "PESSOA",
                        principalColumn: "Idpessoa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "USUARIO",
                columns: table => new
                {
                    Idusuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cod_usuario = table.Column<int>(nullable: true),
                    usuario = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    senha = table.Column<string>(unicode: false, maxLength: 18, nullable: true),
                    idpessoa = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__USUARIO__7AC21576C1425656", x => x.Idusuario);
                    table.ForeignKey(
                        name: "S#USUARIO001",
                        column: x => x.idpessoa,
                        principalTable: "PESSOA",
                        principalColumn: "Idpessoa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LEITURA",
                columns: table => new
                {
                    Idmeta = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    idpessoa = table.Column<int>(nullable: true),
                    idlivro = table.Column<int>(nullable: true),
                    tempoleitura = table.Column<TimeSpan>(nullable: true),
                    avaliacao = table.Column<int>(nullable: true),
                    descavaliacao = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LEITURA__2779D57AFE5CF9E9", x => x.Idmeta);
                    table.ForeignKey(
                        name: "S#LEITURA001",
                        column: x => x.idlivro,
                        principalTable: "LIVRO",
                        principalColumn: "idlivro",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserId",
                table: "AspNetUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CONTA_PAGAR_idpessoa",
                table: "CONTA_PAGAR",
                column: "idpessoa");

            migrationBuilder.CreateIndex(
                name: "IX_CONTA_RECEBER_idpessoa",
                table: "CONTA_RECEBER",
                column: "idpessoa");

            migrationBuilder.CreateIndex(
                name: "IX_LEITURA_idlivro",
                table: "LEITURA",
                column: "idlivro");

            migrationBuilder.CreateIndex(
                name: "IX_LIVRO_Idautor",
                table: "LIVRO",
                column: "Idautor");

            migrationBuilder.CreateIndex(
                name: "IX_LIVRO_Idgenero",
                table: "LIVRO",
                column: "Idgenero");

            migrationBuilder.CreateIndex(
                name: "IX_META_idpessoa",
                table: "META",
                column: "idpessoa");

            migrationBuilder.CreateIndex(
                name: "IX_USUARIO_idpessoa",
                table: "USUARIO",
                column: "idpessoa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "__MigrationHistory");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "CONTA_PAGAR");

            migrationBuilder.DropTable(
                name: "CONTA_RECEBER");

            migrationBuilder.DropTable(
                name: "LEITURA");

            migrationBuilder.DropTable(
                name: "META");

            migrationBuilder.DropTable(
                name: "USUARIO");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "LIVRO");

            migrationBuilder.DropTable(
                name: "PESSOA");

            migrationBuilder.DropTable(
                name: "AUTOR");

            migrationBuilder.DropTable(
                name: "GENERO");
        }
    }
}
