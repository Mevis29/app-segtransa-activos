using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DAL
{
    public interface ICategoriasDAL: IDisposable

    {
        void Add(Categorias Categoria);
        void Delete(int idCategoria);
        void Update(Categorias Categoria);
        Categorias GetCategoria(int idCategoria);
        List<Categorias> GetCategorias();
    }
}
