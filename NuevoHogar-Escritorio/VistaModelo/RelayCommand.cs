using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace NuevoHogar_Escritorio.VistaModelo
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object> executeAction;
        private readonly Predicate<object> canExecuteAction;
        //private readonly Func<object, bool> canExecuteAction;

        public RelayCommand(Action<object> executeAction)
        {
            this.executeAction = executeAction;
            canExecuteAction = null;
        }

        public RelayCommand(Action<object> executeAction, Predicate<object> canExecuteAction)
        {
            this.executeAction = executeAction;
            this.canExecuteAction = canExecuteAction;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return canExecuteAction == null ? true : canExecuteAction(parameter);
        }

        public void Execute(object parameter)
        {
            executeAction(parameter);
        }
    }
}
