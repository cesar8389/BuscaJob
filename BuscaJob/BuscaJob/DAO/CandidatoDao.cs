using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BuscaJob.DAO
{
    class CandidatoDao
    {
        private Model.Candidato candidato;
        private MySqlConnection con;
        private Conexao.Conexao conexao;

        public void AdicionarCandidato(int id, string nome, string email, string cpf, string dtNascimento, string nacionalidade, string endereco, string complemento, string bairro, string cidade, string uf, string cep) {
            con = new MySqlConnection();
            candidato = new Model.Candidato();
            conexao = new Conexao.Conexao();
            con.ConnectionString = conexao.getConnecttionString();

            String query = "INSERT INTO candidato (id, nome, email, cpf, dtNascimento, nacionalidade, endereco, complemento, bairro, cidade, uf, cep) VALUES (?id, ?nome, ?email, ?cpf, ?dtNascimento, ?nacionalidade, ?endereco, ?complemento, ?bairro, ?cidade, ?uf, ?cep)";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?id", id);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?email", email);
                cmd.Parameters.AddWithValue("?cpf", cpf);
                cmd.Parameters.AddWithValue("?dtNascimento", dtNascimento);
                cmd.Parameters.AddWithValue("?nacionalidade", nacionalidade);
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
        public void EditarCandidato(int id, string nome, string email, string cpf, string dtNascimento, string nacionalidade, string endereco, string complemento, string bairro, string cidade, string uf, string cep)
        {
            con = new MySqlConnection();
            candidato = new Model.Candidato();
            conexao = new Conexao.Conexao();
            con.ConnectionString = conexao.getConnecttionString();
            String query = "UPDATE candidato SET id = ?id, nome = ?nome, email = ?email, cpf = ?cpf, dtNascimento = ?dtNascimento, nacionalidade = ?nacionalidade, endereco = ?endereco, complemento = ?complemento, bairro = ?bairro, cidade = ?cidade, uf = ?uf, cep = ?cep WHERE candidato.id = ?id";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?id", id);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?email", email);
                cmd.Parameters.AddWithValue("?cpf", cpf);
                cmd.Parameters.AddWithValue("?dtNascimento", dtNascimento);
                cmd.Parameters.AddWithValue("?nacionalidade", nacionalidade);
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
        public void ExcluirCandidato(int id)
        {
            con = new MySqlConnection();
            candidato = new Model.Candidato();
            conexao = new Conexao.Conexao();
            con.ConnectionString = conexao.getConnecttionString();
            String query = "DELETE FROM candidato WHERE candidato.id = ?id";

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
