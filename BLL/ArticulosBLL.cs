using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

    public class ArticulosBLL
    {
        private Contexto _contexto;

        public ArticulosBLL(Contexto contexto)
        {
            _contexto = contexto;
        }
        public bool Existe(int articuloId)
        {
            return _contexto.Articulos
                .Any(o => o.ArticuloId == articuloId);
        }
        private bool Insertar(Articulos articulo)
        {
            _contexto.Articulos.Add(articulo);
            return _contexto.SaveChanges() > 0;
        }
        private bool Modificar(Articulos articulo)
        {
            _contexto.Entry(articulo).State = EntityState.Modified;
            return _contexto.SaveChanges() > 0;
        }
        public bool Guardar(Articulos articulo)
        {
            if (!Existe(articulo.ArticuloId))
                return this.Insertar(articulo);
            else
                return this.Modificar(articulo);
        }
        public bool Eliminar(Articulos articulo)
        {
            _contexto.Entry(articulo).State = EntityState.Deleted;
            return _contexto.SaveChanges() > 0;
        }
        public Articulos? Buscar(int articuloId)
        {
            return _contexto.Articulos
            .Where(o => o.ArticuloId == articuloId)
            .AsNoTracking()
            .SingleOrDefault();
        }
        public List<Articulos> GetList(Expression<Func<Articulos, bool>> criterio)
        {
            return _contexto.Articulos
            .AsNoTracking()
            .Where(criterio)
            .ToList();
        }
    }