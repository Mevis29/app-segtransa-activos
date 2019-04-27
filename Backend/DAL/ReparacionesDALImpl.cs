using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DAL
{
    public class ReparacionesDALImpl : IReparacionesDAL
    {
        private BDContext context;

        public void AgregarReparacion(THReparaciones reparacion, int idActivo)
        {
            try
            {
                using (context = new BDContext())
                {
                    context.sp_InsertaReparacion(idActivo, reparacion.FechaInicialReparacion, reparacion.FechafinalReparacion);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Eliminar(int idReparacion)
        {

            using (context = new BDContext())
            {
                context.sp_eliminarReparacion(idReparacion);
                context.SaveChanges();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<sp_RetornaReparacion_Result> ObtenerReparaciones(string cod)
        {
            try
            {
                THReparaciones reparacione = new THReparaciones();
                List<sp_RetornaReparacion_Result> result;
                using (context = new BDContext())
                {
                    result = context.sp_RetornaReparacion(cod).ToList();
                }
                return result;
            }
            catch (Exception e)
            {

                throw;
            }
        }
        public List<THReparaciones> GetReparaciones()
        {
            List<THReparaciones> result;
            using (context = new BDContext())
            {
                result = (from c in context.THReparaciones
                          select c).ToList();
            }
            return result;
        }

        public void ModificarReparacion(THReparaciones reparacion)
        {
            try
            {
                using (context = new BDContext())
                {
                    context.sp_modificaReparacion(reparacion.IdReparacion, reparacion.FechaInicialReparacion, reparacion.FechafinalReparacion);
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
