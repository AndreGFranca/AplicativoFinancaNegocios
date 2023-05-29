using DTO.Models.Estoque;
using DTO.Models.Financeiro;
using DTO.Models.Imagem;
using DTO.Models.Materiais;
using DTO.Models.Produtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.DataBase
{
    public class ApplicationDBContext: DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Financeiro> Financas { get; set; }
        public DbSet<Cor> Cores { get; set; }
        public DbSet<Material> Materiais { get; set; }
        public DbSet<UnidadeDeMedida> UnidadesDeMedida { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<HistoricoEstoque> HistoricoEstoques { get; set; }
        public DbSet<Imagem> Imagens { get; internal set; }
        public DbSet<ProdutoComposicao> ProdutoComposicoes { get; set; }
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{

        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //.OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProdutoComposicao>()
                .HasKey(composicao => new
                {
                    composicao.ProdutoId,
                    composicao.MaterialId
                });
            modelBuilder.Entity<ProdutoComposicao>()
                    .HasOne(composicao => composicao.Produto)
                    .WithMany(produto => produto.ComposicoesDoProduto)
                    .HasForeignKey(composicao => composicao.ProdutoId);
            //        modelBuilder.Entity<Sessao>()
            //            .HasOne(sessao => sessao.Cinema)
            //            .WithMany(cinema => cinema.Sessoes)
            //            .HasForeignKey(sessao => sessao.CinemaId);
            //        modelBuilder.Entity<Sessao>()
            //            .HasOne(sessao => sessao.Filme)
            //            .WithMany(filme => filme.Sessoes)
            //            .HasForeignKey(sessao => sessao.FilmeId);

            //        modelBuilder.Entity<Endereco>()
            //            .HasOne(endereco => endereco.Cinema)
            //            .WithOne(cinema => cinema.Endereco)
            //            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
