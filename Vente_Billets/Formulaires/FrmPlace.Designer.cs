
namespace Vente_Billets.Formulaires
{
    partial class FrmPlace
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
            this.BtnDeleteAgent = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateAgent = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAjouterAgent = new Guna.UI2.WinForms.Guna2Button();
            this.txtIdPlace = new Guna.UI2.WinForms.Guna2TextBox();
            this.id = new System.Windows.Forms.Label();
            this.txtNumPlace = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSallePlace = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dgvPlace = new System.Windows.Forms.DataGridView();
            this.txtRecherche = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCatPlace = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlace)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDeleteAgent
            // 
            this.BtnDeleteAgent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeleteAgent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeleteAgent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDeleteAgent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDeleteAgent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnDeleteAgent.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteAgent.Location = new System.Drawing.Point(733, 706);
            this.BtnDeleteAgent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDeleteAgent.Name = "BtnDeleteAgent";
            this.BtnDeleteAgent.Size = new System.Drawing.Size(160, 36);
            this.BtnDeleteAgent.TabIndex = 92;
            this.BtnDeleteAgent.Text = "Delete";
            this.BtnDeleteAgent.Click += new System.EventHandler(this.BtnDeleteAgent_Click);
            // 
            // btnUpdateAgent
            // 
            this.btnUpdateAgent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateAgent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateAgent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateAgent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateAgent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateAgent.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAgent.Location = new System.Drawing.Point(451, 706);
            this.btnUpdateAgent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateAgent.Name = "btnUpdateAgent";
            this.btnUpdateAgent.Size = new System.Drawing.Size(160, 36);
            this.btnUpdateAgent.TabIndex = 91;
            this.btnUpdateAgent.Text = "Update";
            this.btnUpdateAgent.Click += new System.EventHandler(this.btnUpdateAgent_Click);
            // 
            // BtnAjouterAgent
            // 
            this.BtnAjouterAgent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAjouterAgent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAjouterAgent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAjouterAgent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAjouterAgent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAjouterAgent.ForeColor = System.Drawing.Color.White;
            this.BtnAjouterAgent.Location = new System.Drawing.Point(176, 706);
            this.BtnAjouterAgent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAjouterAgent.Name = "BtnAjouterAgent";
            this.BtnAjouterAgent.Size = new System.Drawing.Size(160, 36);
            this.BtnAjouterAgent.TabIndex = 90;
            this.BtnAjouterAgent.Text = "Ajouter";
            this.BtnAjouterAgent.Click += new System.EventHandler(this.BtnAjouterAgent_Click);
            // 
            // txtIdPlace
            // 
            this.txtIdPlace.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdPlace.DefaultText = "";
            this.txtIdPlace.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdPlace.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdPlace.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdPlace.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdPlace.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPlace.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdPlace.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPlace.Location = new System.Drawing.Point(103, 217);
            this.txtIdPlace.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtIdPlace.Name = "txtIdPlace";
            this.txtIdPlace.PlaceholderText = "";
            this.txtIdPlace.SelectedText = "";
            this.txtIdPlace.Size = new System.Drawing.Size(223, 31);
            this.txtIdPlace.TabIndex = 89;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(9, 233);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(18, 16);
            this.id.TabIndex = 88;
            this.id.Text = "id";
            // 
            // txtNumPlace
            // 
            this.txtNumPlace.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumPlace.DefaultText = "";
            this.txtNumPlace.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumPlace.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumPlace.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumPlace.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumPlace.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumPlace.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNumPlace.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumPlace.Location = new System.Drawing.Point(101, 164);
            this.txtNumPlace.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNumPlace.Name = "txtNumPlace";
            this.txtNumPlace.PlaceholderText = "";
            this.txtNumPlace.SelectedText = "";
            this.txtNumPlace.Size = new System.Drawing.Size(223, 31);
            this.txtNumPlace.TabIndex = 86;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 178);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 16);
            this.label13.TabIndex = 85;
            this.label13.Text = "Numero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(149, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(669, 60);
            this.label7.TabIndex = 80;
            this.label7.Text = "ENREGISTREMENT DES PLACES";
            // 
            // cmbSallePlace
            // 
            this.cmbSallePlace.BackColor = System.Drawing.Color.Transparent;
            this.cmbSallePlace.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSallePlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSallePlace.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSallePlace.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSallePlace.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSallePlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSallePlace.ItemHeight = 30;
            this.cmbSallePlace.Location = new System.Drawing.Point(491, 119);
            this.cmbSallePlace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSallePlace.Name = "cmbSallePlace";
            this.cmbSallePlace.Size = new System.Drawing.Size(223, 36);
            this.cmbSallePlace.TabIndex = 94;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(408, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 16);
            this.label11.TabIndex = 93;
            this.label11.Text = "Salle";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Vente_Billets.Properties.Resources.place;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1021, 98);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(400, 396);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 95;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // dgvPlace
            // 
            this.dgvPlace.BackgroundColor = System.Drawing.Color.White;
            this.dgvPlace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlace.GridColor = System.Drawing.Color.White;
            this.dgvPlace.Location = new System.Drawing.Point(63, 361);
            this.dgvPlace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPlace.Name = "dgvPlace";
            this.dgvPlace.RowHeadersWidth = 62;
            this.dgvPlace.RowTemplate.Height = 28;
            this.dgvPlace.Size = new System.Drawing.Size(1013, 330);
            this.dgvPlace.TabIndex = 96;
            this.dgvPlace.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlace_CellClick);
            // 
            // txtRecherche
            // 
            this.txtRecherche.BorderRadius = 20;
            this.txtRecherche.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRecherche.DefaultText = "";
            this.txtRecherche.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRecherche.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRecherche.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRecherche.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRecherche.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRecherche.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.ForeColor = System.Drawing.Color.Black;
            this.txtRecherche.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRecherche.Location = new System.Drawing.Point(63, 290);
            this.txtRecherche.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtRecherche.PlaceholderText = "Recherche";
            this.txtRecherche.SelectedText = "";
            this.txtRecherche.Size = new System.Drawing.Size(411, 36);
            this.txtRecherche.TabIndex = 97;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 98;
            this.label1.Text = "Categorie";
            // 
            // cmbCatPlace
            // 
            this.cmbCatPlace.BackColor = System.Drawing.Color.Transparent;
            this.cmbCatPlace.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCatPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCatPlace.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCatPlace.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCatPlace.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCatPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCatPlace.ItemHeight = 30;
            this.cmbCatPlace.Location = new System.Drawing.Point(101, 119);
            this.cmbCatPlace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCatPlace.Name = "cmbCatPlace";
            this.cmbCatPlace.Size = new System.Drawing.Size(223, 36);
            this.cmbCatPlace.TabIndex = 99;
            this.cmbCatPlace.SelectedIndexChanged += new System.EventHandler(this.cmbCatPlace_SelectedIndexChanged);
            // 
            // FrmPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1437, 816);
            this.Controls.Add(this.cmbCatPlace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.dgvPlace);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.cmbSallePlace);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtnDeleteAgent);
            this.Controls.Add(this.btnUpdateAgent);
            this.Controls.Add(this.BtnAjouterAgent);
            this.Controls.Add(this.txtIdPlace);
            this.Controls.Add(this.id);
            this.Controls.Add(this.txtNumPlace);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPlace";
            this.Text = "FrmPlace";
            this.Load += new System.EventHandler(this.FrmPlace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnDeleteAgent;
        private Guna.UI2.WinForms.Guna2Button btnUpdateAgent;
        private Guna.UI2.WinForms.Guna2Button BtnAjouterAgent;
        private Guna.UI2.WinForms.Guna2TextBox txtIdPlace;
        private System.Windows.Forms.Label id;
        private Guna.UI2.WinForms.Guna2TextBox txtNumPlace;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSallePlace;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.DataGridView dgvPlace;
        private Guna.UI2.WinForms.Guna2TextBox txtRecherche;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCatPlace;
    }
}