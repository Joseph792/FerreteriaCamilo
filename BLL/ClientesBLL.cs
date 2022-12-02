using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

    public class ClientesBLL
    {
        private Contexto _contexto;

        public ClientesBLL(Contexto contexto)
        {
            _contexto = contexto;
        }
        public bool Existe(int clienteId)
        {
            return _contexto.Clientes
                .Any(o => o.ClienteId == clienteId);
        }
        private bool Insertar(Clientes cliente)
        {
            _contexto.Clientes.Add(cliente);
            return _contexto.SaveChanges() > 0;
        }
        private bool Modificar(Clientes cliente)
        {
            _contexto.Entry(cliente).State = EntityState.Modified;
            return _contexto.SaveChanges() > 0;
        }
        public bool Guardar(Clientes cliente)
        {
            if (!Existe(cliente.ClienteId))
                return this.Insertar(cliente);
            else
                return this.Modificar(cliente);
        }
        public bool Eliminar(Clientes cliente)
        {
            _contexto.Entry(cliente).State = EntityState.Deleted;
            return _contexto.SaveChanges() > 0;
        }
        public Clientes? Buscar(int clienteId)
        {
            return _contexto.Clientes
            .Where(o => o.ClienteId == clienteId)
            .AsNoTracking()
            .SingleOrDefault();
        }
        public List<Clientes> GetList(Expression<Func<Clientes, bool>> criterio)
        {
            return _contexto.Clientes
            .AsNoTracking()
            .Where(criterio)
            .ToList();
        }
    }
