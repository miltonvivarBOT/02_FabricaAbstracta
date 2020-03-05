using PatronFabricaAbstracta.Fabrica;
using PatronFabricaAbstracta.Interfaces;
using System;

namespace PatronFabricaAbstracta
{
    class Principal
    {
        static void Main(string[] args)
        {

            ITiendaProductos Tienda = null;
            string cProveedor = "";
            string cProducto = "";
            int iCantidad = 0;

            Console.WriteLine("Selecciona Proveedor: \n  Dell \n  HP");
            cProveedor = Console.ReadLine();
            Console.WriteLine("Selecciona Producto: \n  Laptop \n  Impresora");
            cProducto = Console.ReadLine();
            Console.WriteLine("Indica la cantidad:");
            iCantidad = Convert.ToInt32(Console.ReadLine());

            switch (cProveedor)
            {
                case "Dell":
                case "DELL":
                    Tienda = new ProveedorDell();
                    break;
                case "HP":
                case "Hp":
                    Tienda = new ProveedorHP();
                    break;
            }

            IProcesarCotizacion cotizacion = new ProcesadorCotizacion(Tienda, cProducto, iCantidad);
            cotizacion.ProcesarCotizacion();

        }
    }
}
