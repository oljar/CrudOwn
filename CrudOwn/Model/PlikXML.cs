using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CrudOwn.Model
{
    public static class PlikXML
    {
     
        internal static void ZapiszDoPliku(string sciezka, ObservableCollection<string> mojaLista)
        {
            using (System.IO.StreamWriter plik = new System.IO.StreamWriter(sciezka))
            {
                foreach (string element in mojaLista)
                {
                    plik.WriteLine(element);
                }
            }
            MessageBox.Show("Zapisano do pliku txt");
        }




        internal static ObservableCollection<string> OdczytajZPliku(string sciezka)
        {
            ObservableCollection<string> lista = new ObservableCollection<string>();

            try
            {
                using (StreamReader plik = new StreamReader(sciezka))
                {
                    string linia;
                    while ((linia = plik.ReadLine()) != null)
                    {
                        lista.Add(linia);
                        
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas odczytu pliku: {ex.Message}");
            }

            return lista;
        }
    }
}
