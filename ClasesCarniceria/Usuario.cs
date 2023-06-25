namespace ClasesCarniceria
{
    public abstract class Usuario
    {
        public abstract string Contraseña
        {
            get;
            set;
        }
        public abstract string Mail
        {
            get;
            set;
        }

        public virtual string Detallar()
        {
            return "Hola, soy un Usuario";
        }

    }
}
