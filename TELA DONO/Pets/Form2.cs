using System;
using System.Windows.Forms;

namespace usúario_e_pets
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            btnCrudDono.Click += btnCrudDono_Click;
        }

        private void btnCrudPET_Click(object sender, EventArgs e)
        {
            Form3 cadastroPet = new Form3();
            cadastroPet.Show();
            Hide();
        }

        private void btnCrudDono_Click(object? sender, EventArgs e)
        {
            Hide();
            try
            {
                using TELA_DONO.Form1 telaDono = new TELA_DONO.Form1();
                telaDono.ShowDialog(this);
            }
            finally
            {
                Show();
            }
        }
    }
}
