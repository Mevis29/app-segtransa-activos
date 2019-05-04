using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Entities;
using Backend.DAL;
using System.Data.Entity;

public class UsuariosImplDAL : IUsuariosDAL
{

    private BDContext context;

    public void Add(Usuarios Usuario)
    {
        try
        {
            using (context = new BDContext())
            {
                Usuario.RolUsuarios = (from c in context.RolUsuarios
                                        where c.IdRol == Usuario.RolUsuario //idRolUsuario
                                        select c).First();

                context.Usuarios.Add(Usuario);
                context.SaveChanges();
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void Delete(int idUsuario)
    {
        Usuarios Usuario = this.GetUsuario(idUsuario);
        using (context = new BDContext())
        {
            context.Usuarios.Attach(Usuario);
            context.Usuarios.Remove(Usuario);
            context.SaveChanges();
        }
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public List<Usuarios> GetUsuarios()
    {
        List<Usuarios> result;
        using (context = new BDContext())
        {
            result = (from c in context.Usuarios
                      select c).ToList();
        }
        return result;
    }

    public List<spUsuariosRetornaListaId_Result> retornaListaUsuarioId(int pIdUsuario)
    {
        List<spUsuariosRetornaListaId_Result> resultado;

        using(context = new BDContext())
        {
            resultado = this.context.spUsuariosRetornaListaId(pIdUsuario).ToList();
        }
        return resultado;

        //List<spUsuariosRetornaListaId_Result> resultado = new List<spUsuariosRetornaListaId_Result>();

//        resultado = this.context.spUsuariosRetornaListaId(pIdUsuario).ToList();

  //      return resultado;
    }



    public Usuarios GetUsuario(int idUsuario)
    {
        try
        {
            Usuarios result;
            using (context = new BDContext())
            {
                result = (from c in context.Usuarios
                          where c.IdUsuario == idUsuario
                          select c).First();
            }
            return result;
        }
        catch (Exception)
        {

            return null;
        }

    }
    public Usuarios Getcorreo(string correo)
    {
        try
        {
            Usuarios result;
            using (context = new BDContext())
            {
                result = (from c in context.Usuarios
                          where c.Correo == correo
                          select c).First();
            }
            return result;
        }
        catch (Exception)
        {

            return null;
        }

    }

    public void Update(Usuarios Usuario)
    {
        try
        {
            using (context = new BDContext())
            {
                context.Entry(Usuario).State = EntityState.Modified;
                context.SaveChanges();
            }

        }
        catch (Exception)
        {
            throw;
        }
    }







    public bool isRealUser(string correo)
    {
        bool real = false;
        Usuarios usuarios = Getcorreo(correo);
        if (usuarios.Correo == correo)
        {
            real = true;
        }
        return real;
    }
    public bool isValidPassword(string passUser, string correo)
    {
        CryptoEngine cryptoEngine = new CryptoEngine();
        string passDecrypted = cryptoEngine.Decrypt(passUser);
        bool valid = false;
        if (this.Getcorreo(correo).Contrasena.Equals(passDecrypted))
        {
            valid = true;
        }
        return valid;
    }

    /// <summary>
    /// Método para retornar lista de Usuario por Id
    /// </summary>


    #region Método para actualizar fecha/hora de login del Usuario
    /// <summary>
    /// Método para actualizar fecha/hora de login del Usuario
    /// Mostrara la ultm fecha de ingreso en un mensj  
    /// </summary>
    public bool actualizaDatosLogin(int pIdUsuario)
    {
        bool resultado = false;
        try
        {
            using(context = new BDContext())
            {
                int registrosAfectados = context.spUsuariosActualizaUltLogin(pIdUsuario);

                if (registrosAfectados > 0)
                {
                    resultado = true;
                }
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

