using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DAL
{
    public class EstadoUsuariosImplDAL : IEstadoUsuariosDAL
    {
        private BDContext context;

        public void Add(EstadoUsuarios EstadoUsuario)
        {
            using (context = new BDContext())
            {
                context.EstadoUsuarios.Add(EstadoUsuario);
                context.SaveChanges();
            }
        }

        public void Delete(int idEstadoUsuario)
        {
            EstadoUsuarios EstadoUsuario = this.GetEstadoUsuario(idEstadoUsuario);
            using (context = new BDContext())
            {
                context.EstadoUsuarios.Attach(EstadoUsuario);
                context.EstadoUsuarios.Remove(EstadoUsuario);
                context.SaveChanges();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<EstadoUsuarios> GetEstadoUsuarios()
        {
            List<EstadoUsuarios> result;
            using (context = new BDContext())
            {
                result = (from c in context.EstadoUsuarios
                          select c).ToList();
            }
            return result;
        }

        public EstadoUsuarios GetEstadoUsuario(int idEstadoUsuario)
        {
            EstadoUsuarios result;
            using (context = new BDContext())
            {
                result = (from c in context.EstadoUsuarios
                          where c.IdEstadoUsuario == idEstadoUsuario
                          select c).First();
            }
            return result;
        }

        public void Update(EstadoUsuarios EstadoUsuario)
        {
            try
            {
                using (context = new BDContext())
                {
                    context.Entry(EstadoUsuario).State = EntityState.Modified;
                    context.SaveChanges();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
