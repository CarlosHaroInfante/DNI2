using EjercicioDNI.Servicios;

namespace EjercicioDNI.Controladores
{

    class Program
    {

        static void Main(string[] args)
        {

            NombreInterfaz nombre = new NombreImplementacion();
            DNIinterfaz dni = new DNIimplementacion();

            nombre.nombre();

            dni.numDNI();
            dni.letDNI();

            Console.WriteLine(dni.solucion());

            }



        }





    }





