using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaJob.Model
{
    class Empresa
    {
        private string id;
        private string nome;
        private string email;
        private string cnpj;
        private string emailContato;
        private string idEndereco;

        public string Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string EmailContato { get => emailContato; set => emailContato = value; }
        public string IdEndereco { get => idEndereco; set => idEndereco = value; }
    }
}
