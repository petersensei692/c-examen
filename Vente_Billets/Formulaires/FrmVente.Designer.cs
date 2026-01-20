
namespace Vente_Billets.Formulaires
{
    partial class FrmVente
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.DateAchat = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtIdBillet = new Guna.UI2.WinForms.Guna2TextBox();
            this.id = new System.Windows.Forms.Label();
            this.cmbAgent = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrix = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSpectacle = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbPlace = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbClient = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.dgvBillet = new System.Windows.Forms.DataGridView();
            this.txtRecherche = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCatPlace = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 105;
            this.label1.Text = "Place";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DateAchat
            // 
            this.DateAchat.BackColor = System.Drawing.Color.White;
            this.DateAchat.Checked = true;
            this.DateAchat.FillColor = System.Drawing.Color.White;
            this.DateAchat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateAchat.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateAchat.Location = new System.Drawing.Point(1043, 90);
            this.DateAchat.Margin = new System.Windows.Forms.Padding(4);
            this.DateAchat.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateAchat.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateAchat.Name = "DateAchat";
            this.DateAchat.Size = new System.Drawing.Size(256, 36);
            this.DateAchat.TabIndex = 104;
            this.DateAchat.Value = new System.DateTime(2025, 7, 21, 4, 51, 15, 315);
            this.DateAchat.ValueChanged += new System.EventHandler(this.DateAchat_ValueChanged);
            // 
            // txtIdBillet
            // 
            this.txtIdBillet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdBillet.DefaultText = "";
            this.txtIdBillet.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdBillet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdBillet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdBillet.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdBillet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdBillet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdBillet.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdBillet.Location = new System.Drawing.Point(554, 222);
            this.txtIdBillet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtIdBillet.Name = "txtIdBillet";
            this.txtIdBillet.PlaceholderText = "";
            this.txtIdBillet.SelectedText = "";
            this.txtIdBillet.Size = new System.Drawing.Size(313, 31);
            this.txtIdBillet.TabIndex = 100;
            this.txtIdBillet.TextChanged += new System.EventHandler(this.txtIdBillet_TextChanged);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(528, 231);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(18, 16);
            this.id.TabIndex = 99;
            this.id.Text = "id";
            this.id.Click += new System.EventHandler(this.id_Click);
            // 
            // cmbAgent
            // 
            this.cmbAgent.BackColor = System.Drawing.Color.Transparent;
            this.cmbAgent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAgent.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAgent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAgent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAgent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbAgent.ItemHeight = 30;
            this.cmbAgent.Location = new System.Drawing.Point(390, 160);
            this.cmbAgent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAgent.Name = "cmbAgent";
            this.cmbAgent.Size = new System.Drawing.Size(290, 36);
            this.cmbAgent.TabIndex = 97;
            this.cmbAgent.SelectedIndexChanged += new System.EventHandler(this.cmbAgent_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(387, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 16);
            this.label11.TabIndex = 96;
            this.label11.Text = "Agent";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(387, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 16);
            this.label12.TabIndex = 94;
            this.label12.Text = "Spectacle";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1043, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 16);
            this.label13.TabIndex = 93;
            this.label13.Text = "Date du Spectacle";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(736, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 91;
            this.label10.Text = "Client";
            // 
            // txtPrix
            // 
            this.txtPrix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrix.DefaultText = "";
            this.txtPrix.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrix.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrix.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrix.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrix.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrix.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrix.Location = new System.Drawing.Point(70, 90);
            this.txtPrix.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.PlaceholderText = "";
            this.txtPrix.SelectedText = "";
            this.txtPrix.Size = new System.Drawing.Size(269, 31);
            this.txtPrix.TabIndex = 88;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 16);
            this.label8.TabIndex = 87;
            this.label8.Text = "Prix";
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
            this.label7.Size = new System.Drawing.Size(1386, 50);
            this.label7.TabIndex = 86;
            this.label7.Text = "ENREGISTREMENT DES BILLETS";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cmbSpectacle.Location = new System.Drawing.Point(390, 90);
            this.cmbSpectacle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSpectacle.Name = "cmbSpectacle";
            this.cmbSpectacle.Size = new System.Drawing.Size(290, 36);
            this.cmbSpectacle.TabIndex = 106;
            // 
            // cmbPlace
            // 
            this.cmbPlace.BackColor = System.Drawing.Color.Transparent;
            this.cmbPlace.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlace.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPlace.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPlace.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPlace.ItemHeight = 30;
            this.cmbPlace.Location = new System.Drawing.Point(70, 160);
            this.cmbPlace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPlace.Name = "cmbPlace";
            this.cmbPlace.Size = new System.Drawing.Size(269, 36);
            this.cmbPlace.TabIndex = 107;
            this.cmbPlace.SelectedIndexChanged += new System.EventHandler(this.cmbPlace_SelectedIndexChanged);
            // 
            // cmbClient
            // 
            this.cmbClient.BackColor = System.Drawing.Color.Transparent;
            this.cmbClient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClient.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbClient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbClient.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbClient.ItemHeight = 30;
            this.cmbClient.Location = new System.Drawing.Point(736, 90);
            this.cmbClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(267, 36);
            this.cmbClient.TabIndex = 108;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1792, 10);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(40, 23);
            this.guna2ControlBox1.TabIndex = 110;
            // 
            // dgvBillet
            // 
            this.dgvBillet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBillet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBillet.BackgroundColor = System.Drawing.Color.White;
            this.dgvBillet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBillet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBillet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBillet.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBillet.GridColor = System.Drawing.Color.White;
            this.dgvBillet.Location = new System.Drawing.Point(1, 309);
            this.dgvBillet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBillet.Name = "dgvBillet";
            this.dgvBillet.RowHeadersWidth = 62;
            this.dgvBillet.RowTemplate.Height = 28;
            this.dgvBillet.Size = new System.Drawing.Size(1385, 348);
            this.dgvBillet.TabIndex = 113;
            this.dgvBillet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillet_CellClick_1);
            this.dgvBillet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillet_CellContentClick);
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
            this.txtRecherche.Location = new System.Drawing.Point(14, 265);
            this.txtRecherche.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtRecherche.PlaceholderText = "Recherche";
            this.txtRecherche.SelectedText = "";
            this.txtRecherche.Size = new System.Drawing.Size(1346, 36);
            this.txtRecherche.TabIndex = 114;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Black;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(775, 728);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(218, 36);
            this.guna2Button2.TabIndex = 141;
            this.guna2Button2.Text = "Delete";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Black;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(418, 728);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(227, 36);
            this.guna2Button3.TabIndex = 140;
            this.guna2Button3.Text = "Update";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.Black;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(70, 728);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(218, 36);
            this.guna2Button4.TabIndex = 139;
            this.guna2Button4.Text = "Ajouter";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.Black;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Location = new System.Drawing.Point(1099, 728);
            this.guna2Button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(200, 36);
            this.guna2Button5.TabIndex = 142;
            this.guna2Button5.Text = "Imprimer Billet";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1043, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 143;
            this.label3.Text = "Cat_Place";
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
            this.cmbCatPlace.Location = new System.Drawing.Point(1046, 162);
            this.cmbCatPlace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCatPlace.Name = "cmbCatPlace";
            this.cmbCatPlace.Size = new System.Drawing.Size(253, 36);
            this.cmbCatPlace.TabIndex = 144;
            // 
            // FrmVente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1386, 809);
            this.Controls.Add(this.guna2Button5);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.dgvBillet);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.cmbPlace);
            this.Controls.Add(this.cmbSpectacle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateAchat);
            this.Controls.Add(this.txtIdBillet);
            this.Controls.Add(this.id);
            this.Controls.Add(this.cmbAgent);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmVente";
            this.Text = "FrmVente";
            this.Load += new System.EventHandler(this.FrmVente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateAchat;
        private Guna.UI2.WinForms.Guna2TextBox txtIdBillet;
        private System.Windows.Forms.Label id;
        private Guna.UI2.WinForms.Guna2ComboBox cmbAgent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtPrix;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSpectacle;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPlace;
        private Guna.UI2.WinForms.Guna2ComboBox cmbClient;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.DataGridView dgvBillet;
        private Guna.UI2.WinForms.Guna2TextBox txtRecherche;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCatPlace;
        private System.Windows.Forms.Label label3;
    }
}