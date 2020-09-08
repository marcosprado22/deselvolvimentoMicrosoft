﻿using System;

namespace VendasConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("--- Aplicação de Vendas ---\n");
                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Listar cliente");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("\nDigite a opção desejada");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("--- CADASTRAR CLIENTE ---\n");
                        break;
                    case 2:
                        Console.WriteLine("--- LISTAR CLIENTE ---\n");
                        break;
                    case 0:
                        Console.WriteLine("Saindo...\n");
                        break;
                    default:
                        Console.WriteLine("--- OPÇÃO INVÁLIDA! ---\n");
                        break;
                }
                Console.WriteLine("\nPressione uma tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }
    }
}
