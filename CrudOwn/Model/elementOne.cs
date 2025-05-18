using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public class elementOne
    {
        public string name;
        public string zawartośćListy;
        public ObservableCollection<string> mojaLista = new ObservableCollection<string>();
        public string selectedItem;
        public int indeks;



    public elementOne(string name = "", string zawartośćListy = "", ObservableCollection<string> mojaLista = null, string selectedItem = "", int indeks=0)

        {
            this.name = name;
            this.zawartośćListy = zawartośćListy;
            this.mojaLista = new ObservableCollection<string>();
            this.selectedItem = selectedItem;
            this.indeks = indeks;
    }
    }

    


