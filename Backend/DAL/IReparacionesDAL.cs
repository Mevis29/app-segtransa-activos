using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DAL
{
    public interface IReparacionesDAL
    {
        void AgregarReparacion(THReparaciones reparacion, int idActivo); //El activo a reparar.
        void ModificarReparacion(THReparaciones reparacion);
        void Eliminar(int idReparacion);
        List<sp_RetornaReparacion_Result> ObtenerReparaciones(string cod);

        List<THReparaciones> GetReparaciones();

    }
}
