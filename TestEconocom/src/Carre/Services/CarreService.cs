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

        public List< string> GetColorCarreListe(int max)
        {
            throw  new NotImplementedException();
        }
    }
}
