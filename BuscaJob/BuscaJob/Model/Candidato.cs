﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaJob.Model
{
    class Candidato
    {
        private DAO.CandidatoDao candidatoDao;
        private int id;
        private string nome;
        private string email;
        private string cpf;
        private string dtNascimento;
        private string nacionalidade;
        private string endereco;
        private string complemento;
        private string bairro;
        private string cidade;
        private string uf;
        private string cep;
        

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string DtNascimento { get => dtNascimento; set => dtNascimento = value; }
        public string Nacionalidade { get => nacionalidade; set => nacionalidade = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string UF { get => uf; set => uf = value; }
        public string Cep { get => cep; set => cep = value; }

        public void AdicionarCandidato() {
            candidatoDao = new DAO.CandidatoDao();
            candidatoDao.AdicionarCandidato(Nome, Email, Cpf, DtNascimento, Nacionalidade, Endereco, Complemento, Bairro, Cidade, UF, Cep);
        }
        public void EditarCandidato() {
            candidatoDao = new DAO.CandidatoDao();
            candidatoDao.EditarCandidato(Id, Nome, Email, Cpf, DtNascimento, Nacionalidade, Endereco, Complemento, Bairro, Cidade, UF, Cep);
        }
        public void ExcluirCandidato() {
            candidatoDao = new DAO.CandidatoDao();
            candidatoDao.ExcluirCandidato(Id);
        }
    }
}
