using System;

namespace Ex7_ListaFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] numeros = new float[15];

            for (var i = 0; i < 15; i++) {
                
                Console.WriteLine();
                Console.WriteLine($"Digite o {i+1}° número (para número decimal use vírgula ao invés de ponto):\n ");
                numeros[i] = float.Parse(Console.ReadLine());
            
            }
            
            Console.WriteLine("--------------------------------");

            Console.WriteLine();

            Console.WriteLine("Sua lista com os números na ordem invertida em que digitou é:\n ");
            
            for (var i = 14; i >= 0; i--) {

                Console.WriteLine();

                Console.WriteLine(numeros[i]);

            }
            
            Console.WriteLine("--------------------------------");
        }
    }
}
                
        
                



                



