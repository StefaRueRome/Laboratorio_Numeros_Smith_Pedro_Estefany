using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_Smith_Pedro_Estefany
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numero;
      
            
            numero = Convert.ToInt32(Console.ReadLine());
            
            
            //Suma de los digitos del número ingresado
            int sDigitos(int n)
            {
                int sumaDigitos;
                sumaDigitos = 0;
                while (n > 0)
                {
                    sumaDigitos += n % 10;
                    n = n / 10;
                }
               
                return sumaDigitos;

            }

            
            
            //Bucle para encontrar los factores del número ingresado
            int sfactores(int n2)
            {
                List<int> factoresP = new List<int>();
                int numPrueba = 2;
                int suma;
                suma = 0;
                while (n2 != 1)
                {
                    
                    if (n2 % numPrueba == 0)
                    {
                        factoresP.Add(numPrueba);
                        n2 = n2 / numPrueba;
                    }
                    else
                    {
                        numPrueba += 1;
                    }
                   
                }
                Console.ReadKey();
                foreach (int i in factoresP)
                {
                    suma += i;
                }

                return suma;
            }

            Console.WriteLine(sDigitos(numero)); 
            Console.WriteLine(sfactores(numero));
            




        }
    }
}
