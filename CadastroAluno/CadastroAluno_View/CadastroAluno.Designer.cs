namespace WindowsFormsApplication2
{
    partial class frmCadastroAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxDados = new System.Windows.Forms.GroupBox();
            this.tbxCPF = new System.Windows.Forms.TextBox();
            this.tbxRG = new System.Windows.Forms.TextBox();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.gbxOperacoes = new System.Windows.Forms.GroupBox();
            this.btnInclusão = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnExclusao = new System.Windows.Forms.Button();
            this.btnAlteracao = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gbxAcoes = new System.Windows.Forms.GroupBox();
            this.gbxDados.SuspendLayout();
            this.gbxOperacoes.SuspendLayout();
            this.gbxAcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDados
            // 
            this.gbxDados.Controls.Add(this.tbxCPF);
            this.gbxDados.Controls.Add(this.tbxRG);
            this.gbxDados.Controls.Add(this.tbxNome);
            this.gbxDados.Controls.Add(this.lblRG);
            this.gbxDados.Controls.Add(this.lblCPF);
            this.gbxDados.Controls.Add(this.lblNome);
            this.gbxDados.Location = new System.Drawing.Point(12, 12);
            this.gbxDados.Name = "gbxDados";
            this.gbxDados.Size = new System.Drawing.Size(273, 156);
            this.gbxDados.TabIndex = 0;
            this.gbxDados.TabStop = false;
            this.gbxDados.Text = "Dados";
            // 
            // tbxCPF
            // 
            this.tbxCPF.Location = new System.Drawing.Point(68, 69);
            this.tbxCPF.Name = "tbxCPF";
            this.tbxCPF.Size = new System.Drawing.Size(191, 20);
            this.tbxCPF.TabIndex = 5;
            // 
            // tbxRG
            // 
            this.tbxRG.Location = new System.Drawing.Point(68, 95);
            this.tbxRG.Name = "tbxRG";
            this.tbxRG.Size = new System.Drawing.Size(191, 20);
            this.tbxRG.TabIndex = 4;
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(68, 43);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(191, 20);
            this.tbxNome.TabIndex = 3;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(17, 98);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(23, 13);
            this.lblRG.TabIndex = 2;
            this.lblRG.Text = "RG";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(17, 72);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 1;
            this.lblCPF.Text = "CPF";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(17, 46);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // gbxOperacoes
            // 
            this.gbxOperacoes.Controls.Add(this.btnInclusão);
            this.gbxOperacoes.Controls.Add(this.btnConsulta);
            this.gbxOperacoes.Controls.Add(this.btnExclusao);
            this.gbxOperacoes.Controls.Add(this.btnAlteracao);
            this.gbxOperacoes.Location = new System.Drawing.Point(291, 12);
            this.gbxOperacoes.Name = "gbxOperacoes";
            this.gbxOperacoes.Size = new System.Drawing.Size(162, 156);
            this.gbxOperacoes.TabIndex = 6;
            this.gbxOperacoes.TabStop = false;
            this.gbxOperacoes.Text = "Operações";
            // 
            // btnInclusão
            // 
            this.btnInclusão.Location = new System.Drawing.Point(43, 27);
            this.btnInclusão.Name = "btnInclusão";
            this.btnInclusão.Size = new System.Drawing.Size(75, 23);
            this.btnInclusão.TabIndex = 0;
            this.btnInclusão.Text = "Incluir";
            this.btnInclusão.UseVisualStyleBackColor = true;
            this.btnInclusão.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(43, 114);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 3;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnExclusao
            // 
            this.btnExclusao.Location = new System.Drawing.Point(43, 85);
            this.btnExclusao.Name = "btnExclusao";
            this.btnExclusao.Size = new System.Drawing.Size(75, 23);
            this.btnExclusao.TabIndex = 2;
            this.btnExclusao.Text = "Excluir";
            this.btnExclusao.UseVisualStyleBackColor = true;
            this.btnExclusao.Click += new System.EventHandler(this.btnExclusao_Click);
            // 
            // btnAlteracao
            // 
            this.btnAlteracao.Location = new System.Drawing.Point(43, 56);
            this.btnAlteracao.Name = "btnAlteracao";
            this.btnAlteracao.Size = new System.Drawing.Size(75, 23);
            this.btnAlteracao.TabIndex = 1;
            this.btnAlteracao.Text = "Alterar";
            this.btnAlteracao.UseVisualStyleBackColor = true;
            this.btnAlteracao.Click += new System.EventHandler(this.btnAlteracao_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(6, 52);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(153, 27);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(6, 91);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(153, 27);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gbxAcoes
            // 
            this.gbxAcoes.Controls.Add(this.btnSair);
            this.gbxAcoes.Controls.Add(this.btnLimpar);
            this.gbxAcoes.Location = new System.Drawing.Point(459, 12);
            this.gbxAcoes.Name = "gbxAcoes";
            this.gbxAcoes.Size = new System.Drawing.Size(165, 156);
            this.gbxAcoes.TabIndex = 9;
            this.gbxAcoes.TabStop = false;
            this.gbxAcoes.Text = "Ações";
            // 
            // frmCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(642, 175);
            this.ControlBox = false;
            this.Controls.Add(this.gbxAcoes);
            this.Controls.Add(this.gbxOperacoes);
            this.Controls.Add(this.gbxDados);
            this.Name = "frmCadastroAluno";
            this.Text = "Cadastro Aluno";
            this.gbxDados.ResumeLayout(false);
            this.gbxDados.PerformLayout();
            this.gbxOperacoes.ResumeLayout(false);
            this.gbxAcoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDados;
        private System.Windows.Forms.TextBox tbxCPF;
        private System.Windows.Forms.TextBox tbxRG;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gbxOperacoes;
        private System.Windows.Forms.Button btnInclusão;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnExclusao;
        private System.Windows.Forms.Button btnAlteracao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox gbxAcoes;
    }
}

