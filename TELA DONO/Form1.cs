namespace TELA_DONO
{
    public partial class Form1 : Form
    {
        private readonly DonoJsonRepository _repository = new();
        private readonly MaskedTextBox _cpfTextBox = new();
        private readonly TextBox _nomeTextBox = new();
        private readonly TextBox _telefoneTextBox = new();
        private readonly TextBox _emailTextBox = new();
        private readonly TextBox _enderecoTextBox = new();
        private readonly DataGridView _donosGrid = new();
        private int? _donoSelecionadoId;

        public Form1()
        {
            InitializeComponent();
            ConfigurarFormulario();
            CriarInterface();
            AtualizarLista();
        }

        private void ConfigurarFormulario()
        {
            Text = "CRUD de Donos";
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new Size(900, 650);
            ClientSize = new Size(1120, 760);
            BackColor = Color.FromArgb(243, 246, 250);
            Font = new Font("Segoe UI", 9F);
        }

        private void CriarInterface()
        {
            var titulo = new Label
            {
                Text = "Tela 2 - CRUD de Donos",
                Font = new Font("Segoe UI", 20F, FontStyle.Bold),
                ForeColor = Color.FromArgb(31, 55, 83),
                AutoSize = true,
                Location = new Point(34, 24)
            };

            var cartao = new Panel
            {
                BackColor = Color.White,
                Location = new Point(34, 76),
                Size = new Size(1052, 642),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                Padding = new Padding(22)
            };
            cartao.Paint += (_, e) => ControlPaint.DrawBorder(e.Graphics, cartao.ClientRectangle,
                Color.FromArgb(202, 215, 232), ButtonBorderStyle.Solid);

            _cpfTextBox.Mask = "000.000.000-00";
            _cpfTextBox.Font = new Font("Segoe UI", 10F);
            _cpfTextBox.Location = new Point(26, 57);
            _cpfTextBox.Size = new Size(240, 27);
            _cpfTextBox.PromptChar = ' ';

            _nomeTextBox.Location = new Point(292, 57);
            _nomeTextBox.Size = new Size(700, 27);
            _nomeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            _telefoneTextBox.Location = new Point(26, 132);
            _telefoneTextBox.Size = new Size(240, 27);

            _emailTextBox.Location = new Point(292, 132);
            _emailTextBox.Size = new Size(420, 27);
            _emailTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            _enderecoTextBox.Location = new Point(26, 207);
            _enderecoTextBox.Size = new Size(966, 27);
            _enderecoTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            cartao.Controls.AddRange(new Control[]
            {
                CriarRotulo("CPF", 26, 34), _cpfTextBox,
                CriarRotulo("Nome", 292, 34), _nomeTextBox,
                CriarRotulo("Telefone", 26, 109), _telefoneTextBox,
                CriarRotulo("E-mail", 292, 109), _emailTextBox,
                CriarRotulo("Endereço", 26, 184), _enderecoTextBox
            });

            var botoes = new FlowLayoutPanel
            {
                Location = new Point(26, 252),
                Size = new Size(966, 46),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                WrapContents = false,
                BackColor = Color.Transparent
            };
            botoes.Controls.Add(CriarBotao("SALVAR", SalvarDono));
            botoes.Controls.Add(CriarBotao("ALTERAR", AlterarDono));
            botoes.Controls.Add(CriarBotao("EXCLUIR", ExcluirDono));
            botoes.Controls.Add(CriarBotao("LIMPAR", LimparFormulario));

            ConfigurarGrade();
            _donosGrid.Location = new Point(26, 318);
            _donosGrid.Size = new Size(966, 286);
            _donosGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _donosGrid.SelectionChanged += SelecionarDono;

            cartao.Controls.Add(botoes);
            cartao.Controls.Add(_donosGrid);
            Controls.Add(titulo);
            Controls.Add(cartao);
        }

        private static Label CriarRotulo(string texto, int x, int y)
        {
            return new Label
            {
                Text = texto,
                Location = new Point(x, y),
                AutoSize = true,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.FromArgb(48, 62, 81)
            };
        }

        private static Button CriarBotao(string texto, EventHandler acao)
        {
            var botao = new Button
            {
                Text = texto,
                Size = new Size(128, 36),
                Margin = new Padding(0, 0, 18, 0),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(235, 242, 255),
                ForeColor = Color.FromArgb(35, 86, 190),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            botao.FlatAppearance.BorderColor = Color.FromArgb(73, 125, 255);
            botao.FlatAppearance.BorderSize = 1;
            botao.Click += acao;
            return botao;
        }

        private void ConfigurarGrade()
        {
            _donosGrid.AutoGenerateColumns = false;
            _donosGrid.AllowUserToAddRows = false;
            _donosGrid.AllowUserToDeleteRows = false;
            _donosGrid.AllowUserToResizeRows = false;
            _donosGrid.ReadOnly = true;
            _donosGrid.MultiSelect = false;
            _donosGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _donosGrid.RowHeadersVisible = false;
            _donosGrid.BackgroundColor = Color.White;
            _donosGrid.BorderStyle = BorderStyle.FixedSingle;
            _donosGrid.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            _donosGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(232, 238, 246);
            _donosGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(48, 62, 81);
            _donosGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            _donosGrid.EnableHeadersVisualStyles = false;
            _donosGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(213, 229, 255);
            _donosGrid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(31, 55, 83);
            _donosGrid.RowTemplate.Height = 30;

            AdicionarColuna("Id", "ID", 55, DataGridViewAutoSizeColumnMode.None);
            AdicionarColuna("Cpf", "CPF", 140);
            AdicionarColuna("Nome", "Nome", 190);
            AdicionarColuna("Telefone", "Telefone", 150);
            AdicionarColuna("Email", "E-mail", 180);
            AdicionarColuna("Endereco", "Endereço", 250);
        }

        private void AdicionarColuna(string propriedade, string titulo, int largura,
            DataGridViewAutoSizeColumnMode modo = DataGridViewAutoSizeColumnMode.Fill)
        {
            _donosGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = propriedade,
                HeaderText = titulo,
                Name = propriedade,
                AutoSizeMode = modo,
                Width = largura,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });
        }

        private void AtualizarLista()
        {
            _donosGrid.DataSource = null;
            _donosGrid.DataSource = _repository.Listar();
            _donosGrid.ClearSelection();
            _donoSelecionadoId = null;
        }

        private void SalvarDono(object? sender, EventArgs e)
        {
            if (!TentarCriarDono(out var dono))
            {
                return;
            }

            ExecutarOperacao(() => _repository.Adicionar(dono), "Dono cadastrado com sucesso.");
        }

        private void AlterarDono(object? sender, EventArgs e)
        {
            if (_donoSelecionadoId is null)
            {
                MostrarAviso("Selecione um dono na lista para alterar.");
                return;
            }

            if (!TentarCriarDono(out var dono))
            {
                return;
            }

            dono.Id = _donoSelecionadoId.Value;
            ExecutarOperacao(() => _repository.Atualizar(dono), "Dados do dono alterados com sucesso.");
        }

        private void ExcluirDono(object? sender, EventArgs e)
        {
            if (_donoSelecionadoId is null)
            {
                MostrarAviso("Selecione um dono na lista para excluir.");
                return;
            }

            var confirmacao = MessageBox.Show("Deseja realmente excluir este dono?", "Confirmar exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacao != DialogResult.Yes)
            {
                return;
            }

            ExecutarOperacao(() => _repository.Excluir(_donoSelecionadoId.Value), "Dono excluído com sucesso.");
        }

        private void LimparFormulario(object? sender, EventArgs e)
        {
            _cpfTextBox.Clear();
            _nomeTextBox.Clear();
            _telefoneTextBox.Clear();
            _emailTextBox.Clear();
            _enderecoTextBox.Clear();
            _donosGrid.ClearSelection();
            _donoSelecionadoId = null;
            _cpfTextBox.Focus();
        }

        private bool TentarCriarDono(out Dono dono)
        {
            dono = new Dono();
            var cpf = new string(_cpfTextBox.Text.Where(char.IsDigit).ToArray());
            if (cpf.Length != 11 || string.IsNullOrWhiteSpace(_nomeTextBox.Text) ||
                string.IsNullOrWhiteSpace(_telefoneTextBox.Text) || string.IsNullOrWhiteSpace(_emailTextBox.Text) ||
                string.IsNullOrWhiteSpace(_enderecoTextBox.Text))
            {
                MostrarAviso("Preencha todos os campos e informe um CPF com 11 dígitos.");
                return false;
            }

            try
            {
                _ = new System.Net.Mail.MailAddress(_emailTextBox.Text.Trim());
            }
            catch (FormatException)
            {
                MostrarAviso("Informe um endereço de e-mail válido.");
                return false;
            }

            dono = new Dono
            {
                Cpf = _cpfTextBox.Text.Trim(),
                Nome = _nomeTextBox.Text.Trim(),
                Telefone = _telefoneTextBox.Text.Trim(),
                Email = _emailTextBox.Text.Trim(),
                Endereco = _enderecoTextBox.Text.Trim()
            };
            return true;
        }

        private void ExecutarOperacao(Action operacao, string mensagemSucesso)
        {
            try
            {
                operacao();
                AtualizarLista();
                LimparFormulario(this, EventArgs.Empty);
                MessageBox.Show(mensagemSucesso, "CRUD de Donos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidOperationException ex)
            {
                MostrarAviso(ex.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Não foi possível salvar os dados: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelecionarDono(object? sender, EventArgs e)
        {
            if (_donosGrid.CurrentRow?.DataBoundItem is not Dono dono)
            {
                return;
            }

            _donoSelecionadoId = dono.Id;
            _cpfTextBox.Text = dono.Cpf;
            _nomeTextBox.Text = dono.Nome;
            _telefoneTextBox.Text = dono.Telefone;
            _emailTextBox.Text = dono.Email;
            _enderecoTextBox.Text = dono.Endereco;
        }

        private static void MostrarAviso(string mensagem)
        {
            MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
