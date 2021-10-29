using System;

namespace revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            string  opcaoUsuario = ObterOpcaoUsuario();
            var indiceAluno = 0;

           while (opcaoUsuario.ToUpper() != "X")
           {
                switch (opcaoUsuario)
                {
                    case "1":
                    Console.WriteLine("Informe o nome do aluno:");
                    var aluno = new Aluno(); // instacia
                    aluno.Nome = Console.ReadLine();

                    Console.WriteLine("Informe a nota do aluno:");                    

                    if(decimal.TryParse(Console.ReadLine(), out decimal nota)) // trasformando string em decimal
                    {
                        aluno.Nota = nota;
                    }

                    else
                    {
                           throw new ArgumentException("Valor da nota deve ser decimal");
                    }

                    alunos[indiceAluno] = aluno;
                    indiceAluno++;

                    break;

                    case "2":
                    foreach (var a in alunos)
                    {
                        if(!string.IsNullOrEmpty(a.Nome))
                        { // quando a posição não tiver vazia
                        Console.WriteLine($"ALUNO: {a.Nome} - NOTA: {a.Nota}");
                        }
                    }
                    
                    break;

                    case "3":
                    decimal notaTotal = 0;
                    var totalAlunos = 0;
                    for(int i= 0; i < alunos.Length; i++ )
                    {
                        if(!string.IsNullOrEmpty(alunos[i].Nome))
                        { 
                        notaTotal = notaTotal + alunos[i].Nota;
                        totalAlunos++;
                        }

                    }
                    var media = notaTotal/totalAlunos;
                   
                    ConceitoEnum conceitoGeral;
                    
                    if( media < 2)
                    {
                           conceitoGeral = ConceitoEnum.E;
                    }
                    else if(media < 4)
                    {
                         conceitoGeral = ConceitoEnum.D;
                    }

                    else if(media < 6)
                    {
                         conceitoGeral = ConceitoEnum.C;
                    }

                    else if(media < 8)
                    {
                         conceitoGeral = ConceitoEnum.B;
                    }
                    else
                    {
                        conceitoGeral = ConceitoEnum.A;
                    }

                     Console.WriteLine($"Média geral: {media} - Conceito: {conceitoGeral}");

                    
                    
                    break;

                    default:
                    throw new ArgumentOutOfRangeException();
                }
                

                  opcaoUsuario = ObterOpcaoUsuario();

               
           }

        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

           string opcaoUsuario = Console.ReadLine(); // tipo scanf
           Console.WriteLine();
           return opcaoUsuario;
        }
    }
}
