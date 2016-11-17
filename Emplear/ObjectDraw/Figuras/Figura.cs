using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;

namespace ObjectDraw.Figuras
{
  public class Figura : INotifyPropertyChanged
  {
    private double _x, _y;

    public double X
    {
      get { return _x; }
      set
      {
        _x = value;
        OnPropertyChanged(nameof(X));
      }
    }

    public double Y
    {
      get { return _y; }
      set
      {
        _y = value;
        OnPropertyChanged(nameof(Y));
      }
    }

    private bool _visible;

    public bool Visible
    {
      get { return _visible;}
      set
      {
        _visible = value;
        OnPropertyChanged(nameof(Visible));
      }
    }

    protected Shape Forma { get; set; }

    public event PropertyChangedEventHandler PropertyChanged;

    public Shape Mostrar()
    {
      if (Forma == null)
      {
        //  no se que shape voy a crear concretamente...pero se que siempre voy a tener que crear una!!
        Forma = CrearShape();
      }

      Visible = true;

      return Forma;
    }

    protected virtual Shape CrearShape()
    {
      return null;
    }

    public Shape Ocultar()
    {
      Visible = false;
      return Forma;
    }

    public void Mover(double newX, double newY)
    {
      X = newX;
      Y = newY;
    }

    protected void OnPropertyChanged(string prop)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
  }
}
