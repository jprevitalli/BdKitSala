
namespace BdKitSala
{
    partial class TelaKitSalaPesquisaCodigo
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
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.tbCodigoKitSala = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscaKitSala = new System.Windows.Forms.Button();
            this.tbkitSala = new System.Windows.Forms.TextBox();
            this.checkBoxPreto = new System.Windows.Forms.CheckBox();
            this.checkBoxAzul = new System.Windows.Forms.CheckBox();
            this.checkBoxChave = new System.Windows.Forms.CheckBox();
            this.checkBoxApagador = new System.Windows.Forms.CheckBox();
            this.checkBoxConData = new System.Windows.Forms.CheckBox();
            this.checkBoxConAr = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPesqTodosKitSala = new System.Windows.Forms.Button();
            this.dataGridViewKitSala = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ControleAr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ControleDataShow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apagador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canetaoAzul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canetaoPreto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitSala)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("LEMON MILK Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(362, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 40);
            this.label5.TabIndex = 17;
            this.label5.Text = "Pesquisa Kit Sala";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 77);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(955, 427);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnExcluir);
            this.tabPage1.Controls.Add(this.btnAlterar);
            this.tabPage1.Controls.Add(this.tbCodigoKitSala);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnBuscaKitSala);
            this.tabPage1.Controls.Add(this.tbkitSala);
            this.tabPage1.Controls.Add(this.checkBoxPreto);
            this.tabPage1.Controls.Add(this.checkBoxAzul);
            this.tabPage1.Controls.Add(this.checkBoxChave);
            this.tabPage1.Controls.Add(this.checkBoxApagador);
            this.tabPage1.Controls.Add(this.checkBoxConData);
            this.tabPage1.Controls.Add(this.checkBoxConAr);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(947, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisa Código";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(570, 302);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(85, 33);
            this.btnExcluir.TabIndex = 24;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(479, 303);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(85, 33);
            this.btnAlterar.TabIndex = 23;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click_1);
            // 
            // tbCodigoKitSala
            // 
            this.tbCodigoKitSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoKitSala.Location = new System.Drawing.Point(258, 47);
            this.tbCodigoKitSala.Name = "tbCodigoKitSala";
            this.tbCodigoKitSala.Size = new System.Drawing.Size(111, 28);
            this.tbCodigoKitSala.TabIndex = 21;
            this.tbCodigoKitSala.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Digite o Kit Sala:";
            // 
            // btnBuscaKitSala
            // 
            this.btnBuscaKitSala.Location = new System.Drawing.Point(391, 45);
            this.btnBuscaKitSala.Name = "btnBuscaKitSala";
            this.btnBuscaKitSala.Size = new System.Drawing.Size(85, 33);
            this.btnBuscaKitSala.TabIndex = 22;
            this.btnBuscaKitSala.Text = "Pesquisar";
            this.btnBuscaKitSala.UseVisualStyleBackColor = true;
            this.btnBuscaKitSala.Click += new System.EventHandler(this.btnBuscaKitSala_Click);
            // 
            // tbkitSala
            // 
            this.tbkitSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbkitSala.Location = new System.Drawing.Point(187, 95);
            this.tbkitSala.Name = "tbkitSala";
            this.tbkitSala.Size = new System.Drawing.Size(111, 27);
            this.tbkitSala.TabIndex = 19;
            // 
            // checkBoxPreto
            // 
            this.checkBoxPreto.AutoSize = true;
            this.checkBoxPreto.Location = new System.Drawing.Point(333, 276);
            this.checkBoxPreto.Name = "checkBoxPreto";
            this.checkBoxPreto.Size = new System.Drawing.Size(164, 21);
            this.checkBoxPreto.TabIndex = 18;
            this.checkBoxPreto.Text = "Canetão Digital Preto";
            this.checkBoxPreto.UseVisualStyleBackColor = true;
            // 
            // checkBoxAzul
            // 
            this.checkBoxAzul.AutoSize = true;
            this.checkBoxAzul.Location = new System.Drawing.Point(333, 233);
            this.checkBoxAzul.Name = "checkBoxAzul";
            this.checkBoxAzul.Size = new System.Drawing.Size(157, 21);
            this.checkBoxAzul.TabIndex = 17;
            this.checkBoxAzul.Text = "Canetão Digital Azul";
            this.checkBoxAzul.UseVisualStyleBackColor = true;
            // 
            // checkBoxChave
            // 
            this.checkBoxChave.AutoSize = true;
            this.checkBoxChave.Location = new System.Drawing.Point(333, 190);
            this.checkBoxChave.Name = "checkBoxChave";
            this.checkBoxChave.Size = new System.Drawing.Size(122, 21);
            this.checkBoxChave.TabIndex = 16;
            this.checkBoxChave.Text = "Chave da Sala";
            this.checkBoxChave.UseVisualStyleBackColor = true;
            // 
            // checkBoxApagador
            // 
            this.checkBoxApagador.AutoSize = true;
            this.checkBoxApagador.Location = new System.Drawing.Point(100, 276);
            this.checkBoxApagador.Name = "checkBoxApagador";
            this.checkBoxApagador.Size = new System.Drawing.Size(198, 21);
            this.checkBoxApagador.TabIndex = 15;
            this.checkBoxApagador.Text = "Apagador da Lousa Digital";
            this.checkBoxApagador.UseVisualStyleBackColor = true;
            // 
            // checkBoxConData
            // 
            this.checkBoxConData.AutoSize = true;
            this.checkBoxConData.Location = new System.Drawing.Point(100, 233);
            this.checkBoxConData.Name = "checkBoxConData";
            this.checkBoxConData.Size = new System.Drawing.Size(176, 21);
            this.checkBoxConData.TabIndex = 14;
            this.checkBoxConData.Text = "Controle do Data-Show";
            this.checkBoxConData.UseVisualStyleBackColor = true;
            // 
            // checkBoxConAr
            // 
            this.checkBoxConAr.AutoSize = true;
            this.checkBoxConAr.Location = new System.Drawing.Point(100, 190);
            this.checkBoxConAr.Name = "checkBoxConAr";
            this.checkBoxConAr.Size = new System.Drawing.Size(212, 21);
            this.checkBoxConAr.TabIndex = 13;
            this.checkBoxConAr.Text = "Controle do Ar-Condicionado";
            this.checkBoxConAr.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Itens:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kit Sala:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnPesqTodosKitSala);
            this.tabPage2.Controls.Add(this.dataGridViewKitSala);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(947, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisa Tudo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnPesqTodosKitSala
            // 
            this.btnPesqTodosKitSala.Location = new System.Drawing.Point(379, 40);
            this.btnPesqTodosKitSala.Name = "btnPesqTodosKitSala";
            this.btnPesqTodosKitSala.Size = new System.Drawing.Size(250, 37);
            this.btnPesqTodosKitSala.TabIndex = 3;
            this.btnPesqTodosKitSala.Text = "Pesquisar Todos os Kit Sala";
            this.btnPesqTodosKitSala.UseVisualStyleBackColor = true;
            this.btnPesqTodosKitSala.Click += new System.EventHandler(this.btnPesqTodosKitSala_Click);
            // 
            // dataGridViewKitSala
            // 
            this.dataGridViewKitSala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKitSala.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Sala,
            this.ControleAr,
            this.ControleDataShow,
            this.apagador,
            this.chave,
            this.canetaoAzul,
            this.canetaoPreto});
            this.dataGridViewKitSala.Location = new System.Drawing.Point(30, 104);
            this.dataGridViewKitSala.Name = "dataGridViewKitSala";
            this.dataGridViewKitSala.RowHeadersWidth = 51;
            this.dataGridViewKitSala.RowTemplate.Height = 24;
            this.dataGridViewKitSala.Size = new System.Drawing.Size(889, 199);
            this.dataGridViewKitSala.TabIndex = 2;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Cód.";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 50;
            // 
            // Sala
            // 
            this.Sala.HeaderText = "Sala";
            this.Sala.MinimumWidth = 6;
            this.Sala.Name = "Sala";
            this.Sala.Width = 50;
            // 
            // ControleAr
            // 
            this.ControleAr.HeaderText = "Controle Ar";
            this.ControleAr.MinimumWidth = 6;
            this.ControleAr.Name = "ControleAr";
            this.ControleAr.Width = 125;
            // 
            // ControleDataShow
            // 
            this.ControleDataShow.HeaderText = "Controle DataShow";
            this.ControleDataShow.MinimumWidth = 6;
            this.ControleDataShow.Name = "ControleDataShow";
            this.ControleDataShow.Width = 125;
            // 
            // apagador
            // 
            this.apagador.HeaderText = "Apagador";
            this.apagador.MinimumWidth = 6;
            this.apagador.Name = "apagador";
            this.apagador.Width = 125;
            // 
            // chave
            // 
            this.chave.HeaderText = "Chave";
            this.chave.MinimumWidth = 6;
            this.chave.Name = "chave";
            this.chave.Width = 50;
            // 
            // canetaoAzul
            // 
            this.canetaoAzul.HeaderText = "Canetão Azul";
            this.canetaoAzul.MinimumWidth = 6;
            this.canetaoAzul.Name = "canetaoAzul";
            this.canetaoAzul.Width = 125;
            // 
            // canetaoPreto
            // 
            this.canetaoPreto.HeaderText = "Canetão Preto";
            this.canetaoPreto.MinimumWidth = 6;
            this.canetaoPreto.Name = "canetaoPreto";
            this.canetaoPreto.Width = 125;
            // 
            // TelaKitSalaPesquisaCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 507);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TelaKitSalaPesquisaCodigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaKitSalaPesquisaCodigo";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitSala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbkitSala;
        private System.Windows.Forms.CheckBox checkBoxPreto;
        private System.Windows.Forms.CheckBox checkBoxAzul;
        private System.Windows.Forms.CheckBox checkBoxChave;
        private System.Windows.Forms.CheckBox checkBoxApagador;
        private System.Windows.Forms.CheckBox checkBoxConData;
        private System.Windows.Forms.CheckBox checkBoxConAr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCodigoKitSala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscaKitSala;
        private System.Windows.Forms.Button btnPesqTodosKitSala;
        private System.Windows.Forms.DataGridView dataGridViewKitSala;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn ControleAr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ControleDataShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn apagador;
        private System.Windows.Forms.DataGridViewTextBoxColumn chave;
        private System.Windows.Forms.DataGridViewTextBoxColumn canetaoAzul;
        private System.Windows.Forms.DataGridViewTextBoxColumn canetaoPreto;
    }
}