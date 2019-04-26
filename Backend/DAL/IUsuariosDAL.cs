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
        List<Usuarios> GetUsuarios();

        /*Metodos necesarios para validar al usuario*/
        bool isRealUser(int idUsuario);
        bool isValidPassword(string passUser, int idUsuario);

        /// <summary>
        /// Método para retornar lista de Usuario por Id
        /// </summary>
        List<spUsuariosRetornaListaId_Result> retornaListaUsuarioId(int pIdUsuario);

        /// <summary>
        /// Método para actualizar fecha/hora de login del Usuario
        /// </summary>
        bool actualizaDatosLogin(int IdUsuario);
    }
}
