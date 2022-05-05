using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9Guia
{
    internal class Ejercicios
    {
        
        public void Ej49()
        {
            //49. Cree un archivo de texto que contenga la cadena “hola mundo”.
            using StreamWriter writer = File.CreateText("Cadena.txt");
            string linea = "Hola mundo";
            writer.WriteLine(linea);
        }

        public void ej50()
        {
            //50.Solicite el ingreso de la ruta de un archivo de texto y presente el contenido.
            Console.WriteLine("Por favor ingrese la ruta de un archivo de texto: ");
            string archivo = Console.ReadLine();
            StreamWriter writer = File.CreateText(archivo);
            Console.WriteLine(writer);

        }

        public void ej51()
        {
            //51. Solicite el ingreso de la ruta de un archivo de texto.
            //Luego, permita el ingreso de una lista de cadenas (hasta que el usuario indique “fin”),
            //grabándolas en el archivo a medida que el usuario las ingresa.
            Console.WriteLine("Por favor ingrese la ruta de un archivo de texto: ");
            string archivo = Console.ReadLine();
            using StreamWriter writer = File.CreateText(archivo);
            string linea = "";
            
            while (true)
            {
                Console.WriteLine("Ingrese una cadena: ");
                string cadena = Console.ReadLine();
                if (cadena != "fin")
                {
                    linea += cadena + Environment.NewLine;                    
                    continue;
                }
                else if (cadena == "fin")
                {
                    break;
                }
            }
            writer.WriteLine(linea);

        }

        public void ej52()
        {
            //52. Implemente un programa con los siguientes comandos,
            //utilizando un diccionario para mantener los datos en memoria:
            //a. “Alta[legajo][nombre]”: da de alta el legajo / nombre en el diccionario.
            //b. “Baja[legajo]”: da de baja el legajo del diccionario.
            //c. “Grabar[ruta de archivo]”: graba el diccionario en el archivo indicado.
            //d. “Leer[ruta de archivo]”: Lee el diccionario a partir del archivo indicado.
            Dictionary<int, string> DiccLegajoYNombre = new Dictionary<int, string>();

            while (true) 
            {
                Console.WriteLine("1. Alta");
                Console.WriteLine("2. Baja");
                Console.WriteLine("3. Grabar");
                Console.WriteLine("4. Leer");
                Console.WriteLine("Ingrese una opcion:");
                string ingreso = Console.ReadLine();
                
                if (!int.TryParse(ingreso, out int opcion))
                {
                    Console.WriteLine("ingrese una opcion valida");
                    continue;
                }
                if (opcion == 1)
                {
                    Console.WriteLine("Ingrese numero de legajo y nombre:");
                    int legajo = Convert.ToInt32(Console.ReadLine());
                    string nombre = Console.ReadLine();
                    DiccLegajoYNombre.Add(legajo, nombre);
                    continue;
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("Ingrese numero de legajo: ");
                    int legajo = Convert.ToInt32(Console.ReadLine());                    
                    DiccLegajoYNombre.Remove(legajo);
                    continue;
                }
                else if (opcion == 3)
                {
                    using StreamWriter writer = File.CreateText("Diccionario.txt");
                    writer.WriteLine(DiccLegajoYNombre.ToString());
                    continue;
                }
                else if (opcion == 4)
                {
                    StreamReader reader = new StreamReader("Diccionario.txt");
                    continue;
                }                
                else
                {
                    break;
                }
                
            }
        }
    }
}
