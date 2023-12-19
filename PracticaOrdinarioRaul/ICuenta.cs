using System;

public interface ICuenta
{
    private List<ElementoCuenta> _elementosCuenta;

    public void AgregarElemento(Platillo platillo, Cantidad cantidad);

    public void MostrarCuenta();
}
