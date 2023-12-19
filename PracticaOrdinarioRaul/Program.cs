using System;

namespace PracticaOrdinarioRaul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

















































































































































































































    public class ElementoCuenta : IElementoCuenta
    {
        private Platillo _platillo { get; set; }

        private int _cantidad { get; set; };


        public Platillo Platillo
        {
            get { return _platillo; }
            set
            {
                if ((Platillo)_platillo == null)
                {
                    throw new Exception("El platillo no puede estar vacío");
                }
                _platillo = value;
            }

        }
        public int Cantidad
        {
            get { return = _cantidad}
            set
            {
                if (_cantidad <= 0)
                {
                    throw new Exception("La cantidad debe ser mayor a 0");
                }
            }
        }
        public int TotalElemento
        {
            get { Platillo.Precio* Cantidad}
        }

        public ElementoCuenta(Platillo platillo, int cantidad)
        {
            this.Platillo = platillo;
            this.Cantidad = cantidad;
        }

    }

    public class Cuenta : ICuenta
    {

        private List<ElementoCuenta> _elementosCuenta;

        public int Total
        {
            get
            {
                int total = 0;
                foreach (var elementoDeCuenta in _elementosCuenta)
                {
                    int total += elementoDeCuenta.TotalElemento;
                }
                return total;
            }
        }

        public Cuenta()
        {
            _elementosCuenta = new List<ElementoCuenta>();
        }

        public void AgregarElemento(Platillo platillo, Cantidad cantidad)
        {
            foreach (var elementoDeCuenta in _elementosCuenta)
            {
                if (elementoDeCuenta.Platillo.Id == platillo.Id)
                {
                    elementoDeCuenta.Cantidad += cantidad;
                    return;
                }
            }
            _elementosCuenta.Add(new ElementoCuenta(platillo, cantidad));
        }

        public void MostrarCuenta()
        {
            Console.WriteLine("Su total sería");
            foreach (var elementoDeCuenta in _elementosCuenta)
            {
                Console.WriteLine($"{elementoDeCuenta.Platillo.Nombre}. Cantidad: {elementoDeCuenta.Cantidad} Total: {elementoDeCuenta.Precio}");
            }
        }

    }









}

    
//////END


















