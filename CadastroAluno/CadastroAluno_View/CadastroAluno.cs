using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadastroAluno_Model;
using CadastroAluno_Controller;

namespace WindowsFormsApplication2
{
    public partial class frmCadastroAluno : Form
    {
        public frmCadastroAluno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno alunoInclusao = new Aluno();
            alunoInclusao.nomeAluno = tbxNome.Text;
            alunoInclusao.cpfAluno = tbxCPF.Text;
            alunoInclusao.rgAluno = tbxRG.Text;

            AlunoController alunoController = new AlunoController();
            alunoController.Cadastrar(alunoInclusao);

            MessageBox.Show("Registro Inserido com sucesso!");

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbxNome.Text = string.Empty;
            tbxCPF.Text = string.Empty;
            tbxRG.Text = string.Empty;
            tbxNome.Focus();

        }

        private void btnAlteracao_Click(object sender, EventArgs e)
        {
            Aluno alunoAlteracao = new Aluno();
            alunoAlteracao.nomeAluno = tbxNome.Text;
            alunoAlteracao.cpfAluno = tbxCPF.Text;
            alunoAlteracao.rgAluno = tbxRG.Text;

            AlunoController alunoController = new AlunoController();
            alunoController.Alterar(alunoAlteracao);

            MessageBox.Show("Registro alterado com sucesso!");

        }

        private void btnExclusao_Click(object sender, EventArgs e)
        {
            Aluno alunoExclusao = new Aluno();
            alunoExclusao.nomeAluno = tbxNome.Text;
            alunoExclusao.cpfAluno = tbxCPF.Text;
            alunoExclusao.rgAluno = tbxRG.Text;

            AlunoController alunoController = new AlunoController();
            alunoController.Exclusao(alunoExclusao);
            MessageBox.Show("Registro Excluído com sucesso!");

            tbxCPF.Text = string.Empty;
            tbxNome.Text = string.Empty;
            tbxRG.Text = string.Empty;

            tbxNome.Focus();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Aluno alunoConsulta = new Aluno();
            alunoConsulta.nomeAluno = tbxNome.Text;
            alunoConsulta.cpfAluno = tbxCPF.Text;
            alunoConsulta.rgAluno = tbxRG.Text;

            AlunoController alunoController = new AlunoController();

            Aluno novoAluno = new Aluno();
            if (alunoConsulta.cpfAluno != "")
            {
                novoAluno = alunoController.Consulta(alunoConsulta);
                if (novoAluno == null)
                {
                    MessageBox.Show("Esse Registro não existe!");
                }
                else
                {
                    tbxNome.Text = novoAluno.nomeAluno;
                    tbxRG.Text = novoAluno.rgAluno;
                    tbxCPF.Text = novoAluno.cpfAluno;
                }

            }
            else
            {
                MessageBox.Show("Por Favor preencha o CPF para executar uma pesquisa!");
            }


        }
    }
}
