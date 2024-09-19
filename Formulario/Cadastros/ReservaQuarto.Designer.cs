namespace Hotel.Formulario
{
    partial class ReservaQuarto
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
            this.dtpSaida = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbQuartoReservaQuarto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvQuartosDisponivels = new System.Windows.Forms.DataGridView();
            this.btReservarReservaQuarto = new System.Windows.Forms.Button();
            this.btCancelarReservaQuarto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCPFReservaQuarto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btBuscarReservaQuarto = new System.Windows.Forms.Button();
            this.mkdTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mkdCelular = new System.Windows.Forms.MaskedTextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuartosDisponivels)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpSaida
            // 
            this.dtpSaida.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpSaida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSaida.Location = new System.Drawing.Point(512, 476);
            this.dtpSaida.Margin = new System.Windows.Forms.Padding(4);
            this.dtpSaida.Name = "dtpSaida";
            this.dtpSaida.Size = new System.Drawing.Size(172, 22);
            this.dtpSaida.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(509, 457);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Data e horário de saída:";
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntrada.Location = new System.Drawing.Point(70, 476);
            this.dtpEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(172, 22);
            this.dtpEntrada.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 457);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Data e horário de entrada:";
            // 
            // tbQuartoReservaQuarto
            // 
            this.tbQuartoReservaQuarto.Location = new System.Drawing.Point(70, 541);
            this.tbQuartoReservaQuarto.Margin = new System.Windows.Forms.Padding(4);
            this.tbQuartoReservaQuarto.Name = "tbQuartoReservaQuarto";
            this.tbQuartoReservaQuarto.Size = new System.Drawing.Size(301, 22);
            this.tbQuartoReservaQuarto.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 522);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Número do Quarto:";
            // 
            // dgvQuartosDisponivels
            // 
            this.dgvQuartosDisponivels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuartosDisponivels.Location = new System.Drawing.Point(13, 610);
            this.dgvQuartosDisponivels.Margin = new System.Windows.Forms.Padding(4);
            this.dgvQuartosDisponivels.Name = "dgvQuartosDisponivels";
            this.dgvQuartosDisponivels.RowHeadersWidth = 51;
            this.dgvQuartosDisponivels.Size = new System.Drawing.Size(880, 242);
            this.dgvQuartosDisponivels.TabIndex = 20;
            // 
            // btReservarReservaQuarto
            // 
            this.btReservarReservaQuarto.Location = new System.Drawing.Point(590, 879);
            this.btReservarReservaQuarto.Margin = new System.Windows.Forms.Padding(4);
            this.btReservarReservaQuarto.Name = "btReservarReservaQuarto";
            this.btReservarReservaQuarto.Size = new System.Drawing.Size(140, 28);
            this.btReservarReservaQuarto.TabIndex = 21;
            this.btReservarReservaQuarto.Text = "Reservar";
            this.btReservarReservaQuarto.UseVisualStyleBackColor = true;
            this.btReservarReservaQuarto.Click += new System.EventHandler(this.btReservarReservaQuarto_Click);
            // 
            // btCancelarReservaQuarto
            // 
            this.btCancelarReservaQuarto.Location = new System.Drawing.Point(753, 879);
            this.btCancelarReservaQuarto.Margin = new System.Windows.Forms.Padding(4);
            this.btCancelarReservaQuarto.Name = "btCancelarReservaQuarto";
            this.btCancelarReservaQuarto.Size = new System.Drawing.Size(140, 28);
            this.btCancelarReservaQuarto.TabIndex = 22;
            this.btCancelarReservaQuarto.Text = "Cancelar";
            this.btCancelarReservaQuarto.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(173, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(557, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "--------------------------- Reserva do Quarto ---------------------------";
            // 
            // tbCPFReservaQuarto
            // 
            this.tbCPFReservaQuarto.Location = new System.Drawing.Point(70, 79);
            this.tbCPFReservaQuarto.Margin = new System.Windows.Forms.Padding(4);
            this.tbCPFReservaQuarto.Name = "tbCPFReservaQuarto";
            this.tbCPFReservaQuarto.Size = new System.Drawing.Size(301, 22);
            this.tbCPFReservaQuarto.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Buscar Cliente por CPF:";
            // 
            // btBuscarReservaQuarto
            // 
            this.btBuscarReservaQuarto.Location = new System.Drawing.Point(404, 76);
            this.btBuscarReservaQuarto.Margin = new System.Windows.Forms.Padding(4);
            this.btBuscarReservaQuarto.Name = "btBuscarReservaQuarto";
            this.btBuscarReservaQuarto.Size = new System.Drawing.Size(100, 28);
            this.btBuscarReservaQuarto.TabIndex = 30;
            this.btBuscarReservaQuarto.Text = "Buscar";
            this.btBuscarReservaQuarto.UseVisualStyleBackColor = true;
            this.btBuscarReservaQuarto.Click += new System.EventHandler(this.btBuscarReservaQuarto_Click);
            // 
            // mkdTelefone
            // 
            this.mkdTelefone.Location = new System.Drawing.Point(514, 273);
            this.mkdTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.mkdTelefone.Mask = "(99)9999-9999";
            this.mkdTelefone.Name = "mkdTelefone";
            this.mkdTelefone.Size = new System.Drawing.Size(308, 22);
            this.mkdTelefone.TabIndex = 109;
            // 
            // mkdCelular
            // 
            this.mkdCelular.Location = new System.Drawing.Point(69, 273);
            this.mkdCelular.Margin = new System.Windows.Forms.Padding(4);
            this.mkdCelular.Mask = "(99)99999-9999";
            this.mkdCelular.Name = "mkdCelular";
            this.mkdCelular.Size = new System.Drawing.Size(308, 22);
            this.mkdCelular.TabIndex = 108;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(243, 215);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(388, 25);
            this.label28.TabIndex = 106;
            this.label28.Text = "------------------ Contato ------------------\r\n";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(69, 336);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(308, 22);
            this.tbEmail.TabIndex = 105;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(69, 316);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(51, 17);
            this.label30.TabIndex = 104;
            this.label30.Text = "E-mail:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(510, 254);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(68, 17);
            this.label31.TabIndex = 103;
            this.label31.Text = "Telefone:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(69, 254);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(56, 17);
            this.label32.TabIndex = 102;
            this.label32.Text = "Celular:";
            // 
            // tbNome
            // 
            this.tbNome.Enabled = false;
            this.tbNome.Location = new System.Drawing.Point(70, 152);
            this.tbNome.Margin = new System.Windows.Forms.Padding(4);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(434, 22);
            this.tbNome.TabIndex = 118;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(66, 131);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(49, 17);
            this.label38.TabIndex = 117;
            this.label38.Text = "Nome:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(243, 403);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(391, 25);
            this.label7.TabIndex = 121;
            this.label7.Text = "------------------ Reserva ------------------\r\n";
            // 
            // ReservaQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 920);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.mkdTelefone);
            this.Controls.Add(this.mkdCelular);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.btBuscarReservaQuarto);
            this.Controls.Add(this.tbCPFReservaQuarto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btCancelarReservaQuarto);
            this.Controls.Add(this.btReservarReservaQuarto);
            this.Controls.Add(this.dgvQuartosDisponivels);
            this.Controls.Add(this.dtpSaida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpEntrada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbQuartoReservaQuarto);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReservaQuarto";
            this.Text = "Reserva Pessoa Física";
            this.Load += new System.EventHandler(this.ReservaQuarto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuartosDisponivels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpSaida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbQuartoReservaQuarto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvQuartosDisponivels;
        private System.Windows.Forms.Button btReservarReservaQuarto;
        private System.Windows.Forms.Button btCancelarReservaQuarto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCPFReservaQuarto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btBuscarReservaQuarto;
        private System.Windows.Forms.MaskedTextBox mkdTelefone;
        private System.Windows.Forms.MaskedTextBox mkdCelular;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label7;
    }
}