using Ex26_WPFAndMVVM1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ex26_WPFAndMVVM1.Commands
{
    public class UpdateLabelCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            // Makes sure CanExecuteChanged is updated more often
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            bool result = true;

            // Checks the value of SliderTextBox in order to determine whether UpdateLabel button is enabled
            if (parameter is MainViewModel mvm) {
                if (mvm.SliderTextBox == null || mvm.SliderTextBox == "0") {
                    result = false; 
                }
            }
            
            return result;

        }

        public void Execute(object? parameter)
        {
            if(parameter is MainViewModel mvm) {
                mvm.MyLabelText = DateTime.Now.ToString();
            }
            else {
                throw new ArgumentException("Illegal parameter type.");
            }
        }
    }
}
