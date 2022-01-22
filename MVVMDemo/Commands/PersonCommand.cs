using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using MVVMDemo.Model;
using MVVMDemo.ViewModel;

namespace MVVMDemo.Commands
{
    public class PersonCommand : ICommand
    {
        private PersonViewModel person;
        public PersonCommand(PersonViewModel person)
        {
            this.person = person;
        }
        public bool CanExecute(object parameter)
        {
            return person.CanSave();
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            person.Save();
        }
    }
}
