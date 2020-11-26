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

        public frmCadastroCandi()
        {
            InitializeComponent();
        }
        /*public void getNacionalidade()
        {
            conexao = new Conexao.Conexao();
            string connectionString = conexao.getConnecttionString();
            string query = "CALL getNacionalidade()";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                {
                    try
                    {
                        DataTable datatable = new DataTable();
                        adapter.Fill(datatable);
                        cbNacionalidade.Items.AddRange(new object[] {datatable});
                        //cbNacionalidade.DataSource = datatable;
                        cbNacionalidade.Update();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex, "Erɹo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }*/

        private void button5_Click(object sender, EventArgs e)
        {
            DAO.FormataDados formata = new DAO.FormataDados();
            //MessageBox.Show(Convert.ToString(formata.RetiraPontos(txbCpf.Text)));
            MessageBox.Show(Convert.ToString(formata.RetiraPontos(cbNacionalidade.Text)));
        }

        private void frmCadastroCandi_Load(object sender, EventArgs e)
        {
            //getNacionalidade();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            novo = true;
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

