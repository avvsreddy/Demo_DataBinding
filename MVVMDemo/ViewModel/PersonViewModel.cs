using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVVMDemo.Model;
using System.ComponentModel;
using System.Windows.Input;
using System.Diagnostics;
using MVVMDemo.Commands;
using System.Windows;

namespace MVVMDemo.ViewModel
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private Person person = new Person();

        public PersonViewModel()
        {
            SaveCommand = new PersonCommand(this);
        }

        public string Name 
        {
            get { return person.PersonName;}
            set 
           {
                person.PersonName = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }

        public ICommand SaveCommand { get; set; }

        //public RoutedUICommand SavePersonCommand { get; set; }


        public bool CanSave()
        {
            return Name.Length > 0;
        }

        public void Save()
        {
            //Debug.Write("Saving ... " + Name);
            MessageBox.Show("Saving ... " + Name);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
