using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaJob
{
    public partial class frmCadastroCandi : Form
    {
        bool novo;
        private Conexao.Conexao conexao;
        private Model.Candidato candidato;
        private DAO.CandidatoDao candidatoDao;

        public frmCadastroCandi(bool aNovo)
        {
            InitializeComponent();
            novo = aNovo;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DAO.FormataDados formata = new DAO.FormataDados();
            //MessageBox.Show(Convert.ToString(formata.RetiraPontos(txbCpf.Text)));
            MessageBox.Show(Convert.ToString(formata.RetiraPontos(cbNacionalidade.Text)));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (novo == true)
            {
                try
                {
                    candidato = new Model.Candidato();
                    candidato.Nome = txbNome.Text;
                    candidato.Email = txbEmail.Text;
                    candidato.Cpf = txbCpf.Text;
                    candidato.DtNascimento = txbNascimento.Text;
                    candidato.Nacionalidade = cbNacionalidade.Text;
                    candidato.Endereco = txbEndereco.Text;
                    candidato.Complemento = txbComplemento.Text;
                    candidato.Bairro = txbBairro.Text;
                    candidato.Cidade = txbCidade.Text;
                    candidato.UF = txbUf.Text;
                    candidato.Cep = txbCep.Text;
                    candidato.AdicionarCandidato();
                    MessageBox.Show("Seu cadastro foi criado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else if (novo == false)
            {
                try
                {
                    candidato = new Model.Candidato();
                    candidato.Id = Convert.ToInt32(lblId.Text);
                    candidato.Nome = txbNome.Text;
                    candidato.Email = txbEmail.Text;
                    candidato.Cpf = txbCpf.Text;
                    candidato.DtNascimento = txbNascimento.Text;
                    candidato.Nacionalidade = cbNacionalidade.Text;
                    candidato.Endereco = txbEndereco.Text;
                    candidato.Complemento = txbComplemento.Text;
                    candidato.Bairro = txbBairro.Text;
                    candidato.Cidade = txbCidade.Text;
                    candidato.UF = txbUf.Text;
                    candidato.Cep = txbCep.Text;
                    candidato.EditarCandidato();
                    MessageBox.Show("Cadastro editado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {
            this.Text = "Cadastro: " + txbNome.Text;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

