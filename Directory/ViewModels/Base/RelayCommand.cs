using System;
using System.Collections.Generic;
using System.Windows.Input;
using System.Text;
using System.Threading.Tasks;

namespace TotalComrade
{
    public class RelayCommand : ICommand
    {

        private Action mAction;

        public RelayCommand(Action action)
        {
            this.mAction = action;
        }

        public event EventHandler CanExecuteChanged = (sender, e) => { };

        public bool CanExecute(object param)
        {
            return true;
        }

        public void Execute(object param)
        {
            mAction();
        }
    }
}
