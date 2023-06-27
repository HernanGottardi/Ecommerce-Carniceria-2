using ClasesCarniceria.Excepctions;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace ClasesCarniceria.MetodosDeExt
{
    public static class ControlarString
    {
        public static bool CantidadCaracteresEnRango(this string texto, int minimo, int mayor)
        {

            if (string.IsNullOrEmpty(texto))
            {
                throw new TextoNuloException("Campo vacio.");

            }
            if (texto.Length >= minimo && texto.Length <= mayor)
            {
                return true;
            }
            else
            {
                throw new CantidadDeCaracteresException("Datos incorrectos.");
            }

        }

        public static int ContarCantidadMayusculas(this string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new TextoNuloException("Texto vacio.");
            }
            int contador = 0;
            foreach (var c in texto)
            {
                if (char.IsUpper(c))
                {
                    contador++;
                }
            }
            return contador;
        }

        public static int ContarCantidadMinusculas(this string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new TextoNuloException("Texto vacio.");
            }
            int contador = 0;
            foreach (var c in texto)
            {
                if (char.IsLower(c))
                {
                    contador++;
                }
            }
            return contador;
        }

        public static int ContarVocales(this string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new TextoNuloException("Texto vacio.");
            }
            texto = texto.ToLower();
            char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
            int contador = 0;

            foreach (var item in texto)
            {
                if (vocales.Contains(item))
                {
                    contador++;
                }
            }
            return contador;
        }

        public static int ContarCaracter(this string texto, char caracter)
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new TextoNuloException("Texto vacio.");
            }

            int contador = 0;

            foreach (var letra in texto)
            {
                if (letra == caracter)
                {
                    contador++;
                }
            }
            return contador;
        }

        public static int ContarCantidadCaracteresEpeciales(this string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new TextoNuloException("Texto vacio.");
            }
            char[] caracteresEsp = { '@', '$', '!', '&', '#', '%', '/', '-', '+', '*' };
            int contador = 0;
            foreach (char c in texto)
            {
                if (caracteresEsp.Contains(c))
                {
                    contador++;
                }
            }
            return contador;
        }

        public static bool ValidarCorreoElectronico(this string correo)
        {

            if (correo.CantidadCaracteresEnRango(15, 30) == true)
            {
                string patron = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z]+\.(com)$";
                Regex regex = new Regex(patron);
                if (regex.IsMatch(correo))
                {
                    return true;
                }
                else
                {
                    throw new CorreoCaracteresInvalidos($"El correo ingreso: '{correo}' no cumple con el formato.");
                }
            }
            else
            {
                throw new CantidadDeCaracteresException($"El 'Correo Electronico' debe estar en el rango {15}-{30}");
            }
        }

        public static bool ValidarContraseña(this string contrasena)
        {
            if (contrasena.CantidadCaracteresEnRango(8, 20))
            {
                if (contrasena.Contains(" "))
                {
                    throw new ContraseñaCaracteresInvalidos($"La contraseña '{contrasena}' no debe contener espacios");
                }
                return true;
            }
            else
            {
                throw new CantidadDeCaracteresException($"La 'Contraseña' debe estar en el rango {8}-{20}");
            }
        }
    }
}

