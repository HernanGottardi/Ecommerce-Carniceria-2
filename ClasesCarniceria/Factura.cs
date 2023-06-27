using ClasesCarniceria.Interfaces;
using System.Text;

namespace ClasesCarniceria
{
    public class Factura: IMostrar
    {
        // lo cambie a privado porq tenemos las propiedades
        private string mailCliente;
        private int cantidadDeKilos;
        private decimal precioFinal;
        private string corteDeCarne;
        private decimal precioPorKilo;
        private DateTime fechaFactura;

        public string MailCliente { get => mailCliente; set => mailCliente = value; }
        public int CantidadDeKilos { get => cantidadDeKilos; set => cantidadDeKilos = value; }
        public decimal PrecioFinal { get => precioFinal; set => precioFinal = value; }
        public string CorteDeCarne { get => corteDeCarne; set => corteDeCarne = value; }
        public decimal PrecioPorKilo { get => precioPorKilo; set => precioPorKilo = value; }
        public DateTime FechaFactura { get => fechaFactura; set => fechaFactura = value; }

        public Factura(string mail, int cantidadKilos, decimal precioPorKilo, decimal precio, string corteDeCarne, DateTime fecha)
        {
            this.MailCliente = mail;
            this.CantidadDeKilos = cantidadKilos;
            this.PrecioPorKilo = precioPorKilo;
            this.PrecioFinal = precio;
            this.CorteDeCarne = corteDeCarne;
            this.fechaFactura = fecha;
        }

        public string Mostrar() 
        { 
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("###########################################");
            sb.AppendLine($"Fecha de la venta: {this.fechaFactura}");
            sb.AppendLine($"Mail del cliente: {this.MailCliente}");
            sb.AppendLine("-------------------------------------------");
            sb.AppendLine($"Corte de carne elegido: {this.corteDeCarne}");
            sb.AppendLine($"Precio xKg: {this.PrecioPorKilo}");
            sb.AppendLine($"Cantidad de Kilos: {this.CantidadDeKilos}");
            sb.AppendLine("-------------------------------------------");
            sb.AppendLine($"PRECIO FINAL: {this.PrecioFinal}");
            sb.AppendLine("###########################################");

            return sb.ToString();
        }
    }
}
