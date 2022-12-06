using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

public class SuplidoresBLL
{
    private Contexto _contexto;

    public SuplidoresBLL(Contexto contexto)
    {
        _contexto = contexto;
    }
    public bool Existe(int suplidorId)
    {
        return _contexto.Suplidores
            .Any(o => o.SuplidorId == suplidorId);
    }
    private bool Insertar(Suplidores suplidor)
    {
        _contexto.Suplidores.Add(suplidor);
        return _contexto.SaveChanges() > 0;
    }
    private bool Modificar(Suplidores suplidor)
    {
        _contexto.Entry(suplidor).State = EntityState.Modified;
        return _contexto.SaveChanges() > 0;
    }
    public bool Guardar(Suplidores suplidor)
    {
        if (!Existe(suplidor.SuplidorId))
            return this.Insertar(suplidor);
        else
            return this.Modificar(suplidor);
    }
    public bool Eliminar(Suplidores suplidor)
    {
        _contexto.Entry(suplidor).State = EntityState.Deleted;
        return _contexto.SaveChanges() > 0;
    }
    public Suplidores? Buscar(int suplidorId)
    {
        return _contexto.Suplidores
        .Where(o => o.SuplidorId == suplidorId)
        .AsNoTracking()
        .SingleOrDefault();
    }
    public List<Suplidores> GetList(Expression<Func<Suplidores, bool>> criterio)
    {
        return _contexto.Suplidores
        .AsNoTracking()
        .Where(criterio)
        .ToList();
    }
}
