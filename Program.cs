namespace EscolinhaDoCleitoUsandoCollections
{

    using static System.Console;
    using static System.Convert;
    internal class Program
    {



        static void Main(string[] args)
        {
            WriteLine("Bem Vindo a escola do Cleitinho, aqui você aprende a programar e outras coisas que o usuário inserir na seção ");
            int opcaoMenu = 0;

            List<Aluno> alunoLista = new List<Aluno>();

            Aluno novo = new Aluno();
            decimal[] notas;
            string[] materias;

            do
            {

                WriteLine($"Escolha uma dessas opções:\n1-Cadastrar novo Aluno         2-Consultar aluno por Nome\n3-Consultar aluno por matrícula   4-Mostrar todos os Alunos.\n0-Sair do menu");

                opcaoMenu = ToInt32(ReadLine());


                switch (opcaoMenu)
                {
                    case 1:
                        novo = new Aluno();
                        Console.WriteLine("Entre com o nome do aluno:");
                        novo.nome = ReadLine();
                        WriteLine("Entre com o número da matrícula:");
                        novo.matricula = ReadLine();
                        WriteLine("Entre com o curso:");
                        novo.curso = ReadLine();
                        WriteLine($"Quantas disciplinas o aluno fez no curso de {novo.curso}");
                        int quantas = ToInt32(ReadLine());
                        notas = new decimal[quantas];
                        materias = new string[quantas];
                        for (int i = 0; i < quantas; i++)
                        {
                            WriteLine($"Qual é o nome da {i + 1}° disciplina: ");
                            materias[i] = ReadLine();
                            WriteLine("Entre com a nota do aluno na matéria: ");
                            notas[i] = ToDecimal(ReadLine());



                        }
                        novo.notas = notas;
                        novo.disciplina = materias;
                        decimal media = 0;

                        for (int i = 0; i < notas.Length; i++)
                        {

                            media += notas[i];

                        }
                        media = media / notas.Length;
                        novo.media = media;

                        alunoLista.Add(novo);


                        break;

                    case 2:
                        WriteLine("Entre com o nome do aluno que deseja encontrar: ");
                        string nome = ReadLine();


                        Aluno alunoProcurado = alunoLista.Find(x => x.nome.Equals(nome));
                        if (alunoProcurado != null)
                        {
                            WriteLine(alunoProcurado);
                        }

                        else
                        {
                            WriteLine("Aluno não encontrado");
                        }





                        break;
                    case 3:



                        WriteLine("Entre com o código da matricula do aluno que deseja encontrar: ");
                        string matricula = ReadLine();
                         alunoProcurado = alunoLista.Find(x => x.matricula.Equals(matricula));
                        if (alunoProcurado != null)
                        {
                            WriteLine(alunoProcurado);
                        }

                        else
                        {
                            WriteLine("Aluno não encontrado");
                        }








                        break;
                    case 4:

                       foreach (var item in alunoLista) { WriteLine(item); }

                        


                        break;
                    default:
                        WriteLine("Escolha uma opção valida");
                        break;
                    case 0: break;
                }


            }
            while (opcaoMenu != 0);

        }
    }
}        
    

