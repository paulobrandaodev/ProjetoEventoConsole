using System;
using Data.ClassePai.ClasseFilhas;

namespace ProjetoEventoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
           string op = 0;
           
           do{

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
           }while(op != "9");

        }


        static void OpcaoShow(){
            string opcao = "";
            do
            {
            Console.WriteLine("Digite uma das opções abaixo: ");
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Pesquisar título");
            Console.WriteLine("3 - Pesquisar data");
            Console.WriteLine("9 - Sair");

            switch (opcao)
            {
                
                case "1":
                {
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

                    break;
                    
                }
                

                case "2":
                {


                    break;
                }
                

                case "3":
                {

                    break;
                }
                

                default:
                Console.WriteLine("Opção inválida");
                break;
            }    
                
            } while (opcao != "9");
        }

        static void OpcaoTeatro(){

        }

        static void OpcaoCinema(){

        }
    }
}
