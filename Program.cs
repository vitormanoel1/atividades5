using System;

namespace atividades5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

            Os produtos terão os seguintes atributos:

            - string Nome
            - float Preco
            - bool Promocao (se está em promoção ou não)

            O sistema deverá ter as seguintes funçoes:

            - CadastrarProduto
            - ListarProdutos
            - MostrarMenu
            */
                //declaração de variaveis
                string promocao;
                string[] nomes = new string [10];
                string[] produto = new string [10];   
                string[] preco = new string [10];
                string resposta; 
                int escolha;
                int produtos = 0;
                bool[] promo = new bool [10];
                
                Console.WriteLine("--------------------------");
                Console.WriteLine("----Sistama De Produtos---");
                Console.WriteLine("--------------------------");

                //menu
                do
                {
                    Console.WriteLine("Menu Principal");
                    Console.WriteLine("Selecione uma opção abaixo");
                    Console.WriteLine("[1] cadastrar Produtos");
                    Console.WriteLine("[2] listar Produtos");
                    Console.WriteLine("[0] Sair");
                    escolha = int.Parse(Console.ReadLine());
                switch (escolha){
                    case 1:
                        Console.WriteLine("Cadastrar Produtos");
                        do
                        {
                        if (produtos < 10)
                        {
                            Console.WriteLine($"Digite o nome do  {1 + produtos}° produto: ");
                            nomes[produtos] = Console.ReadLine();
                            Console.WriteLine("Digite o preço do produto:");
                            nomes[produtos] = Console.ReadLine();
                            Console.WriteLine("Esse produto está em promoção? s/n");
                            resposta = Console.ReadLine();
                            promo[produtos] = Promocao(resposta);
                            produtos++;
                        }else{
                            Console.WriteLine("Limite atingido!");
                        break;
                        }
                        Console.WriteLine("Deseja colocar um novo produto? s/n");
                        resposta = Console.ReadLine();                  
                    } while (resposta.ToUpper() == "s");
                    break;

                    case 2:
                    Console.WriteLine("Listar Produtos");
                    for (var i = 0; i < produtos; i++)
                    {
                        Console.WriteLine($"Produto {produto[i]}, Preço {preco[i]} e Promoção {promo[i]}");
                    }
                        break;
                    case 0:
                    Console.WriteLine("volte sempre!");
                        break; 
                    default:
                        Console.WriteLine("Inválido");
                    break;
                }
                }while(escolha != 0);
            //função
            bool Promocao(string promocao){
                if (promocao == "s"){
                    Console.WriteLine("Tem promoção");
                    return true;
                }else{
                    Console.WriteLine("não tem  promoção");
                    return false;
                } 
            }  
        }
    }
}