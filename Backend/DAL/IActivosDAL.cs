using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Entities;
using Backend.DAL;

namespace Backend.DAL
{
    public interface IActivosDAL
    {
        void agregarActivo(Activos Activo); //Add
        void eliminarActivo(int idActivo); //Delete
        void actualizarActivo(Activos Activo); //Update
        Activos GetActivo(int idActivo);
        Activos mostrarActivo(int idActivo);
        List<Activos> GetActivos();
        List<Activos> obtenerActivos();
        List<Object> obtenerActivosObjetos();
        List<object> buscarActivos(String busqueda);

    }
}
