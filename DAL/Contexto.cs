using FerreteriaCamilo.Models;
using Microsoft.EntityFrameworkCore;

namespace FerreteriaCamilo.DAL
{
    public class Contexto : DbContext
    {
    public DbSet <Clientes> Clientes { get; set; }
    public Contexto(DbContextOptions<Contexto> options): base(options)
    {
    }
    }
}
