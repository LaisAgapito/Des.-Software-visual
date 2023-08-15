using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ContaCorrente c1 = new ContaCorrente();
            Cliente cliente1 = new Cliente();
            Console.WriteLine("Digite o nome do cliente");
            cliente1.Nome = Console.ReadLine();
            c1.Titular = cliente1;
            Console.WriteLine("Digite o saldo inicial da conta ");
            c1.Saldo = double.Parse(Console.ReadLine());
            //Criando cliente e conta 2
            ContaCorrente c2 = new ContaCorrente();
            Cliente cliente2 = new Cliente();
            Console.WriteLine("Digite o nome do Cliente 2");
            cliente2.Nome = Console.ReadLine();
            c2.Titular = cliente2;
            Console.WriteLine("Digite o saldo inicial da conta 2");
            c2.Saldo = double.Parse(Console.ReadLine());

            // Testando Pix 
            Console.WriteLine("Digite o valor que será transferido do cliente " + c1.Titular.Nome + " para o cliente 2 " + c2.Titular.Nome);
            double valor = double.Parse(Console.ReadLine());
            if(c1.Pix(valor, c2))
            {
                Console.WriteLine("Pix realizado com sucesso! ");
            }
            else
            {
                Console.WriteLine("ERRO! Pix não realizado.");
            }
            Console.ReadLine();



































            /*/ Testando os metodos sacar e depositar
            c1.Depositar(-1);
            Console.WriteLine("Saldo de " +
                c1.titular + " é " + c1.saldo);//100
            c1.Depositar(200);
            Console.WriteLine("Saldo de " +
               c1.titular + " é " + c1.saldo);//300
            c1.Sacar(350);
            Console.WriteLine("Saldo de " +
               c1.titular + " é " + c1.saldo);//300
            c1.Sacar(50);
            Console.WriteLine("Saldo de " +
               c1.titular + " é " + c1.saldo); //250 /*/

            
        }
    }
}
