namespace eBankingUI.Forme
{
    partial class frmLogovi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogovi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtIPAdresa = new System.Windows.Forms.TextBox();
            this.lblIPAdresa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.cbxUspjeh = new System.Windows.Forms.ComboBox();
            this.dtpOD = new System.Windows.Forms.DateTimePicker();
            this.dtpDO = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.dgvLogovi = new System.Windows.Forms.DataGridView();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumVrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPAdresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Browser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uspjesnost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGlavniMeni = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBroj = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFocus = new System.Windows.Forms.Label();
            this.btnIspis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogovi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIPAdresa
            // 
            this.txtIPAdresa.Location = new System.Drawing.Point(130, 64);
            this.txtIPAdresa.Name = "txtIPAdresa";
            this.txtIPAdresa.Size = new System.Drawing.Size(130, 20);
            this.txtIPAdresa.TabIndex = 0;
            // 
            // lblIPAdresa
            // 
            this.lblIPAdresa.AutoSize = true;
            this.lblIPAdresa.Location = new System.Drawing.Point(127, 48);
            this.lblIPAdresa.Name = "lblIPAdresa";
            this.lblIPAdresa.Size = new System.Drawing.Size(56, 13);
            this.lblIPAdresa.TabIndex = 1;
            this.lblIPAdresa.Text = "IP Adresa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Uspjeh:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(415, 27);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(104, 20);
            this.txtIme.TabIndex = 4;
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.AutoSize = true;
            this.lblImePrezime.Location = new System.Drawing.Point(413, 10);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(27, 13);
            this.lblImePrezime.TabIndex = 5;
            this.lblImePrezime.Text = "Ime:";
            // 
            // cbxUspjeh
            // 
            this.cbxUspjeh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxUspjeh.FormattingEnabled = true;
            this.cbxUspjeh.Items.AddRange(new object[] {
            "-Odaberite uspjesnost-",
            "Uspjesno",
            "Neuspjesno"});
            this.cbxUspjeh.Location = new System.Drawing.Point(130, 25);
            this.cbxUspjeh.Name = "cbxUspjeh";
            this.cbxUspjeh.Size = new System.Drawing.Size(130, 21);
            this.cbxUspjeh.TabIndex = 6;
            // 
            // dtpOD
            // 
            this.dtpOD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpOD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOD.Location = new System.Drawing.Point(294, 26);
            this.dtpOD.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.dtpOD.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtpOD.Name = "dtpOD";
            this.dtpOD.Size = new System.Drawing.Size(106, 20);
            this.dtpOD.TabIndex = 7;
            this.dtpOD.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // dtpDO
            // 
            this.dtpDO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDO.Location = new System.Drawing.Point(294, 64);
            this.dtpDO.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.dtpDO.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtpDO.Name = "dtpDO";
            this.dtpDO.Size = new System.Drawing.Size(106, 20);
            this.dtpDO.TabIndex = 8;
            this.dtpDO.Value = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Od:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Do:";
            // 
            // btnTrazi
            // 
            this.btnTrazi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTrazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrazi.Image = ((System.Drawing.Image)(resources.GetObject("btnTrazi.Image")));
            this.btnTrazi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrazi.Location = new System.Drawing.Point(537, 30);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(65, 23);
            this.btnTrazi.TabIndex = 11;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrazi.UseVisualStyleBackColor = false;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // dgvLogovi
            // 
            this.dgvLogovi.AllowUserToAddRows = false;
            this.dgvLogovi.AllowUserToDeleteRows = false;
            this.dgvLogovi.AllowUserToOrderColumns = true;
            this.dgvLogovi.AllowUserToResizeColumns = false;
            this.dgvLogovi.AllowUserToResizeRows = false;
            this.dgvLogovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLogovi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLogovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.JMBG,
            this.DatumVrijeme,
            this.IPAdresa,
            this.Browser,
            this.Uspjesnost});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLogovi.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLogovi.Location = new System.Drawing.Point(17, 91);
            this.dgvLogovi.Name = "dgvLogovi";
            this.dgvLogovi.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLogovi.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLogovi.RowHeadersVisible = false;
            this.dgvLogovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLogovi.Size = new System.Drawing.Size(724, 279);
            this.dgvLogovi.TabIndex = 12;
            // 
            // ImePrezime
            // 
            this.ImePrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.HeaderText = "Ime i prezime";
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            this.ImePrezime.Width = 93;
            // 
            // JMBG
            // 
            this.JMBG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.JMBG.DataPropertyName = "JMBG";
            this.JMBG.HeaderText = "JMBG";
            this.JMBG.Name = "JMBG";
            this.JMBG.ReadOnly = true;
            // 
            // DatumVrijeme
            // 
            this.DatumVrijeme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DatumVrijeme.DataPropertyName = "DatumVrijeme";
            this.DatumVrijeme.HeaderText = "Datum i vrijeme";
            this.DatumVrijeme.Name = "DatumVrijeme";
            this.DatumVrijeme.ReadOnly = true;
            this.DatumVrijeme.Width = 127;
            // 
            // IPAdresa
            // 
            this.IPAdresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IPAdresa.DataPropertyName = "IPAdresa";
            this.IPAdresa.HeaderText = "IP Adresa";
            this.IPAdresa.Name = "IPAdresa";
            this.IPAdresa.ReadOnly = true;
            this.IPAdresa.Width = 128;
            // 
            // Browser
            // 
            this.Browser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Browser.DataPropertyName = "Browser";
            this.Browser.HeaderText = "Web pretraživač";
            this.Browser.Name = "Browser";
            this.Browser.ReadOnly = true;
            this.Browser.Width = 127;
            // 
            // Uspjesnost
            // 
            this.Uspjesnost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Uspjesnost.DataPropertyName = "Uspjesnost";
            this.Uspjesnost.HeaderText = "Uspjeh";
            this.Uspjesnost.Name = "Uspjesnost";
            this.Uspjesnost.ReadOnly = true;
            this.Uspjesnost.Width = 127;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Datum:";
            // 
            // btnGlavniMeni
            // 
            this.btnGlavniMeni.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGlavniMeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGlavniMeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlavniMeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGlavniMeni.Image = ((System.Drawing.Image)(resources.GetObject("btnGlavniMeni.Image")));
            this.btnGlavniMeni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGlavniMeni.Location = new System.Drawing.Point(501, 374);
            this.btnGlavniMeni.Name = "btnGlavniMeni";
            this.btnGlavniMeni.Size = new System.Drawing.Size(119, 27);
            this.btnGlavniMeni.TabIndex = 14;
            this.btnGlavniMeni.Text = "Meni";
            this.btnGlavniMeni.UseVisualStyleBackColor = false;
            this.btnGlavniMeni.Click += new System.EventHandler(this.btnGlavniMeni_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Broj logova:";
            // 
            // lblBroj
            // 
            this.lblBroj.AutoSize = true;
            this.lblBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBroj.Location = new System.Drawing.Point(119, 379);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(52, 18);
            this.lblBroj.TabIndex = 17;
            this.lblBroj.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(415, 64);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(104, 20);
            this.txtPrezime.TabIndex = 20;
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOsvjezi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOsvjezi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOsvjezi.Image = ((System.Drawing.Image)(resources.GetObject("btnOsvjezi.Image")));
            this.btnOsvjezi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOsvjezi.Location = new System.Drawing.Point(537, 57);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(65, 23);
            this.btnOsvjezi.TabIndex = 21;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOsvjezi.UseVisualStyleBackColor = false;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // label7
            // 
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(14, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 23);
            this.label7.TabIndex = 22;
            // 
            // lblFocus
            // 
            this.lblFocus.AutoSize = true;
            this.lblFocus.Location = new System.Drawing.Point(665, 48);
            this.lblFocus.Name = "lblFocus";
            this.lblFocus.Size = new System.Drawing.Size(0, 13);
            this.lblFocus.TabIndex = 23;
            // 
            // btnIspis
            // 
            this.btnIspis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIspis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIspis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIspis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIspis.Image = ((System.Drawing.Image)(resources.GetObject("btnIspis.Image")));
            this.btnIspis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIspis.Location = new System.Drawing.Point(622, 374);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(119, 27);
            this.btnIspis.TabIndex = 24;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = false;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // frmLogovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(757, 415);
            this.ControlBox = false;
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.lblFocus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblBroj);
            this.Controls.Add(this.btnGlavniMeni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvLogovi);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDO);
            this.Controls.Add(this.dtpOD);
            this.Controls.Add(this.cbxUspjeh);
            this.Controls.Add(this.lblImePrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIPAdresa);
            this.Controls.Add(this.txtIPAdresa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogovi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eBanking";
            this.Load += new System.EventHandler(this.frmLogovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIPAdresa;
        private System.Windows.Forms.Label lblIPAdresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.ComboBox cbxUspjeh;
        private System.Windows.Forms.DateTimePicker dtpOD;
        private System.Windows.Forms.DateTimePicker dtpDO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.DataGridView dgvLogovi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGlavniMeni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBroj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn JMBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumVrijeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPAdresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Browser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uspjesnost;
        private System.Windows.Forms.Label lblFocus;
        private System.Windows.Forms.Button btnIspis;
    }
}