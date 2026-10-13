namespace usúario_e_pets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            lblSenha = new Label();
            btnEntrar = new Button();
            grpBoxLogin = new GroupBox();
            picOlho_click = new PictureBox();
            lblSingIn = new Label();
            grpBoxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picOlho_click).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.Red;
            lblUsuario.Location = new Point(16, 89);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(103, 34);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Username";
            lblUsuario.Click += label1_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(117, 89);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(214, 27);
            txtUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(117, 141);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(214, 27);
            txtSenha.TabIndex = 3;
            txtSenha.TextChanged += txtSenha_TextChanged;
            txtSenha.KeyPress += txtSenha_KeyPress;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.BackColor = Color.Transparent;
            lblSenha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.ForeColor = Color.Gold;
            lblSenha.Location = new Point(0, 144);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(112, 28);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Passaword";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.Snow;
            btnEntrar.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.Red;
            btnEntrar.Location = new Point(134, 199);
            btnEntrar.Margin = new Padding(3, 4, 3, 4);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(122, 51);
            btnEntrar.TabIndex = 6;
            btnEntrar.Text = "Join";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // grpBoxLogin
            // 
            grpBoxLogin.Controls.Add(picOlho_click);
            grpBoxLogin.Controls.Add(lblSingIn);
            grpBoxLogin.Controls.Add(lblUsuario);
            grpBoxLogin.Controls.Add(btnEntrar);
            grpBoxLogin.Controls.Add(txtUsuario);
            grpBoxLogin.Controls.Add(txtSenha);
            grpBoxLogin.Controls.Add(lblSenha);
            grpBoxLogin.Location = new Point(227, 91);
            grpBoxLogin.Margin = new Padding(3, 4, 3, 4);
            grpBoxLogin.Name = "grpBoxLogin";
            grpBoxLogin.Padding = new Padding(3, 4, 3, 4);
            grpBoxLogin.Size = new Size(410, 347);
            grpBoxLogin.TabIndex = 7;
            grpBoxLogin.TabStop = false;
            grpBoxLogin.Text = "                                                                            ";
            // 
            // picOlho_click
            // 
            picOlho_click.BackColor = Color.Transparent;
            picOlho_click.BackgroundImageLayout = ImageLayout.Stretch;
            picOlho_click.ErrorImage = null;
            picOlho_click.Location = new Point(349, 144);
            picOlho_click.Margin = new Padding(3, 4, 3, 4);
            picOlho_click.Name = "picOlho_click";
            picOlho_click.Size = new Size(21, 24);
            picOlho_click.SizeMode = PictureBoxSizeMode.Zoom;
            picOlho_click.TabIndex = 8;
            picOlho_click.TabStop = false;
            picOlho_click.Click += picOlho_click_Click;
            // 
            // lblSingIn
            // 
            lblSingIn.AutoSize = true;
            lblSingIn.BackColor = Color.Transparent;
            lblSingIn.Font = new Font("Elephant", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSingIn.ForeColor = Color.Gold;
            lblSingIn.Location = new Point(130, 25);
            lblSingIn.Name = "lblSingIn";
            lblSingIn.Size = new Size(134, 38);
            lblSingIn.TabIndex = 7;
            lblSingIn.Text = "Sing In";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(953, 534);
            Controls.Add(grpBoxLogin);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            grpBoxLogin.ResumeLayout(false);
            grpBoxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picOlho_click).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblUsuario;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label lblSenha;
        private Button btnEntrar;
        private GroupBox grpBoxLogin;
        private Label lblSingIn;
        private PictureBox picOlho_click;
    }
}

