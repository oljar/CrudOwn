using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOwn.Model
{
    
        public interface IElement
        {
            string Name { get; set; }
            string ZawartośćListy { get; set; }
            ObservableCollection<string> MojaLista { get; set; }
            string SelectedItem { get; set; }
            int Indeks { get; set; }
        
    }
}
