using PatronFabricaAbstracta.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabricaAbstracta.Fabrica
{
    class ProveedorHP : ITiendaProductos
    {
        public IImpresora GenerarInstanciaImpresora()
        {
            return new ImpresoraHP();
        }

        public ILaptop GenerarInstanciaLaptop()
        {
            return new LaptopHP();
        }
    }
}
