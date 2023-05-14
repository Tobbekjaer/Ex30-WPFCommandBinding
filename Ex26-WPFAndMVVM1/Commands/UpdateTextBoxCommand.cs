using Ex26_WPFAndMVVM1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ex26_WPFAndMVVM1.Commands
{
    public class UpdateTextBoxCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true; 
        }

        public void Execute(object? parameter)
        {
            if(parameter is MainViewModel mvm) {
                mvm.MyTextBoxText = DateTime.Now.ToString();
            }
            else {
                throw new ArgumentException("Illegal parameter type");
            }

        }
    }
}
