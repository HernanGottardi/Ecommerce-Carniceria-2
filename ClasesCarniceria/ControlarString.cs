using ClasesCarniceria.Excepctions;
using System.Text.RegularExpressions;

namespace ClasesCarniceria
{
    public static class ControlarString
    {
        public static bool CantidadCaracteresEnRango(this string texto, int minimo, int mayor)
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new TextoNuloException("Texto vacio.");

            }
            if (texto.Length >= minimo && texto.Length <= mayor)
            {
                return true;
            }
            else
            {
                return false;
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
            if (CantidadCaracteresEnRango(correo, 15, 30) == true)
            {
                string patron = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
                Regex regex = new Regex(patron);
                if (regex.IsMatch(correo)) 
                { 
                    return true;
                } 
                else 
                {
                    throw new CorreoCaracteresInvalidos($"El correo '{correo}' contiene caracteres invalidos");
                }
            }
            else 
            {
                throw new CorreoCantidadDeCaracteresException($"El correo '{correo}' debe tener entre 15 y 30 caracteres!");
            }   
        }
    }
}

