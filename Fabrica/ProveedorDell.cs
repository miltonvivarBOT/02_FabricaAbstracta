using PatronFabricaAbstracta.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabricaAbstracta.Fabrica
{
    class ProveedorDell : ITiendaProductos
    {
        public IImpresora GenerarInstanciaImpresora()
        {
            return new ImpresoraDell();
        }

        public ILaptop GenerarInstanciaLaptop()
        {
            return new LaptopDell();
        }
    }
}
