namespace Crud
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCadastrar = new Button();
            label1 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtCpf = new TextBox();
            txtEndereco = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(176, 350);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(127, 47);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 64);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 2;
            label1.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(122, 64);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(278, 27);
            txtNome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 126);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 4;
            label2.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(122, 126);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(278, 27);
            txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 201);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 6;
            label3.Text = "CPF:";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(122, 198);
            txtCpf.MaxLength = 11;
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(278, 27);
            txtCpf.TabIndex = 7;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(122, 265);
            txtEndereco.MaxLength = 200;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(278, 27);
            txtEndereco.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 268);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 9;
            label4.Text = "Endereço";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 450);
            Controls.Add(label4);
            Controls.Add(txtEndereco);
            Controls.Add(txtCpf);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(btnCadastrar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Funcionário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCadastrar;
        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtCpf;
        private TextBox txtEndereco;
        private Label label4;
    }
}