﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaJob.Model
{
    class Candidato
    {
        private string id;
        private string nome;
        private string email;
        private string cpf;
        private string dtNascimento;
        private string nacionalidade;
        private string idEndereco;

        public string Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string DtNascimento { get => dtNascimento; set => dtNascimento = value; }
        public string Nacionalidade { get => nacionalidade; set => nacionalidade = value; }
        public string IdEndereco { get => idEndereco; set => idEndereco = value; }
    }
}