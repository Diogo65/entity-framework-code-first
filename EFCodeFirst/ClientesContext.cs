using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    class ClientesContext : DbContext
    {
        /*Aqui invocamos o construtor da classe pai, passando como parâmetro o 
         * nome da string de conexão na qual essa classe encontrará as informações 
         * necessárias para se conectar ao banco de dados*/
        public ClientesContext() : base("BancoClientes")
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
