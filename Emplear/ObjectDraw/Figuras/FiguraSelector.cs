using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ObjectDraw.Figuras
{
  /// <summary>
  /// Permite seleccionar una visualizacion determinada dependiendo del tipo de figura que tenemos en el item del combo
  /// </summary>
  public class FiguraSelector : DataTemplateSelector
  {
    public DataTemplate RectTemplate { get; set; }

    public DataTemplate CircTemplate { get; set; }

    public DataTemplate LineTemplate { get; set; }

    public override DataTemplate SelectTemplate(object item, DependencyObject container)
    {
      Figura figura = item as Figura;
      DataTemplate result = null;

      if (figura != null)
      {
        if (figura is Rectangulo)
          result = RectTemplate;
        if (figura is Linea)
          result = LineTemplate;
        if (figura is Circulo)
          result = CircTemplate;
      }
      return result;
    }
  }
}
