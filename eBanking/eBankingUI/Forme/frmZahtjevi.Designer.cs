namespace eBankingUI.Forme
{
    partial class frmZahtjevi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZahtjevi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPrezimeKlijent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDO = new System.Windows.Forms.DateTimePicker();
            this.dtpOD = new System.Windows.Forms.DateTimePicker();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.txtImeKlijent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTipZahtjevi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Klijent = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrezimeRadnik = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtImeRadnik = new System.Windows.Forms.TextBox();
            this.dgvZahtjevi = new System.Windows.Forms.DataGridView();
            this.DatumKreiranja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KlijentImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obradio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipZahtjeva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGlavniMeni = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblBrojZahtjeva = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.lblFocus = new System.Windows.Forms.Label();
            this.btnIspis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrezimeKlijent
            // 
            this.txtPrezimeKlijent.Location = new System.Drawing.Point(366, 63);
            this.txtPrezimeKlijent.Name = "txtPrezimeKlijent";
            this.txtPrezimeKlijent.Size = new System.Drawing.Size(104, 20);
            this.txtPrezimeKlijent.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Prezime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 32;
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
            this.btnTrazi.Location = new System.Drawing.Point(636, 33);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(65, 23);
            this.btnTrazi.TabIndex = 31;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrazi.UseVisualStyleBackColor = false;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Do:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Od:";
            // 
            // dtpDO
            // 
            this.dtpDO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDO.Location = new System.Drawing.Point(205, 63);
            this.dtpDO.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dtpDO.MinDate = new System.DateTime(1989, 1, 1, 0, 0, 0, 0);
            this.dtpDO.Name = "dtpDO";
            this.dtpDO.Size = new System.Drawing.Size(106, 20);
            this.dtpDO.TabIndex = 28;
            this.dtpDO.Value = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            // 
            // dtpOD
            // 
            this.dtpOD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpOD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOD.Location = new System.Drawing.Point(205, 32);
            this.dtpOD.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dtpOD.MinDate = new System.DateTime(1989, 1, 1, 0, 0, 0, 0);
            this.dtpOD.Name = "dtpOD";
            this.dtpOD.Size = new System.Drawing.Size(106, 20);
            this.dtpOD.TabIndex = 27;
            this.dtpOD.Value = new System.DateTime(1989, 1, 1, 0, 0, 0, 0);
            // 
            // cbxStatus
            // 
            this.cbxStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "-Odaberite uspjesnost-",
            "Uspjesno",
            "Neuspjesno"});
            this.cbxStatus.Location = new System.Drawing.Point(28, 28);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(147, 21);
            this.cbxStatus.TabIndex = 26;
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.AutoSize = true;
            this.lblImePrezime.Location = new System.Drawing.Point(333, 35);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(27, 13);
            this.lblImePrezime.TabIndex = 25;
            this.lblImePrezime.Text = "Ime:";
            // 
            // txtImeKlijent
            // 
            this.txtImeKlijent.Location = new System.Drawing.Point(366, 35);
            this.txtImeKlijent.Name = "txtImeKlijent";
            this.txtImeKlijent.Size = new System.Drawing.Size(104, 20);
            this.txtImeKlijent.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Status:";
            // 
            // cbxTipZahtjevi
            // 
            this.cbxTipZahtjevi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxTipZahtjevi.FormattingEnabled = true;
            this.cbxTipZahtjevi.Items.AddRange(new object[] {
            "-Odaberite uspjesnost-",
            "Uspjesno",
            "Neuspjesno"});
            this.cbxTipZahtjevi.Location = new System.Drawing.Point(28, 66);
            this.cbxTipZahtjevi.Name = "cbxTipZahtjevi";
            this.cbxTipZahtjevi.Size = new System.Drawing.Size(147, 21);
            this.cbxTipZahtjevi.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Tip zahtjeva:";
            // 
            // Klijent
            // 
            this.Klijent.AutoSize = true;
            this.Klijent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Klijent.Location = new System.Drawing.Point(396, 16);
            this.Klijent.Name = "Klijent";
            this.Klijent.Size = new System.Drawing.Size(42, 13);
            this.Klijent.TabIndex = 37;
            this.Klijent.Text = "Klijent";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(555, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Radnik";
            // 
            // txtPrezimeRadnik
            // 
            this.txtPrezimeRadnik.Location = new System.Drawing.Point(526, 63);
            this.txtPrezimeRadnik.Name = "txtPrezimeRadnik";
            this.txtPrezimeRadnik.Size = new System.Drawing.Size(104, 20);
            this.txtPrezimeRadnik.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(473, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Prezime:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(493, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Ime:";
            // 
            // txtImeRadnik
            // 
            this.txtImeRadnik.Location = new System.Drawing.Point(526, 35);
            this.txtImeRadnik.Name = "txtImeRadnik";
            this.txtImeRadnik.Size = new System.Drawing.Size(104, 20);
            this.txtImeRadnik.TabIndex = 38;
            // 
            // dgvZahtjevi
            // 
            this.dgvZahtjevi.AllowUserToAddRows = false;
            this.dgvZahtjevi.AllowUserToDeleteRows = false;
            this.dgvZahtjevi.AllowUserToOrderColumns = true;
            this.dgvZahtjevi.AllowUserToResizeColumns = false;
            this.dgvZahtjevi.AllowUserToResizeRows = false;
            this.dgvZahtjevi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvZahtjevi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvZahtjevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZahtjevi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DatumKreiranja,
            this.KlijentImePrezime,
            this.Obradio,
            this.Status,
            this.TipZahtjeva});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZahtjevi.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvZahtjevi.Location = new System.Drawing.Point(46, 93);
            this.dgvZahtjevi.Name = "dgvZahtjevi";
            this.dgvZahtjevi.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZahtjevi.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvZahtjevi.RowHeadersVisible = false;
            this.dgvZahtjevi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZahtjevi.Size = new System.Drawing.Size(619, 258);
            this.dgvZahtjevi.TabIndex = 43;
            // 
            // DatumKreiranja
            // 
            this.DatumKreiranja.DataPropertyName = "DatumKreiranja";
            this.DatumKreiranja.FillWeight = 12.69035F;
            this.DatumKreiranja.HeaderText = "Datum i vrijeme kreiranja";
            this.DatumKreiranja.Name = "DatumKreiranja";
            this.DatumKreiranja.ReadOnly = true;
            // 
            // KlijentImePrezime
            // 
            this.KlijentImePrezime.DataPropertyName = "KlijentImePrezime";
            this.KlijentImePrezime.FillWeight = 12.69035F;
            this.KlijentImePrezime.HeaderText = "Klijent";
            this.KlijentImePrezime.Name = "KlijentImePrezime";
            this.KlijentImePrezime.ReadOnly = true;
            // 
            // Obradio
            // 
            this.Obradio.DataPropertyName = "Obradio";
            this.Obradio.FillWeight = 12.69035F;
            this.Obradio.HeaderText = "Obradio";
            this.Obradio.Name = "Obradio";
            this.Obradio.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Status.DataPropertyName = "Status";
            this.Status.FillWeight = 253.8071F;
            this.Status.HeaderText = "Status zahtjeva";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // TipZahtjeva
            // 
            this.TipZahtjeva.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TipZahtjeva.DataPropertyName = "TipZahtjeva";
            this.TipZahtjeva.FillWeight = 208.1218F;
            this.TipZahtjeva.HeaderText = "Tip zahtjeva";
            this.TipZahtjeva.Name = "TipZahtjeva";
            this.TipZahtjeva.ReadOnly = true;
            this.TipZahtjeva.Width = 140;
            // 
            // btnGlavniMeni
            // 
            this.btnGlavniMeni.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGlavniMeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGlavniMeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlavniMeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGlavniMeni.Image = ((System.Drawing.Image)(resources.GetObject("btnGlavniMeni.Image")));
            this.btnGlavniMeni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGlavniMeni.Location = new System.Drawing.Point(452, 356);
            this.btnGlavniMeni.Name = "btnGlavniMeni";
            this.btnGlavniMeni.Size = new System.Drawing.Size(105, 27);
            this.btnGlavniMeni.TabIndex = 44;
            this.btnGlavniMeni.Text = "Meni";
            this.btnGlavniMeni.UseVisualStyleBackColor = false;
            this.btnGlavniMeni.Click += new System.EventHandler(this.btnGlavniMeni_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(62, 361);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 18);
            this.label10.TabIndex = 46;
            this.label10.Text = "Broj zahtjeva:";
            // 
            // lblBrojZahtjeva
            // 
            this.lblBrojZahtjeva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojZahtjeva.Location = new System.Drawing.Point(155, 362);
            this.lblBrojZahtjeva.Name = "lblBrojZahtjeva";
            this.lblBrojZahtjeva.Size = new System.Drawing.Size(52, 18);
            this.lblBrojZahtjeva.TabIndex = 47;
            this.lblBrojZahtjeva.Text = "label11";
            // 
            // label11
            // 
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(44, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 23);
            this.label11.TabIndex = 48;
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOsvjezi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOsvjezi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOsvjezi.Image = ((System.Drawing.Image)(resources.GetObject("btnOsvjezi.Image")));
            this.btnOsvjezi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOsvjezi.Location = new System.Drawing.Point(636, 60);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(65, 23);
            this.btnOsvjezi.TabIndex = 49;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOsvjezi.UseVisualStyleBackColor = false;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // lblFocus
            // 
            this.lblFocus.AutoSize = true;
            this.lblFocus.Location = new System.Drawing.Point(654, 12);
            this.lblFocus.Name = "lblFocus";
            this.lblFocus.Size = new System.Drawing.Size(0, 13);
            this.lblFocus.TabIndex = 50;
            // 
            // btnIspis
            // 
            this.btnIspis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIspis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIspis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIspis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIspis.Image = ((System.Drawing.Image)(resources.GetObject("btnIspis.Image")));
            this.btnIspis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIspis.Location = new System.Drawing.Point(560, 356);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(105, 27);
            this.btnIspis.TabIndex = 51;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = false;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // frmZahtjevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(726, 398);
            this.ControlBox = false;
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.lblFocus);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblBrojZahtjeva);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnGlavniMeni);
            this.Controls.Add(this.dgvZahtjevi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrezimeRadnik);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtImeRadnik);
            this.Controls.Add(this.Klijent);
            this.Controls.Add(this.cbxTipZahtjevi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrezimeKlijent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDO);
            this.Controls.Add(this.dtpOD);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.lblImePrezime);
            this.Controls.Add(this.txtImeKlijent);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmZahtjevi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eBanking";
            this.Load += new System.EventHandler(this.Zahtjevi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrezimeKlijent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDO;
        private System.Windows.Forms.DateTimePicker dtpOD;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.TextBox txtImeKlijent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTipZahtjevi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Klijent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrezimeRadnik;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtImeRadnik;
        private System.Windows.Forms.DataGridView dgvZahtjevi;
        private System.Windows.Forms.Button btnGlavniMeni;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblBrojZahtjeva;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumKreiranja;
        private System.Windows.Forms.DataGridViewTextBoxColumn KlijentImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obradio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipZahtjeva;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.Label lblFocus;
        private System.Windows.Forms.Button btnIspis;
    }
}