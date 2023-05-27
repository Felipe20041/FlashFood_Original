using Microsoft.EntityFrameworkCore;
using FlashFood_Original.Entidades;
namespace FlashFood_Original
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<CARDAPIO> CARDAPIO { get; set; }
    }
}
