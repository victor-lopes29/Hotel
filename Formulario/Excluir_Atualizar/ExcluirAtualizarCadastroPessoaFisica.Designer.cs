namespace Hotel.Formulario
{
    partial class ExcluirAtualizarCadastroPessoaFisica
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
            this.mskdTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mskdCelular = new System.Windows.Forms.MaskedTextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.tbRG = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tbSobrenome = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.cbxUF = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tbComplemento = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tbLogradouro = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.tbCEP = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBuscarPessoaFisicaExcluirAtualizar = new System.Windows.Forms.TextBox();
            this.btBuscarPessoaFisicaExcluirAtualizar = new System.Windows.Forms.Button();
            this.btAtualizarPessoaFisicaExcluirAtualizar = new System.Windows.Forms.Button();
            this.btExcluirPessoaFisicaExcluirAtualizar = new System.Windows.Forms.Button();
            this.btPessoaFisicaExcluirAtualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mskdTelefone
            // 
            this.mskdTelefone.Location = new System.Drawing.Point(305, 275);
            this.mskdTelefone.Mask = "(99)99999-9999";
            this.mskdTelefone.Name = "mskdTelefone";
            this.mskdTelefone.Size = new System.Drawing.Size(232, 20);
            this.mskdTelefone.TabIndex = 120;
            // 
            // mskdCelular
            // 
            this.mskdCelular.Location = new System.Drawing.Point(9, 275);
            this.mskdCelular.Mask = "(99)99999-9999";
            this.mskdCelular.Name = "mskdCelular";
            this.mskdCelular.Size = new System.Drawing.Size(232, 20);
            this.mskdCelular.TabIndex = 119;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(122, 226);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(299, 20);
            this.label28.TabIndex = 118;
            this.label28.Text = "------------------ Contato ------------------\r\n";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(9, 326);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(232, 20);
            this.tbEmail.TabIndex = 117;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(9, 310);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(38, 13);
            this.label30.TabIndex = 116;
            this.label30.Text = "E-mail:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(302, 259);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(52, 13);
            this.label31.TabIndex = 115;
            this.label31.Text = "Telefone:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(9, 259);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(42, 13);
            this.label32.TabIndex = 114;
            this.label32.Text = "Celular:";
            // 
            // cbxGenero
            // 
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Não binário"});
            this.cbxGenero.Location = new System.Drawing.Point(305, 193);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(232, 21);
            this.cbxGenero.TabIndex = 113;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(302, 177);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(45, 13);
            this.label33.TabIndex = 112;
            this.label33.Text = "Gênero:";
            // 
            // tbCPF
            // 
            this.tbCPF.Location = new System.Drawing.Point(305, 141);
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(232, 20);
            this.tbCPF.TabIndex = 111;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(302, 125);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(30, 13);
            this.label34.TabIndex = 110;
            this.label34.Text = "CPF:";
            // 
            // tbRG
            // 
            this.tbRG.Location = new System.Drawing.Point(9, 141);
            this.tbRG.Name = "tbRG";
            this.tbRG.Size = new System.Drawing.Size(232, 20);
            this.tbRG.TabIndex = 109;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(6, 125);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(26, 13);
            this.label35.TabIndex = 108;
            this.label35.Text = "RG:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(6, 177);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(107, 13);
            this.label36.TabIndex = 107;
            this.label36.Text = "Data de Nascimento:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(9, 193);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(232, 20);
            this.dateTimePicker2.TabIndex = 106;
            // 
            // tbSobrenome
            // 
            this.tbSobrenome.Location = new System.Drawing.Point(305, 89);
            this.tbSobrenome.Name = "tbSobrenome";
            this.tbSobrenome.Size = new System.Drawing.Size(232, 20);
            this.tbSobrenome.TabIndex = 105;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(302, 72);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(64, 13);
            this.label37.TabIndex = 104;
            this.label37.Text = "Sobrenome:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(9, 89);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(232, 20);
            this.tbNome.TabIndex = 103;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(6, 72);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(38, 13);
            this.label38.TabIndex = 102;
            this.label38.Text = "Nome:";
            // 
            // cbxUF
            // 
            this.cbxUF.FormattingEnabled = true;
            this.cbxUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbxUF.Location = new System.Drawing.Point(9, 572);
            this.cbxUF.Name = "cbxUF";
            this.cbxUF.Size = new System.Drawing.Size(232, 21);
            this.cbxUF.TabIndex = 137;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 556);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(24, 13);
            this.label20.TabIndex = 136;
            this.label20.Text = "UF:";
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(305, 520);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(232, 20);
            this.tbCidade.TabIndex = 135;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(302, 504);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 13);
            this.label21.TabIndex = 134;
            this.label21.Text = "Cidade:";
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(9, 520);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(232, 20);
            this.tbBairro.TabIndex = 133;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 504);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 13);
            this.label22.TabIndex = 132;
            this.label22.Text = "Bairro:";
            // 
            // tbComplemento
            // 
            this.tbComplemento.Location = new System.Drawing.Point(429, 466);
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.Size = new System.Drawing.Size(108, 20);
            this.tbComplemento.TabIndex = 131;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(426, 450);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(74, 13);
            this.label23.TabIndex = 130;
            this.label23.Text = "Complemento:";
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(305, 465);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(106, 20);
            this.tbNumero.TabIndex = 129;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(302, 449);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 13);
            this.label24.TabIndex = 128;
            this.label24.Text = "Número:";
            // 
            // tbLogradouro
            // 
            this.tbLogradouro.Location = new System.Drawing.Point(9, 466);
            this.tbLogradouro.Name = "tbLogradouro";
            this.tbLogradouro.Size = new System.Drawing.Size(232, 20);
            this.tbLogradouro.TabIndex = 127;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 450);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(64, 13);
            this.label25.TabIndex = 126;
            this.label25.Text = "Logradouro:";
            // 
            // tbRua
            // 
            this.tbRua.Location = new System.Drawing.Point(305, 410);
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(232, 20);
            this.tbRua.TabIndex = 125;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(302, 394);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(30, 13);
            this.label26.TabIndex = 124;
            this.label26.Text = "Rua:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(127, 354);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(294, 20);
            this.label27.TabIndex = 123;
            this.label27.Text = "----------------- Endereço ----------------";
            // 
            // tbCEP
            // 
            this.tbCEP.Location = new System.Drawing.Point(9, 410);
            this.tbCEP.Name = "tbCEP";
            this.tbCEP.Size = new System.Drawing.Size(232, 20);
            this.tbCEP.TabIndex = 122;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 394);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(31, 13);
            this.label29.TabIndex = 121;
            this.label29.Text = "CEP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 138;
            this.label1.Text = "Buscar CPF:";
            // 
            // tbBuscarPessoaFisicaExcluirAtualizar
            // 
            this.tbBuscarPessoaFisicaExcluirAtualizar.Location = new System.Drawing.Point(9, 30);
            this.tbBuscarPessoaFisicaExcluirAtualizar.Name = "tbBuscarPessoaFisicaExcluirAtualizar";
            this.tbBuscarPessoaFisicaExcluirAtualizar.Size = new System.Drawing.Size(357, 20);
            this.tbBuscarPessoaFisicaExcluirAtualizar.TabIndex = 139;
            // 
            // btBuscarPessoaFisicaExcluirAtualizar
            // 
            this.btBuscarPessoaFisicaExcluirAtualizar.Location = new System.Drawing.Point(390, 28);
            this.btBuscarPessoaFisicaExcluirAtualizar.Name = "btBuscarPessoaFisicaExcluirAtualizar";
            this.btBuscarPessoaFisicaExcluirAtualizar.Size = new System.Drawing.Size(147, 23);
            this.btBuscarPessoaFisicaExcluirAtualizar.TabIndex = 140;
            this.btBuscarPessoaFisicaExcluirAtualizar.Text = "Buscar";
            this.btBuscarPessoaFisicaExcluirAtualizar.UseVisualStyleBackColor = true;
            // 
            // btAtualizarPessoaFisicaExcluirAtualizar
            // 
            this.btAtualizarPessoaFisicaExcluirAtualizar.Location = new System.Drawing.Point(305, 615);
            this.btAtualizarPessoaFisicaExcluirAtualizar.Name = "btAtualizarPessoaFisicaExcluirAtualizar";
            this.btAtualizarPessoaFisicaExcluirAtualizar.Size = new System.Drawing.Size(106, 23);
            this.btAtualizarPessoaFisicaExcluirAtualizar.TabIndex = 141;
            this.btAtualizarPessoaFisicaExcluirAtualizar.Text = "Atualizar";
            this.btAtualizarPessoaFisicaExcluirAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizarPessoaFisicaExcluirAtualizar.Click += new System.EventHandler(this.btAtualizarPessoaFisicaExcluirAtualizar_Click);
            // 
            // btExcluirPessoaFisicaExcluirAtualizar
            // 
            this.btExcluirPessoaFisicaExcluirAtualizar.Location = new System.Drawing.Point(429, 615);
            this.btExcluirPessoaFisicaExcluirAtualizar.Name = "btExcluirPessoaFisicaExcluirAtualizar";
            this.btExcluirPessoaFisicaExcluirAtualizar.Size = new System.Drawing.Size(106, 23);
            this.btExcluirPessoaFisicaExcluirAtualizar.TabIndex = 142;
            this.btExcluirPessoaFisicaExcluirAtualizar.Text = "Excluir";
            this.btExcluirPessoaFisicaExcluirAtualizar.UseVisualStyleBackColor = true;
            // 
            // btPessoaFisicaExcluirAtualizar
            // 
            this.btPessoaFisicaExcluirAtualizar.Location = new System.Drawing.Point(9, 615);
            this.btPessoaFisicaExcluirAtualizar.Name = "btPessoaFisicaExcluirAtualizar";
            this.btPessoaFisicaExcluirAtualizar.Size = new System.Drawing.Size(106, 23);
            this.btPessoaFisicaExcluirAtualizar.TabIndex = 143;
            this.btPessoaFisicaExcluirAtualizar.Text = "Cancelar";
            this.btPessoaFisicaExcluirAtualizar.UseVisualStyleBackColor = true;
            // 
            // ExcluirAtualizarCadastroPessoaFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 650);
            this.Controls.Add(this.btPessoaFisicaExcluirAtualizar);
            this.Controls.Add(this.btExcluirPessoaFisicaExcluirAtualizar);
            this.Controls.Add(this.btAtualizarPessoaFisicaExcluirAtualizar);
            this.Controls.Add(this.btBuscarPessoaFisicaExcluirAtualizar);
            this.Controls.Add(this.tbBuscarPessoaFisicaExcluirAtualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxUF);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.tbBairro);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.tbComplemento);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.tbLogradouro);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.tbRua);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.tbCEP);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.mskdTelefone);
            this.Controls.Add(this.mskdCelular);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.cbxGenero);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.tbCPF);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.tbRG);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.tbSobrenome);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label38);
            this.Name = "ExcluirAtualizarCadastroPessoaFisica";
            this.Text = "ExcluirAtualizarCadastroPessoaFisica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskdTelefone;
        private System.Windows.Forms.MaskedTextBox mskdCelular;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox tbCPF;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox tbRG;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox tbSobrenome;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ComboBox cbxUF;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbComplemento;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tbLogradouro;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tbCEP;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBuscarPessoaFisicaExcluirAtualizar;
        private System.Windows.Forms.Button btBuscarPessoaFisicaExcluirAtualizar;
        private System.Windows.Forms.Button btAtualizarPessoaFisicaExcluirAtualizar;
        private System.Windows.Forms.Button btExcluirPessoaFisicaExcluirAtualizar;
        private System.Windows.Forms.Button btPessoaFisicaExcluirAtualizar;
    }
}