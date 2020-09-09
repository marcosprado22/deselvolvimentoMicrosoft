using System;
using System.Collections.Generic;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views
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
                        CadastrarCliente.Renderizar();
                        break;
                    case 2:
                        ListarClientes.Renderizar();
                        
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

        private static bool ValidarCpf(string cpf)
        {
            int peso = 10, soma = 0, resto, digito1, digito2;
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
            {
                return false;
            }
            switch (cpf)
            {
                case "11111111111": return false;
                case "22222222222": return false;
                case "33333333333": return false;
                case "44444444444": return false;
                case "55555555555": return false;
                case "66666666666": return false;
                case "77777777777": return false;
                case "88888888888": return false;
                case "99999999999": return false;
                case "00000000000": return false;
            }
            //Primeiro Digito:
            for (int i = 0; i < 9; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * peso;
                peso--;                
            }
            resto = soma % 11;
            if (resto < 2)
            {
                digito1 = 0;
            }
            else
            {
                digito1 = 11 - resto;
            }
            if (Convert.ToInt32(cpf[9].ToString()) != digito1)
            {
                return false;
            }
            //Segundo Digito:
            peso = 11;
            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * peso;
                peso--;
            }
            resto = soma % 11;
            if (resto < 2)
            {
                digito2 = 0;
            }
            else
            {
                digito2 = 11 - resto;
            }
            if (Convert.ToInt32(cpf[10].ToString()) != digito2)
            {
                return false;
            }
            return true;
        }
    }
}
