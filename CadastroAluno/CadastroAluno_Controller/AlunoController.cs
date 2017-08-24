using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroAluno_Model;
using System.Data.OleDb;

namespace CadastroAluno_Controller
{
    public class AlunoController
    {
        public bool Cadastrar(string nome, string rg, string cpf)
        {
            string query = "INSERT into Alunos(nome,rg,cpf) VALUES('" + nome + "','" + rg + "','" + cpf + "')";
            Boolean retorno = Execucao(query);
            return retorno;
        }

        public bool Alterar(string nome, string rg, string cpf)
        {
            string query = "UPDATE Alunos  SET nome ='" + nome + "', rg ='" + rg + "' WHERE CPF='" + cpf+"'";
            Boolean retorno = Execucao(query);
            return retorno;
        }

        public bool Exclusao(string nome, string rg, string cpf)
        {
            string query = "DELETE FROM Alunos WHERE cpf='"+cpf+"'";
            Boolean retorno = Execucao(query);
            return retorno;
        }

        public Aluno Consulta(string nome, string rg, string cpf)
        {
            string query = "SELECT*FROM Alunos WHERE CPF='" + cpf + "'";
            Aluno retorno = ExecucaoConsulta(query);
            return retorno;
        }

        public Aluno ExecucaoConsulta(string query)
        {
            OleDbDataReader reader = null;
            OleDbConnection conn = null;
            Aluno aluno = null;
            try
            {
                conn = obterConexao();

                OleDbCommand cmd = new OleDbCommand(query, conn);

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        aluno = new Aluno();
                        aluno.nomeAluno = reader.GetString(1);
                        aluno.rgAluno = reader.GetString(2);
                        aluno.cpfAluno = reader.GetString(3);
                        return aluno;
                    }
                }
                reader.Close();
                fecharConexao(conn);
                return aluno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public bool Execucao(string query)
        {
            OleDbDataReader reader = null;
            OleDbConnection conn = null;
            try
            {
                conn = obterConexao();
                OleDbCommand cmd = new OleDbCommand(query, conn);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    return true;
                }

                fecharConexao(conn);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return true;
        }

        public void fecharConexao(OleDbConnection conn)
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public OleDbConnection obterConexao()
        {
            OleDbConnection conn = null;

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Alunos.accdb;";
            conn = new OleDbConnection(connectionString);

            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            return conn;

        }
    }
}
