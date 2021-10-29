using System;

namespace teste2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int numeroVezes = 5;

            if(numeroVezes == 5){
                Console.WriteLine("5 vezes\n");
            }

            for (int i = 0; i < numeroVezes; i++){
                Console.WriteLine($"Bem vindo pela {i}");
            }
        }
    }
}
