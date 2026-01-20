
namespace Vente_Billets.Formulaires
{
    partial class FrmPaiement
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
            this.DatePaie = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtIdPaiement = new Guna.UI2.WinForms.Guna2TextBox();
            this.id = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMontant = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbModePaie = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbAgent = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cmbClient = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPaiement = new System.Windows.Forms.DataGridView();
            this.txtRecherche = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaiement)).BeginInit();
            this.SuspendLayout();
            // 
            // DatePaie
            // 
            this.DatePaie.BackColor = System.Drawing.Color.White;
            this.DatePaie.Checked = true;
            this.DatePaie.FillColor = System.Drawing.Color.White;
            this.DatePaie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DatePaie.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DatePaie.Location = new System.Drawing.Point(101, 139);
            this.DatePaie.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DatePaie.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DatePaie.Name = "DatePaie";
            this.DatePaie.Size = new System.Drawing.Size(179, 37);
            this.DatePaie.TabIndex = 104;
            this.DatePaie.Value = new System.DateTime(2025, 7, 21, 4, 51, 15, 315);
            // 
            // txtIdPaiement
            // 
            this.txtIdPaiement.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdPaiement.DefaultText = "";
            this.txtIdPaiement.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdPaiement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdPaiement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdPaiement.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdPaiement.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPaiement.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdPaiement.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPaiement.Location = new System.Drawing.Point(424, 186);
            this.txtIdPaiement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdPaiement.Name = "txtIdPaiement";
            this.txtIdPaiement.PlaceholderText = "";
            this.txtIdPaiement.SelectedText = "";
            this.txtIdPaiement.Size = new System.Drawing.Size(178, 25);
            this.txtIdPaiement.TabIndex = 100;
            this.txtIdPaiement.TextChanged += new System.EventHandler(this.txtIdPaiement_TextChanged);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(363, 198);
            this.id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(15, 13);
            this.id.TabIndex = 99;
            this.id.Text = "id";
            this.id.Click += new System.EventHandler(this.id_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(363, 149);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 94;
            this.label12.Text = "Agent";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 149);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 93;
            this.label13.Text = "Date";
            // 
            // txtMontant
            // 
            this.txtMontant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMontant.DefaultText = "";
            this.txtMontant.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMontant.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMontant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMontant.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMontant.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMontant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMontant.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMontant.Location = new System.Drawing.Point(423, 88);
            this.txtMontant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.PlaceholderText = "";
            this.txtMontant.SelectedText = "";
            this.txtMontant.Size = new System.Drawing.Size(167, 25);
            this.txtMontant.TabIndex = 90;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(363, 101);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 89;
            this.label9.Text = "Montant";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 100);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 87;
            this.label8.Text = "Mode_Paiement";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(115, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(612, 47);
            this.label7.TabIndex = 86;
            this.label7.Text = "ENREGISTREMENT DES PAIEMENTS";
            // 
            // cmbModePaie
            // 
            this.cmbModePaie.BackColor = System.Drawing.Color.White;
            this.cmbModePaie.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbModePaie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModePaie.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbModePaie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbModePaie.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbModePaie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbModePaie.ItemHeight = 30;
            this.cmbModePaie.Location = new System.Drawing.Point(103, 90);
            this.cmbModePaie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbModePaie.Name = "cmbModePaie";
            this.cmbModePaie.Size = new System.Drawing.Size(178, 36);
            this.cmbModePaie.TabIndex = 107;
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
            this.cmbAgent.Location = new System.Drawing.Point(424, 139);
            this.cmbAgent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbAgent.Name = "cmbAgent";
            this.cmbAgent.Size = new System.Drawing.Size(168, 36);
            this.cmbAgent.TabIndex = 108;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Vente_Billets.Properties.Resources.paiement;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(785, 261);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(300, 268);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 109;
            this.guna2PictureBox1.TabStop = false;
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
            this.cmbClient.Location = new System.Drawing.Point(705, 84);
            this.cmbClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(168, 36);
            this.cmbClient.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(641, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 111;
            this.label1.Text = "Client";
            // 
            // dgvPaiement
            // 
            this.dgvPaiement.BackgroundColor = System.Drawing.Color.White;
            this.dgvPaiement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaiement.GridColor = System.Drawing.Color.White;
            this.dgvPaiement.Location = new System.Drawing.Point(11, 261);
            this.dgvPaiement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPaiement.Name = "dgvPaiement";
            this.dgvPaiement.RowHeadersWidth = 62;
            this.dgvPaiement.RowTemplate.Height = 28;
            this.dgvPaiement.Size = new System.Drawing.Size(760, 268);
            this.dgvPaiement.TabIndex = 112;
            this.dgvPaiement.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaiement_CellClick_1);
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
            this.txtRecherche.Location = new System.Drawing.Point(11, 189);
            this.txtRecherche.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtRecherche.PlaceholderText = "Recherche";
            this.txtRecherche.SelectedText = "";
            this.txtRecherche.Size = new System.Drawing.Size(308, 29);
            this.txtRecherche.TabIndex = 113;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(464, 603);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(120, 29);
            this.guna2Button2.TabIndex = 117;
            this.guna2Button2.Text = "Delete";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(252, 603);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(120, 29);
            this.guna2Button3.TabIndex = 116;
            this.guna2Button3.Text = "Update";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(45, 603);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(120, 29);
            this.guna2Button4.TabIndex = 115;
            this.guna2Button4.Text = "Ajouter";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Location = new System.Drawing.Point(643, 603);
            this.guna2Button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(120, 29);
            this.guna2Button5.TabIndex = 118;
            this.guna2Button5.Text = "Recu";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // FrmPaiement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1283, 843);
            this.Controls.Add(this.guna2Button5);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.dgvPaiement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.cmbAgent);
            this.Controls.Add(this.cmbModePaie);
            this.Controls.Add(this.DatePaie);
            this.Controls.Add(this.txtIdPaiement);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "FrmPaiement";
            this.Text = "FrmPaiement";
            this.Load += new System.EventHandler(this.FrmPaiement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaiement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DateTimePicker DatePaie;
        private Guna.UI2.WinForms.Guna2TextBox txtIdPaiement;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox txtMontant;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cmbModePaie;
        private Guna.UI2.WinForms.Guna2ComboBox cmbAgent;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPaiement;
        private Guna.UI2.WinForms.Guna2TextBox txtRecherche;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
    }
}