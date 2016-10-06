namespace eBankingUI.Forme
{
    partial class frmPoruke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPoruke));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFocus = new System.Windows.Forms.Label();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrezimeRadnik = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtImeRadnik = new System.Windows.Forms.TextBox();
            this.Klijent = new System.Windows.Forms.Label();
            this.txtPrezimeKlijent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDO = new System.Windows.Forms.DateTimePicker();
            this.dtpOD = new System.Windows.Forms.DateTimePicker();
            this.cbxStatusPoruke = new System.Windows.Forms.ComboBox();
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.txtImeKlijent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPoruke = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.lblBrojPoruka = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGlavniMeni = new System.Windows.Forms.Button();
            this.btnProcitajPoruku = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumVrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odgovorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klijentt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odgovorena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoruke)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFocus
            // 
            this.lblFocus.AutoSize = true;
            this.lblFocus.Location = new System.Drawing.Point(680, 21);
            this.lblFocus.Name = "lblFocus";
            this.lblFocus.Size = new System.Drawing.Size(0, 13);
            this.lblFocus.TabIndex = 72;
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOsvjezi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOsvjezi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOsvjezi.Image = ((System.Drawing.Image)(resources.GetObject("btnOsvjezi.Image")));
            this.btnOsvjezi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOsvjezi.Location = new System.Drawing.Point(662, 59);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(69, 23);
            this.btnOsvjezi.TabIndex = 71;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOsvjezi.UseVisualStyleBackColor = false;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(575, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 70;
            this.label7.Text = "Radnik";
            // 
            // txtPrezimeRadnik
            // 
            this.txtPrezimeRadnik.Location = new System.Drawing.Point(548, 61);
            this.txtPrezimeRadnik.Name = "txtPrezimeRadnik";
            this.txtPrezimeRadnik.Size = new System.Drawing.Size(104, 20);
            this.txtPrezimeRadnik.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(495, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "Prezime:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(515, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "Ime:";
            // 
            // txtImeRadnik
            // 
            this.txtImeRadnik.Location = new System.Drawing.Point(548, 34);
            this.txtImeRadnik.Name = "txtImeRadnik";
            this.txtImeRadnik.Size = new System.Drawing.Size(104, 20);
            this.txtImeRadnik.TabIndex = 66;
            // 
            // Klijent
            // 
            this.Klijent.AutoSize = true;
            this.Klijent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Klijent.Location = new System.Drawing.Point(418, 15);
            this.Klijent.Name = "Klijent";
            this.Klijent.Size = new System.Drawing.Size(42, 13);
            this.Klijent.TabIndex = 65;
            this.Klijent.Text = "Klijent";
            // 
            // txtPrezimeKlijent
            // 
            this.txtPrezimeKlijent.Location = new System.Drawing.Point(388, 61);
            this.txtPrezimeKlijent.Name = "txtPrezimeKlijent";
            this.txtPrezimeKlijent.Size = new System.Drawing.Size(104, 20);
            this.txtPrezimeKlijent.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Prezime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Datum:";
            // 
            // btnTrazi
            // 
            this.btnTrazi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTrazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrazi.Image = ((System.Drawing.Image)(resources.GetObject("btnTrazi.Image")));
            this.btnTrazi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrazi.Location = new System.Drawing.Point(662, 32);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(69, 23);
            this.btnTrazi.TabIndex = 59;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrazi.UseVisualStyleBackColor = false;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Do:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Od:";
            // 
            // dtpDO
            // 
            this.dtpDO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDO.Location = new System.Drawing.Point(227, 61);
            this.dtpDO.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dtpDO.MinDate = new System.DateTime(1989, 1, 1, 0, 0, 0, 0);
            this.dtpDO.Name = "dtpDO";
            this.dtpDO.Size = new System.Drawing.Size(106, 20);
            this.dtpDO.TabIndex = 56;
            this.dtpDO.Value = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            // 
            // dtpOD
            // 
            this.dtpOD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpOD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOD.Location = new System.Drawing.Point(227, 31);
            this.dtpOD.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dtpOD.MinDate = new System.DateTime(1989, 1, 1, 0, 0, 0, 0);
            this.dtpOD.Name = "dtpOD";
            this.dtpOD.Size = new System.Drawing.Size(106, 20);
            this.dtpOD.TabIndex = 55;
            this.dtpOD.Value = new System.DateTime(1989, 1, 1, 0, 0, 0, 0);
            // 
            // cbxStatusPoruke
            // 
            this.cbxStatusPoruke.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxStatusPoruke.FormattingEnabled = true;
            this.cbxStatusPoruke.Items.AddRange(new object[] {
            "-Odaberite uspjesnost-",
            "Uspjesno",
            "Neuspjesno"});
            this.cbxStatusPoruke.Location = new System.Drawing.Point(48, 46);
            this.cbxStatusPoruke.Name = "cbxStatusPoruke";
            this.cbxStatusPoruke.Size = new System.Drawing.Size(147, 21);
            this.cbxStatusPoruke.TabIndex = 54;
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.AutoSize = true;
            this.lblImePrezime.Location = new System.Drawing.Point(355, 34);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(27, 13);
            this.lblImePrezime.TabIndex = 53;
            this.lblImePrezime.Text = "Ime:";
            // 
            // txtImeKlijent
            // 
            this.txtImeKlijent.Location = new System.Drawing.Point(388, 34);
            this.txtImeKlijent.Name = "txtImeKlijent";
            this.txtImeKlijent.Size = new System.Drawing.Size(104, 20);
            this.txtImeKlijent.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Status poruke:";
            // 
            // dgvPoruke
            // 
            this.dgvPoruke.AllowUserToAddRows = false;
            this.dgvPoruke.AllowUserToDeleteRows = false;
            this.dgvPoruke.AllowUserToOrderColumns = true;
            this.dgvPoruke.AllowUserToResizeColumns = false;
            this.dgvPoruke.AllowUserToResizeRows = false;
            this.dgvPoruke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPoruke.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPoruke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoruke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DatumVrijeme,
            this.Naslov,
            this.Odgovorio,
            this.Klijentt,
            this.Odgovorena});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPoruke.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPoruke.Location = new System.Drawing.Point(19, 88);
            this.dgvPoruke.Name = "dgvPoruke";
            this.dgvPoruke.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPoruke.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPoruke.RowHeadersVisible = false;
            this.dgvPoruke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPoruke.Size = new System.Drawing.Size(746, 258);
            this.dgvPoruke.TabIndex = 73;
            // 
            // label11
            // 
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(16, 353);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 23);
            this.label11.TabIndex = 77;
            // 
            // lblBrojPoruka
            // 
            this.lblBrojPoruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojPoruka.Location = new System.Drawing.Point(121, 356);
            this.lblBrojPoruka.Name = "lblBrojPoruka";
            this.lblBrojPoruka.Size = new System.Drawing.Size(52, 18);
            this.lblBrojPoruka.TabIndex = 76;
            this.lblBrojPoruka.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 18);
            this.label10.TabIndex = 75;
            this.label10.Text = "Broj poruka:";
            // 
            // btnGlavniMeni
            // 
            this.btnGlavniMeni.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGlavniMeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGlavniMeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlavniMeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGlavniMeni.Image = ((System.Drawing.Image)(resources.GetObject("btnGlavniMeni.Image")));
            this.btnGlavniMeni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGlavniMeni.Location = new System.Drawing.Point(413, 352);
            this.btnGlavniMeni.Name = "btnGlavniMeni";
            this.btnGlavniMeni.Size = new System.Drawing.Size(116, 26);
            this.btnGlavniMeni.TabIndex = 74;
            this.btnGlavniMeni.Text = "Meni";
            this.btnGlavniMeni.UseVisualStyleBackColor = false;
            this.btnGlavniMeni.Click += new System.EventHandler(this.btnGlavniMeni_Click);
            // 
            // btnProcitajPoruku
            // 
            this.btnProcitajPoruku.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProcitajPoruku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcitajPoruku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcitajPoruku.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcitajPoruku.Image = ((System.Drawing.Image)(resources.GetObject("btnProcitajPoruku.Image")));
            this.btnProcitajPoruku.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcitajPoruku.Location = new System.Drawing.Point(531, 352);
            this.btnProcitajPoruku.Name = "btnProcitajPoruku";
            this.btnProcitajPoruku.Size = new System.Drawing.Size(116, 26);
            this.btnProcitajPoruku.TabIndex = 78;
            this.btnProcitajPoruku.Text = "Pročitaj poruku";
            this.btnProcitajPoruku.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcitajPoruku.UseVisualStyleBackColor = false;
            this.btnProcitajPoruku.Click += new System.EventHandler(this.btnProcitajPoruku_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIspis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIspis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIspis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIspis.Image = ((System.Drawing.Image)(resources.GetObject("btnIspis.Image")));
            this.btnIspis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIspis.Location = new System.Drawing.Point(649, 352);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(116, 26);
            this.btnIspis.TabIndex = 79;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = false;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // DatumVrijeme
            // 
            this.DatumVrijeme.DataPropertyName = "DatumVrijeme";
            this.DatumVrijeme.FillWeight = 12.69035F;
            this.DatumVrijeme.HeaderText = "Datum i vrijeme";
            this.DatumVrijeme.Name = "DatumVrijeme";
            this.DatumVrijeme.ReadOnly = true;
            // 
            // Naslov
            // 
            this.Naslov.DataPropertyName = "Naslov";
            this.Naslov.FillWeight = 12.69035F;
            this.Naslov.HeaderText = "Naslov";
            this.Naslov.Name = "Naslov";
            this.Naslov.ReadOnly = true;
            // 
            // Odgovorio
            // 
            this.Odgovorio.DataPropertyName = "Odgovorio";
            this.Odgovorio.FillWeight = 12.69035F;
            this.Odgovorio.HeaderText = "Odgovorio";
            this.Odgovorio.Name = "Odgovorio";
            this.Odgovorio.ReadOnly = true;
            // 
            // Klijentt
            // 
            this.Klijentt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Klijentt.DataPropertyName = "Klijentt";
            this.Klijentt.FillWeight = 253.8071F;
            this.Klijentt.HeaderText = "Klijent";
            this.Klijentt.Name = "Klijentt";
            this.Klijentt.ReadOnly = true;
            this.Klijentt.Width = 157;
            // 
            // Odgovorena
            // 
            this.Odgovorena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Odgovorena.DataPropertyName = "Odgovorena";
            this.Odgovorena.FillWeight = 208.1218F;
            this.Odgovorena.HeaderText = "Status poruke";
            this.Odgovorena.Name = "Odgovorena";
            this.Odgovorena.ReadOnly = true;
            this.Odgovorena.Width = 82;
            // 
            // frmPoruke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(787, 391);
            this.ControlBox = false;
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnProcitajPoruku);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblBrojPoruka);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnGlavniMeni);
            this.Controls.Add(this.dgvPoruke);
            this.Controls.Add(this.lblFocus);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrezimeRadnik);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtImeRadnik);
            this.Controls.Add(this.Klijent);
            this.Controls.Add(this.txtPrezimeKlijent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDO);
            this.Controls.Add(this.dtpOD);
            this.Controls.Add(this.cbxStatusPoruke);
            this.Controls.Add(this.lblImePrezime);
            this.Controls.Add(this.txtImeKlijent);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPoruke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eBanking";
            this.Load += new System.EventHandler(this.frmPoruke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoruke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFocus;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrezimeRadnik;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtImeRadnik;
        private System.Windows.Forms.Label Klijent;
        private System.Windows.Forms.TextBox txtPrezimeKlijent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDO;
        private System.Windows.Forms.DateTimePicker dtpOD;
        private System.Windows.Forms.ComboBox cbxStatusPoruke;
        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.TextBox txtImeKlijent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPoruke;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblBrojPoruka;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGlavniMeni;
        private System.Windows.Forms.Button btnProcitajPoruku;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumVrijeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odgovorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klijentt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odgovorena;
    }
}