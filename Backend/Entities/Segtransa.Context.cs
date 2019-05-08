﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Backend.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BDContext : DbContext
    {
        public BDContext()
            : base("name=BDContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Activos> Activos { get; set; }
        public virtual DbSet<Bitacora> Bitacora { get; set; }
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Depreciacion> Depreciacion { get; set; }
        public virtual DbSet<EstadoActivos> EstadoActivos { get; set; }
        public virtual DbSet<EstadoUsuarios> EstadoUsuarios { get; set; }
        public virtual DbSet<Proveedores> Proveedores { get; set; }
        public virtual DbSet<RolUsuarios> RolUsuarios { get; set; }
        public virtual DbSet<THAsignaciones> THAsignaciones { get; set; }
        public virtual DbSet<THReparaciones> THReparaciones { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
    
        public virtual int sp_actualizarActivo(Nullable<int> idActivo, string codActivo, Nullable<int> categoria, string descripcion, Nullable<decimal> precioInicial, Nullable<decimal> precioActual, string fechaCompra, Nullable<int> proveedor, Nullable<int> estadoActivo, Nullable<int> garantia)
        {
            var idActivoParameter = idActivo.HasValue ?
                new ObjectParameter("idActivo", idActivo) :
                new ObjectParameter("idActivo", typeof(int));
    
            var codActivoParameter = codActivo != null ?
                new ObjectParameter("codActivo", codActivo) :
                new ObjectParameter("codActivo", typeof(string));
    
            var categoriaParameter = categoria.HasValue ?
                new ObjectParameter("categoria", categoria) :
                new ObjectParameter("categoria", typeof(int));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            var precioInicialParameter = precioInicial.HasValue ?
                new ObjectParameter("precioInicial", precioInicial) :
                new ObjectParameter("precioInicial", typeof(decimal));
    
            var precioActualParameter = precioActual.HasValue ?
                new ObjectParameter("precioActual", precioActual) :
                new ObjectParameter("precioActual", typeof(decimal));
    
            var fechaCompraParameter = fechaCompra != null ?
                new ObjectParameter("fechaCompra", fechaCompra) :
                new ObjectParameter("fechaCompra", typeof(string));
    
            var proveedorParameter = proveedor.HasValue ?
                new ObjectParameter("proveedor", proveedor) :
                new ObjectParameter("proveedor", typeof(int));
    
            var estadoActivoParameter = estadoActivo.HasValue ?
                new ObjectParameter("estadoActivo", estadoActivo) :
                new ObjectParameter("estadoActivo", typeof(int));
    
            var garantiaParameter = garantia.HasValue ?
                new ObjectParameter("garantia", garantia) :
                new ObjectParameter("garantia", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_actualizarActivo", idActivoParameter, codActivoParameter, categoriaParameter, descripcionParameter, precioInicialParameter, precioActualParameter, fechaCompraParameter, proveedorParameter, estadoActivoParameter, garantiaParameter);
        }
    
        public virtual int sp_agregarActivo(string codActivo, Nullable<int> categoria, string descripcion, Nullable<decimal> precioInicial, Nullable<decimal> precioActual, string fechaCompra, Nullable<int> proveedor, Nullable<int> estadoActivo, Nullable<int> garantia)
        {
            var codActivoParameter = codActivo != null ?
                new ObjectParameter("codActivo", codActivo) :
                new ObjectParameter("codActivo", typeof(string));
    
            var categoriaParameter = categoria.HasValue ?
                new ObjectParameter("categoria", categoria) :
                new ObjectParameter("categoria", typeof(int));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            var precioInicialParameter = precioInicial.HasValue ?
                new ObjectParameter("precioInicial", precioInicial) :
                new ObjectParameter("precioInicial", typeof(decimal));
    
            var precioActualParameter = precioActual.HasValue ?
                new ObjectParameter("precioActual", precioActual) :
                new ObjectParameter("precioActual", typeof(decimal));
    
            var fechaCompraParameter = fechaCompra != null ?
                new ObjectParameter("fechaCompra", fechaCompra) :
                new ObjectParameter("fechaCompra", typeof(string));
    
            var proveedorParameter = proveedor.HasValue ?
                new ObjectParameter("proveedor", proveedor) :
                new ObjectParameter("proveedor", typeof(int));
    
            var estadoActivoParameter = estadoActivo.HasValue ?
                new ObjectParameter("estadoActivo", estadoActivo) :
                new ObjectParameter("estadoActivo", typeof(int));
    
            var garantiaParameter = garantia.HasValue ?
                new ObjectParameter("garantia", garantia) :
                new ObjectParameter("garantia", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_agregarActivo", codActivoParameter, categoriaParameter, descripcionParameter, precioInicialParameter, precioActualParameter, fechaCompraParameter, proveedorParameter, estadoActivoParameter, garantiaParameter);
        }
    
        public virtual ObjectResult<sp_BuscarActivos_Result> sp_BuscarActivos(string string_busqueda)
        {
            var string_busquedaParameter = string_busqueda != null ?
                new ObjectParameter("string_busqueda", string_busqueda) :
                new ObjectParameter("string_busqueda", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_BuscarActivos_Result>("sp_BuscarActivos", string_busquedaParameter);
        }
    
        public virtual ObjectResult<sp_BuscarActivosPorIdYNombre_Result> sp_BuscarActivosPorIdYNombre(string string_busqueda)
        {
            var string_busquedaParameter = string_busqueda != null ?
                new ObjectParameter("string_busqueda", string_busqueda) :
                new ObjectParameter("string_busqueda", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_BuscarActivosPorIdYNombre_Result>("sp_BuscarActivosPorIdYNombre", string_busquedaParameter);
        }
    
        public virtual int sp_EliminaDepreciacion(Nullable<int> activo)
        {
            var activoParameter = activo.HasValue ?
                new ObjectParameter("activo", activo) :
                new ObjectParameter("activo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminaDepreciacion", activoParameter);
        }
    
        public virtual int sp_eliminarActivo(Nullable<int> idActivo)
        {
            var idActivoParameter = idActivo.HasValue ?
                new ObjectParameter("idActivo", idActivo) :
                new ObjectParameter("idActivo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_eliminarActivo", idActivoParameter);
        }
    
        public virtual int sp_eliminarReparacion(Nullable<int> idReparacion)
        {
            var idReparacionParameter = idReparacion.HasValue ?
                new ObjectParameter("idReparacion", idReparacion) :
                new ObjectParameter("idReparacion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_eliminarReparacion", idReparacionParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_IdCategoriaporNombreCategoria(string nombreCategoria)
        {
            var nombreCategoriaParameter = nombreCategoria != null ?
                new ObjectParameter("nombreCategoria", nombreCategoria) :
                new ObjectParameter("nombreCategoria", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_IdCategoriaporNombreCategoria", nombreCategoriaParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_IdEstadoActivoEstadoActivo(string nombreEstado)
        {
            var nombreEstadoParameter = nombreEstado != null ?
                new ObjectParameter("nombreEstado", nombreEstado) :
                new ObjectParameter("nombreEstado", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_IdEstadoActivoEstadoActivo", nombreEstadoParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_IdEstadoActivoporNombreEstadoActivo(string nombreEstado)
        {
            var nombreEstadoParameter = nombreEstado != null ?
                new ObjectParameter("nombreEstado", nombreEstado) :
                new ObjectParameter("nombreEstado", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_IdEstadoActivoporNombreEstadoActivo", nombreEstadoParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_IdProveedorporNombreProveedor(string nombreProveedor)
        {
            var nombreProveedorParameter = nombreProveedor != null ?
                new ObjectParameter("nombreProveedor", nombreProveedor) :
                new ObjectParameter("nombreProveedor", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_IdProveedorporNombreProveedor", nombreProveedorParameter);
        }
    
        public virtual int sp_InsertaBitacora(Nullable<int> idUsuario, string descripcion)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("idUsuario", idUsuario) :
                new ObjectParameter("idUsuario", typeof(int));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertaBitacora", idUsuarioParameter, descripcionParameter);
        }
    
        public virtual int sp_InsertaDepreciacion(Nullable<int> idActivo, Nullable<System.DateTime> fechaDepreciacion, Nullable<int> mesesDepreciacion, Nullable<double> valor)
        {
            var idActivoParameter = idActivo.HasValue ?
                new ObjectParameter("idActivo", idActivo) :
                new ObjectParameter("idActivo", typeof(int));
    
            var fechaDepreciacionParameter = fechaDepreciacion.HasValue ?
                new ObjectParameter("fechaDepreciacion", fechaDepreciacion) :
                new ObjectParameter("fechaDepreciacion", typeof(System.DateTime));
    
            var mesesDepreciacionParameter = mesesDepreciacion.HasValue ?
                new ObjectParameter("mesesDepreciacion", mesesDepreciacion) :
                new ObjectParameter("mesesDepreciacion", typeof(int));
    
            var valorParameter = valor.HasValue ?
                new ObjectParameter("valor", valor) :
                new ObjectParameter("valor", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertaDepreciacion", idActivoParameter, fechaDepreciacionParameter, mesesDepreciacionParameter, valorParameter);
        }
    
        public virtual int sp_InsertaReparacion(Nullable<int> idActivo, Nullable<System.DateTime> fechaInicialReparacion, Nullable<System.DateTime> fechaFinalReparacion)
        {
            var idActivoParameter = idActivo.HasValue ?
                new ObjectParameter("idActivo", idActivo) :
                new ObjectParameter("idActivo", typeof(int));
    
            var fechaInicialReparacionParameter = fechaInicialReparacion.HasValue ?
                new ObjectParameter("fechaInicialReparacion", fechaInicialReparacion) :
                new ObjectParameter("fechaInicialReparacion", typeof(System.DateTime));
    
            var fechaFinalReparacionParameter = fechaFinalReparacion.HasValue ?
                new ObjectParameter("fechaFinalReparacion", fechaFinalReparacion) :
                new ObjectParameter("fechaFinalReparacion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertaReparacion", idActivoParameter, fechaInicialReparacionParameter, fechaFinalReparacionParameter);
        }
    
        public virtual ObjectResult<string> sp_listarCategoriaPorId(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_listarCategoriaPorId", idParameter);
        }
    
        public virtual ObjectResult<string> sp_listarCodActivoPorId(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_listarCodActivoPorId", idParameter);
        }
    
        public virtual ObjectResult<string> sp_listarEstadoActivoPorId(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_listarEstadoActivoPorId", idParameter);
        }
    
        public virtual ObjectResult<string> sp_listarProveedorPorId(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_listarProveedorPorId", idParameter);
        }
    
        public virtual int sp_ModificaDepreciacion(Nullable<int> activo, Nullable<System.DateTime> fechaDepreciacion, Nullable<double> valor)
        {
            var activoParameter = activo.HasValue ?
                new ObjectParameter("activo", activo) :
                new ObjectParameter("activo", typeof(int));
    
            var fechaDepreciacionParameter = fechaDepreciacion.HasValue ?
                new ObjectParameter("fechaDepreciacion", fechaDepreciacion) :
                new ObjectParameter("fechaDepreciacion", typeof(System.DateTime));
    
            var valorParameter = valor.HasValue ?
                new ObjectParameter("valor", valor) :
                new ObjectParameter("valor", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ModificaDepreciacion", activoParameter, fechaDepreciacionParameter, valorParameter);
        }
    
        public virtual int sp_modificaReparacion(Nullable<int> idReparacion, Nullable<System.DateTime> fechaInicialReparacion, Nullable<System.DateTime> fechaFinalReparacion)
        {
            var idReparacionParameter = idReparacion.HasValue ?
                new ObjectParameter("idReparacion", idReparacion) :
                new ObjectParameter("idReparacion", typeof(int));
    
            var fechaInicialReparacionParameter = fechaInicialReparacion.HasValue ?
                new ObjectParameter("fechaInicialReparacion", fechaInicialReparacion) :
                new ObjectParameter("fechaInicialReparacion", typeof(System.DateTime));
    
            var fechaFinalReparacionParameter = fechaFinalReparacion.HasValue ?
                new ObjectParameter("fechaFinalReparacion", fechaFinalReparacion) :
                new ObjectParameter("fechaFinalReparacion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_modificaReparacion", idReparacionParameter, fechaInicialReparacionParameter, fechaFinalReparacionParameter);
        }
    
        public virtual ObjectResult<sp_mostrarActivo_Result> sp_mostrarActivo()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_mostrarActivo_Result>("sp_mostrarActivo");
        }
    
        public virtual ObjectResult<Nullable<int>> sp_mostrarCategoriasDiferentes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_mostrarCategoriasDiferentes");
        }
    
        public virtual ObjectResult<string> sp_mostrarCodActivo()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_mostrarCodActivo");
        }
    
        public virtual ObjectResult<string> sp_mostrarCodActivoDiferentes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_mostrarCodActivoDiferentes");
        }
    
        public virtual ObjectResult<sp_obtenerActivos_Result> sp_obtenerActivos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_obtenerActivos_Result>("sp_obtenerActivos");
        }
    
        public virtual ObjectResult<sp_RetornaBitacora_Result> sp_RetornaBitacora()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaBitacora_Result>("sp_RetornaBitacora");
        }
    
        public virtual ObjectResult<sp_RetornaDepreciacion_Result> sp_RetornaDepreciacion(Nullable<int> activo)
        {
            var activoParameter = activo.HasValue ?
                new ObjectParameter("activo", activo) :
                new ObjectParameter("activo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaDepreciacion_Result>("sp_RetornaDepreciacion", activoParameter);
        }
    
        public virtual ObjectResult<sp_retornaDepreciacionesLista_Result> sp_retornaDepreciacionesLista()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_retornaDepreciacionesLista_Result>("sp_retornaDepreciacionesLista");
        }
    
        public virtual ObjectResult<sp_RetornaDepreciacionId_Result> sp_RetornaDepreciacionId(Nullable<int> idActivo)
        {
            var idActivoParameter = idActivo.HasValue ?
                new ObjectParameter("idActivo", idActivo) :
                new ObjectParameter("idActivo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaDepreciacionId_Result>("sp_RetornaDepreciacionId", idActivoParameter);
        }
    
        public virtual ObjectResult<sp_RetornaDepreciados_Result> sp_RetornaDepreciados()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaDepreciados_Result>("sp_RetornaDepreciados");
        }
    
        public virtual ObjectResult<sp_RetornaReparacion_Result> sp_RetornaReparacion(string string_busqueda)
        {
            var string_busquedaParameter = string_busqueda != null ?
                new ObjectParameter("string_busqueda", string_busqueda) :
                new ObjectParameter("string_busqueda", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaReparacion_Result>("sp_RetornaReparacion", string_busquedaParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> spActivosCalcularCant(Nullable<int> idUsuario)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("spActivosCalcularCant", idUsuarioParameter);
        }
    
        public virtual ObjectResult<spActivosRetornaDatosId_Result> spActivosRetornaDatosId(Nullable<int> idActivo)
        {
            var idActivoParameter = idActivo.HasValue ?
                new ObjectParameter("IdActivo", idActivo) :
                new ObjectParameter("IdActivo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spActivosRetornaDatosId_Result>("spActivosRetornaDatosId", idActivoParameter);
        }
    
        public virtual ObjectResult<spActivosRetornaLista_Result> spActivosRetornaLista(string codigo, string descripcion)
        {
            var codigoParameter = codigo != null ?
                new ObjectParameter("codigo", codigo) :
                new ObjectParameter("codigo", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spActivosRetornaLista_Result>("spActivosRetornaLista", codigoParameter, descripcionParameter);
        }
    
        public virtual ObjectResult<spActivosRetornaListaId_Result> spActivosRetornaListaId(Nullable<int> idActivo)
        {
            var idActivoParameter = idActivo.HasValue ?
                new ObjectParameter("IdActivo", idActivo) :
                new ObjectParameter("IdActivo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spActivosRetornaListaId_Result>("spActivosRetornaListaId", idActivoParameter);
        }
    
        public virtual ObjectResult<spActivosRetornaListaResumen_Result> spActivosRetornaListaResumen(Nullable<int> idActivo)
        {
            var idActivoParameter = idActivo.HasValue ?
                new ObjectParameter("IdActivo", idActivo) :
                new ObjectParameter("IdActivo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spActivosRetornaListaResumen_Result>("spActivosRetornaListaResumen", idActivoParameter);
        }
    
        public virtual int spAsignUsuarioEliminaDatos(Nullable<int> idAsignacion)
        {
            var idAsignacionParameter = idAsignacion.HasValue ?
                new ObjectParameter("IdAsignacion", idAsignacion) :
                new ObjectParameter("IdAsignacion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAsignUsuarioEliminaDatos", idAsignacionParameter);
        }
    
        public virtual int spAsignUsuarioInsertaDatos(Nullable<int> idUsuario, Nullable<int> idActivo, Nullable<System.DateTime> fechaInicialAsignacion, Nullable<System.DateTime> fechafinalAsignacion)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            var idActivoParameter = idActivo.HasValue ?
                new ObjectParameter("IdActivo", idActivo) :
                new ObjectParameter("IdActivo", typeof(int));
    
            var fechaInicialAsignacionParameter = fechaInicialAsignacion.HasValue ?
                new ObjectParameter("FechaInicialAsignacion", fechaInicialAsignacion) :
                new ObjectParameter("FechaInicialAsignacion", typeof(System.DateTime));
    
            var fechafinalAsignacionParameter = fechafinalAsignacion.HasValue ?
                new ObjectParameter("FechafinalAsignacion", fechafinalAsignacion) :
                new ObjectParameter("FechafinalAsignacion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAsignUsuarioInsertaDatos", idUsuarioParameter, idActivoParameter, fechaInicialAsignacionParameter, fechafinalAsignacionParameter);
        }
    
        public virtual int spAsignUsuarioModificaDatos(Nullable<int> idAsignacion, Nullable<int> idUsuario, Nullable<int> idActivo, Nullable<System.DateTime> fechaInicialAsignacion, Nullable<System.DateTime> fechafinalAsignacion)
        {
            var idAsignacionParameter = idAsignacion.HasValue ?
                new ObjectParameter("IdAsignacion", idAsignacion) :
                new ObjectParameter("IdAsignacion", typeof(int));
    
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            var idActivoParameter = idActivo.HasValue ?
                new ObjectParameter("IdActivo", idActivo) :
                new ObjectParameter("IdActivo", typeof(int));
    
            var fechaInicialAsignacionParameter = fechaInicialAsignacion.HasValue ?
                new ObjectParameter("FechaInicialAsignacion", fechaInicialAsignacion) :
                new ObjectParameter("FechaInicialAsignacion", typeof(System.DateTime));
    
            var fechafinalAsignacionParameter = fechafinalAsignacion.HasValue ?
                new ObjectParameter("FechafinalAsignacion", fechafinalAsignacion) :
                new ObjectParameter("FechafinalAsignacion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAsignUsuarioModificaDatos", idAsignacionParameter, idUsuarioParameter, idActivoParameter, fechaInicialAsignacionParameter, fechafinalAsignacionParameter);
        }
    
        public virtual ObjectResult<spAsignUsuarioRetornaDatosId_Result> spAsignUsuarioRetornaDatosId(Nullable<int> idAsignacion)
        {
            var idAsignacionParameter = idAsignacion.HasValue ?
                new ObjectParameter("IdAsignacion", idAsignacion) :
                new ObjectParameter("IdAsignacion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spAsignUsuarioRetornaDatosId_Result>("spAsignUsuarioRetornaDatosId", idAsignacionParameter);
        }
    
        public virtual ObjectResult<spAsignUsuarioRetornaLista_Result> spAsignUsuarioRetornaLista(string nombre, string descripcion)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spAsignUsuarioRetornaLista_Result>("spAsignUsuarioRetornaLista", nombreParameter, descripcionParameter);
        }
    
        public virtual ObjectResult<spAsignUsuarioRetornaListaId_Result> spAsignUsuarioRetornaListaId(Nullable<int> idUsuario)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spAsignUsuarioRetornaListaId_Result>("spAsignUsuarioRetornaListaId", idUsuarioParameter);
        }
    
        public virtual ObjectResult<spEstadoActivosRetornaLista_Result> spEstadoActivosRetornaLista()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spEstadoActivosRetornaLista_Result>("spEstadoActivosRetornaLista");
        }
    
        public virtual ObjectResult<spEstadoUsuariosRetornaLista_Result> spEstadoUsuariosRetornaLista()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spEstadoUsuariosRetornaLista_Result>("spEstadoUsuariosRetornaLista");
        }
    
        public virtual ObjectResult<spRolesRetornaLista_Result> spRolesRetornaLista()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spRolesRetornaLista_Result>("spRolesRetornaLista");
        }
    
        public virtual int spUsuariosActualizaUltLogin(Nullable<int> idUsuario)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUsuariosActualizaUltLogin", idUsuarioParameter);
        }
    
        public virtual int spUsuariosEliminaDatos(Nullable<int> idUsuario)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUsuariosEliminaDatos", idUsuarioParameter);
        }
    
        public virtual int spUsuariosInsertaDatos(string nombre, string apellido, Nullable<int> estado, Nullable<int> rol, Nullable<int> cedula, string contrasena, string telefono, string correo, string direccion, Nullable<System.DateTime> fechaCreacion)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("apellido", apellido) :
                new ObjectParameter("apellido", typeof(string));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("estado", estado) :
                new ObjectParameter("estado", typeof(int));
    
            var rolParameter = rol.HasValue ?
                new ObjectParameter("rol", rol) :
                new ObjectParameter("rol", typeof(int));
    
            var cedulaParameter = cedula.HasValue ?
                new ObjectParameter("cedula", cedula) :
                new ObjectParameter("cedula", typeof(int));
    
            var contrasenaParameter = contrasena != null ?
                new ObjectParameter("contrasena", contrasena) :
                new ObjectParameter("contrasena", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("telefono", telefono) :
                new ObjectParameter("telefono", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("correo", correo) :
                new ObjectParameter("correo", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("direccion", direccion) :
                new ObjectParameter("direccion", typeof(string));
    
            var fechaCreacionParameter = fechaCreacion.HasValue ?
                new ObjectParameter("fechaCreacion", fechaCreacion) :
                new ObjectParameter("fechaCreacion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUsuariosInsertaDatos", nombreParameter, apellidoParameter, estadoParameter, rolParameter, cedulaParameter, contrasenaParameter, telefonoParameter, correoParameter, direccionParameter, fechaCreacionParameter);
        }
    
        public virtual int spUsuariosModificaDatos(Nullable<int> idUsuario, string nombre, string apellido, Nullable<int> estado, Nullable<int> rol, Nullable<int> cedula, string contrasena, string telefono, string correo, string direccion, Nullable<System.DateTime> fechaCreacion)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("apellido", apellido) :
                new ObjectParameter("apellido", typeof(string));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("estado", estado) :
                new ObjectParameter("estado", typeof(int));
    
            var rolParameter = rol.HasValue ?
                new ObjectParameter("rol", rol) :
                new ObjectParameter("rol", typeof(int));
    
            var cedulaParameter = cedula.HasValue ?
                new ObjectParameter("cedula", cedula) :
                new ObjectParameter("cedula", typeof(int));
    
            var contrasenaParameter = contrasena != null ?
                new ObjectParameter("contrasena", contrasena) :
                new ObjectParameter("contrasena", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("telefono", telefono) :
                new ObjectParameter("telefono", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("correo", correo) :
                new ObjectParameter("correo", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("direccion", direccion) :
                new ObjectParameter("direccion", typeof(string));
    
            var fechaCreacionParameter = fechaCreacion.HasValue ?
                new ObjectParameter("fechaCreacion", fechaCreacion) :
                new ObjectParameter("fechaCreacion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUsuariosModificaDatos", idUsuarioParameter, nombreParameter, apellidoParameter, estadoParameter, rolParameter, cedulaParameter, contrasenaParameter, telefonoParameter, correoParameter, direccionParameter, fechaCreacionParameter);
        }
    
        public virtual ObjectResult<spUsuariosRetornaDatosId_Result> spUsuariosRetornaDatosId(Nullable<int> idUsuario)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spUsuariosRetornaDatosId_Result>("spUsuariosRetornaDatosId", idUsuarioParameter);
        }
    
        public virtual ObjectResult<spUsuariosRetornaDatosLogin_Result> spUsuariosRetornaDatosLogin(string correo, string contrasena)
        {
            var correoParameter = correo != null ?
                new ObjectParameter("correo", correo) :
                new ObjectParameter("correo", typeof(string));
    
            var contrasenaParameter = contrasena != null ?
                new ObjectParameter("Contrasena", contrasena) :
                new ObjectParameter("Contrasena", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spUsuariosRetornaDatosLogin_Result>("spUsuariosRetornaDatosLogin", correoParameter, contrasenaParameter);
        }
    
        public virtual ObjectResult<spUsuariosRetornaLista_Result> spUsuariosRetornaLista(string cedula, string nombre, string correo)
        {
            var cedulaParameter = cedula != null ?
                new ObjectParameter("cedula", cedula) :
                new ObjectParameter("cedula", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("correo", correo) :
                new ObjectParameter("correo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spUsuariosRetornaLista_Result>("spUsuariosRetornaLista", cedulaParameter, nombreParameter, correoParameter);
        }
    
        public virtual ObjectResult<spUsuariosRetornaListaEmpleado_Result> spUsuariosRetornaListaEmpleado(Nullable<int> idEmpleado)
        {
            var idEmpleadoParameter = idEmpleado.HasValue ?
                new ObjectParameter("IdEmpleado", idEmpleado) :
                new ObjectParameter("IdEmpleado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spUsuariosRetornaListaEmpleado_Result>("spUsuariosRetornaListaEmpleado", idEmpleadoParameter);
        }
    
        public virtual ObjectResult<spUsuariosRetornaListaId_Result> spUsuariosRetornaListaId(Nullable<int> idUsuario)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spUsuariosRetornaListaId_Result>("spUsuariosRetornaListaId", idUsuarioParameter);
        }
    }
}
