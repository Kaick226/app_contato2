namespace ProjetoPDS.Formularios
{
    partial class ListarContato
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
            this.components = new System.ComponentModel.Container();
            this.dgvListarContato = new System.Windows.Forms.DataGridView();
            this.bsListaContato = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarContato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListaContato)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListarContato
            // 
            this.dgvListarContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarContato.Location = new System.Drawing.Point(12, 12);
            this.dgvListarContato.Name = "dgvListarContato";
            this.dgvListarContato.Size = new System.Drawing.Size(873, 455);
            this.dgvListarContato.TabIndex = 0;
            // 
            // ListarContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 479);
            this.Controls.Add(this.dgvListarContato);
            this.Name = "ListarContato";
            this.Text = "ListarContato";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarContato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListaContato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListarContato;
        private System.Windows.Forms.BindingSource bsListaContato;
    }
}