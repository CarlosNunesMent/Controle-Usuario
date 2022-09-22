using Microsoft.EntityFrameworkCore;

namespace Meu_Controle_Usuarios.Context
{
  public class UserContext: DbContext
  {
    public DbSet<UserContext> Users { get; set; }

    public UserContext(DbSet<UserContext> options) : base()
    {
      
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }
  }
}
