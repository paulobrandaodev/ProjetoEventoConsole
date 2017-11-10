using System;
using Data.ClassePai.ClasseFilhas;

namespace ProjetoEventoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string op = "0";

            do
            {

                Console.WriteLine("Digite uma das opções abaixo: ");
                Console.WriteLine("1 - Shows");
                Console.WriteLine("2 - Teatro");
                Console.WriteLine("3 - Cinema");
                Console.WriteLine("9 - Sair");

                op = Console.ReadLine();


                switch (op)
                {
                    case "1":
                        OpcaoShow();
                        break;


                    case "2":
                        OpcaoTeatro();
                        break;


                    case "3":
                        OpcaoCinema();
                        break;


                    default:
                        Console.WriteLine("Opção inválida!");
                        break;

                }
            } while (op != "9");

        }


        static void OpcaoShow()
        {
            string opcao = "0";
            do
            {
                Console.WriteLine("Digite uma das opções abaixo: ");
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Pesquisar título");
                Console.WriteLine("3 - Pesquisar data");
                Console.WriteLine("9 - Sair");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        {
                            Console.WriteLine("------------------- SHOW ------------------- ");
                            Console.WriteLine("Digite o título: ");
                            string titulo = Console.ReadLine();
                            Console.WriteLine("Digite o local: ");
                            string local = Console.ReadLine();
                            Console.WriteLine("Digite a capacidade: ");
                            int lotacao = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Digite a duração: ");
                            string duracao = Console.ReadLine();
                            Console.WriteLine("Digite a classificação etária: ");
                            int classificacao = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Digite a data do evento: ");
                            DateTime data = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Digite a artista: ");
                            string artista = Console.ReadLine();
                            Console.WriteLine("Digite o gênero: ");
                            string genero = Console.ReadLine();

                            Show show = new Show(titulo, local, lotacao, duracao, classificacao, data, artista, genero);
                            
                            if(show.Cadastrar() == true){
                                Console.WriteLine("Evento cadastrado  com sucesso!");
                            }else{
                                Console.WriteLine("Falha na criação do evento :( ");
                            }
                        }
                        break;

                    case "2":
                        {
                            Console.WriteLine("-------------PESQUISAR SHOW ---------------- ");
                            Console.WriteLine("Digite o título para pesquisar: ");
                            Console.WriteLine(new Show().Pesquisar(Console.ReadLine()));
                        }
                        break;


                    case "3":
                        {
                            Console.WriteLine("-------------PESQUISAR SHOW POR DATA ---------------- ");
                            Console.WriteLine("Digite a data para pesquisar: ");
                            Console.WriteLine(new Show().Pesquisar(Convert.ToDateTime(Console.ReadLine())));
                        }
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            } while (opcao != "9");
        }

        static void OpcaoTeatro()
        {
            string opcao = "0";
            do
            {
                Console.WriteLine("Digite uma das opções abaixo: ");
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Pesquisar título");
                Console.WriteLine("3 - Pesquisar data");
                Console.WriteLine("9 - Sair");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        {
                            Console.WriteLine("------------------- TEATRO ------------------- ");
                            Console.WriteLine("Digite o título: ");
                            string titulo = Console.ReadLine();
                            Console.WriteLine("Digite o local: ");
                            string local = Console.ReadLine();
                            Console.WriteLine("Digite a capacidade: ");
                            int lotacao = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Digite a duração: ");
                            string duracao = Console.ReadLine();
                            Console.WriteLine("Digite a classificação etária: ");
                            int classificacao = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Digite a data do evento: ");
                            DateTime data = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Digite os atores ");
                            string[] elenco = Console.ReadLine().Split(';');

                            Console.WriteLine("Digite o gênero: ");
                            string genero = Console.ReadLine();

                            Teatro teatro = new Teatro(titulo, local, lotacao, duracao, classificacao, data, elenco, genero);
                            
                            if(teatro.Cadastrar()){
                                Console.WriteLine("Evento cadastrado  com sucesso!");
                            }else{
                                Console.WriteLine("Falha na criação do evento :( ");
                            }
                        }
                        break;

                    case "2":
                        {
                            Console.WriteLine("-------------PESQUISAR PEÇA ---------------- ");
                            Console.WriteLine("Digite o título para pesquisar: ");
                            Console.WriteLine(new Teatro().Pesquisar(Console.ReadLine()));
                        }
                        break;


                    case "3":
                        {
                            Console.WriteLine("-------------PESQUISAR PEÇA POR DATA ---------------- ");
                            Console.WriteLine("Digite a data para pesquisar: ");
                            Console.WriteLine(new Teatro().Pesquisar(Convert.ToDateTime(Console.ReadLine())));
                        }
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            } while (opcao != "9");
        }

        static void OpcaoCinema()
        {
            string opcao = "0";
            do
            {
                Console.WriteLine("Digite uma das opções abaixo: ");
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Pesquisar título");
                Console.WriteLine("3 - Pesquisar data");
                Console.WriteLine("9 - Sair");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        {
                            Console.WriteLine("------------------- CINEMA ------------------- ");
                            Console.WriteLine("Digite o título: ");
                            string titulo = Console.ReadLine();
                            Console.WriteLine("Digite o local: ");
                            string local = Console.ReadLine();
                            Console.WriteLine("Digite a capacidade: ");
                            int lotacao = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Digite a duração: ");
                            string duracao = Console.ReadLine();
                            Console.WriteLine("Digite a classificação etária: ");
                            int classificacao = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Digite a data do evento: ");
                            DateTime data = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Digite os horários das sessões separados por ';' : ");
                            DateTime[] sessoes = null;
                            string[] linhas = Console.ReadLine().Split(';');
                            for (int i = 0; i < linhas.Length; i++)
                            {
                               sessoes += DateTime.Parse(linhas[i])+",";
                            }
                            

                            Console.WriteLine("Digite o gênero: ");
                            string genero = Console.ReadLine();

                            Cinema cinema = new Cinema(titulo, local, lotacao, duracao, classificacao, data, sessoes, genero);
                            
                            if(cinema.Cadastrar()){
                                Console.WriteLine("Evento cadastrado  com sucesso!");
                            }else{
                                Console.WriteLine("Falha na criação do evento :( ");
                            }
                        }
                        break;

                    case "2":
                        {
                            Console.WriteLine("-------------PESQUISAR PEÇA ---------------- ");
                            Console.WriteLine("Digite o título para pesquisar: ");
                            Console.WriteLine(new Cinema().Pesquisar(Console.ReadLine()));
                        }
                        break;


                    case "3":
                        {
                            Console.WriteLine("-------------PESQUISAR PEÇA POR DATA ---------------- ");
                            Console.WriteLine("Digite a data para pesquisar: ");
                            Console.WriteLine(new Teatro().Pesquisar(Convert.ToDateTime(Console.ReadLine())));
                        }
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            } while (opcao != "9");
        }
    }
}
