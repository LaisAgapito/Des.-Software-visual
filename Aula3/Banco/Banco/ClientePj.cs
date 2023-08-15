using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    // Conceito herança. ":" equivale ao "extend"
    public class ClientePj : Cliente 
    {
        public string Cnpj { get; set; }
        public string Razaosocial { get; set; }

        // ": base" = ao "super", indica o atributo que está sendo herdado da classe pai 
        public ClientePj(string nome, string cnpj) : base(nome)
       {
            Cnpj = cnpj;
       }
        
        public string GerarRelatorio()
        {
            return this.Razaosocial + " - " + base.Email;
        }

    }

}
