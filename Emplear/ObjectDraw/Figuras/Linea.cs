using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ObjectDraw.Figuras
{
  public class Linea : Figura
  {
    public double Longitud { get; set; }
    public double Direccion { get; set; }

    protected override Shape CrearShape()
    {
      Line linea = new Line();
      double radianes = (Math.PI/180)*Direccion;

      linea.X2 = X + Longitud*Math.Cos(radianes);
      linea.Y2 = Y + Longitud*Math.Sin(radianes);

      linea.Stroke = Brushes.Chocolate;
      linea.StrokeThickness = 5;

      return linea;
    }
  }
}
