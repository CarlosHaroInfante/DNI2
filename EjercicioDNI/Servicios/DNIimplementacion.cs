using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDNI.Servicios
{
    internal class DNIimplementacion : DNIinterfaz
    {
        long num;
        string letra;
        public long numDNI()
        {

            Console.WriteLine("Dame las letras de tu DNI");
            num  = Convert.ToInt64(Console.ReadLine());
            return num;
        }

        public string letDNI()
        {
            Console.WriteLine("Dame la letra de tu DNI");
            letra = Convert.ToString(Console.ReadLine());
            return letra;
        }

        public bool solucion()
        {
            bool validarDNI = false;
            long dniBien = num % 23;
            
            //long num = numDNI();

            switch (dniBien)
            {
                case 0:
                    validarDNI = letra.Equals("T");
                    break;
                case 1:
                    validarDNI = letra.Equals("R");
                    break;
                case 2:
                    validarDNI = letra.Equals("W");
                    break;
                case 3:
                    validarDNI = letra.Equals("A");
                    break;
                case 4:
                    validarDNI = letra.Equals("G");
                    break;
                case 5:
                    validarDNI = letra.Equals("M");
                    break;
                case 6:
                    validarDNI = letra.Equals("Y");
                    break;
                case 7:
                    validarDNI = letra.Equals("F");
                    break;
                case 8:
                    validarDNI = letra.Equals("P");
                    break;
                case 9:
                    validarDNI = letra.Equals("D");
                    break;
                case 10:
                    validarDNI = letra.Equals("X");
                    break;
                case 11:
                    validarDNI = letra.Equals("B");
                    break;
                case 12:
                    validarDNI = letra.Equals("N");
                    break;
                case 13:
                    validarDNI = letra.Equals("J");
                    break;
                case 14:
                    validarDNI = letra.Equals("Z");
                    break;
                case 15:
                    validarDNI = letra.Equals("S");
                    break;
                case 16:
                    validarDNI = letra.Equals("Q");
                    break;
                case 17:
                    validarDNI = letra.Equals("V");
                    break;
                case 18:
                    validarDNI = letra.Equals("H");
                    break;
                case 19:
                    validarDNI = letra.Equals("L");
                    break;
                case 20:
                    validarDNI = letra.Equals("C");
                    break;
                case 21:
                    validarDNI = letra.Equals("K");
                    break;
                case 22:
                    validarDNI = letra.Equals("E");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
                    
            }
            return validarDNI;
        }
        
        
    }
}
