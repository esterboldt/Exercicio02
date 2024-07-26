using System;

namespace Empresa.Cliente
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Cliente(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Cliente: {Nome}, Email: {Email}");
        }
         
    }
}