namespace Hotel.Formulario
{
    partial class VisualisarCadastroHospede
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
            this.label6 = new System.Windows.Forms.Label();
            this.btBuscarReservaQuarto = new System.Windows.Forms.Button();
            this.tbCPFReservaQuarto = new System.Windows.Forms.TextBox();
            this.dgvReservaQuarto = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservaQuarto)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(575, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "--------------------------- Hospede Cadastrado ---------------------------";
            // 
            // btBuscarReservaQuarto
            // 
            this.btBuscarReservaQuarto.Location = new System.Drawing.Point(493, 75);
            this.btBuscarReservaQuarto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btBuscarReservaQuarto.Name = "btBuscarReservaQuarto";
            this.btBuscarReservaQuarto.Size = new System.Drawing.Size(100, 28);
            this.btBuscarReservaQuarto.TabIndex = 33;
            this.btBuscarReservaQuarto.Text = "Buscar";
            this.btBuscarReservaQuarto.UseVisualStyleBackColor = true;
            this.btBuscarReservaQuarto.Click += new System.EventHandler(this.btBuscarReservaQuarto_Click);
            // 
            // tbCPFReservaQuarto
            // 
            this.tbCPFReservaQuarto.Location = new System.Drawing.Point(159, 75);
            this.tbCPFReservaQuarto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCPFReservaQuarto.Name = "tbCPFReservaQuarto";
            this.tbCPFReservaQuarto.Size = new System.Drawing.Size(301, 22);
            this.tbCPFReservaQuarto.TabIndex = 32;
            // 
            // dgvReservaQuarto
            // 
            this.dgvReservaQuarto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservaQuarto.Location = new System.Drawing.Point(16, 130);
            this.dgvReservaQuarto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvReservaQuarto.Name = "dgvReservaQuarto";
            this.dgvReservaQuarto.RowHeadersWidth = 51;
            this.dgvReservaQuarto.Size = new System.Drawing.Size(703, 242);
            this.dgvReservaQuarto.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "CPF/CNPJ::";
            // 
            // VisualisarCadastroHospede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 398);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btBuscarReservaQuarto);
            this.Controls.Add(this.tbCPFReservaQuarto);
            this.Controls.Add(this.dgvReservaQuarto);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VisualisarCadastroHospede";
            this.Text = "VisualisarCadastroPessoaFisica";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservaQuarto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btBuscarReservaQuarto;
        private System.Windows.Forms.TextBox tbCPFReservaQuarto;
        private System.Windows.Forms.DataGridView dgvReservaQuarto;
        private System.Windows.Forms.Label label2;
    }
}