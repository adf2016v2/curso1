using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ObjectDraw.Figuras
{
  public class Circulo : Figura, IRellenable
  {
    public double Radio { get; set; }

    public void Rellenar(Brush color)
    {
      Forma.Fill = color;
    }

    protected override Shape CrearShape()
    {
      Ellipse circ;

      circ = new Ellipse();

      circ.StrokeThickness = 3;
      circ.Stroke = Brushes.Blue;
      circ.Width = circ.Height = Radio*2;
      return circ;
    }

  }
}
