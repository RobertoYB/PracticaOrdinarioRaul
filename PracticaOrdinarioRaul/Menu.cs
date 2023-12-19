using PracticaOrdinarioRaul.Interfaces;
using System;
using System.Collections.Generic;

namespace PracticaOrdinarioRaul
{
    public class Menu : IMenu
    {
        public string NombreMenu { get; set; }
        private List<Platillo> Platillos { get; set; }

        public Menu(string nombreMenu)
        {
            if (string.IsNullOrWhiteSpace(nombreMenu))
            {
                throw new ArgumentException("El título del menú no puede estar vacío.");
            }

            NombreMenu = nombreMenu;
            Platillos = new List<Platillo>();
        }

        public void VerMenu()
        {
            Console.WriteLine($"Menú: {NombreMenu}");

            foreach (var platillo in Platillos)
            {
                Console.WriteLine($"{platillo.IdentificadorPlatillo} - {platillo.NombrePlatillo}: ${platillo.PrecioPlatillo}");
            }
        }

        public void AgregarPlatillo(string NombrePlatillo, int PrecioPlatillo)
        {
            if (Platillos.Exists(p => p.NombrePlatillo == NombrePlatillo))
            {
                Console.WriteLine($"El platillo '{NombrePlatillo}' ya existe en el menú.");
                return;
            }

            var nuevoPlatillo = new Platillo(NombrePlatillo, PrecioPlatillo);
            Platillos.Add(nuevoPlatillo);
        }

        // Corregir el nivel de acceso a 'public'
        public Platillo ObtenerPlatillo(int IdentificadorPlatillo)
        {
            return Platillos.Find(p => p.IdentificadorPlatillo == IdentificadorPlatillo);
        }
    }
}