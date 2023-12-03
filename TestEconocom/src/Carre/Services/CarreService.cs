using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carre.Services
{
    public class CarreService
    {
        /// <summary>
        /// Elle retourne 
        /// la couleur du Carré
        /// </summary>
        /// <param name="valeur"></param>
        /// <returns></returns>
        public string GetColorCarre(int valeur)
        {
            if (valeur % 3 == 0 && valeur % 5 == 0)
            {
                return "Jaune";
            }
            else if (valeur % 3 == 0)
            {
                return "Verte";
            }
            else if (valeur % 5 == 0)
            {
                return "Bleu";
            }
            else
            {
                return valeur.ToString();
            }
             
        }

        /// <summary>
        /// elle parcour un maximum d'entier
        /// en affichant la couleur des differents
        /// carrés 
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        public Dictionary<int, string> GetListeColorsCarres(int max)
        {
            Dictionary<int, string> listeColorCarres = new Dictionary<int, string>();
            bool itsOk = false;
            string valeur = string.Empty;
            int numbre;

            for(int i= 1; i <= max; i++)
            {
                valeur = GetColorCarre(i);
                itsOk= int.TryParse(valeur, out numbre);    
                if(!itsOk )
                {
                    listeColorCarres.Add(i, valeur);    
                }
            }
            return listeColorCarres;
        }
    }
}
