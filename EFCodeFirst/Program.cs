using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cli = new Cliente
            {
                Nome = "Diogo",
                Credito = 900,
                Idade = 24
            };

            ClientesContext db = new ClientesContext();

            db.Clientes.Add(cli);

            db.SaveChanges();

            Console.WriteLine("Cliente salvo com sucesso.");

            Console.ReadKey();
        }
    }
}
