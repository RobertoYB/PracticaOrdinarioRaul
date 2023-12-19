using PracticaOrdinarioRaul.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOrdinarioRaul
{
    public class Platillo : IPlatillo
    {
        public string NombrePlatillo { get; set; }
        public int PrecioPlatillo { get; set; }
        public int IdentificadorPlatillo { get; set; }
        public int IdentificadorPlatilloAnterior { get; set; }

        public Platillo(string nombre, int precio)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El nombre del platillo no puede estar vacío o ser espacios en blanco.");
            }

            if (precio <= 0)
            {
                throw new ArgumentException("El precio del platillo debe ser mayor a 0.");
            }

            NombrePlatillo = nombre;
            PrecioPlatillo = precio;
            IdentificadorPlatilloAnterior = 0; // Inicializamos el identificador anterior
            IdentificadorPlatillo = ++IdentificadorPlatilloAnterior; // Incrementamos el identificador actual
        }

        public bool ValidarNombre()
        {
            return !string.IsNullOrWhiteSpace(NombrePlatillo);
        }

        public bool ValidarPrecio()
        {
            return PrecioPlatillo > 0;
        }
    }
}
