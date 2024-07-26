using System;
using System.Net.NetworkInformation;
using Empresa.Cliente;
using Empresa.Produto;

class Program
{
    static void Main()
    {
        Cliente cliente = new Cliente("Pedro", "pedro@example.com");
        Produto produto = new Produto("Carro");

        Console.WriteLine($"Cliente: {cliente.Nome}, Email: {cliente.Email}, Produto: {produto.Produtos}");
    }
}