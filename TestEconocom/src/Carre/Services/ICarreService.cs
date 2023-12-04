using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carre.Services
{
    public interface ICarreService
    {
        string GetColorCarre(int valeur);
        Dictionary<int, string> GetListeColorsCarres(int max);

    }
}
