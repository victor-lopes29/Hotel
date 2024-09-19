namespace Hotel.Formulario
{
    partial class VisualizarCadastroFuncionario
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
            this.label2 = new System.Windows.Forms.Label();
            this.btBuscarReservaQuarto = new System.Windows.Forms.Button();
            this.tbCPFReservaQuarto = new System.Windows.Forms.TextBox();
            this.dgvReservaQuarto = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservaQuarto)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "CPF/CNPJ::";
            // 
            // btBuscarReservaQuarto
            // 
            this.btBuscarReservaQuarto.Location = new System.Drawing.Point(370, 60);
            this.btBuscarReservaQuarto.Name = "btBuscarReservaQuarto";
            this.btBuscarReservaQuarto.Size = new System.Drawing.Size(75, 23);
            this.btBuscarReservaQuarto.TabIndex = 38;
            this.btBuscarReservaQuarto.Text = "Buscar";
            this.btBuscarReservaQuarto.UseVisualStyleBackColor = true;
            // 
            // tbCPFReservaQuarto
            // 
            this.tbCPFReservaQuarto.Location = new System.Drawing.Point(119, 60);
            this.tbCPFReservaQuarto.Name = "tbCPFReservaQuarto";
            this.tbCPFReservaQuarto.Size = new System.Drawing.Size(227, 20);
            this.tbCPFReservaQuarto.TabIndex = 37;
            // 
            // dgvReservaQuarto
            // 
            this.dgvReservaQuarto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservaQuarto.Location = new System.Drawing.Point(12, 105);
            this.dgvReservaQuarto.Name = "dgvReservaQuarto";
            this.dgvReservaQuarto.Size = new System.Drawing.Size(527, 197);
            this.dgvReservaQuarto.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(452, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "--------------------------- Funcionário Cadastrado ---------------------------";
            // 
            // VisualizarCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 315);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btBuscarReservaQuarto);
            this.Controls.Add(this.tbCPFReservaQuarto);
            this.Controls.Add(this.dgvReservaQuarto);
            this.Controls.Add(this.label6);
            this.Name = "VisualizarCadastroFuncionario";
            this.Text = "VisualizarCadastroFuncionarioCLT";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservaQuarto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btBuscarReservaQuarto;
        private System.Windows.Forms.TextBox tbCPFReservaQuarto;
        private System.Windows.Forms.DataGridView dgvReservaQuarto;
        private System.Windows.Forms.Label label6;
    }
}