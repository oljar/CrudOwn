using CrudOwn.Model;
using System.Collections.ObjectModel;



public class elementOne :IElement
{
    public string name { get; set; }
    public string Name { get; set; }
    public string ZawartośćListy { get; set; }
    public ObservableCollection<string> MojaLista { get; set; }
    public string SelectedItem { get; set; }
    public int Indeks { get; set; }

    public string zawartośćListy;
    public ObservableCollection<string> mojaLista = new ObservableCollection<string>();
    public string selectedItem;
    public int indeks;



    public elementOne(string name = "", string zawartośćListy = "", ObservableCollection<string> mojaLista = null, string selectedItem = "", int indeks = 0)

    {
        this.name = name;
        this.zawartośćListy = zawartośćListy;
        this.mojaLista = new ObservableCollection<string>();
        this.selectedItem = selectedItem;
        this.indeks = indeks;
    }


}




