using System;
using POO_Interface.Classes;

namespace POO_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho cart = new Carrinho();

            Produto p1 = new Produto{ Codigo = 1, Nome = "Playstation 5", Preco = 10000};
            Produto p2 = new Produto{ Codigo = 2, Nome = "X Box Serie X", Preco = 5000};
            Produto p3 = new Produto{ Codigo = 3, Nome = "Nintendo Switch", Preco = 3000};

            cart.Cadastrar(p1);
            cart.Cadastrar(p2);
            cart.Listar();

            Console.ForegroundColor = ConsoleColor.Green;

            cart.Alterar(p2.Codigo, p3);
            cart.Listar();

            Console.ResetColor();

        }
    }
}
