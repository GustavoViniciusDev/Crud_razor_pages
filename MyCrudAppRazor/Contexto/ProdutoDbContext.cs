using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyCrudAppRazor.Models;
using System.Configuration;

namespace MyCrudAppRazor.Contexto
{
    public class ProdutoDbContext : DbContext
    {

        private readonly IConfiguration _config;

        public ProdutoDbContext(DbContextOptions<ProdutoDbContext> options, IConfiguration config) : base(options)
        {
            _config = config;
        }
        public DbSet<Produtos> Produtos {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_config.GetConnectionString("StringConexao"));
            }
        }
    }
}
