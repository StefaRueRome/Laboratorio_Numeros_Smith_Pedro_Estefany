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

            long numero;
      
            
            numero = Convert.ToInt64(Console.ReadLine());


            //Metodo de suma de los digitos del número ingresado
            long sDigitos(long n)
            {
                long sumaDigitos;
                sumaDigitos = 0;
                while (n > 0)
                {
                    sumaDigitos += n % 10;
                    n = n / 10;
                }
                //Console.WriteLine(sumaDigitos);
                //Console.ReadLine();
                return sumaDigitos;
            }



            //Metodo para encontrar los factores del número ingresado, los cuales se pasar a string para asi poder sumar cada digito del número
            long SacaFactores(long num)
            {
                String factoresP = "";
                long numPrueba = 2;
                while (num != 1)
                {

                    if (num % numPrueba == 0)
                    {

                        num = num / numPrueba;
                        factoresP += numPrueba.ToString();
                    }
                    else
                    {
                        numPrueba += 1;
                    }
                }
                return Convert.ToInt64(factoresP);
            }
            
            long NumSmith(long n)
            {
                long numSGrande = 4937775;
                long numeroSmith = 0;
                for (long i = 0; i <= numSGrande; i++)
                {
                    if (i >= n)
                    {
                        long Factoresi = SacaFactores(i);
                        long sumaFactoresi = sDigitos(Factoresi);
                        long sumanumI = sDigitos(i);

                        if (sumaFactoresi == sumanumI)
                        {
                            numeroSmith = i;
                        }
                    }
                    

                }
                return numeroSmith;               
            }
            Console.WriteLine(NumSmith(numero));
            Console.ReadLine();
            
            Console.WriteLine(SacaFactores(numero));

            Console.ReadLine();
            
             






        }
    }
}
