using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Xml.Schema;

namespace VerduraoDoJoao.Melanciometro
{
    internal class Program
    {
        private static int cont;
        private static object resp;
        private static int dia;
       

        private static void Main(string[] args)

        {


            string resp;

            do
            {


                {
                    string senhaCorreta = "joao123";
                    int tentativasRestantes = 3;

                    while (tentativasRestantes > 0)
                    {
                        Console.Write("Digite a senha: ");
                        string senhaDigitada = Console.ReadLine();

                        if (senhaDigitada == senhaCorreta)
                        {
                            Console.WriteLine("Senha correta!");
                            break;
                        }
                        else
                        {
                            tentativasRestantes--;
                            Console.WriteLine($"Senha incorreta. Restam {tentativasRestantes} tentativas.");

                            if (tentativasRestantes == 0)
                            {
                                Console.WriteLine("Você excedeu o número máximo de tentativas. Sua conta foi bloqueada.");
                               
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                        }
                    }
                }




                Console.WriteLine("Seja Bem-Vindo!  Qual Melancia deseja comprar?");










                Console.WriteLine(" 1- Melancia Comum   2- Melancia Baby");
                int op = int.Parse(Console.ReadLine());
                double preco;


                if (op == 1)
                {
                    preco = 5.50;
                    Console.WriteLine(" Melancia Comum " + preco.ToString());
                }
                else if (op == 2)
                {
                    preco = 8.56;
                    Console.WriteLine(" Melancia Baby " + preco.ToString());
                }
                else
                {
                    Console.WriteLine("Não existe essa opção!");
                }


                Console.WriteLine(" Compre quantas melancias desejar! ");
                if (cont == 3)

                    cont = cont + 1;

         
                
                
                   
                




                {
                    Console.WriteLine("Escolha um dia da semana para receber as melancias (sendo 1-segunda e 5-sexta)");


                    int opcao = Convert.ToInt32(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine(" Segunda ");
                            break;
                        case 2:
                            Console.WriteLine(" TERÇA VERDE com 15% DE DESCONTO!!");
                            break;
                        case 3:
                            Console.WriteLine(" QUARTA VERDE com 17% DE DESCONTO!!");
                            break;
                        case 4:
                            Console.WriteLine(" Quinta");
                            break;
                        case 5:
                            Console.WriteLine("Sexta");
                            break;
                        default:
                            Console.WriteLine("Opção");
                            break;
                    }
                }



                {
                    int numItens = 0;
                    double totalCompra = 0.0;

                    Console.WriteLine("Digite o número de melancias que deseja  comprar:");
                    numItens = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= numItens; i++)
                    {
                        Console.WriteLine("Digite o valor do item " + i);
                        double valorItem = Convert.ToDouble(Console.ReadLine());
                        totalCompra += valorItem;
                    }

                    Console.WriteLine("O total da compra é: R$ " + totalCompra.ToString("F2"));
                }

                string placaCaminhao;
                Console.WriteLine("Qual a placa do caminhão");
                placaCaminhao = Console.ReadLine();

                string tamanho = placaCaminhao.Length.ToString();
                string letras = placaCaminhao.Remove(1, 1);
                Console.WriteLine(letras);
                


                {
                    Console.WriteLine("O caminhão cadastrado possui a placa :" + placaCaminhao);
                }

                Console.WriteLine(" Foi registrado! Obrigada por usar nosso sistema,volte sempre!  Caso queira comprar mais, continue:");
             
                Console.WriteLine("Voce deseja sair ? Sim ou Não?");
                resp = Console.ReadLine();

            } while (resp.ToUpper() != "SIM");






        }
    }
}

