
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data;
using Mysqlx.Crud;
using System.Data;
using MySql.Data.MySqlClient;

namespace usúario_e_pets
{
    public partial class Form3 : Form
    {
        public int id = 0;
        public string conexaocombanco = ConfiguracaoBanco.ConnectionString;database=petshop_tecnico;uid=root;pwd=piclas@12;";
        Form2 CrudPet = new Form2();

        private int idPetSelecionado = 0;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CarregarPets();
            CarregarDonosCombo();
        }

        private void cmbPorte_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cboDono.SelectedValue == null)
            {
                MessageBox.Show("Selecione um dono para o animal.");
                return;
            }

            string sexo = cbMasculino.Checked ? "Masculino" : "Feminino";
            bool vacina = cbSim.Checked;
            bool castrado = cbCSim.Checked;

            using MySqlConnection conexao = new MySqlConnection(conexaocombanco);

            string sql = @"INSERT INTO pets
                (nome, idade, porte, sexo, vacina_raiva, especie, cor, raca, castrado, doencas, id_dono)
                VALUES
                (@nome, @idade, @porte, @sexo, @vacina, @especie, @cor, @raca, @castrado, @doencas, @id_dono)";

            using MySqlCommand cmd = new MySqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@nome", txtNomePet.Text);
            cmd.Parameters.AddWithValue("@idade", (int)nudIdadePet.Value);
            cmd.Parameters.AddWithValue("@porte", cmbPorte.Text);
            cmd.Parameters.AddWithValue("@sexo", sexo);
            cmd.Parameters.AddWithValue("@vacina", vacina);
            cmd.Parameters.AddWithValue("@especie", cmbEspecie.Text);
            cmd.Parameters.AddWithValue("@cor", txtCor.Text);
            cmd.Parameters.AddWithValue("@raca", txtRaca.Text);
            cmd.Parameters.AddWithValue("@castrado", castrado);
            cmd.Parameters.AddWithValue("@doencas", txtDoenca.Text);
            cmd.Parameters.AddWithValue("@id_dono", cboDono.SelectedValue);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("PET cadastrado com sucesso!");

                CarregarPets();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar PET: " + ex.Message);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string buscar = txtNomePet.Text;
            BuscarDados(buscar);
        }

        public void BuscarDados(string busca)
        {
            string queryPesquisa;

            if (string.IsNullOrEmpty(busca))
            {
                queryPesquisa = "SELECT * FROM pets";
            }
            else
            {
                queryPesquisa = "SELECT * FROM pets WHERE nome LIKE @busca";
            }

            using (MySqlConnection conexao = new MySqlConnection(conexaocombanco))
            using (MySqlCommand comando = new MySqlCommand(queryPesquisa, conexao))
            {
                if (!string.IsNullOrEmpty(busca))
                {
                    comando.Parameters.AddWithValue("@busca", "%" + busca + "%");
                }

                try
                {
                    using (MySqlDataAdapter selectao = new MySqlDataAdapter(comando))
                    {
                        DataTable tabelagrid = new DataTable();
                        selectao.Fill(tabelagrid);

                        dgvCarrgarDados.DataSource = tabelagrid;

                        if (dgvCarrgarDados.Columns.Contains("id_pet"))
                            dgvCarrgarDados.Columns["id_pet"].HeaderText = "ID";

                        if (dgvCarrgarDados.Columns.Contains("nome"))
                            dgvCarrgarDados.Columns["nome"].HeaderText = "Nome Do Animal";

                        if (dgvCarrgarDados.Columns.Contains("idade"))
                            dgvCarrgarDados.Columns["idade"].HeaderText = "Idade";

                        if (dgvCarrgarDados.Columns.Contains("porte"))
                            dgvCarrgarDados.Columns["porte"].HeaderText = "Porte";

                        if (dgvCarrgarDados.Columns.Contains("sexo"))
                            dgvCarrgarDados.Columns["sexo"].HeaderText = "Sexo";

                        if (dgvCarrgarDados.Columns.Contains("vacina_raiva"))
                            dgvCarrgarDados.Columns["vacina_raiva"].HeaderText = "Vacina Raiva";

                        if (dgvCarrgarDados.Columns.Contains("especie"))
                            dgvCarrgarDados.Columns["especie"].HeaderText = "Especie";

                        if (dgvCarrgarDados.Columns.Contains("cor"))
                            dgvCarrgarDados.Columns["cor"].HeaderText = "Cor";

                        if (dgvCarrgarDados.Columns.Contains("raca"))
                            dgvCarrgarDados.Columns["raca"].HeaderText = "Raça";

                        if (dgvCarrgarDados.Columns.Contains("castrado"))
                            dgvCarrgarDados.Columns["castrado"].HeaderText = "Castrado";

                        if (dgvCarrgarDados.Columns.Contains("doencas"))
                            dgvCarrgarDados.Columns["doencas"].HeaderText = "Doenças";

                        if (dgvCarrgarDados.Columns.Contains("id_dono"))
                            dgvCarrgarDados.Columns["id_dono"].HeaderText = "ID do Dono";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um Erro: {ex.Message}");
                }
            }
        }

        private void cbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMasculino.Checked)
            {
                cbFeminino.Checked = false;
            }
        }

        private void cbFeminino_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFeminino.Checked)
            {
                cbMasculino.Checked = false;
            }
        }

        private void cbSim_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSim.Checked)
            {
                cbNao.Checked = false;
            }
        }

        private void cbNao_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNao.Checked)
            {
                cbSim.Checked = false;
            }
        }

        private void cbCSim_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCSim.Checked)
            {
                cbCnao.Checked = false;
            }
        }

        private void cbCnao_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCnao.Checked)
            {
                cbCSim.Checked = false;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomePet.Clear();
            nudIdadePet.Value = 0;
            cmbPorte.SelectedIndex = -1;

            cbMasculino.Checked = false;
            cbFeminino.Checked = false;

            cbSim.Checked = false;
            cbNao.Checked = false;

            cmbEspecie.SelectedIndex = -1;

            txtCor.Clear();
            txtRaca.Clear();

            cbCSim.Checked = false;
            cbCnao.Checked = false;

            txtDoenca.Clear();

            cboDono.SelectedIndex = -1;

            idPetSelecionado = 0;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (idPetSelecionado == 0)
            {
                MessageBox.Show("Selecione um PET para alterar.");
                return;
            }

            if (cboDono.SelectedValue == null)
            {
                MessageBox.Show("Selecione um dono.");
                return;
            }

            string sexo = cbMasculino.Checked ? "Masculino" : "Feminino";

            using MySqlConnection conexao = new MySqlConnection(conexaocombanco);

            string sql = @"UPDATE pets SET
                nome=@nome,
                idade=@idade,
                porte=@porte,
                sexo=@sexo,
                vacina_raiva=@vacina,
                especie=@especie,
                cor=@cor,
                raca=@raca,
                castrado=@castrado,
                doencas=@doencas,
                id_dono=@id_dono
                WHERE id_pet=@id_pet";

            using MySqlCommand cmd = new MySqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@nome", txtNomePet.Text);
            cmd.Parameters.AddWithValue("@idade", (int)nudIdadePet.Value);
            cmd.Parameters.AddWithValue("@porte", cmbPorte.Text);
            cmd.Parameters.AddWithValue("@sexo", sexo);
            cmd.Parameters.AddWithValue("@vacina", cbSim.Checked);
            cmd.Parameters.AddWithValue("@especie", cmbEspecie.Text);
            cmd.Parameters.AddWithValue("@cor", txtCor.Text);
            cmd.Parameters.AddWithValue("@raca", txtRaca.Text);
            cmd.Parameters.AddWithValue("@castrado", cbCSim.Checked);
            cmd.Parameters.AddWithValue("@doencas", txtDoenca.Text);
            cmd.Parameters.AddWithValue("@id_dono", cboDono.SelectedValue);
            cmd.Parameters.AddWithValue("@id_pet", idPetSelecionado);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("PET alterado com sucesso!");

                CarregarPets();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar PET: " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (idPetSelecionado == 0)
            {
                MessageBox.Show("Selecione um PET para excluir.");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Deseja realmente excluir este PET?",
                "Confirmação",
                MessageBoxButtons.YesNo);

            if (resposta != DialogResult.Yes)
                return;

            using MySqlConnection conexao = new MySqlConnection(conexaocombanco);

            string sql = "DELETE FROM pets WHERE id_pet=@id";

            using MySqlCommand cmd = new MySqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@id", idPetSelecionado);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("PET excluído com sucesso!");

                CarregarPets();
                idPetSelecionado = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir PET: " + ex.Message);
            }
        }

        private void CarregarDonosCombo()
        {
            using MySqlConnection conexao = new MySqlConnection(conexaocombanco);

            string sql = "SELECT id_dono, nome FROM donos ORDER BY nome";

            using MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexao);

            DataTable tabela = new DataTable();

            try
            {
                adapter.Fill(tabela);

                cboDono.DataSource = tabela;
                cboDono.DisplayMember = "nome";
                cboDono.ValueMember = "id_dono";
                cboDono.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar donos: " + ex.Message);
            }
        }

        private void cboDono_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDono.SelectedValue == null)
                return;

            if (!int.TryParse(cboDono.SelectedValue.ToString(), out int idDono))
                return;

            using MySqlConnection conexao = new MySqlConnection(conexaocombanco);

            string sql = "SELECT telefone, email FROM donos WHERE id_dono=@id";

            using MySqlCommand cmd = new MySqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@id", idDono);

            try
            {
                conexao.Open();

                using MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtTelefone.Text = reader["telefone"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do dono: " + ex.Message);
            }
        }

        private void CarregarPets()
        {
            using MySqlConnection conexao = new MySqlConnection(conexaocombanco);

            string sql = @"SELECT
                p.id_pet,
                p.nome AS pet,
                d.nome AS dono,
                p.idade,
                p.porte,
                p.sexo,
                p.especie,
                p.cor,
                p.raca,
                p.vacina_raiva,
                p.castrado,
                p.doencas,
                p.id_dono
                FROM pets p
                INNER JOIN donos d ON d.id_dono = p.id_dono
                ORDER BY p.nome";

            using MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexao);

            DataTable tabela = new DataTable();

            try
            {
                adapter.Fill(tabela);
                dgvCarrgarDados.DataSource = tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar PETs: " + ex.Message);
            }
        }

        private void dgvCarrgarDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow linha = dgvCarrgarDados.Rows[e.RowIndex];

            if (linha.Cells["id_pet"].Value == null)
                return;

            idPetSelecionado = Convert.ToInt32(linha.Cells["id_pet"].Value);

            txtNomePet.Text = linha.Cells["pet"].Value?.ToString() ?? "";

            if (linha.Cells["idade"].Value != DBNull.Value)
                nudIdadePet.Value = Convert.ToDecimal(linha.Cells["idade"].Value);

            cmbPorte.Text = linha.Cells["porte"].Value?.ToString() ?? "";
            cmbEspecie.Text = linha.Cells["especie"].Value?.ToString() ?? "";

            txtCor.Text = linha.Cells["cor"].Value?.ToString() ?? "";
            txtRaca.Text = linha.Cells["raca"].Value?.ToString() ?? "";
            txtDoenca.Text = linha.Cells["doencas"].Value?.ToString() ?? "";

            if (linha.Cells["id_dono"].Value != DBNull.Value)
            {
                cboDono.SelectedValue = linha.Cells["id_dono"].Value;
            }

            string sexo = linha.Cells["sexo"].Value?.ToString() ?? "";

            cbMasculino.Checked = sexo == "Masculino";
            cbFeminino.Checked = sexo == "Feminino";

            bool vacina = false;

            if (linha.Cells["vacina_raiva"].Value != DBNull.Value)
                vacina = Convert.ToBoolean(linha.Cells["vacina_raiva"].Value);

            cbSim.Checked = vacina;
            cbNao.Checked = !vacina;

            bool castrado = false;

            if (linha.Cells["castrado"].Value != DBNull.Value)
                castrado = Convert.ToBoolean(linha.Cells["castrado"].Value);

            cbCSim.Checked = castrado;
            cbCnao.Checked = !castrado;
        }
    }
}
