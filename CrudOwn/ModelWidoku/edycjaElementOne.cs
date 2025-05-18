using Kolory_WPF.ModelWidoku;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CrudOwn.ModelWidoku
{



    public class edycjaElementOne : ObservedObject
    {
        public elementOne model = new elementOne("");

        ObservableCollection<string> mojaLista = new ObservableCollection<string>();

        public string name
        {
            get
            {
                return model.name;
            }
            set
            {
                model.name = value;
                onPropertyChanged(nameof(name));
            }
        }
       
        




      
        private RelayCommand dodaj;
      
        public ICommand Dodaj
        {
            get
            {
                if (dodaj == null)
                {
                    dodaj = new RelayCommand(PerformDodaj);
                }

                return dodaj;
            }
        }

        private void PerformDodaj(object commandParameter)

        {
            
            mojaLista.Add(model.name.ToString());
            string zawartoscListy = string.Join("\n", mojaLista);
            MessageBox.Show(zawartoscListy, "Zawartość ObservableCollection");
        }


    }
}


