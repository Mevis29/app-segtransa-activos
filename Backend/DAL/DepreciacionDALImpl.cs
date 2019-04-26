using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Entities;

namespace Backend.DAL
{
    public class DepreciacionDALImpl : IDepreciacionDAL
    {
        private BDContext context;
        //Agrega una depreciación
        public void Add(Activos activo)
        {
            try
            {
                using (context = new BDContext())
                {
                    context.sp_InsertaDepreciacion(activo.IdActivo, activo.FechaCompra, activo.MesesDepreciacion, Convert.ToDouble(activo.PrecioInicial));
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //Borra una depreciación
        public void Delete(int activos)
        {

            using (context = new BDContext())
            {
                context.sp_EliminaDepreciacion(activos);
                context.SaveChanges();
            }
        }
        //Retorna una depreciación
        public Depreciacion GetDepreciacion(int idActivo)
        {
            try
            {
                //Se crea una nueva instancia de depreciación
                Depreciacion depreciacion = new Depreciacion();
                sp_RetornaDepreciacionId_Result result;
                using (context = new BDContext())
                {
                    //Se crea una nueva instancia del objeto que retona el procemiento almacenado.
                    result = context.sp_RetornaDepreciacionId(idActivo).FirstOrDefault();
                    //Se asignan los valores a los atributos de la depreciación
                    depreciacion.MontoDepreciacion = result.MontoDepreciacion;
                    depreciacion.FechaDepreciacion = result.fechaDepreciacion;
                }
                //Retorna la depreciación
                return depreciacion;
            }
            catch (Exception)
            {

                return null;
            }
        }
        //Retorna una lista de depreciaciones
        public List<Depreciacion> GetDepreciaciones()
        {
            List<Depreciacion> result;
            using (context = new BDContext())
            {
                result = (from c in context.Depreciacion
                          select c).ToList();
            }
            return result;
        }
        //Actualiza una depreciación
        public void Update(Depreciacion depreciacion)
        {
            try
            {
                using (context = new BDContext())
                {
                    context.sp_ModificaDepreciacion(depreciacion.Activo, depreciacion.FechaDepreciacion, depreciacion.Valor);
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
