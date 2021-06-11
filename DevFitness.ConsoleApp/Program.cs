using System;
using System.Collections.Generic;
using System.Linq;

namespace DevFitness.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Digite seu nome: ");
            var nome = Console.ReadLine();



            Console.Write("Digite sua altura: ");
            var altura = Console.ReadLine();

            Console.Write("Digite seu peso: ");
            var peso = Console.ReadLine();



            /*
             if (opcao == "1")

            {
                Console.WriteLine($"Nome: {nome}, Altura: {altura}, Peso: {peso}");
            }
            else if (opcao == "2")
            {
                //  Cadastrar();
            }
            else if (opcao == "3")
            {
                //ListarRefeicoes();
            }
            else
            {
                Console.WriteLine("Por favor, digite outra opção.");
            }
            */
            var listaRefeicoes = new List<Refeicao>();
            var opcao = "-1";

            while (opcao != "0")
            {
                ExibirOpcoes();
                opcao = Console.ReadLine();


                switch (opcao)
                {
                    case "1":
                        Console.WriteLine($"Nome: {nome}, Altura: {altura}, Peso: {peso}");
                        break;
                    case "2":
                        Cadastrar(listaRefeicoes);
                        break;
                    case "3":
                        ListarRefeicoes(listaRefeicoes);
                        break;
                    default:
                        Console.WriteLine("Por favor, digite outra opção.");
                        break;
                }

            }
            
            
            Console.WriteLine("Fechando o app.");

            Console.ReadLine();
        }

        public static void ExibirOpcoes()
        {
            Console.WriteLine("--- Seja bem-vindo(a) ao DevFitness ---");
            Console.WriteLine("1 - Exibir detalhes de usuário.");
            Console.WriteLine("2 - Cadastrar nova refeição.");
            Console.WriteLine("3 - Listar todas as refeições.");
            Console.WriteLine("0 - Finalizar aplicação.");
        }

        public static void Cadastrar(List<Refeicao> refeicoes)
        {
            Console.WriteLine("Digite a discrição da refeição. ");
            var descricao = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de calorias.");
            var calorias = Console.ReadLine();

            if (int.TryParse(calorias, out int caloriasInt))
            {
                var refeicao = new Refeicao(descricao, caloriasInt);

                refeicoes.Add(refeicao);

                Console.WriteLine("Refeição adcionada com sucesso.");

            }
            else
            {
                Console.WriteLine("Valor de calorias inválido.");
            }
        }

        public static void ListarRefeicoes(List<Refeicao> refeicoes)
        {
            foreach( var refeicao in refeicoes)
            {
                refeicao.ImprimirMensagem();
            }
        }
    }
}
