using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeMusicas.Database;

internal class MusicContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DINKZ;Database=GerenciadorMusica;User Id=sa;Password=Dev$123;Encrypt=False;");
    }
}
