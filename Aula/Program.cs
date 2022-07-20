using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("USUARIO: informe o seu primeiro nome:  ");
            string usuario = Console.ReadLine();

            Console.Write("USUARIO: informe o seu ultimo nome:  ");
            string ultimonome = Console.ReadLine();


            Console.Write("USUARIO: informe o seu saldo:  ");
            double saldoUsuario = double.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------------");

            //INFORMAÇÕES DO USUARIO
            Console.WriteLine($"NOME DO USUARIO:    {usuario} {ultimonome} ");
            Console.WriteLine($"SALDO DO USUARIO:    {saldoUsuario.ToString("N")}");

            Console.WriteLine("-------------------------------------------");

            //PRODUTOS
            Console.Write("PRODUTO: informe o produto desejado:  ");
            string produto = Console.ReadLine();
            double valorProduto = 145;
            Console.WriteLine($"VALOR DO PRODUTO: {valorProduto.ToString("N")} R$");
            Console.WriteLine($"SEU SALDO: {saldoUsuario.ToString("N")} R$");
            Console.WriteLine($"SEU SALDO APOS A COMPRA:  {saldoUsuario - valorProduto} R$");

            Console.WriteLine("-------------------------------------------");

            Console.Write("Deseja continuar com a compra? (S/N):  ");
            string continuar = Console.ReadLine();

            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("INFORMAÇÕES DO PEDIDO:  ");

            Console.WriteLine($"USUARIO:  {usuario} {ultimonome} ");
            Console.WriteLine($"PRODUTO:  {produto} ");
            Console.WriteLine($"VALOR DO PRODUTO: {valorProduto} R$");
            Console.WriteLine($"TROCO {saldoUsuario - valorProduto} R$");

            Console.WriteLine("-------------------------------------------");
           



            Console.ReadLine(); 

        }
    }
}
