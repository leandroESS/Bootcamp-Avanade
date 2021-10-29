using System;
// ctrl + k + c = comenta //
namespace instrucoes
{
    class Program
    {

        static void Declaracoes()
        {
            int a;
            int b = 2, c = 3;
            const int d = 4;
            a = 1;
            Console.WriteLine(a+b+c+d);

        }

        static void instrucaoIf(string[] args) //recebe um array de strings
        {
           
           if(args.Length == 0)
           {
               Console.WriteLine("Nenhuma registrado");
           }
           else if(args.Length == 1)
           {
               Console.WriteLine("Um argumento");
           }
           else
           {
               Console.WriteLine($"{args.Length} argumentos");
           }
        }

        static void instrucaoSwitch(string[] args)
        {
            int numeroDeArgumentos = args.Length;
            switch (numeroDeArgumentos)
            {
                case 0:
                Console.WriteLine("Nenhum argumento");
                break;
                case 1:
                Console.WriteLine("Um argumento");
                break;               
                default:
                Console.WriteLine($"{numeroDeArgumentos} argumentos");
                break;
            }
        }

        static void instrucaoWhile(string[] args)
        {
           int i = 0;
           while(i < 5)
           {
               Console.WriteLine(args[i]);
               i++;
           }
        }

        static void instrucaoDo(string[] args)
        {
            string texto;
            do
            {
                texto = Console.ReadLine();
                Console.WriteLine(texto);
            }while(!string.IsNullOrEmpty(texto));
        }

        static void instrucaoFor(string[] args)
        {
            for(int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }

        static void instrucaoForEach(string[] args)
        {
            foreach (string s  in args)
            {
                Console.WriteLine(s);
            }
        }

        static void instrucaoBreak(string[] args)
        {
            while(true)
            {
                string s = Console.ReadLine();

                if(string.IsNullOrEmpty(s))
                break;

                Console.WriteLine(s);
            }
        }

        static void instrucaoContinue(string[] args)
        {
            for(int i = 0; i < args.Length; i++)
            {
                if(args[i].StartsWith("/"))
                {
                  continue;
                }

                else
                {
                  Console.WriteLine(args[i]);
                }
            }
        }

        static void instrucaoReturn()
        {
            int somar (int a, int b)
            {
                return a + b;
            }

            Console.WriteLine(somar(1,2));
            Console.WriteLine(somar(3,4));
            Console.WriteLine(somar(5,6));
        }
       
       static void instrucaoTryCatchFianllyThrow(string[] args)
       {
           double dividir(double x, double y)
           {
               if(y==0)
               {
                   throw new DivideByZeroException();
               }
               else
               {
                   return x/y;
               }
           }

           try
           {
               if(args.Length != 2)
               {
                   throw new InvalidOperationException("Infome 2 números");
               }

               double x = double.Parse(args[0]);
               double y = double.Parse(args[1]);
               Console.WriteLine(dividir(x,y));


           }

           catch (InvalidOperationException e)
           {
               Console.WriteLine(e.Message);
           }
           catch (Exception e)
           {
               Console.WriteLine($"Erro genérico: {e.Message}");
           }
           finally
           {
               Console.WriteLine("até breve");
           }

       }
        

        static void InstrucaoUsing(string[] args)
        {
            using(System.IO.TextWriter w = System.IO.File.CreateText("Text.txt"))
            {
                w.WriteLine("Line 1");
                w.WriteLine("Line 2");
                w.WriteLine("Line 3");
            }
        }

        static void Main()
        {
           
        }


    }
}
