using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaJob.DAO
{
    class EmpresaDao
    {
        private Model.Empresa empresa;
        private MySqlConnection con;
        private Conexao.Conexao conexao;

        public void AdicionarEmpresa(int id, string nome, string email, string cnpj, string emailContato, string endereco, string complemento, string bairro, string cidade, string uf, string cep)
        {
            con = new MySqlConnection();
            empresa = new Model.Empresa();
            conexao = new Conexao.Conexao();
            con.ConnectionString = conexao.getConnecttionString();

            String query = "INSERT INTO empresa (id, nome, email, cnpj, emailContato, endereco, complemento, bairro, cidade, uf, cep) VALUES (?id, ?nome, ?email, ?cnpj, ?emailContato, ?endereco, ?complemento, ?bairro, ?cidade, ?uf, ?cep)";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?id", id);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?email", email);
                cmd.Parameters.AddWithValue("?cnpj", cnpj);
                cmd.Parameters.AddWithValue("?emailContato", emailContato);
                cmd.Parameters.AddWithValue("?endereco", endereco);
                cmd.Parameters.AddWithValue("?complemento", complemento);
                cmd.Parameters.AddWithValue("?bairro", bairro);
                cmd.Parameters.AddWithValue("?cidade", cidade);
                cmd.Parameters.AddWithValue("?uf", uf);
                cmd.Parameters.AddWithValue("?cep", cep);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {
                con.Close();
            }
        }
        public void EditarEmpresa(int id, string nome, string email, string cnpj, string emailContato, string endereco, string complemento, string bairro, string cidade, string uf, string cep)
        {
            con = new MySqlConnection();
            empresa = new Model.Empresa();
            conexao = new Conexao.Conexao();
            con.ConnectionString = conexao.getConnecttionString();
            String query = "UPDATE empresa SET id = ?id, nome = ?nome, email = ?email, cnpj = ?cnpj, emailContato = ?emailContato, endereco = ?endereco, complemento = ?complemento, bairro = ?bairro, cidade = ?cidade, uf = ?uf, cep = ?cep WHERE empresa.id = ?id";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?id", id);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?email", email);
                cmd.Parameters.AddWithValue("?cnpj", cnpj);
                cmd.Parameters.AddWithValue("?emailContato", emailContato);
                cmd.Parameters.AddWithValue("?endereco", endereco);
                cmd.Parameters.AddWithValue("?complemento", complemento);
                cmd.Parameters.AddWithValue("?bairro", bairro);
                cmd.Parameters.AddWithValue("?cidade", cidade);
                cmd.Parameters.AddWithValue("?uf", uf);
                cmd.Parameters.AddWithValue("?cep", cep);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {
                con.Close();
            }
        }
        public void ExcluirEmpresa(int id)
        {
            con = new MySqlConnection();
            empresa = new Model.Empresa();
            conexao = new Conexao.Conexao();
            con.ConnectionString = conexao.getConnecttionString();
            String query = "DELETE FROM empresa WHERE empresa.id = ?id";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?id", id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
