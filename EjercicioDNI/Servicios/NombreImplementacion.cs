using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDNI.Servicios
{
    internal class NombreImplementacion : NombreInterfaz
    {

        public string nombre()
        {

            Console.WriteLine("Dame tu nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Dame tu primer apellido");
            string apellido1 = Console.ReadLine();
            Console.WriteLine("Dame tu segundo apellido");
            string apellido2 = Console.ReadLine();


            if (nombre.Equals(apellido1)){

                Console.WriteLine("Tu nombre es igual que tu primer apellido, vuelve a intentarlo");
                Console.WriteLine("Dame tu primer apellido");
                apellido1 = Console.ReadLine();
                if (nombre.Equals(apellido1)) {
                Console.WriteLine("Tu nombre es igual que tu primer apellido, vuelve a intentarlo");
                apellido1 = Console.ReadLine();
                }
                else
                {
                Console.WriteLine("Nombre puesto correctamente");
                }

            }
            else if (nombre.Equals(apellido2))
            {
                Console.WriteLine("Tu nombre es igual que tu segundo apellido, vuelve a intentarlo");
                Console.WriteLine("Dame tu segundo apellido");
                apellido2 = Console.ReadLine();
                if (nombre.Equals(apellido2))
                {

                Console.WriteLine("Tu nombre es igual que tu primer apellido, vuelve a intentarlo");
                apellido2 = Console.ReadLine();

                }
                
                else { 
                Console.WriteLine("Nombre puesto correctamente");
                }
            }
            else
            {
                Console.WriteLine("Nombre puesto correctamente");
                
            }

            return nombre;

        }
    }
}
