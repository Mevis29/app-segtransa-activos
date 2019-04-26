using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DAL
{
    public class CategoriasImplDAL: ICategoriasDAL
    {
        private BDContext context;

        public void Add(Categorias Categoria)
        {
            using (context = new BDContext())
            {
                context.Categorias.Add(Categoria);
                context.SaveChanges();
            }
        }

        public void Delete(int idCategoria)
        {
            Categorias Categoria = this.GetCategoria(idCategoria);
            using (context = new BDContext())
            {
                context.Categorias.Attach(Categoria);
                context.Categorias.Remove(Categoria);
                context.SaveChanges();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<Categorias> GetCategorias()
        {
            List<Categorias> result;
            using (context = new BDContext())
            {
                result = (from c in context.Categorias
                          select c).ToList();
            }
            return result;
        }

        public Categorias GetCategoria(int idCategoria)
        {
            Categorias result;
            using (context = new BDContext())
            {
                result = (from c in context.Categorias
                          where c.IdCategoria == idCategoria
                          select c).First();
            }
            return result;
        }

        public void Update(Categorias Categoria)
        {
            try
            {
                using (context = new BDContext())
                {
                    context.Entry(Categoria).State = EntityState.Modified;
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
