
namespace Vente_Billets.Formulaires
{
    partial class FrmSpectacle
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
            this.txtIdSpectacle = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.cmbSpectacle = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDuree = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDescSpect = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNbrBillet = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTitre = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnDeleteAgent = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateAgent = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAjouterAgent = new Guna.UI2.WinForms.Guna2Button();
            this.DateSpectacle = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dgvSpectacle = new System.Windows.Forms.DataGridView();
            this.txtRecherche = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpectacle)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdSpectacle
            // 
            this.txtIdSpectacle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdSpectacle.DefaultText = "";
            this.txtIdSpectacle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdSpectacle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdSpectacle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdSpectacle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdSpectacle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdSpectacle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdSpectacle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdSpectacle.Location = new System.Drawing.Point(465, 226);
            this.txtIdSpectacle.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdSpectacle.Name = "txtIdSpectacle";
            this.txtIdSpectacle.PlaceholderText = "";
            this.txtIdSpectacle.SelectedText = "";
            this.txtIdSpectacle.Size = new System.Drawing.Size(429, 30);
            this.txtIdSpectacle.TabIndex = 76;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(465, 206);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 16);
            this.lblId.TabIndex = 75;
            this.lblId.Text = "id";
            // 
            // cmbSpectacle
            // 
            this.cmbSpectacle.BackColor = System.Drawing.Color.Transparent;
            this.cmbSpectacle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSpectacle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpectacle.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSpectacle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSpectacle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSpectacle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSpectacle.ItemHeight = 30;
            this.cmbSpectacle.Location = new System.Drawing.Point(465, 155);
            this.cmbSpectacle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSpectacle.Name = "cmbSpectacle";
            this.cmbSpectacle.Size = new System.Drawing.Size(429, 36);
            this.cmbSpectacle.TabIndex = 73;
            this.cmbSpectacle.SelectedIndexChanged += new System.EventHandler(this.cmbSpectacle_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(465, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 16);
            this.label11.TabIndex = 72;
            this.label11.Text = "Salle";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtDuree
            // 
            this.txtDuree.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDuree.DefaultText = "";
            this.txtDuree.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDuree.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDuree.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDuree.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDuree.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDuree.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDuree.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDuree.Location = new System.Drawing.Point(81, 155);
            this.txtDuree.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuree.Name = "txtDuree";
            this.txtDuree.PlaceholderText = "";
            this.txtDuree.SelectedText = "";
            this.txtDuree.Size = new System.Drawing.Size(318, 36);
            this.txtDuree.TabIndex = 71;
            this.txtDuree.TextChanged += new System.EventHandler(this.txtDuree_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(81, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 70;
            this.label12.Text = "Duree";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(966, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 16);
            this.label13.TabIndex = 68;
            this.label13.Text = "Date";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtDescSpect
            // 
            this.txtDescSpect.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescSpect.DefaultText = "";
            this.txtDescSpect.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescSpect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescSpect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescSpect.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescSpect.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescSpect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescSpect.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescSpect.Location = new System.Drawing.Point(966, 155);
            this.txtDescSpect.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescSpect.Name = "txtDescSpect";
            this.txtDescSpect.PlaceholderText = "";
            this.txtDescSpect.SelectedText = "";
            this.txtDescSpect.Size = new System.Drawing.Size(322, 36);
            this.txtDescSpect.TabIndex = 67;
            this.txtDescSpect.TextChanged += new System.EventHandler(this.txtDescSpect_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(966, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 66;
            this.label10.Text = "Description";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtNbrBillet
            // 
            this.txtNbrBillet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNbrBillet.DefaultText = "";
            this.txtNbrBillet.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNbrBillet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNbrBillet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNbrBillet.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNbrBillet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNbrBillet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNbrBillet.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNbrBillet.Location = new System.Drawing.Point(465, 85);
            this.txtNbrBillet.Margin = new System.Windows.Forms.Padding(4);
            this.txtNbrBillet.Name = "txtNbrBillet";
            this.txtNbrBillet.PlaceholderText = "";
            this.txtNbrBillet.SelectedText = "";
            this.txtNbrBillet.Size = new System.Drawing.Size(429, 30);
            this.txtNbrBillet.TabIndex = 65;
            this.txtNbrBillet.TextChanged += new System.EventHandler(this.txtNbrBillet_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(465, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 64;
            this.label9.Text = "Nombre_billets";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtTitre
            // 
            this.txtTitre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitre.DefaultText = "";
            this.txtTitre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTitre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTitre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitre.Location = new System.Drawing.Point(81, 85);
            this.txtTitre.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.PlaceholderText = "";
            this.txtTitre.SelectedText = "";
            this.txtTitre.Size = new System.Drawing.Size(318, 30);
            this.txtTitre.TabIndex = 63;
            this.txtTitre.TextChanged += new System.EventHandler(this.txtTitre_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 62;
            this.label8.Text = "Titre";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1374, 50);
            this.label7.TabIndex = 61;
            this.label7.Text = "ENREGISTREMENT DES SPECTACLES";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnDeleteAgent
            // 
            this.BtnDeleteAgent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeleteAgent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeleteAgent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDeleteAgent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDeleteAgent.FillColor = System.Drawing.Color.Black;
            this.BtnDeleteAgent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnDeleteAgent.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteAgent.Location = new System.Drawing.Point(966, 643);
            this.BtnDeleteAgent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDeleteAgent.Name = "BtnDeleteAgent";
            this.BtnDeleteAgent.Size = new System.Drawing.Size(224, 36);
            this.BtnDeleteAgent.TabIndex = 82;
            this.BtnDeleteAgent.Text = "Delete";
            this.BtnDeleteAgent.Click += new System.EventHandler(this.BtnDeleteAgent_Click);
            // 
            // btnUpdateAgent
            // 
            this.btnUpdateAgent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateAgent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateAgent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateAgent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateAgent.FillColor = System.Drawing.Color.Black;
            this.btnUpdateAgent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateAgent.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAgent.Location = new System.Drawing.Point(562, 643);
            this.btnUpdateAgent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateAgent.Name = "btnUpdateAgent";
            this.btnUpdateAgent.Size = new System.Drawing.Size(246, 36);
            this.btnUpdateAgent.TabIndex = 81;
            this.btnUpdateAgent.Text = "Update";
            this.btnUpdateAgent.Click += new System.EventHandler(this.btnUpdateAgent_Click);
            // 
            // BtnAjouterAgent
            // 
            this.BtnAjouterAgent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAjouterAgent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAjouterAgent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAjouterAgent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAjouterAgent.FillColor = System.Drawing.Color.Black;
            this.BtnAjouterAgent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAjouterAgent.ForeColor = System.Drawing.Color.White;
            this.BtnAjouterAgent.Location = new System.Drawing.Point(169, 643);
            this.BtnAjouterAgent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAjouterAgent.Name = "BtnAjouterAgent";
            this.BtnAjouterAgent.Size = new System.Drawing.Size(230, 36);
            this.BtnAjouterAgent.TabIndex = 80;
            this.BtnAjouterAgent.Text = "Ajouter";
            this.BtnAjouterAgent.Click += new System.EventHandler(this.BtnAjouterAgent_Click);
            // 
            // DateSpectacle
            // 
            this.DateSpectacle.BackColor = System.Drawing.Color.White;
            this.DateSpectacle.Checked = true;
            this.DateSpectacle.FillColor = System.Drawing.Color.White;
            this.DateSpectacle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateSpectacle.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateSpectacle.Location = new System.Drawing.Point(969, 83);
            this.DateSpectacle.Margin = new System.Windows.Forms.Padding(4);
            this.DateSpectacle.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateSpectacle.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateSpectacle.Name = "DateSpectacle";
            this.DateSpectacle.Size = new System.Drawing.Size(319, 32);
            this.DateSpectacle.TabIndex = 83;
            this.DateSpectacle.Value = new System.DateTime(2025, 7, 21, 4, 51, 15, 315);
            this.DateSpectacle.ValueChanged += new System.EventHandler(this.DateSpectacle_ValueChanged);
            // 
            // dgvSpectacle
            // 
            this.dgvSpectacle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSpectacle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSpectacle.BackgroundColor = System.Drawing.Color.White;
            this.dgvSpectacle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSpectacle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpectacle.GridColor = System.Drawing.Color.White;
            this.dgvSpectacle.Location = new System.Drawing.Point(43, 310);
            this.dgvSpectacle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSpectacle.Name = "dgvSpectacle";
            this.dgvSpectacle.RowHeadersWidth = 62;
            this.dgvSpectacle.RowTemplate.Height = 28;
            this.dgvSpectacle.Size = new System.Drawing.Size(1293, 293);
            this.dgvSpectacle.TabIndex = 87;
            this.dgvSpectacle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSpectacle_CellClick_1);
            this.dgvSpectacle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgents_CellContentClick);
            // 
            // txtRecherche
            // 
            this.txtRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.txtRecherche.Location = new System.Drawing.Point(26, 266);
            this.txtRecherche.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtRecherche.PlaceholderText = "Recherche";
            this.txtRecherche.SelectedText = "";
            this.txtRecherche.Size = new System.Drawing.Size(1334, 36);
            this.txtRecherche.TabIndex = 88;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // FrmSpectacle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1374, 809);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.dgvSpectacle);
            this.Controls.Add(this.DateSpectacle);
            this.Controls.Add(this.BtnDeleteAgent);
            this.Controls.Add(this.btnUpdateAgent);
            this.Controls.Add(this.BtnAjouterAgent);
            this.Controls.Add(this.txtIdSpectacle);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.cmbSpectacle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDuree);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDescSpect);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNbrBillet);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSpectacle";
            this.Text = "FrmSpectacle";
            this.Load += new System.EventHandler(this.FrmSpectacle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpectacle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtIdSpectacle;
        private System.Windows.Forms.Label lblId;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSpectacle;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtDuree;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox txtDescSpect;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtNbrBillet;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtTitre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button BtnDeleteAgent;
        private Guna.UI2.WinForms.Guna2Button btnUpdateAgent;
        private Guna.UI2.WinForms.Guna2Button BtnAjouterAgent;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateSpectacle;
        private System.Windows.Forms.DataGridView dgvSpectacle;
        private Guna.UI2.WinForms.Guna2TextBox txtRecherche;
    }
}