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

        public ObservableCollection<string> mojaLista
        {
            get
            {
                return model.mojaLista;
            }
            set
            {
                model.mojaLista = value;
                
            }
        }

        public string selectedItem
        {
            get
            {
                return model.selectedItem;
            }
            set
            {
                model.selectedItem = value;
                onPropertyChanged(nameof(selectedItem));
            }
        }





        public int indeks
        {
            get
            {
                return model.indeks;
            }
            set
            {
                model.indeks = value;
                onPropertyChanged(nameof(indeks));
            }
        }





        #region dodaj

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

        #endregion

        #region odejmij
        private RelayCommand odejmij;

        public ICommand Odejmij
        {
            get
            {
                if (odejmij == null)
                {
                    odejmij = new RelayCommand(PerformOdejmij);
                }
                return odejmij;
            }
        }

        private void PerformOdejmij(object commandParameter)
        {
            model.indeks = model.mojaLista.IndexOf(model.selectedItem);
            mojaLista.RemoveAt(model.indeks );
            model.zawartośćListy = string.Join("\n", mojaLista);
            onPropertyChanged(nameof(zawartośćListy));
        }

        #endregion 

        #region edytuj
        private RelayCommand edytuj;

        public ICommand Edytuj
        {
            get
            {
                if (edytuj == null)
                {
                    edytuj= new RelayCommand(PerformWyświetl);
                }
                return edytuj;
            }
        }

        private void PerformWyświetl(object commandParameter) 

        {

            model.indeks = model.mojaLista.IndexOf(model.selectedItem);
            model.mojaLista[model.indeks] = model.name;
            model.zawartośćListy = string.Join("\n", mojaLista);
            onPropertyChanged(nameof(zawartośćListy));
           

            MessageBox.Show(model.indeks.ToString());
        }

        #endregion
    }






}


