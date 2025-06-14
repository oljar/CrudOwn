using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CrudOwn.Services
{
    public class WindowService
    {
        public void ZamknijOknoPoNazwie(string nazwaOkna)
        {
            foreach (Window okno in Application.Current.Windows)

            {
                if (okno.Name == nazwaOkna)
                {  
                    okno.Close();
                    break;
                }
            }
        }
    }
}
