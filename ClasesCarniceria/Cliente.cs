using System.Text;

namespace ClasesCarniceria
{
    public class Cliente : Usuario
    {
        private string mail;
        private string contraseña;
        private decimal cantidadDinero;

        public decimal CantidadDinero { get => cantidadDinero; set => cantidadDinero = value; }
        public override string Mail { get => mail; set => mail = value; }
        public override string Contraseña { get => contraseña; set => contraseña = value; }

        // para poder deserializar.
        public Cliente()
        {
            this.mail = "soynadie@gmail.com";
            this.contraseña = "contrafalsa123";
            this.cantidadDinero = 3000;
        }

        public Cliente(string mail, string contraseña)
        {
            this.mail = mail;
            this.contraseña = contraseña;
        }

        public Cliente(string mail, string contraseña, decimal cantidadDinero) : this(mail, contraseña)
        {
            this.CantidadDinero = cantidadDinero;
        }
        /// <summary>
        /// Convertir todos los atributos del objeto Cliente en un string.
        /// </summary>
        /// <returns> una cadena de texto que representa al objeto.</returns>
        public override string Detallar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Cliente: ");
            sb.AppendLine($"Mail: {this.Mail}");
            sb.AppendLine($"Monto: ${this.CantidadDinero}");

            return sb.ToString();
        }

    }
}