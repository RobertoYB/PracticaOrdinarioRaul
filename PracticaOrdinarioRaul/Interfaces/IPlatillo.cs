using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOrdinarioRaul.Interfaces
{
    public interface IPlatillo
    {
        string NombrePlatillo { get; set; }
        int PrecioPlatillo { get; set; }
        int IdentificadorPlatillo { get; set; } //Cada platillo tiene un código que lo identifica
        int IdentificadorPlatilloAnterior { get; set; } //El identificador de antes que se actualice el platillo en un menú

        bool ValidarNombre();
        bool ValidarPrecio();
    }
}
