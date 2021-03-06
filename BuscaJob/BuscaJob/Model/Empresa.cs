﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaJob.Model
{
    class Empresa
    {
        private DAO.EmpresaDao empresaDao;
        private int id;
        private string nome;
        private string email;
        private string cnpj;
        private string emailContato;
        private string endereco;
        private string complemento;
        private string bairro;
        private string cidade;
        private string uf;
        private string cep;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string EmailContato { get => emailContato; set => emailContato = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string UF { get => uf; set => uf = value; }
        public string Cep { get => cep; set => cep = value; }

        public void AdicionarEmpresa()
        {
            empresaDao = new DAO.EmpresaDao();
            empresaDao.AdicionarEmpresa(Id, Nome, Email, Cnpj, EmailContato, Endereco, Complemento, Bairro, Cidade, UF, Cep);
        }
        public void EditarEmpresa()
        {
            empresaDao = new DAO.EmpresaDao();
            empresaDao.EditarEmpresa(Id, Nome, Email, Cnpj, EmailContato, Endereco, Complemento, Bairro, Cidade, UF, Cep);
        }
        public void ExcluirEmpresa()
        {
            empresaDao = new DAO.EmpresaDao();
            empresaDao.ExcluirEmpresa(Id);
        }
    }
}
