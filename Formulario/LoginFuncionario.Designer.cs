namespace Hotel.Formulario
{
    partial class LoginFuncionario
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
            this.tbCargoLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUsuarioLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSenhaLogin = new System.Windows.Forms.TextBox();
            this.btEntrarLogin = new System.Windows.Forms.Button();
            this.btCancelarLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "---------------------------- Login ----------------------------\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cargo:";
            // 
            // tbCargoLogin
            // 
            this.tbCargoLogin.Location = new System.Drawing.Point(44, 72);
            this.tbCargoLogin.Name = "tbCargoLogin";
            this.tbCargoLogin.Size = new System.Drawing.Size(255, 22);
            this.tbCargoLogin.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuário:";
            // 
            // tbUsuarioLogin
            // 
            this.tbUsuarioLogin.Location = new System.Drawing.Point(44, 128);
            this.tbUsuarioLogin.Name = "tbUsuarioLogin";
            this.tbUsuarioLogin.Size = new System.Drawing.Size(255, 22);
            this.tbUsuarioLogin.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Senha:";
            // 
            // tbSenhaLogin
            // 
            this.tbSenhaLogin.Location = new System.Drawing.Point(44, 184);
            this.tbSenhaLogin.Name = "tbSenhaLogin";
            this.tbSenhaLogin.Size = new System.Drawing.Size(255, 22);
            this.tbSenhaLogin.TabIndex = 6;
            // 
            // btEntrarLogin
            // 
            this.btEntrarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEntrarLogin.Location = new System.Drawing.Point(118, 235);
            this.btEntrarLogin.Name = "btEntrarLogin";
            this.btEntrarLogin.Size = new System.Drawing.Size(134, 23);
            this.btEntrarLogin.TabIndex = 7;
            this.btEntrarLogin.Text = "Entrar";
            this.btEntrarLogin.UseVisualStyleBackColor = true;
            // 
            // btCancelarLogin
            // 
            this.btCancelarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelarLogin.Location = new System.Drawing.Point(118, 264);
            this.btCancelarLogin.Name = "btCancelarLogin";
            this.btCancelarLogin.Size = new System.Drawing.Size(134, 23);
            this.btCancelarLogin.TabIndex = 8;
            this.btCancelarLogin.Text = "Cancelar";
            this.btCancelarLogin.UseVisualStyleBackColor = true;
            this.btCancelarLogin.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoginFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 303);
            this.Controls.Add(this.btCancelarLogin);
            this.Controls.Add(this.btEntrarLogin);
            this.Controls.Add(this.tbSenhaLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbUsuarioLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCargoLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginFuncionario";
            this.Text = "LoginFuncionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCargoLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUsuarioLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSenhaLogin;
        private System.Windows.Forms.Button btEntrarLogin;
        private System.Windows.Forms.Button btCancelarLogin;
    }
}