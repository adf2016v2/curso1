using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace ObjectDraw.Figuras
{
  /// <summary>
  /// Permite convertir una Figura en general a una cadena de texto
  /// </summary>
  public class FiguraConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      Rectangulo rect = value as Rectangulo;

      if (rect != null)
      {
        return $"RECT: ({rect.X}, {rect.Y}) [{rect.Base} x {rect.Altura}]";
      }

      Circulo circ = value as Circulo;

      if (circ != null)
      {
        return $"CIRC: ({circ.X}, {circ.Y}) Radio: {circ.Radio}";
      }

      Linea linea = value as Linea;

      if (linea != null)
      {
        return $"LINEA: ({linea.X}, {linea.Y}) Sz: {linea.Longitud} Ang: {linea.Direccion}";
      }
      return null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
