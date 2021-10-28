
namespace BdKitSala
{
    partial class TelaKitSala
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxConAr = new System.Windows.Forms.CheckBox();
            this.checkBoxConData = new System.Windows.Forms.CheckBox();
            this.checkBoxApagador = new System.Windows.Forms.CheckBox();
            this.checkBoxChave = new System.Windows.Forms.CheckBox();
            this.checkBoxAzul = new System.Windows.Forms.CheckBox();
            this.checkBoxPreto = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tbKitSala = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LEMON MILK Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Kits Salas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kit Sala:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Itens:";
            // 
            // checkBoxConAr
            // 
            this.checkBoxConAr.AutoSize = true;
            this.checkBoxConAr.Location = new System.Drawing.Point(94, 230);
            this.checkBoxConAr.Name = "checkBoxConAr";
            this.checkBoxConAr.Size = new System.Drawing.Size(212, 21);
            this.checkBoxConAr.TabIndex = 3;
            this.checkBoxConAr.Text = "Controle do Ar-Condicionado";
            this.checkBoxConAr.UseVisualStyleBackColor = true;
            // 
            // checkBoxConData
            // 
            this.checkBoxConData.AutoSize = true;
            this.checkBoxConData.Location = new System.Drawing.Point(94, 273);
            this.checkBoxConData.Name = "checkBoxConData";
            this.checkBoxConData.Size = new System.Drawing.Size(176, 21);
            this.checkBoxConData.TabIndex = 4;
            this.checkBoxConData.Text = "Controle do Data-Show";
            this.checkBoxConData.UseVisualStyleBackColor = true;
            // 
            // checkBoxApagador
            // 
            this.checkBoxApagador.AutoSize = true;
            this.checkBoxApagador.Location = new System.Drawing.Point(94, 316);
            this.checkBoxApagador.Name = "checkBoxApagador";
            this.checkBoxApagador.Size = new System.Drawing.Size(198, 21);
            this.checkBoxApagador.TabIndex = 5;
            this.checkBoxApagador.Text = "Apagador da Lousa Digital";
            this.checkBoxApagador.UseVisualStyleBackColor = true;
            // 
            // checkBoxChave
            // 
            this.checkBoxChave.AutoSize = true;
            this.checkBoxChave.Location = new System.Drawing.Point(327, 230);
            this.checkBoxChave.Name = "checkBoxChave";
            this.checkBoxChave.Size = new System.Drawing.Size(122, 21);
            this.checkBoxChave.TabIndex = 6;
            this.checkBoxChave.Text = "Chave da Sala";
            this.checkBoxChave.UseVisualStyleBackColor = true;
            // 
            // checkBoxAzul
            // 
            this.checkBoxAzul.AutoSize = true;
            this.checkBoxAzul.Location = new System.Drawing.Point(327, 273);
            this.checkBoxAzul.Name = "checkBoxAzul";
            this.checkBoxAzul.Size = new System.Drawing.Size(157, 21);
            this.checkBoxAzul.TabIndex = 7;
            this.checkBoxAzul.Text = "Canetão Digital Azul";
            this.checkBoxAzul.UseVisualStyleBackColor = true;
            // 
            // checkBoxPreto
            // 
            this.checkBoxPreto.AutoSize = true;
            this.checkBoxPreto.Location = new System.Drawing.Point(327, 316);
            this.checkBoxPreto.Name = "checkBoxPreto";
            this.checkBoxPreto.Size = new System.Drawing.Size(164, 21);
            this.checkBoxPreto.TabIndex = 8;
            this.checkBoxPreto.Text = "Canetão Digital Preto";
            this.checkBoxPreto.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(458, 377);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(83, 32);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tbKitSala
            // 
            this.tbKitSala.Location = new System.Drawing.Point(304, 117);
            this.tbKitSala.Name = "tbKitSala";
            this.tbKitSala.Size = new System.Drawing.Size(100, 22);
            this.tbKitSala.TabIndex = 10;
            // 
            // TelaKitSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.tbKitSala);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.checkBoxPreto);
            this.Controls.Add(this.checkBoxAzul);
            this.Controls.Add(this.checkBoxChave);
            this.Controls.Add(this.checkBoxApagador);
            this.Controls.Add(this.checkBoxConData);
            this.Controls.Add(this.checkBoxConAr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TelaKitSala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro dos Kit Salas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxConAr;
        private System.Windows.Forms.CheckBox checkBoxConData;
        private System.Windows.Forms.CheckBox checkBoxApagador;
        private System.Windows.Forms.CheckBox checkBoxChave;
        private System.Windows.Forms.CheckBox checkBoxAzul;
        private System.Windows.Forms.CheckBox checkBoxPreto;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox tbKitSala;
    }
}