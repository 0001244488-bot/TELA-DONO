namespace usúario_e_pets
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            txtNomePet = new TextBox();
            txtEmail = new TextBox();
            lblNomePet = new Label();
            lblDonoPet = new Label();
            lblTel = new Label();
            lblEmail = new Label();
            txtTelefone = new TextBox();
            label1 = new Label();
            lblPorte = new Label();
            cmbPorte = new ComboBox();
            cbNao = new CheckBox();
            cbSim = new CheckBox();
            lblVacina = new Label();
            cmbEspecie = new ComboBox();
            lblEspecie = new Label();
            lblCor = new Label();
            cbCnao = new CheckBox();
            cbCSim = new CheckBox();
            label4 = new Label();
            lblDoenca = new Label();
            txtDoenca = new TextBox();
            btnSalvar = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            dgvCarrgarDados = new DataGridView();
            txtCor = new TextBox();
            txtRaca = new TextBox();
            lblRaca = new Label();
            btnPesquisar = new Button();
            txtPesquisar = new TextBox();
            cbFeminino = new CheckBox();
            cbMasculino = new CheckBox();
            label2 = new Label();
            cboDono = new ComboBox();
            nudIdadePet = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvCarrgarDados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudIdadePet).BeginInit();
            SuspendLayout();
            // 
            // txtNomePet
            // 
            txtNomePet.Location = new Point(0, 36);
            txtNomePet.Margin = new Padding(3, 4, 3, 4);
            txtNomePet.Name = "txtNomePet";
            txtNomePet.PlaceholderText = "Digite o Nome do Pet";
            txtNomePet.Size = new Size(156, 27);
            txtNomePet.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(677, 37);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Digite seu Email";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(141, 27);
            txtEmail.TabIndex = 3;
            // 
            // lblNomePet
            // 
            lblNomePet.AutoSize = true;
            lblNomePet.BackColor = SystemColors.Control;
            lblNomePet.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomePet.Location = new Point(0, 9);
            lblNomePet.Name = "lblNomePet";
            lblNomePet.Size = new Size(174, 23);
            lblNomePet.TabIndex = 5;
            lblNomePet.Text = "🐶Nome Do Animal";
            // 
            // lblDonoPet
            // 
            lblDonoPet.AutoSize = true;
            lblDonoPet.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDonoPet.Location = new Point(241, 11);
            lblDonoPet.Name = "lblDonoPet";
            lblDonoPet.Size = new Size(165, 23);
            lblDonoPet.TabIndex = 6;
            lblDonoPet.Text = "\U0001f9d1Dono do Animal";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTel.Location = new Point(446, 12);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(175, 23);
            lblTel.TabIndex = 7;
            lblTel.Text = "📞Telefone do Dono";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(677, 12);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(159, 23);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "📧E-mail do Dono";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(446, 39);
            txtTelefone.Margin = new Padding(3, 4, 3, 4);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Digite seu Telefone";
            txtTelefone.ReadOnly = true;
            txtTelefone.Size = new Size(175, 27);
            txtTelefone.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 114);
            label1.Name = "label1";
            label1.Size = new Size(167, 23);
            label1.TabIndex = 11;
            label1.Text = "🎂Idade do Animal";
            // 
            // lblPorte
            // 
            lblPorte.AutoSize = true;
            lblPorte.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPorte.Location = new Point(193, 111);
            lblPorte.Name = "lblPorte";
            lblPorte.Size = new Size(76, 23);
            lblPorte.TabIndex = 13;
            lblPorte.Text = "🐕‍\U0001f9baPorte";
            // 
            // cmbPorte
            // 
            cmbPorte.DisplayMember = "medio";
            cmbPorte.FormattingEnabled = true;
            cmbPorte.Items.AddRange(new object[] { "Pequeno", "Médio", "Grande" });
            cmbPorte.Location = new Point(193, 138);
            cmbPorte.Margin = new Padding(3, 4, 3, 4);
            cmbPorte.Name = "cmbPorte";
            cmbPorte.Size = new Size(138, 28);
            cmbPorte.TabIndex = 14;
            cmbPorte.SelectedIndexChanged += cmbPorte_SelectedIndexChanged;
            // 
            // cbNao
            // 
            cbNao.AutoSize = true;
            cbNao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbNao.Location = new Point(758, 140);
            cbNao.Name = "cbNao";
            cbNao.Size = new Size(60, 24);
            cbNao.TabIndex = 20;
            cbNao.Text = "Não";
            cbNao.UseVisualStyleBackColor = true;
            cbNao.CheckedChanged += cbNao_CheckedChanged;
            // 
            // cbSim
            // 
            cbSim.AutoSize = true;
            cbSim.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbSim.Location = new Point(660, 138);
            cbSim.Name = "cbSim";
            cbSim.Size = new Size(57, 24);
            cbSim.TabIndex = 19;
            cbSim.Text = "Sim";
            cbSim.UseVisualStyleBackColor = true;
            cbSim.CheckedChanged += cbSim_CheckedChanged;
            // 
            // lblVacina
            // 
            lblVacina.AutoSize = true;
            lblVacina.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVacina.Location = new Point(660, 114);
            lblVacina.Name = "lblVacina";
            lblVacina.Size = new Size(278, 23);
            lblVacina.TabIndex = 18;
            lblVacina.Text = "💉Vacina da raiva no último ano?";
            // 
            // cmbEspecie
            // 
            cmbEspecie.DisplayMember = "medio";
            cmbEspecie.FormattingEnabled = true;
            cmbEspecie.Items.AddRange(new object[] { " cachorro", " gato", " passar", " peixe", " coelho", " hamster", " tartaruga", " iguana", " cobra", " outros" });
            cmbEspecie.Location = new Point(0, 238);
            cmbEspecie.Margin = new Padding(3, 4, 3, 4);
            cmbEspecie.Name = "cmbEspecie";
            cmbEspecie.Size = new Size(138, 28);
            cmbEspecie.TabIndex = 22;
            cmbEspecie.SelectedIndexChanged += cmbEspecie_SelectedIndexChanged;
            // 
            // lblEspecie
            // 
            lblEspecie.AutoSize = true;
            lblEspecie.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEspecie.Location = new Point(0, 211);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(92, 23);
            lblEspecie.TabIndex = 21;
            lblEspecie.Text = "🐈Especíe";
            // 
            // lblCor
            // 
            lblCor.AutoSize = true;
            lblCor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCor.Location = new Point(193, 211);
            lblCor.Name = "lblCor";
            lblCor.Size = new Size(62, 23);
            lblCor.TabIndex = 24;
            lblCor.Text = "🎨Cor";
            // 
            // cbCnao
            // 
            cbCnao.AutoSize = true;
            cbCnao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbCnao.Location = new Point(481, 240);
            cbCnao.Name = "cbCnao";
            cbCnao.Size = new Size(60, 24);
            cbCnao.TabIndex = 28;
            cbCnao.Text = "Não";
            cbCnao.UseVisualStyleBackColor = true;
            cbCnao.CheckedChanged += cbCnao_CheckedChanged;
            // 
            // cbCSim
            // 
            cbCSim.AutoSize = true;
            cbCSim.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbCSim.Location = new Point(400, 240);
            cbCSim.Name = "cbCSim";
            cbCSim.Size = new Size(57, 24);
            cbCSim.TabIndex = 27;
            cbCSim.Text = "Sim";
            cbCSim.UseVisualStyleBackColor = true;
            cbCSim.CheckedChanged += cbCSim_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(400, 211);
            label4.Name = "label4";
            label4.Size = new Size(105, 23);
            label4.TabIndex = 26;
            label4.Text = "✂️Castrado";
            // 
            // lblDoenca
            // 
            lblDoenca.AutoSize = true;
            lblDoenca.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDoenca.Location = new Point(752, 211);
            lblDoenca.Name = "lblDoenca";
            lblDoenca.Size = new Size(100, 23);
            lblDoenca.TabIndex = 30;
            lblDoenca.Text = "🤒Doenças";
            // 
            // txtDoenca
            // 
            txtDoenca.Location = new Point(752, 235);
            txtDoenca.Margin = new Padding(3, 4, 3, 4);
            txtDoenca.Name = "txtDoenca";
            txtDoenca.PlaceholderText = "Digite a Doença do Animal";
            txtDoenca.Size = new Size(186, 27);
            txtDoenca.TabIndex = 29;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.ActiveCaption;
            btnSalvar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = SystemColors.Highlight;
            btnSalvar.Location = new Point(40, 294);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(138, 32);
            btnSalvar.TabIndex = 31;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = SystemColors.ActiveCaption;
            btnAlterar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterar.ForeColor = SystemColors.Highlight;
            btnAlterar.Location = new Point(233, 294);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(138, 32);
            btnAlterar.TabIndex = 32;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = SystemColors.ActiveCaption;
            btnExcluir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = SystemColors.Highlight;
            btnExcluir.Location = new Point(425, 294);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(138, 32);
            btnExcluir.TabIndex = 33;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = SystemColors.ActiveCaption;
            btnLimpar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = SystemColors.Highlight;
            btnLimpar.Location = new Point(619, 294);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(138, 32);
            btnLimpar.TabIndex = 34;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // dgvCarrgarDados
            // 
            dgvCarrgarDados.BackgroundColor = SystemColors.ControlLightLight;
            dgvCarrgarDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrgarDados.Location = new Point(12, 403);
            dgvCarrgarDados.Name = "dgvCarrgarDados";
            dgvCarrgarDados.RowHeadersWidth = 51;
            dgvCarrgarDados.Size = new Size(878, 195);
            dgvCarrgarDados.TabIndex = 35;
            dgvCarrgarDados.CellContentClick += dgvCarrgarDados_CellContentClick;
            // 
            // txtCor
            // 
            txtCor.Location = new Point(193, 235);
            txtCor.Margin = new Padding(3, 4, 3, 4);
            txtCor.Name = "txtCor";
            txtCor.PlaceholderText = "Digite a Cor do Animal";
            txtCor.Size = new Size(167, 27);
            txtCor.TabIndex = 36;
            // 
            // txtRaca
            // 
            txtRaca.Location = new Point(560, 235);
            txtRaca.Margin = new Padding(3, 4, 3, 4);
            txtRaca.Name = "txtRaca";
            txtRaca.PlaceholderText = "Digite a Raça do Animal";
            txtRaca.Size = new Size(167, 27);
            txtRaca.TabIndex = 38;
            // 
            // lblRaca
            // 
            lblRaca.AutoSize = true;
            lblRaca.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRaca.Location = new Point(559, 211);
            lblRaca.Name = "lblRaca";
            lblRaca.Size = new Size(47, 23);
            lblRaca.TabIndex = 37;
            lblRaca.Text = "Raça";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(447, 368);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(122, 29);
            btnPesquisar.TabIndex = 39;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(12, 370);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquise um nome";
            txtPesquisar.Size = new Size(419, 27);
            txtPesquisar.TabIndex = 40;
            // 
            // cbFeminino
            // 
            cbFeminino.AutoSize = true;
            cbFeminino.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbFeminino.Location = new Point(508, 140);
            cbFeminino.Name = "cbFeminino";
            cbFeminino.Size = new Size(96, 24);
            cbFeminino.TabIndex = 17;
            cbFeminino.Text = "Feminino";
            cbFeminino.UseVisualStyleBackColor = true;
            cbFeminino.CheckedChanged += cbFeminino_CheckedChanged;
            // 
            // cbMasculino
            // 
            cbMasculino.AutoSize = true;
            cbMasculino.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbMasculino.Location = new Point(400, 140);
            cbMasculino.Name = "cbMasculino";
            cbMasculino.Size = new Size(102, 24);
            cbMasculino.TabIndex = 16;
            cbMasculino.Text = "Masculino";
            cbMasculino.UseVisualStyleBackColor = true;
            cbMasculino.CheckedChanged += cbMasculino_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(400, 111);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 15;
            label2.Text = "♂️♀️Sexo";
            // 
            // cboDono
            // 
            cboDono.FormattingEnabled = true;
            cboDono.Location = new Point(241, 35);
            cboDono.Name = "cboDono";
            cboDono.Size = new Size(151, 28);
            cboDono.TabIndex = 41;
            cboDono.SelectedIndexChanged += cboDono_SelectedIndexChanged;
            // 
            // nudIdadePet
            // 
            nudIdadePet.Location = new Point(0, 140);
            nudIdadePet.Name = "nudIdadePet";
            nudIdadePet.Size = new Size(167, 27);
            nudIdadePet.TabIndex = 42;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(934, 600);
            Controls.Add(nudIdadePet);
            Controls.Add(cboDono);
            Controls.Add(txtPesquisar);
            Controls.Add(btnPesquisar);
            Controls.Add(txtRaca);
            Controls.Add(lblRaca);
            Controls.Add(txtCor);
            Controls.Add(dgvCarrgarDados);
            Controls.Add(btnLimpar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(btnSalvar);
            Controls.Add(lblDoenca);
            Controls.Add(txtDoenca);
            Controls.Add(cbCnao);
            Controls.Add(cbCSim);
            Controls.Add(label4);
            Controls.Add(lblCor);
            Controls.Add(cmbEspecie);
            Controls.Add(lblEspecie);
            Controls.Add(cbNao);
            Controls.Add(cbSim);
            Controls.Add(lblVacina);
            Controls.Add(cbFeminino);
            Controls.Add(cbMasculino);
            Controls.Add(label2);
            Controls.Add(cmbPorte);
            Controls.Add(lblPorte);
            Controls.Add(label1);
            Controls.Add(txtTelefone);
            Controls.Add(lblEmail);
            Controls.Add(lblTel);
            Controls.Add(lblDonoPet);
            Controls.Add(lblNomePet);
            Controls.Add(txtEmail);
            Controls.Add(txtNomePet);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            Text = "🗝️TELA DE CADASTRO DE PET";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarrgarDados).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudIdadePet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomePet;
        private TextBox textBox3;
        private TextBox txtEmail;
        private Label lblNomePet;
        private Label lblDonoPet;
        private Label lblTel;
        private Label lblEmail;
        private TextBox txtTelefone;
        private Label label1;
        private Label lblPorte;
        private ComboBox cmbPorte;
        private CheckBox cbNao;
        private CheckBox cbSim;
        private Label lblVacina;
        private ComboBox cmbEspecie;
        private Label lblEspecie;
        private Label lblCor;
        private CheckBox cbCnao;
        private CheckBox cbCSim;
        private Label label4;
        private Label lblDoenca;
        private TextBox txtDoenca;
        private Button btnSalvar;
        private Button btnAlterar;
        private Button btnExcluir;
        private Button btnLimpar;
        private DataGridView dgvCarrgarDados;
        private TextBox txtCor;
        private TextBox txtRaca;
        private Label lblRaca;
        private Button btnPesquisar;
        private TextBox txtPesquisar;
        private CheckBox cbFeminino;
        private CheckBox cbMasculino;
        private Label label2;
        private ComboBox cboDono;
        private NumericUpDown nudIdadePet;
    }
}
