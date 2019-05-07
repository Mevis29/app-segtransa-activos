using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Entities;
using Backend.DAL;
using System.Data.Entity;
using System.Windows.Forms;


namespace BackEnd.DAL
{


    public class ActivosImplDAL : IActivosDAL
    {

        //private BDContext context;
        BDContext context = new BDContext();

        public ActivosImplDAL()
        {

        }

        //(Create)
        public void agregarActivo(Activos activo)
        {
            try
            {
                using (context = new BDContext())
                {
                    context.Activos.Add(activo);
                    context.SaveChanges();
                } 
            }
            catch(Exception ex)
            {
                MessageBox.Show("hola" + ex);
            }
        }

        //(Update)
        public void actualizarActivo(Activos activo)
        {
            try
            {
                using (context = new BDContext())
                {
                    context.Entry(activo).State = EntityState.Modified;
                    context.SaveChanges();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        //Read
        public Activos mostrarActivo(int idActivo)
        {
            using (context = new BDContext())
            {
                return context.Activos.Single(elActivo => elActivo.IdActivo == idActivo);
            }
        }

        //Delete
        public void eliminarActivo(int idActivo)
        {
            //Activos Activo = this.GetActivo(idActivo);
            using (context = new BDContext())
            {
                //context.Activos.Attach(Activo);
                //context.Activos.Remove(Activo);
                //context.SaveChanges();
                context.Activos.Remove(context.Activos.Single(elActivo => elActivo.IdActivo == idActivo));
                context.SaveChanges();
            }
        }

        public List<object> buscarActivos(string busqueda)
        {
            using (context = new BDContext())
            {
                List<object> activos = context.sp_BuscarActivos(busqueda).ToList<object>();
                if (activos.Count > 0)
                {
                    return activos;
                }
                else
                {
                    return null;
                }
            }
        }


        public List<Activos> obtenerActivos()
        {
            List<Activos> listaActivos = new List<Activos>();
            using (BDContext db = new BDContext())
            {
                listaActivos = (from Activos in db.Activos
                                select Activos).ToList();
                if (listaActivos.Count > 0)
                {
                    return listaActivos;
                }
                else
                {
                    return null;
                }
            }
        }

        public List<object> obtenerActivosObjetos()
        {
            using (BDContext db = new BDContext())
            {
                var listaActivos = (from activos in db.Activos
                                    join Proveedores in db.Proveedores on activos.Proveedor equals Proveedores.IdProveedor
                                    join EstadoActivos in db.EstadoActivos on activos.EstadoActivo equals EstadoActivos.IdEstadoActivo
                                    select new
                                    {
                                        Id = activos.IdActivo,
                                        CodActivo = activos.CodActivo,
                                        Descripcion = activos.Descripcion,
                                        PrecioInicial = activos.PrecioInicial,
                                        FechaCompra = activos.FechaCompra,
                                        Proveedor = Proveedores.NombreProveedor,
                                        Estado = EstadoActivos.NombreEstado
                                    }
                                  ).ToList<Object>();
                if (listaActivos.Count > 0)
                {
                    return listaActivos;
                }
                else
                {
                    return null;
                }
            }
        }


        public List<Activos> GetActivos()
    {
        List<Activos> result;
        using (context = new BDContext())
        {
            result = (from c in context.Activos
                      select c).ToList();
        }

        return result;
    }

    public Activos GetActivo(int idActivo)
    {
        Activos result;
        using (context = new BDContext())
        {
            result = (from c in context.Activos
                      where c.IdActivo == idActivo
                      select c).First();
        }
        IEstadoActivosDAL estadoActivosDAL = new EstadoActivosImplDAL();
        IProveedoresDAL proveedoresDAL = new ProveedoresImplDAL();
        result.EstadoActivos = estadoActivosDAL.GetEstadoActivo(result.EstadoActivo ?? default(int));
        result.Proveedores = proveedoresDAL.GetProveedor(result.Proveedor ?? default(int));
        return result;
    }


        //SE AGREGARON LAS LLAMADAS DE LOS SPS DE IACTIVOSDAL -
        // SPs para Asignaciones - Usuarios - Activos
        #region Todos los llamados pr Asignacion de Activos

        #region  Método para retornar Cantidad de Activos por IdUsuario
        /// <summary>
        /// Método para retornar Cantidad de Activos por IdUsuario
        /// </summary>
        public int? CalculaCantActivos(int pIdUsuario)


        {
            int? resultado;
            try
            {
                resultado = context.spActivosCalcularCant(pIdUsuario).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;

        }
        #endregion

        //este metodo no esta en uso aun
        #region  Método para retornar Activo por Id
        /// <summary>
        /// Método para retornar Activo por Id
        /// </summary>
        public spActivosRetornaDatosId_Result retornaActivoId(int pIdActivo)
        {
            spActivosRetornaDatosId_Result resultado = new spActivosRetornaDatosId_Result();

            resultado = this.context.spActivosRetornaDatosId(pIdActivo).FirstOrDefault();

            return resultado;
        }

        #endregion

        ///Todos los llamados pr Asignacion de Activos
        #region  Método para retornar lista completa de activos
        /// <summary>
        /// Método para retornar lista completa de Activos
        /// </summary>
        public List<spActivosRetornaLista_Result> retornaListaActivos(string pCodigo, string pDescripcion)
        {
            List<spActivosRetornaLista_Result> resultado = new List<spActivosRetornaLista_Result>();

            resultado = this.context.spActivosRetornaLista(pCodigo, pDescripcion).ToList();

            return resultado;
        }
        #endregion


        #region Método para retornar resumen de Activos por Id
        public spActivosRetornaListaResumen_Result retornaActivosResumenId(int pIdActivo)
        {
            spActivosRetornaListaResumen_Result resultado = new spActivosRetornaListaResumen_Result();

            resultado = this.context.spActivosRetornaListaResumen(pIdActivo).FirstOrDefault();

            return resultado;
        }
        #endregion

        #region Método para retornar lista resumen de Activos
        public List<spActivosRetornaListaResumen_Result> retornaListaActivosResumen(int? pIdActivo)
        {
            List<spActivosRetornaListaResumen_Result> resultado = new List<spActivosRetornaListaResumen_Result>();

            resultado = this.context.spActivosRetornaListaResumen(pIdActivo).ToList();

            return resultado;

        }
        #endregion

        #endregion Todos los llamados pr Asignacion de Activos


    }
}