using ClasesCarniceria.Interfaces;
using ClasesCarniceria.SQL;
using System.Text;

namespace ClasesCarniceria
{
    public class Carne: IMostrarProductos
    {
        private int cantidadKilos;
        private string tipoDeCorte;
        private decimal precioPorKilo;

        public int CantidadKilos { get => cantidadKilos; set => cantidadKilos = value; }
        public string TipoDeCorte { get => tipoDeCorte; set => tipoDeCorte = value; }
        public decimal PrecioPorKilo { get => precioPorKilo; set => precioPorKilo = value; }

        private Carne()
        {
            // Inicializar propiedades u otras operaciones de configuración
        }

        public Carne(int cantidadKilos, string tipoDeCorte, decimal precioPorKilo)
        {
            this.cantidadKilos = cantidadKilos;
            this.tipoDeCorte = tipoDeCorte;
            this.PrecioPorKilo = precioPorKilo;
        }

        /// <summary>
        /// Convertir cada atributo del objeto, en un string.
        /// </summary>
        /// <returns> 
        /// cadena de texto que representa las caracteristicas 
        /// del objeto instanciado del tipo Carne.
        /// </returns>
        public string Mostrar_carne()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Carne: {this.tipoDeCorte}");
            sb.AppendLine($"cantidad de kilos: {this.cantidadKilos}");
            sb.AppendLine($"Precio por kilo: ${this.precioPorKilo}");

            return sb.ToString();
        }

        public string MostrarProductos(List<Carne> lista)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Carne c in lista)
            {
                sb.AppendLine($"Corte: {c.TipoDeCorte}");
                sb.AppendLine($"Kilos: {c.CantidadKilos}");
                sb.AppendLine($"Precio por Kg: {c.PrecioPorKilo}");
                sb.AppendLine("##############################");
            }
            return sb.ToString();
        }

    }
}
