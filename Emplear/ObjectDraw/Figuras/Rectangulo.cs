using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ObjectDraw.Figuras
{
  public class Rectangulo : Figura
  {
    public float Base { get; set; }
    public float Altura { get; set; }

    protected override Shape CrearShape()
    {
      Rectangle rect;

      rect = new Rectangle();

      rect.StrokeThickness = 4;
      rect.Stroke = Brushes.Black;
      rect.Width = Base;
      rect.Height = Altura;
      return rect;
    }
  }
}
