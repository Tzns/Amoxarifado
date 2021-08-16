using Almoxarifado.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Almoxarifado.Data
{
    public class DataContext : DbContext

    {
        public DbSet<Competencia> Competencia { get; set; }
        public DbSet<Entrada> Entrada { get; set; }
        public DbSet<EntradaItem> EntradaItem { get; set; }
        public DbSet<EntradaTipo> EntradaTipo { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<ProdutoGrupo> ProdutoGrupo { get; set; }
        public DbSet<ProdutoUnidade> ProdutoUnidade { get; set; }
        public DbSet<Saida> Saida { get; set; }
        public DbSet<SaidaItem> SaidaItem { get; set; }
        public DbSet<SaidaTipo> SaidaTipo { get; set; }

        public DataContext(DbContextOptions options): base (options)
        {

        }

    }
}
