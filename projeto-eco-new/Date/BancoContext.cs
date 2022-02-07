using Microsoft.EntityFrameworkCore;
using projeto_eco.Models;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace projeto_eco.DAO
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }
        public DbSet<ContatoModel> Usuarios { get; set; }

    }
}