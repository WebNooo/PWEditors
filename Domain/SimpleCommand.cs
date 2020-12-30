using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Domain
{
    class SimpleCommand<T> : ICommand
    {
        readonly Action<T> onExecute;
        public SimpleCommand(Action<T> onExecute) { this.onExecute = onExecute; }

        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter) => true;
        public void Execute(object parameter) => onExecute((T)parameter);
    }
}
