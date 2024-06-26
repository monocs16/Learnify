﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Learnify.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class LearnifyEntities : DbContext
    {
        public LearnifyEntities()
            : base("name=LearnifyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cursos> Cursos { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    
        public virtual ObjectResult<Nullable<int>> AuthenticateUser(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("AuthenticateUser", usernameParameter, passwordParameter);
        }
    
        public virtual int InsertarUsuario(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertarUsuario", usernameParameter, passwordParameter);
        }
    
        public virtual int ModificarCurso(Nullable<int> id, string nuevoNombre, string nuevaDescripcion, Nullable<decimal> nuevoCosto, Nullable<int> nuevaDuracionSemanas)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var nuevoNombreParameter = nuevoNombre != null ?
                new ObjectParameter("NuevoNombre", nuevoNombre) :
                new ObjectParameter("NuevoNombre", typeof(string));
    
            var nuevaDescripcionParameter = nuevaDescripcion != null ?
                new ObjectParameter("NuevaDescripcion", nuevaDescripcion) :
                new ObjectParameter("NuevaDescripcion", typeof(string));
    
            var nuevoCostoParameter = nuevoCosto.HasValue ?
                new ObjectParameter("NuevoCosto", nuevoCosto) :
                new ObjectParameter("NuevoCosto", typeof(decimal));
    
            var nuevaDuracionSemanasParameter = nuevaDuracionSemanas.HasValue ?
                new ObjectParameter("NuevaDuracionSemanas", nuevaDuracionSemanas) :
                new ObjectParameter("NuevaDuracionSemanas", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModificarCurso", idParameter, nuevoNombreParameter, nuevaDescripcionParameter, nuevoCostoParameter, nuevaDuracionSemanasParameter);
        }
    
        public virtual ObjectResult<ObtenerCursos_Result> ObtenerCursos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ObtenerCursos_Result>("ObtenerCursos");
        }
    }
}
