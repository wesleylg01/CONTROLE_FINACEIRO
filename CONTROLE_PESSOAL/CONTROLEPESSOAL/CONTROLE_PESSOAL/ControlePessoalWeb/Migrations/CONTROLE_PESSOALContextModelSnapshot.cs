﻿// <auto-generated />
using System;
using ControlePessoalWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ControlePessoalWeb.Migrations
{
    [DbContext(typeof(CONTROLE_PESSOALContext))]
    partial class CONTROLE_PESSOALContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ControlePessoalWeb.Models.AspNetRoles", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("ControlePessoalWeb.Models.AspNetUserClaims", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .HasName("IX_UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("ControlePessoalWeb.Models.AspNetUserLogins", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("UserId")
                        .HasMaxLength(128);

                    b.HasKey("LoginProvider", "ProviderKey", "UserId")
                        .HasName("PK_dbo.AspNetUserLogins");

                    b.HasIndex("UserId")
                        .HasName("IX_UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("ControlePessoalWeb.Models.AspNetUserRoles", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(128);

                    b.Property<string>("RoleId")
                        .HasMaxLength(128);

                    b.HasKey("UserId", "RoleId")
                        .HasName("PK_dbo.AspNetUserRoles");

                    b.HasIndex("RoleId")
                        .HasName("IX_RoleId");

                    b.HasIndex("UserId")
                        .HasName("IX_UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("ControlePessoalWeb.Models.AspNetUsers", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(128);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTime?>("LockoutEndDateUtc")
                        .HasColumnType("datetime");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("UserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ControlePessoalWeb.Models.Autor", b =>
                {
                    b.Property<int>("Idautor")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnName("nome")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.HasKey("Idautor")
                        .HasName("PK__AUTOR__9C1E582EDDA98922");

                    b.ToTable("AUTOR");
                });

            modelBuilder.Entity("ControlePessoalWeb.Models.ContaPagar", b =>
                {
                    b.Property<int>("IdcontaPagar")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Idconta_pagar")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Anoreferencia")
                        .HasColumnName("anoreferencia");

                    b.Property<string>("Descricao")
                        .HasColumnName("descricao")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<int?>("Formapagamento")
                        .HasColumnName("formapagamento");

                    b.Property<int?>("Idpessoa")
                        .HasColumnName("idpessoa");

                    b.Property<int?>("Mesreferencia")
                        .HasColumnName("mesreferencia");

                    b.Property<bool?>("Parcelamento")
                        .HasColumnName("parcelamento");

                    b.Property<int?>("Parcelasapagar")
                        .HasColumnName("parcelasapagar");

                    b.Property<int?>("Parcelaspagas")
                        .HasColumnName("parcelaspagas");

                    b.Property<int?>("Totalparcelas")
                        .HasColumnName("totalparcelas");

                    b.Property<decimal?>("Valor")
                        .HasColumnName("valor")
                        .HasColumnType("money");

                    b.Property<DateTime?>("Vencimento")
                        .HasColumnName("vencimento")
                        .HasColumnType("datetime");

                    b.HasKey("IdcontaPagar")
                        .HasName("PK__CONTA_PA__BE52FA94FEE7E5D3");

                    b.HasIndex("Idpessoa");

                    b.ToTable("CONTA_PAGAR");
                });

            modelBuilder.Entity("ControlePessoalWeb.Models.ContaReceber", b =>
                {
                    b.Property<int>("IdcontaReceber")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Idconta_receber")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Anoreferencia")
                        .HasColumnName("anoreferencia");

                    b.Property<string>("Descricao")
                        .HasColumnName("descricao")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<int?>("Formapagamento")
                        .HasColumnName("formapagamento");

                    b.Property<int?>("Idpessoa")
                        .HasColumnName("idpessoa");

                    b.Property<int?>("Mesreferencia")
                        .HasColumnName("mesreferencia");

                    b.Property<bool?>("Parcelamento")
                        .HasColumnName("parcelamento");

                    b.Property<int?>("Parcelasreceber")
                        .HasColumnName("parcelasreceber");

                    b.Property<int?>("Parcelasrecebidas")
                        .HasColumnName("parcelasrecebidas");

                    b.Property<int?>("Totalparcelas")
                        .HasColumnName("totalparcelas");

                    b.Property<decimal?>("Valor")
                        .HasColumnName("valor")
                        .HasColumnType("money");

                    b.Property<DateTime?>("Vencimento")
                        .HasColumnName("vencimento")
                        .HasColumnType("datetime");

                    b.HasKey("IdcontaReceber")
                        .HasName("PK__CONTA_RE__DFAFF2D26E287AA0");

                    b.HasIndex("Idpessoa");

                    b.ToTable("CONTA_RECEBER");
                });

            modelBuilder.Entity("ControlePessoalWeb.Models.Genero", b =>
                {
                    b.Property<int>("Idgenero")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnName("nome")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.HasKey("Idgenero")
                        .HasName("PK__GENERO__EFE568FA82346E69");

                    b.ToTable("GENERO");
                });

            modelBuilder.Entity("ControlePessoalWeb.Models.Leitura", b =>
                {
                    b.Property<int>("Idmeta")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Avaliacao")
                        .HasColumnName("avaliacao");

                    b.Property<string>("Descavaliacao")
                        .HasColumnName("descavaliacao")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<int?>("Idlivro")
                        .HasColumnName("idlivro");

                    b.Property<int?>("Idpessoa")
                        .HasColumnName("idpessoa");

                    b.Property<TimeSpan?>("Tempoleitura")
                        .HasColumnName("tempoleitura");

                    b.HasKey("Idmeta")
                        .HasName("PK__LEITURA__2779D57AFE5CF9E9");

                    b.HasIndex("Idlivro");

                    b.ToTable("LEITURA");
                });

            modelBuilder.Entity("ControlePessoalWeb.Models.Livro", b =>
                {
                    b.Property<int>("Idlivro")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idlivro")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Idautor");

                    b.Property<int?>("Idgenero");

                    b.Property<string>("Idioma")
                        .HasColumnName("idioma")
                        .HasMaxLength(40)
                        .IsUnicode(false);

                    b.Property<int?>("QtdPaginas")
                        .HasColumnName("qtd_paginas");

                    b.Property<string>("Titulo")
                        .HasColumnName("titulo")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.HasKey("Idlivro")
                        .HasName("PK__LIVRO__C2F51079CEA58EE9");

                    b.HasIndex("Idautor");

                    b.HasIndex("Idgenero");

                    b.ToTable("LIVRO");
                });

            modelBuilder.Entity("ControlePessoalWeb.Models.Meta", b =>
                {
                    b.Property<int>("Idmeta")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnName("descricao")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<int?>("Idpessoa")
                        .HasColumnName("idpessoa");

                    b.Property<string>("Nomemeta")
                        .HasColumnName("nomemeta")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<DateTime?>("Prazo")
                        .HasColumnName("prazo")
                        .HasColumnType("datetime");

                    b.Property<int?>("Tipometa")
                        .HasColumnName("tipometa");

                    b.HasKey("Idmeta")
                        .HasName("PK__META__2779D57AF78809AC");

                    b.HasIndex("Idpessoa");

                    b.ToTable("META");
                });

            modelBuilder.Entity("ControlePessoalWeb.Models.MigrationHistory", b =>
                {
                    b.Property<string>("MigrationId")
                        .HasMaxLength(150);

                    b.Property<string>("ContextKey")
                        .HasMaxLength(300);

                    b.Property<byte[]>("Model")
                        .IsRequired();

                    b.Property<string>("ProductVersion")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.HasKey("MigrationId", "ContextKey")
                        .HasName("PK_dbo.__MigrationHistory");

                    b.ToTable("__MigrationHistory");
                });

            modelBuilder.Entity("ControlePessoalWeb.Models.Pessoa", b =>
                {
                    b.Property<int>("Idpessoa")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Celular")
                        .HasColumnName("celular")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("Cep")
                        .HasColumnName("cep")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.Property<string>("Cidade")
                        .HasColumnName("cidade")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Complmento")
                        .HasColumnName("complmento")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<DateTime?>("Datanasc")
                        .HasColumnName("datanasc")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Endereco")
                        .HasColumnName("endereco")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<int?>("Estadocivil")
                        .HasColumnName("estadocivil");

                    b.Property<string>("Nome")
                        .HasColumnName("nome")
                        .HasMaxLength(80)
                        .IsUnicode(false);

                    b.Property<string>("Numero")
                        .HasColumnName("numero")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Telefone")
                        .HasColumnName("telefone")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("Uf")
                        .HasColumnName("uf")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    b.HasKey("Idpessoa")
                        .HasName("PK__PESSOA__4B7C35F6C956C8D2");

                    b.ToTable("PESSOA");
                });

            modelBuilder.Entity("ControlePessoalWeb.Models.Usuario", b =>
                {
                    b.Property<int>("Idusuario")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CodUsuario")
                        .HasColumnName("Cod_usuario");

                    b.Property<int?>("Idpessoa")
                        .HasColumnName("idpessoa");

                    b.Property<string>("Senha")
                        .HasColumnName("senha")
                        .HasMaxLength(18)
                        .IsUnicode(false);

                    b.Property<string>("Usuario1")
                        .HasColumnName("usuario")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.HasKey("Idusuario")
                        .HasName("PK__USUARIO__7AC21576C1425656");

                    b.HasIndex("Idpessoa");

                    b.ToTable("USUARIO");
                });

            modelBuilder.Entity("ControlePessoalWeb.Models.AspNetUserClaims", b =>
                {
                    b.HasOne("ControlePessoalWeb.Models.AspNetUsers", "User")
                        .WithMany("AspNetUserClaims")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ControlePessoalWeb.Models.AspNetUserLogins", b =>
                {
                    b.HasOne("ControlePessoalWeb.Models.AspNetUsers", "User")
                        .WithMany("AspNetUserLogins")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ControlePessoalWeb.Models.AspNetUserRoles", b =>
                {
                    b.HasOne("ControlePessoalWeb.Models.AspNetRoles", "Role")
                        .WithMany("AspNetUserRoles")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ControlePessoalWeb.Models.AspNetUsers", "User")
                        .WithMany("AspNetUserRoles")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ControlePessoalWeb.Models.ContaPagar", b =>
                {
                    b.HasOne("ControlePessoalWeb.Models.Pessoa", "IdpessoaNavigation")
                        .WithMany("ContaPagar")
                        .HasForeignKey("Idpessoa")
                        .HasConstraintName("S#CONTA_PAGAR001");
                });

            modelBuilder.Entity("ControlePessoalWeb.Models.ContaReceber", b =>
                {
                    b.HasOne("ControlePessoalWeb.Models.Pessoa", "IdpessoaNavigation")
                        .WithMany("ContaReceber")
                        .HasForeignKey("Idpessoa")
                        .HasConstraintName("S#CONTA_RECEBER001");
                });

            modelBuilder.Entity("ControlePessoalWeb.Models.Leitura", b =>
                {
                    b.HasOne("ControlePessoalWeb.Models.Livro", "IdlivroNavigation")
                        .WithMany("Leitura")
                        .HasForeignKey("Idlivro")
                        .HasConstraintName("S#LEITURA001");
                });

            modelBuilder.Entity("ControlePessoalWeb.Models.Livro", b =>
                {
                    b.HasOne("ControlePessoalWeb.Models.Autor", "IdautorNavigation")
                        .WithMany("Livro")
                        .HasForeignKey("Idautor")
                        .HasConstraintName("S#LIVRO002");

                    b.HasOne("ControlePessoalWeb.Models.Genero", "IdgeneroNavigation")
                        .WithMany("Livro")
                        .HasForeignKey("Idgenero")
                        .HasConstraintName("S#LIVRO001");
                });

            modelBuilder.Entity("ControlePessoalWeb.Models.Meta", b =>
                {
                    b.HasOne("ControlePessoalWeb.Models.Pessoa", "IdpessoaNavigation")
                        .WithMany("Meta")
                        .HasForeignKey("Idpessoa")
                        .HasConstraintName("S#META001");
                });

            modelBuilder.Entity("ControlePessoalWeb.Models.Usuario", b =>
                {
                    b.HasOne("ControlePessoalWeb.Models.Pessoa", "IdpessoaNavigation")
                        .WithMany("Usuario")
                        .HasForeignKey("Idpessoa")
                        .HasConstraintName("S#USUARIO001");
                });
#pragma warning restore 612, 618
        }
    }
}
