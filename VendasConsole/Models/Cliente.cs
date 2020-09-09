using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace VendasConsole.Models
{
    class Cliente
    {
        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = Cpf;  
        }
        public Cliente()
        {
            CriadoEm = DateTime.Now;
        }
        //Atributos, propriedade e características
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public DateTime CriadoEm { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome} | CPF: {Cpf} | Criado em: {CriadoEm}";
        }
    }
}
