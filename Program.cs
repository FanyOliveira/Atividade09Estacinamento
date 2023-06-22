using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09Estacionamento
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> estacionamento = new List<string>();

            Console.WriteLine("Bem-vindo ao Estacionamento Auto Conrado");
            while (true)
            {
                Console.WriteLine("Por favor, escolha uma opção: ");
                Console.WriteLine("1 - Estacionar");
                Console.WriteLine("2 - Retirar veículo");
                Console.WriteLine("3 - Listar veículos");
                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.WriteLine("Digite a placa do veículo que deseja estacionar:");
                    string placa = Console.ReadLine().ToUpper();

                    if (placa.Length != 6)
                    {
                        Console.WriteLine("Placa inválida, ela preicisa ter 6 dígitos.");
                    }
                    else if (estacionamento.Contains(placa))
                    {
                        Console.WriteLine($"Veículo com a {placa} já está estacionado, tente novamente.");
                    }
                    else
                    {
                        estacionamento.Add(placa);
                        Console.WriteLine($"Veículo com a {placa} estacionado com sucesso!");
                    }
                }
                else if (opcao == "2")
                {
                    Console.WriteLine("Digite a placa do veículo que deseja retirar:");
                    string placa = Console.ReadLine().ToUpper();

                    if (estacionamento.Contains(placa))
                    {
                        estacionamento.Remove(placa);
                        Console.WriteLine($"Veículo com a {placa} foi retirado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine($"Veículo com a {placa} não consta no nosso cadastro!");
                    }
                }
                else if (opcao == "3")
                {
                    Console.WriteLine("Veículos estacionados:");

                    if (estacionamento.Count == 0)
                    {
                        Console.WriteLine("[_____]");
                    }
                    else
                    {

                        string texto = $"[ {estacionamento[0]} ]";
                        int contador = 1;
                        while (contador < estacionamento.Count)
                        {
                            texto += $"[ {estacionamento[contador]} ]";
                            contador++;
                        }
                        Console.WriteLine(texto);
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida! Por favor, escolha uma opção válida.");
                }

            }
        }
    }
}
