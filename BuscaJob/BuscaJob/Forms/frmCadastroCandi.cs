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
        private Conexao.Conexao conexao;

        public frmCadastroCandi()
        {
            InitializeComponent();
        }
        public void getNacionalidade()
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
                        cbNacionalidade.DataSource = datatable;
                        cbNacionalidade.Update();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex, "Erɹo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            DAO.FormataDados formata = new DAO.FormataDados();
            //MessageBox.Show(Convert.ToString(formata.RetiraPontos(txbCpf.Text)));
            MessageBox.Show(Convert.ToString(formata.RetiraPontos(cbNacionalidade.Text)));
        }

        private void frmCadastroCandi_Load(object sender, EventArgs e)
        {
            getNacionalidade();
            
        }
    }
    }

