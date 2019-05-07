using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Entities;
using Backend.DAL;

namespace Backend.DAL
{
    public interface IUsuariosDAL : IDisposable
    {
        void Add(Usuarios Usuario);
        void Delete(int idUsuario);
        void Update(Usuarios Usuario);
        Usuarios GetUsuario(int idUsuario);
        Usuarios Getcorreo(string correo);
        List<Usuarios> GetUsuarios();

        /*Metodos necesarios para validar al usuario*/
        bool isRealUser(string correo);
        bool isValidPassword(string passUser, string correo);

        /// <summary>
        /// Método para retornar lista de Usuario por Id
        /// </summary>
        List<spUsuariosRetornaListaId_Result> retornaListaUsuarioId(int pIdUsuario);

        /// <summary>
        /// Método para actualizar fecha/hora de login del Usuario
        /// </summary>
        bool actualizaDatosLogin(int IdUsuario);

        ///SPS pr ASIGNACIONES
        /// <summary>
        /// Método para retornar lista completa de Usuarios
        /// </summary>
        List<spUsuariosRetornaLista_Result> retornaListaUsuarios(string pCedula, string pNombre, string pCorreo);

        /// <summary>
        /// Método para retornar lista de solo Empleados asignados
        /// </summary>
        List<spUsuariosRetornaListaEmpleado_Result> retornaListaEmpleados(int? pIdEmpleado);


        /// <summary>
        /// Método para retornar Empleado por Id
        /// </summary>
        spUsuariosRetornaListaEmpleado_Result retornaEmpleadoId(int pIdEmpleado);
    }
}
