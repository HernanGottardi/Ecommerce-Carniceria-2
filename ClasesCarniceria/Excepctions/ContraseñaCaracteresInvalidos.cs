using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCarniceria.Excepctions
{
    public class ContraseñaCaracteresInvalidos : Exception
    {
        public ContraseñaCaracteresInvalidos()
        {
        }

        public ContraseñaCaracteresInvalidos(string? message) : base(message)
        {
        }

        public ContraseñaCaracteresInvalidos(string? message, Exception? innerException) : base(message, innerException)
        {
        }

    }
}
