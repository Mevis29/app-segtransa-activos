using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DAL
{
    public interface IEstadoUsuariosDAL: IDisposable
    {

        void Add(EstadoUsuarios EstadoUsuario);
        void Delete(int idEstadoUsuario);
        void Update(EstadoUsuarios EstadoUsuario);
        EstadoUsuarios GetEstadoUsuario(int idEstadoUsuario);
        List<EstadoUsuarios> GetEstadoUsuarios();
    }
}
