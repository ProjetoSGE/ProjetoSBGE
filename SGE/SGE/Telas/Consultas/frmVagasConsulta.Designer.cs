namespace SGE.Telas.Consultas
{
    partial class frmVagasConsulta
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Pesquisar = new System.Windows.Forms.Label();
            this.dgvVaga = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(553, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Pesquisar
            // 
            this.Pesquisar.AutoSize = true;
            this.Pesquisar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pesquisar.Location = new System.Drawing.Point(32, 76);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(44, 21);
            this.Pesquisar.TabIndex = 5;
            this.Pesquisar.Text = "Vaga";
            // 
            // dgvVaga
            // 
            this.dgvVaga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaga.Location = new System.Drawing.Point(16, 108);
            this.dgvVaga.Name = "dgvVaga";
            this.dgvVaga.Size = new System.Drawing.Size(723, 408);
            this.dgvVaga.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(0, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(756, 5);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 64);
            this.label1.TabIndex = 14;
            this.label1.Text = "Consultar vaga";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(655, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmVagasConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Pesquisar);
            this.Controls.Add(this.dgvVaga);
            this.Name = "frmVagasConsulta";
            this.Size = new System.Drawing.Size(755, 536);
            this.Load += new System.EventHandler(this.frmVagasConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Pesquisar;
        private System.Windows.Forms.DataGridView dgvVaga;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
