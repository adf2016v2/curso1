using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Data
{
  /// <summary>
  /// [[SINGLETON]]
  /// </summary>
  public class TestContext : DbContext
  {
    public static TestContext DB { get; private set; }

//referencia las tablas usuarios y perfiles con la clase generica "DbSet" 
//mapea el acceso a una tabla es una propiedad que ya esta en framework
//son propiedades
//para esto hay que ir a Solution Explorer Referencias hacer un add Reference, la solapa Proyect y agregar mis entidades

//    public DbSet<Usuario> Usuarios { get; set; }

    public DbSet<Perfil> Perfiles { get; set; }

//
    static TestContext()
    {
      DB = new TestContext();
    }

    private TestContext()
    {
      //  crear writer para log de eventos
    }

        //METODO OnModelCreating ve como mapear la base de datos a la clase.
        //modelBuilder inspeciona las clases del DbSet

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
            //Se crea una clase ConfiguracionUsuario para configurar usuario y Perfiles
 //     modelBuilder.Configurations.Add(new ConfiguracionUsuario());
      modelBuilder.Configurations.Add(new ConfiguracionPerfil());
    }
  }

//repetir para clase que se quiere comfigurar con el FrameWork

/*  public class ConfiguracionUsuario : EntityTypeConfiguration<Usuario>
  {
    public ConfiguracionUsuario()
    {
      this.HasKey(usr => usr.Login);

      this.Property(usr => usr.LastLogin)
        .HasColumnName("FechaUltimoLogin");

      this.HasRequired(usr => usr.Perfil)
        .WithMany()
        .Map(cfg => cfg.MapKey("ID_Perfil"));
    }
  }*/

  public class ConfiguracionPerfil : EntityTypeConfiguration<Perfil>
  {
    public ConfiguracionPerfil()
    {
//Totable le configura el nombre verdadero de la tabla
      ToTable("Perfiles");
//per => per.IDPerfil = expresion landa
      this.HasKey(p => p.IDPerfil);
//setea el mapeo de nombres con la tabla, la mapea
      this.Property(p => p.IDPerfil).HasColumnName("ID_Perfil");
    }
  }
}
