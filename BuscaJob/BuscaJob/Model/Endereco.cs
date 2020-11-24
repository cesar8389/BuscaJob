using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaJob.Model
{
    class Endereco
    {
        private string id;
        private string endereco;
        private string bairro;
        private string cidade;
        private string uf;
        private string cep;

        public string Id { get => id; set => id = value; }
        public string End { get => endereco; set => endereco = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Cep { get => cep; set => cep = value; }
    }
}
