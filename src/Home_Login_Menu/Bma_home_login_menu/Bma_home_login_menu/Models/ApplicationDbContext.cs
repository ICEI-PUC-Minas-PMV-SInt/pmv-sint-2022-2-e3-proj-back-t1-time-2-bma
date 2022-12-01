
using Microsoft.EntityFrameworkCore;

namespace Bma_home_login_menu.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Beneficiario> Beneficiarios { get; set; }
        public DbSet<Dependente> Dependentes { get; set; }

        public DbSet<Doacao> Doacoes { get; set; }
    }
}
