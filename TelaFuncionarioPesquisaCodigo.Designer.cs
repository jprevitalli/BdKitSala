
namespace BdKitSala
{
    partial class TelaFuncionarioPesquisaCodigo
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCodigoFun = new System.Windows.Forms.TextBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.tbChapaFun = new System.Windows.Forms.TextBox();
            this.tbEmailFun = new System.Windows.Forms.TextBox();
            this.tbNomeFun = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBNomeFun = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPesqTodosFun = new System.Windows.Forms.Button();
            this.dataGridViewfuncionario = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o Código do Funcionário:";
            // 
            // tbCodigoFun
            // 
            this.tbCodigoFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoFun.Location = new System.Drawing.Point(403, 15);
            this.tbCodigoFun.Name = "tbCodigoFun";
            this.tbCodigoFun.Size = new System.Drawing.Size(111, 28);
            this.tbCodigoFun.TabIndex = 1;
            this.tbCodigoFun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(546, 11);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(85, 33);
            this.btnBusca.TabIndex = 2;
            this.btnBusca.Text = "Pesquisar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // tbChapaFun
            // 
            this.tbChapaFun.Location = new System.Drawing.Point(159, 215);
            this.tbChapaFun.Name = "tbChapaFun";
            this.tbChapaFun.Size = new System.Drawing.Size(472, 22);
            this.tbChapaFun.TabIndex = 13;
            // 
            // tbEmailFun
            // 
            this.tbEmailFun.Location = new System.Drawing.Point(159, 150);
            this.tbEmailFun.Name = "tbEmailFun";
            this.tbEmailFun.Size = new System.Drawing.Size(472, 22);
            this.tbEmailFun.TabIndex = 12;
            // 
            // tbNomeFun
            // 
            this.tbNomeFun.Location = new System.Drawing.Point(159, 85);
            this.tbNomeFun.Name = "tbNomeFun";
            this.tbNomeFun.Size = new System.Drawing.Size(472, 22);
            this.tbNomeFun.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Chapa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "E-mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome:";
            // 
            // txtBNomeFun
            // 
            this.txtBNomeFun.Location = new System.Drawing.Point(159, 85);
            this.txtBNomeFun.Name = "txtBNomeFun";
            this.txtBNomeFun.Size = new System.Drawing.Size(472, 22);
            this.txtBNomeFun.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(731, 337);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnExcluir);
            this.tabPage1.Controls.Add(this.btnAlterar);
            this.tabPage1.Controls.Add(this.tbCodigoFun);
            this.tabPage1.Controls.Add(this.tbChapaFun);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbEmailFun);
            this.tabPage1.Controls.Add(this.btnBusca);
            this.tabPage1.Controls.Add(this.txtBNomeFun);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbNomeFun);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(723, 308);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisa Código";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(537, 252);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(94, 40);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(410, 252);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(94, 40);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnPesqTodosFun);
            this.tabPage2.Controls.Add(this.dataGridViewfuncionario);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(723, 308);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisa Tudo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnPesqTodosFun
            // 
            this.btnPesqTodosFun.Location = new System.Drawing.Point(238, 28);
            this.btnPesqTodosFun.Name = "btnPesqTodosFun";
            this.btnPesqTodosFun.Size = new System.Drawing.Size(250, 37);
            this.btnPesqTodosFun.TabIndex = 1;
            this.btnPesqTodosFun.Text = "Pesquisar Todos os Funcionários";
            this.btnPesqTodosFun.UseVisualStyleBackColor = true;
            this.btnPesqTodosFun.Click += new System.EventHandler(this.btnPesqTodosFun_Click);
            // 
            // dataGridViewfuncionario
            // 
            this.dataGridViewfuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewfuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Email,
            this.Chapa});
            this.dataGridViewfuncionario.Location = new System.Drawing.Point(105, 83);
            this.dataGridViewfuncionario.Name = "dataGridViewfuncionario";
            this.dataGridViewfuncionario.RowHeadersWidth = 51;
            this.dataGridViewfuncionario.RowTemplate.Height = 24;
            this.dataGridViewfuncionario.Size = new System.Drawing.Size(555, 199);
            this.dataGridViewfuncionario.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 125;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "E-mail";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // Chapa
            // 
            this.Chapa.HeaderText = "Chapa";
            this.Chapa.MinimumWidth = 6;
            this.Chapa.Name = "Chapa";
            this.Chapa.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("LEMON MILK Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(190, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(404, 40);
            this.label5.TabIndex = 15;
            this.label5.Text = "Pesquisa Funcionário";
            // 
            // TelaFuncionarioPesquisaCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 420);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TelaFuncionarioPesquisaCodigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa por Código";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCodigoFun;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.TextBox tbChapaFun;
        private System.Windows.Forms.TextBox tbEmailFun;
        private System.Windows.Forms.TextBox tbNomeFun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBNomeFun;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnPesqTodosFun;
        private System.Windows.Forms.DataGridView dataGridViewfuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chapa;
    }
}