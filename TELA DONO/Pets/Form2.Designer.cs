namespace usúario_e_pets
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            btnCrudPET = new Button();
            btnCrudDono = new Button();
            SuspendLayout();
            // 
            // btnCrudPET
            // 
            btnCrudPET.Location = new Point(341, 124);
            btnCrudPET.Margin = new Padding(3, 4, 3, 4);
            btnCrudPET.Name = "btnCrudPET";
            btnCrudPET.Size = new Size(123, 31);
            btnCrudPET.TabIndex = 0;
            btnCrudPET.Text = "🐐CRUD PET";
            btnCrudPET.UseVisualStyleBackColor = true;
            btnCrudPET.Click += btnCrudPET_Click;
            // 
            // btnCrudDono
            // 
            btnCrudDono.Location = new Point(320, 192);
            btnCrudDono.Margin = new Padding(3, 4, 3, 4);
            btnCrudDono.Name = "btnCrudDono";
            btnCrudDono.Size = new Size(168, 31);
            btnCrudDono.TabIndex = 1;
            btnCrudDono.Text = "\U0001f9d1CRUD DONO DO PET";
            btnCrudDono.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(btnCrudDono);
            Controls.Add(btnCrudPET);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "💾CRUD";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCrudPET;
        private Button btnCrudDono;
    }
}
