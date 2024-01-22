using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDNI.Servicios
{
    internal class CPImplementacion : CPInterfaz
    {
        public string CP()
        {

            Console.WriteLine("Código Postal de su domicilio: ");
            string num = (Console.ReadLine());

            return num;

        }

        public string sev()
        {
            string valorFijo = "41000";
            int startIndex = 0;
            int lenght = 3;
            int cosas; 
            string substring = valorFijo.Substring(startIndex, lenght);
        }
    }
}
