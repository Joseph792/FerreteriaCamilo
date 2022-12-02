using Microsoft.EntityFrameworkCore;

    public class Contexto : DbContext
    {
    public DbSet <Clientes> Clientes { get; set; }
    public Contexto(DbContextOptions<Contexto> options): base(options)
    {
    }
    }
