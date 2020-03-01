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
                //Console.WriteLine(sumaDigitos);
                //Console.ReadLine();
                return sumaDigitos;
            }



            //Bucle para encontrar los factores del número ingresado, los cuales se pasar a string para asi poder sumar cada digito del número

             String factoresP = "";
             int numPrueba = 2;
             while (numero != 1)
             {
                    
                 if (numero % numPrueba == 0)
                 {
                     
                    numero = numero / numPrueba;
                    factoresP+=numPrueba.ToString();
                }
                 else
                 {
                     numPrueba += 1;
                 }     
             }
            //Console.WriteLine(factoresP);
            //Se suman los digitos del número ingresado
            int Digitos = sDigitos(numero);
            //La variable factoresP se convierte a int para poder sumar digitos
            int IfactoresP = int.Parse(factoresP);
            //suma de los factores primos
            int sumaFinal=sDigitos(IfactoresP);
            
             
            if (Digitos == sumaFinal && IfactoresP>numero)
            {
                Console.WriteLine(IfactoresP);
            }
            else
            {
                Console.WriteLine("No existe");
            }
            Console.ReadLine();







        }
    }
}
