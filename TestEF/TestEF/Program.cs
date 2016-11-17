using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Data;
using Entidades;

namespace TestEF
{
  class Program
  {
    static void Main(string[] args)
    {

//con esto nos conectamos a la base de datos

      TestContext ctx = TestContext.DB;

//funcion del contexto para validar que la base exista

      if (ctx.Database.Exists())
        Console.WriteLine("Conexion con la base de datos...");
      else
        Console.WriteLine("No existe la Base de datos...");
//
      Perfil p = ctx.Perfiles.FirstOrDefault();

      Console.WriteLine($" Descripcion:  {p.Descripcion}");
      Console.ReadLine();
    }
  }
}
