using System;
using System.Drawing;
using System.Windows.Forms;

namespace usúario_e_pets
{
    // Mostra a tela de donos após a tela de cadastro de pets.
    public partial class Form3
    {
        private Button? _btnAbrirTelaDonos;

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (_btnAbrirTelaDonos != null)
                return;

            _btnAbrirTelaDonos = new Button
            {
                Name = "btnAbrirTelaDonos",
                Text = "CRUD DONOS",
                Location = new Point(770, 294),
                Size = new Size(118, 32),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Cursor = Cursors.Hand
            };

            _btnAbrirTelaDonos.Click += (_, _) => AbrirTelaDonos();
            Controls.Add(_btnAbrirTelaDonos);
            _btnAbrirTelaDonos.BringToFront();
        }

        private void AbrirTelaDonos()
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
                CarregarDonosCombo();
                CarregarPets();
            }
        }
    }
}
