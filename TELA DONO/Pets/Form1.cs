using MySql.Data;
using MySql.Data.MySqlClient;
using BCrypt;
using System.Security.Cryptography;
namespace usúario_e_pets
{
    public partial class Form1 : Form
    {
        public string conexaocombanco = ConfiguracaoBanco.ConnectionString;
        Form2 TelaCrudDecisao = new Form2();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
            picOlho_click.Image = SystemIcons.Information.ToBitmap();
            picOlho_click.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
        private bool senhaVisivel = false;
        private void picOlho_click_Click(object sender, EventArgs e)
        {
            senhaVisivel = !senhaVisivel;
            txtSenha.UseSystemPasswordChar = !senhaVisivel;
            if (senhaVisivel)
            {
                txtSenha.UseSystemPasswordChar = false;
                picOlho_click.Image = SystemIcons.Warning.ToBitmap();
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
                picOlho_click.Image = SystemIcons.Information.ToBitmap();
            }
           if(txtSenha.PasswordChar == '*')
            {
                txtSenha.PasswordChar = '\0';

                picOlho_click.Image = SystemIcons.Warning.ToBitmap();
            }
            else
            {
                txtSenha.PasswordChar = '*';
                picOlho_click.Image = SystemIcons.Information.ToBitmap();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string query = "select senha_hash from usuarios where usuario = @usuario";
            string login = txtUsuario.Text;
            string senha = txtSenha.Text;
            string senhaCriptografada = BCrypt.Net.BCrypt.HashPassword(senha);
            if(login!="" && senha != "")
            {
                using (MySqlConnection conn = new MySqlConnection(conexaocombanco))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", login);
                        

                        using (MySqlDataReader LEITURA = cmd.ExecuteReader())
                        {
                            if (LEITURA.Read())
                            {
                               string  senhareal = LEITURA["senha_hash"].ToString();
                                bool senhacorreta = BCrypt.Net.BCrypt.Verify(senha, senhareal);
                                if (senhacorreta == true)
                                {
                                    MessageBox.Show("senha correta!!!");
                                }
                                else
                                {
                                    MessageBox.Show("senha incorreta!!!");
                                }

                            }
                        }
                    }
                }
                MessageBox.Show($"Parabéns você logou!!{login} , " +
                    $"A senha é: {senha}, a senha criptografada é: {senhaCriptografada}");

                TelaCrudDecisao.Show();

            }
        }
    }
}
