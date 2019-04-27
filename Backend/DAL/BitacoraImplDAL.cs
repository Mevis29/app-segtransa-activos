using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DAL
{
    public class BitacoraImplDAL : IBitacoraDAL
    {
        private BDContext context;
        //Inserta en la bitacora
        public void Add(Bitacora bitacora)
        {
            try
            {
                using (context = new BDContext())
                {
                    context.sp_InsertaBitacora(bitacora.IdUsuario, bitacora.DetalleBitacora);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        //Retorna la lista de la bitacora
        public List<Bitacora> GetBitacora()
        {
            List<Bitacora> result;
            using (context = new BDContext())
            {
                result = (from c in context.Bitacora
                          select c).ToList();
            }
            return result;
        }
    }
}

