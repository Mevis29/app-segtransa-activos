using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DAL
{
    public interface IDepreciacionDAL
    {
        void Add(Activos activo); //Se agrega la depreciación de acuerdo a un activo.
        void Update(Depreciacion depreciacion);
        void Delete(int activos); //Se borra la depreciacion del activo en el parametro.
        List<Depreciacion> GetDepreciaciones();
        Depreciacion GetDepreciacion(int idActivo);//Obtiene una depreciación de acuerdo a un activo.
    }
}
