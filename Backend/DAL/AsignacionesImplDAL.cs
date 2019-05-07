using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Entities;
using Backend.DAL;
using System.Data.Entity;

public class AsignacionesImplDAL : IAsignacionesDAL
{

    // Crear una instancia del modelo de la BD
    BDContext context = new BDContext();

    #region Método para retornar Asignacion por Usuario-Empleado por Id Datos Asignaciones
    /// <summary>
    /// Método para retornar Asignacion por Usuario-Empleado por Id
    /// </summary>
    public spAsignUsuarioRetornaDatosId_Result retornaAsignUsuarioId(int pIdAsignacion)
    {
        spAsignUsuarioRetornaDatosId_Result resultado = new spAsignUsuarioRetornaDatosId_Result();

        resultado = this.context.spAsignUsuarioRetornaDatosId(pIdAsignacion).FirstOrDefault();

        return resultado;
    }
    #endregion

    #region Método para retornar lista completa de Asignacion por Usuario-Empleado

    /// <summary>
    /// Método para retornar lista completa de Asignacions por Usuario-Empleado
    /// </summary>
    public List<spAsignUsuarioRetornaLista_Result> retornaListaAsignUsuario(string pEmpleado, string pActivo)
    {
        List<spAsignUsuarioRetornaLista_Result> resultado = new List<spAsignUsuarioRetornaLista_Result>();

        resultado = this.context.spAsignUsuarioRetornaLista(pEmpleado, pActivo).ToList();

        return resultado;
    }
    #endregion

    #region Método para retornar lista completa de Asignacion por ID de Usuario-Empleado
    /// <summary>
    /// Método para retornar lista de Asignacions por Usuario-Empleado por Id
    /// </summary>
    public List<spAsignUsuarioRetornaListaId_Result> retornaListaAsignUsuarioId(int pIdUsuario)
    {
        List<spAsignUsuarioRetornaListaId_Result> resultado = new List<spAsignUsuarioRetornaListaId_Result>();

        resultado = this.context.spAsignUsuarioRetornaListaId(pIdUsuario).ToList();

        return resultado;
    }

    #endregion

    #region Método para insertar nueva Asignacion por Usuario-Empleado
    /// <summary>
    /// Método para insertar nueva Asignacion por Usuario-Empleado
    /// </summary>
    public bool InsertaAsignUsuario(int pIdUsuario, int pIdActivo, DateTime pFechaInicialAsignacion, DateTime pFechafinalAsignacion)
    {
        bool resultado = false;
        try
        {
            int registrosAfectados = this.context.spAsignUsuarioInsertaDatos(pIdUsuario, pIdActivo, pFechaInicialAsignacion, pFechafinalAsignacion);

            if (registrosAfectados > 0)
            {
                resultado = true;
            }
        }
        catch (Exception)
        {
            throw;
        }
        return resultado;
    }

    #endregion

    #region  Método para modificar Asignacion por Usuario-Empleado existente
    /// <summary>
    /// Método para modificar Asignacion por Usuario-Empleado existente
    /// </summary>
    public bool ModificaAsignUsuario(int pIdAsignacion, int pIdUsuario, int pIdActivo, DateTime pFechaInicialAsignacion, DateTime pFechafinalAsignacion)
    {
        bool resultado = false;
        try
        {
            int registrosAfectados = this.context.spAsignUsuarioModificaDatos(pIdAsignacion, pIdUsuario, pIdActivo, pFechaInicialAsignacion, pFechafinalAsignacion);

            if (registrosAfectados > 0)
            {
                resultado = true;
            }
        }
        catch (Exception)
        {
            throw;
        }
        return resultado;
    }
    #endregion

    #region Método para eliminar Asignacion por Usuario-Empleado existente
    /// <summary>
    /// Método para eliminar Asignacion por Usuario-Empleado existente
    /// </summary>
    public bool EliminaAsignUsuario(int pIdAsignacion)
    {
        bool resultado = false;
        try
        {
            int registrosAfectados = this.context.spAsignUsuarioEliminaDatos(pIdAsignacion);

            if (registrosAfectados > 0)
            {
                resultado = true;
            }
        }
        catch (Exception)
        {
            throw;
        }
        return resultado;
    }
    #endregion

}

