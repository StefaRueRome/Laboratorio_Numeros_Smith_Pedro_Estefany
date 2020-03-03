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
            long casos = Convert.ToInt64(Console.ReadLine());
            
            for (long i = 1; i <= casos; i++)
            {
                long numero = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine($"Caso {i}:" +NumSmith(numero));
                //Metodo que determina si el número que ingrese es primo, si es primo devuelve true de lo contarrio devuelve false.
                bool esPrimo(long n)
                {
                    long divisor = 2;
                    long resto = 0;
                    while (divisor < n)
                    {
                        resto = n % divisor;
                        if (resto == 0)
                        {
                            return false;
                        }
                        divisor = divisor + 1;
                    }
                    return true;
                }


                //Metodo de suma de los digitos del número ingresado
                long sDigitos(long n)
                {
                    long sumaDigitos = 0;
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
                            factoresP += numPrueba.ToString();
                            num = num / numPrueba;
                        }
                        else
                        {
                            numPrueba += 1;
                        }
                    }
                    return Convert.ToInt64(factoresP);
                }
                //Metodo que determina cual es el número smith mas pequeño mayor que el número ingresado.
                long NumSmith(long n)
                {
                    long numSGrande = 4937775;
                    long numeroSmith = 0;
                    for (long k = n; k <= numSGrande; k++)
                    {
                        bool primo = esPrimo(k);
                        if (primo == false)
                        {
                            long Factoresi = SacaFactores(k);
                            long sumaFactoresi = sDigitos(Factoresi);
                            long sumanumI = sDigitos(k);
                            if (sumaFactoresi == sumanumI)
                            {
                                numeroSmith = k;
                                break;
                            }
                        }

                    }
                    return numeroSmith;

                }
                
            }                                 
            Console.ReadLine();
            
            
        }
    }
}
