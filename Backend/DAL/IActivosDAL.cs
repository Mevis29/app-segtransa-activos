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
        #region Codigo de activos 

        void agregarActivo(Activos Activo); //Add
        void eliminarActivo(int idActivo); //Delete
        void actualizarActivo(Activos Activo); //Update
        Activos GetActivo(int idActivo);
        Activos mostrarActivo(int idActivo);
        List<Activos> GetActivos();
        List<Activos> obtenerActivos();
        List<Object> obtenerActivosObjetos();
        List<object> buscarActivos(String busqueda);

        #endregion

        #region SPS NVOS PR ASIGNACIONES - ACTIVOS X USUARIOS
        ///SE AGREGO SPS NUEVOS ACTIVOS - pr asignaciones 
        /// <summary>
        /// Método para retornar Cantidad de Activos por IdUsuario
        /// </summary>
        int? CalculaCantActivos(int pIdUsuario);


        /// <summary>
        /// Método para retornar Activo por Id
        /// </summary>
        spActivosRetornaDatosId_Result retornaActivoId(int pIdActivo);

        /// <summary>
        /// Método para retornar lista completa de Activos
        /// </summary>
        List<spActivosRetornaLista_Result> retornaListaActivos(string pCodigo, string pDescripcion);


        /// <summary>
        /// Método para retornar lista resumen de Activos
        /// </summary>
        List<spActivosRetornaListaResumen_Result> retornaListaActivosResumen(int? pIdActivo);


        /// <summary>
        /// Método para retornar resumen de Activo por Id
        /// </summary>
        spActivosRetornaListaResumen_Result retornaActivosResumenId(int pIdActivo);

        #endregion
       

    }
}
