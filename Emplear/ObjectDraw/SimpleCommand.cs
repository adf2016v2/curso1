using System;
using System.Windows.Input;

namespace ObjectDraw
{
  public class SimpleCommand : ICommand
  {
    private Action<object> _execute;
    private Predicate<object> _canExecute;

    public SimpleCommand(Action<object> execute, Predicate<object> canExecute)
    {
      _execute = execute;
      _canExecute = canExecute;
    }

    public bool CanExecute(object parameter)
    {
      return _canExecute == null ? true: _canExecute(parameter);
    }

    public void Execute(object parameter)
    {
      _execute(parameter);
    }

    public event EventHandler CanExecuteChanged
    {
      add { CommandManager.RequerySuggested += value;  }
      remove { CommandManager.RequerySuggested -= value; }
    }
  }
}
