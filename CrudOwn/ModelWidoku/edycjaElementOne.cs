using Kolory_WPF.ModelWidoku;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;

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




        public string zawartośćListy
        {
            get
            {
                return model.zawartośćListy;
            }
            set
            {
                model.zawartośćListy = value;
                onPropertyChanged(nameof(zawartośćListy));
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
            
            mojaLista.Add(model.name);
            
            model.zawartośćListy = string.Join("\n", mojaLista);
            onPropertyChanged(nameof(zawartośćListy));



        }


    }
}


