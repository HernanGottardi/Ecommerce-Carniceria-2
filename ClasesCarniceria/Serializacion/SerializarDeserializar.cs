using ClasesCarniceria.Excepctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClasesCarniceria.Serializacion
{

    public class SerializarDeserializar<T>
    {
        private static string ruta = AppDomain.CurrentDomain.BaseDirectory;

        // SERIALIZADOR XML

        public static void Serializar_lista_XML<T>(List<T> lista, string nombreArchivo)
        {
            string nombreArchivoCompleto = @"\" + nombreArchivo + ".xml";
            string rutaCompleta = ruta + nombreArchivoCompleto;

            using (StreamWriter streamWriter = new StreamWriter(rutaCompleta))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                xmlSerializer.Serialize(streamWriter, lista);
            }
        }

        public static void Serializar_objeto_XML<T>(T obj, string nombreArchivo)
        {

            using (StreamWriter streamWriter = new StreamWriter(ruta + @"\" + nombreArchivo + ".xml"))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(streamWriter, obj);
            }
        }
        // DESERIALIZAR XML


        public static List<T> Deserializar_lista_XML<T>(string nombreArchivo)
        {
            string rutaEntera = ruta + @"\" + nombreArchivo + ".xml";

            if (File.Exists(rutaEntera))
            {
                using (StreamReader streamReader = new StreamReader(rutaEntera))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                    List<T> lista = (List<T>)xmlSerializer.Deserialize(streamReader);
                    return lista;
                }
            }
            else
            {
                throw new ArchivoNoEncontradoException($"El archivo {nombreArchivo} todavia no fue serializado.");
            }
        }

        public static T Deserializar_objeto_XML<T>(string nombreArchivo)
        {
            using (StreamReader streamReader = new StreamReader(ruta + @"\" + nombreArchivo + ".xml"))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                T obj = (T)xmlSerializer.Deserialize(streamReader);
                return obj;
            }
        }

        // Serializar JSON
        public static void Serializar_lista_JSON<T>(List<T> lista, string nombreArchivo)
        {
            string json = JsonSerializer.Serialize(lista);
            File.WriteAllText(ruta + @"\" + nombreArchivo + ".json", json);
        }

        public static void Serializar_objeto_JSON<T>(T obj, string nombreArchivo)
        {
            string json = JsonSerializer.Serialize(obj);
            File.WriteAllText(ruta + @"\" + nombreArchivo + ".json", json);
        }

        // Deserializar JSON

        public static List<T> Deserializar_lista_JSON<T>(string nombreArchivo)
        {
            string rutaEntera = ruta + @"\" + nombreArchivo + ".json";

            if (File.Exists(rutaEntera))
            {
                string json = File.ReadAllText(rutaEntera);
                List<T> listaAux = JsonSerializer.Deserialize<List<T>>(json);
                return listaAux;
            }
            else
            {
                throw new ArchivoNoEncontradoException($"El archivo {nombreArchivo} todavia no fue serializado.");
            }
        }

        public static T Deserealizar_objeto_JSON<T>(string nombreArchivo)
        {
            string rutaEntera = ruta + @"\" + nombreArchivo + ".json";

            if (File.Exists(rutaEntera))
            {
                string json = File.ReadAllText(rutaEntera);
                T objAux = JsonSerializer.Deserialize<T>(json);
                return objAux;
            }
            else
            {
                throw new ArchivoNoEncontradoException($"El archivo {nombreArchivo} todavia no fue serializado.");
            }
        }
    }
}
