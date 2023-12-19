using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOrdinarioRaul.Interfaces
{

    public class Platillo
    {

    }

    public interface IMenu
    {
        string NombreMenu { get; set; }

        void VerMenu();
        void AgregarPlatillo(string NombrePlatillo, int PrecioPlatillo);
        Platillo ObtenerPlatillo(int IdentificadorPlatillo);
    }
}
