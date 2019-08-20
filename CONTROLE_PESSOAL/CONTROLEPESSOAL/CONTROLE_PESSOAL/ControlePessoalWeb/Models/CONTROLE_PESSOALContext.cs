using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ControlePessoalWeb.Models
{
    public partial class CONTROLE_PESSOALContext : DbContext
    {
        public CONTROLE_PESSOALContext()
        {
        }

        public CONTROLE_PESSOALContext(DbContextOptions<CONTROLE_PESSOALContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Autor> Autor { get; set; }
        public virtual DbSet<ContaPagar> ContaPagar { get; set; }
        public virtual DbSet<ContaReceber> ContaReceber { get; set; }
        public virtual DbSet<Genero> Genero { get; set; }
        public virtual DbSet<Leitura> Leitura { get; set; }
        public virtual DbSet<Livro> Livro { get; set; }
        public virtual DbSet<Meta> Meta { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<Pessoa> Pessoa { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-3SRFA3M\\SQLEXPRESS;Initial Catalog=CONTROLE_PESSOAL;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_dbo.AspNetUserRoles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_RoleId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.UserName)
                    .HasName("UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Autor>(entity =>
            {
                entity.HasKey(e => e.Idautor)
                    .HasName("PK__AUTOR__9C1E582EDDA98922");

                entity.ToTable("AUTOR");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContaPagar>(entity =>
            {
                entity.HasKey(e => e.IdcontaPagar)
                    .HasName("PK__CONTA_PA__BE52FA94FEE7E5D3");

                entity.ToTable("CONTA_PAGAR");

                entity.Property(e => e.IdcontaPagar).HasColumnName("Idconta_pagar");

                entity.Property(e => e.Anoreferencia).HasColumnName("anoreferencia");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Formapagamento).HasColumnName("formapagamento");

                entity.Property(e => e.Idpessoa).HasColumnName("idpessoa");

                entity.Property(e => e.Mesreferencia).HasColumnName("mesreferencia");

                entity.Property(e => e.Parcelamento).HasColumnName("parcelamento");

                entity.Property(e => e.Parcelasapagar).HasColumnName("parcelasapagar");

                entity.Property(e => e.Parcelaspagas).HasColumnName("parcelaspagas");

                entity.Property(e => e.Totalparcelas).HasColumnName("totalparcelas");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("money");

                entity.Property(e => e.Vencimento)
                    .HasColumnName("vencimento")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.IdpessoaNavigation)
                    .WithMany(p => p.ContaPagar)
                    .HasForeignKey(d => d.Idpessoa)
                    .HasConstraintName("S#CONTA_PAGAR001");
            });

            modelBuilder.Entity<ContaReceber>(entity =>
            {
                entity.HasKey(e => e.IdcontaReceber)
                    .HasName("PK__CONTA_RE__DFAFF2D26E287AA0");

                entity.ToTable("CONTA_RECEBER");

                entity.Property(e => e.IdcontaReceber).HasColumnName("Idconta_receber");

                entity.Property(e => e.Anoreferencia).HasColumnName("anoreferencia");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Formapagamento).HasColumnName("formapagamento");

                entity.Property(e => e.Idpessoa).HasColumnName("idpessoa");

                entity.Property(e => e.Mesreferencia).HasColumnName("mesreferencia");

                entity.Property(e => e.Parcelamento).HasColumnName("parcelamento");

                entity.Property(e => e.Parcelasreceber).HasColumnName("parcelasreceber");

                entity.Property(e => e.Parcelasrecebidas).HasColumnName("parcelasrecebidas");

                entity.Property(e => e.Totalparcelas).HasColumnName("totalparcelas");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("money");

                entity.Property(e => e.Vencimento)
                    .HasColumnName("vencimento")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.IdpessoaNavigation)
                    .WithMany(p => p.ContaReceber)
                    .HasForeignKey(d => d.Idpessoa)
                    .HasConstraintName("S#CONTA_RECEBER001");
            });

            modelBuilder.Entity<Genero>(entity =>
            {
                entity.HasKey(e => e.Idgenero)
                    .HasName("PK__GENERO__EFE568FA82346E69");

                entity.ToTable("GENERO");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Leitura>(entity =>
            {
                entity.HasKey(e => e.Idmeta)
                    .HasName("PK__LEITURA__2779D57AFE5CF9E9");

                entity.ToTable("LEITURA");

                entity.Property(e => e.Avaliacao).HasColumnName("avaliacao");

                entity.Property(e => e.Descavaliacao)
                    .HasColumnName("descavaliacao")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Idlivro).HasColumnName("idlivro");

                entity.Property(e => e.Idpessoa).HasColumnName("idpessoa");

                entity.Property(e => e.Tempoleitura).HasColumnName("tempoleitura");

                entity.HasOne(d => d.IdlivroNavigation)
                    .WithMany(p => p.Leitura)
                    .HasForeignKey(d => d.Idlivro)
                    .HasConstraintName("S#LEITURA001");
            });

            modelBuilder.Entity<Livro>(entity =>
            {
                entity.HasKey(e => e.Idlivro)
                    .HasName("PK__LIVRO__C2F51079CEA58EE9");

                entity.ToTable("LIVRO");

                entity.Property(e => e.Idlivro).HasColumnName("idlivro");

                entity.Property(e => e.Idioma)
                    .HasColumnName("idioma")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.QtdPaginas).HasColumnName("qtd_paginas");

                entity.Property(e => e.Titulo)
                    .HasColumnName("titulo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdautorNavigation)
                    .WithMany(p => p.Livro)
                    .HasForeignKey(d => d.Idautor)
                    .HasConstraintName("S#LIVRO002");

                entity.HasOne(d => d.IdgeneroNavigation)
                    .WithMany(p => p.Livro)
                    .HasForeignKey(d => d.Idgenero)
                    .HasConstraintName("S#LIVRO001");
            });

            modelBuilder.Entity<Meta>(entity =>
            {
                entity.HasKey(e => e.Idmeta)
                    .HasName("PK__META__2779D57AF78809AC");

                entity.ToTable("META");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Idpessoa).HasColumnName("idpessoa");

                entity.Property(e => e.Nomemeta)
                    .HasColumnName("nomemeta")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Prazo)
                    .HasColumnName("prazo")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tipometa).HasColumnName("tipometa");

                entity.HasOne(d => d.IdpessoaNavigation)
                    .WithMany(p => p.Meta)
                    .HasForeignKey(d => d.Idpessoa)
                    .HasConstraintName("S#META001");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Pessoa>(entity =>
            {
                entity.HasKey(e => e.Idpessoa)
                    .HasName("PK__PESSOA__4B7C35F6C956C8D2");

                entity.ToTable("PESSOA");

                entity.Property(e => e.Celular)
                    .HasColumnName("celular")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cep)
                    .HasColumnName("cep")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Cidade)
                    .HasColumnName("cidade")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Complmento)
                    .HasColumnName("complmento")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Datanasc)
                    .HasColumnName("datanasc")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Endereco)
                    .HasColumnName("endereco")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estadocivil).HasColumnName("estadocivil");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .HasColumnName("telefone")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Uf)
                    .HasColumnName("uf")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Idusuario)
                    .HasName("PK__USUARIO__7AC21576C1425656");

                entity.ToTable("USUARIO");

                entity.Property(e => e.CodUsuario).HasColumnName("Cod_usuario");

                entity.Property(e => e.Idpessoa).HasColumnName("idpessoa");

                entity.Property(e => e.Senha)
                    .HasColumnName("senha")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario1)
                    .HasColumnName("usuario")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdpessoaNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.Idpessoa)
                    .HasConstraintName("S#USUARIO001");
            });
        }
    }
}
