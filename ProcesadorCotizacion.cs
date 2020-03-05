using PatronFabricaAbstracta.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabricaAbstracta
{
    class ProcesadorCotizacion:IProcesarCotizacion
    {
        private readonly ITiendaProductos tiendaProductos;
        private readonly string producto;
        private readonly int cantidad;

        public ProcesadorCotizacion(ITiendaProductos tiendaProductos, string producto, int cantidad)
        {
            this.tiendaProductos = tiendaProductos;
            this.producto = producto;
            this.cantidad = cantidad;
        }

        public void ProcesarCotizacion()
        {
            ILaptop laptop = null;
            IImpresora impresora = null;
            int diasEntrega=0;
            decimal importe = 0M;
            switch (this.producto)
            {
                case "Laptop":
                    laptop = this.tiendaProductos.GenerarInstanciaLaptop();
                    importe = laptop.CalcularImporte(this.cantidad);
                    diasEntrega = laptop.ObtenerDiasEntrega();
                    
                    break;
                case "Impresora":
                    impresora = this.tiendaProductos.GenerarInstanciaImpresora();
                    importe = impresora.CalcularImporte(this.cantidad);
                    diasEntrega = impresora.ObtenerDiasEntrega();
                    break;
            }
            this.imprimirMensaje(this.generarMensajeRequisicion(diasEntrega),
                                 this.generarMensajeCotizacion(importe));
            
            
        }
        private void imprimirMensaje(string mensajeRequisicion, string mensajeCotizacion)
        {
            Console.WriteLine(mensajeRequisicion);
            Console.WriteLine(mensajeCotizacion);
        }
        private string generarMensajeRequisicion(int diasEntrega)
        {
            return string.Format("Requisición: Compra de {0} {1} con {2} llegará en {3} días.",
            this.cantidad, this.producto, this.tiendaProductos.GetType().Name, diasEntrega);
           
        }
        private string generarMensajeCotizacion(decimal importe)
        {
            return string.Format("Cotización: La compra tendría un impote de {0}", importe);
        }

    }
}
