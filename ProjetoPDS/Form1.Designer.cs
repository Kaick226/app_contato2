﻿namespace ProjetoPDS
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btCadastrarContato = new System.Windows.Forms.Button();
            this.btListarContato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SpringGreen;
            this.label1.Location = new System.Drawing.Point(251, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu de Cadastro de Contato";
            // 
            // btCadastrarContato
            // 
            this.btCadastrarContato.BackColor = System.Drawing.Color.SpringGreen;
            this.btCadastrarContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarContato.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCadastrarContato.Location = new System.Drawing.Point(311, 125);
            this.btCadastrarContato.Name = "btCadastrarContato";
            this.btCadastrarContato.Size = new System.Drawing.Size(152, 45);
            this.btCadastrarContato.TabIndex = 1;
            this.btCadastrarContato.Text = "Cadastrar Contato";
            this.btCadastrarContato.UseVisualStyleBackColor = false;
            this.btCadastrarContato.Click += new System.EventHandler(this.btCadastrarContato_Click);
            // 
            // btListarContato
            // 
            this.btListarContato.BackColor = System.Drawing.Color.SpringGreen;
            this.btListarContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListarContato.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btListarContato.Location = new System.Drawing.Point(311, 204);
            this.btListarContato.Name = "btListarContato";
            this.btListarContato.Size = new System.Drawing.Size(152, 45);
            this.btListarContato.TabIndex = 2;
            this.btListarContato.Text = "Listar Contato";
            this.btListarContato.UseVisualStyleBackColor = false;
            this.btListarContato.Click += new System.EventHandler(this.btListarContato_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoPDS.Properties.Resources.images__3_;
            this.ClientSize = new System.Drawing.Size(803, 451);
            this.Controls.Add(this.btListarContato);
            this.Controls.Add(this.btCadastrarContato);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCadastrarContato;
        private System.Windows.Forms.Button btListarContato;
    }
}

