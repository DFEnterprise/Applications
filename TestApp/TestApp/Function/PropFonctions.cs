using DFEImmobilier.Fenetre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFEImmobilier.Function
{
    class PropFonctions
    {
        public static void AfficheGoogleSearch(string adress){
            Streetview view = new Streetview();
            view.Show();
            Uri uri = new Uri(@adress);
            view.Browser.Navigate(uri);
           }
    }
}
