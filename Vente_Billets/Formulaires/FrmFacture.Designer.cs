
namespace Vente_Billets.Formulaires
{
    partial class FrmFacture
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
            this.cmbPlace = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdfacture = new Guna.UI2.WinForms.Guna2TextBox();
            this.id = new System.Windows.Forms.Label();
            this.cmbClient = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAgent = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvFacture = new System.Windows.Forms.DataGridView();
            this.txtRecherche = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacture)).BeginInit();
            this.SuspendLayout();
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
            this.cmbPlace.Location = new System.Drawing.Point(764, 65);
            this.cmbPlace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPlace.Name = "cmbPlace";
            this.cmbPlace.Size = new System.Drawing.Size(416, 36);
            this.cmbPlace.TabIndex = 128;
            this.cmbPlace.SelectedIndexChanged += new System.EventHandler(this.cmbPlace_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(714, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 126;
            this.label1.Text = "Place";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIdfacture
            // 
            this.txtIdfacture.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdfacture.DefaultText = "";
            this.txtIdfacture.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdfacture.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdfacture.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdfacture.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdfacture.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdfacture.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdfacture.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdfacture.Location = new System.Drawing.Point(180, 115);
            this.txtIdfacture.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtIdfacture.Name = "txtIdfacture";
            this.txtIdfacture.PlaceholderText = "";
            this.txtIdfacture.SelectedText = "";
            this.txtIdfacture.Size = new System.Drawing.Size(418, 36);
            this.txtIdfacture.TabIndex = 121;
            this.txtIdfacture.TextChanged += new System.EventHandler(this.txtIdfacture_TextChanged);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(150, 125);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(18, 16);
            this.id.TabIndex = 120;
            this.id.Text = "id";
            this.id.Click += new System.EventHandler(this.id_Click);
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
            this.cmbClient.Location = new System.Drawing.Point(180, 65);
            this.cmbClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(418, 36);
            this.cmbClient.TabIndex = 118;
            this.cmbClient.SelectedIndexChanged += new System.EventHandler(this.cmbClient_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(714, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 16);
            this.label11.TabIndex = 117;
            this.label11.Text = "Agent";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 110;
            this.label8.Text = "Client";
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
            this.label7.Size = new System.Drawing.Size(1370, 50);
            this.label7.TabIndex = 109;
            this.label7.Text = "ENREGISTREMENT DES FACTURES";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
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
            this.cmbAgent.Location = new System.Drawing.Point(764, 115);
            this.cmbAgent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAgent.Name = "cmbAgent";
            this.cmbAgent.Size = new System.Drawing.Size(416, 36);
            this.cmbAgent.TabIndex = 132;
            this.cmbAgent.SelectedIndexChanged += new System.EventHandler(this.cmbAgent_SelectedIndexChanged);
            // 
            // dgvFacture
            // 
            this.dgvFacture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFacture.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacture.BackgroundColor = System.Drawing.Color.White;
            this.dgvFacture.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFacture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacture.GridColor = System.Drawing.Color.White;
            this.dgvFacture.Location = new System.Drawing.Point(323, 230);
            this.dgvFacture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFacture.Name = "dgvFacture";
            this.dgvFacture.RowHeadersWidth = 62;
            this.dgvFacture.RowTemplate.Height = 28;
            this.dgvFacture.Size = new System.Drawing.Size(692, 356);
            this.dgvFacture.TabIndex = 134;
            this.dgvFacture.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacture_CellClick_1);
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
            this.txtRecherche.Location = new System.Drawing.Point(20, 170);
            this.txtRecherche.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtRecherche.PlaceholderText = "Recherche";
            this.txtRecherche.SelectedText = "";
            this.txtRecherche.Size = new System.Drawing.Size(1330, 36);
            this.txtRecherche.TabIndex = 135;
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
            this.guna2Button2.Location = new System.Drawing.Point(730, 657);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(197, 36);
            this.guna2Button2.TabIndex = 138;
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
            this.guna2Button3.Location = new System.Drawing.Point(466, 657);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(197, 36);
            this.guna2Button3.TabIndex = 137;
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
            this.guna2Button4.Location = new System.Drawing.Point(180, 657);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(197, 36);
            this.guna2Button4.TabIndex = 136;
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
            this.guna2Button5.Location = new System.Drawing.Point(983, 657);
            this.guna2Button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(197, 36);
            this.guna2Button5.TabIndex = 139;
            this.guna2Button5.Text = "Imprimer";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // FrmFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 809);
            this.Controls.Add(this.guna2Button5);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.dgvFacture);
            this.Controls.Add(this.cmbAgent);
            this.Controls.Add(this.cmbPlace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdfacture);
            this.Controls.Add(this.id);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmFacture";
            this.Text = "FrmFacture";
            this.Load += new System.EventHandler(this.FrmFacture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cmbPlace;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtIdfacture;
        private System.Windows.Forms.Label id;
        private Guna.UI2.WinForms.Guna2ComboBox cmbClient;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cmbAgent;
        private System.Windows.Forms.DataGridView dgvFacture;
        private Guna.UI2.WinForms.Guna2TextBox txtRecherche;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
    }
}