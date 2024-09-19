namespace Hotel.Formulario
{
    partial class VisualizarQuartos
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
            this.tbNumeroQuarto = new System.Windows.Forms.TextBox();
            this.dgvQuarto = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuarto)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Número Do Quarto::";
            // 
            // btBuscarReservaQuarto
            // 
            this.btBuscarReservaQuarto.Location = new System.Drawing.Point(401, 72);
            this.btBuscarReservaQuarto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btBuscarReservaQuarto.Name = "btBuscarReservaQuarto";
            this.btBuscarReservaQuarto.Size = new System.Drawing.Size(100, 28);
            this.btBuscarReservaQuarto.TabIndex = 38;
            this.btBuscarReservaQuarto.Text = "Buscar";
            this.btBuscarReservaQuarto.UseVisualStyleBackColor = true;
            this.btBuscarReservaQuarto.Click += new System.EventHandler(this.btBuscarReservaQuarto_Click);
            // 
            // tbNumeroQuarto
            // 
            this.tbNumeroQuarto.Location = new System.Drawing.Point(68, 75);
            this.tbNumeroQuarto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNumeroQuarto.Name = "tbNumeroQuarto";
            this.tbNumeroQuarto.Size = new System.Drawing.Size(301, 22);
            this.tbNumeroQuarto.TabIndex = 37;
            // 
            // dgvQuarto
            // 
            this.dgvQuarto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuarto.Location = new System.Drawing.Point(16, 129);
            this.dgvQuarto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvQuarto.Name = "dgvQuarto";
            this.dgvQuarto.RowHeadersWidth = 51;
            this.dgvQuarto.Size = new System.Drawing.Size(703, 242);
            this.dgvQuarto.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(578, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "--------------------------- Quartos Cadastrados ---------------------------";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(529, 72);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpar.TabIndex = 40;
            this.btnLimpar.Text = "Limpar Filtro";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // VisualizarQuartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 389);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btBuscarReservaQuarto);
            this.Controls.Add(this.tbNumeroQuarto);
            this.Controls.Add(this.dgvQuarto);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VisualizarQuartos";
            this.Text = "VisualizarQuartos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuarto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btBuscarReservaQuarto;
        private System.Windows.Forms.TextBox tbNumeroQuarto;
        private System.Windows.Forms.DataGridView dgvQuarto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLimpar;
    }
}