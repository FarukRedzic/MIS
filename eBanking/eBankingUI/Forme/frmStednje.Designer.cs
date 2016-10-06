namespace eBankingUI.Forme
{
    partial class frmStednje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStednje));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFocus = new System.Windows.Forms.Label();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblBrojStednji = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGlavniMeni = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIznosDO = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIznosOD = new System.Windows.Forms.TextBox();
            this.Klijent = new System.Windows.Forms.Label();
            this.cbxStatusi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDO = new System.Windows.Forms.DateTimePicker();
            this.dtpOD = new System.Windows.Forms.DateTimePicker();
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStednje = new System.Windows.Forms.DataGridView();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojRacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IznosOrocenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IznosNaGlavnicu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumKreiranja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KrajStednje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblFoc = new System.Windows.Forms.Label();
            this.btnIspis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStednje)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFocus
            // 
            this.lblFocus.AutoSize = true;
            this.lblFocus.Location = new System.Drawing.Point(682, -30);
            this.lblFocus.Name = "lblFocus";
            this.lblFocus.Size = new System.Drawing.Size(0, 13);
            this.lblFocus.TabIndex = 77;
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOsvjezi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOsvjezi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOsvjezi.Image = ((System.Drawing.Image)(resources.GetObject("btnOsvjezi.Image")));
            this.btnOsvjezi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOsvjezi.Location = new System.Drawing.Point(745, 52);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(69, 23);
            this.btnOsvjezi.TabIndex = 76;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOsvjezi.UseVisualStyleBackColor = false;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // label11
            // 
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(23, 374);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 23);
            this.label11.TabIndex = 75;
            // 
            // lblBrojStednji
            // 
            this.lblBrojStednji.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojStednji.Location = new System.Drawing.Point(125, 377);
            this.lblBrojStednji.Name = "lblBrojStednji";
            this.lblBrojStednji.Size = new System.Drawing.Size(52, 18);
            this.lblBrojStednji.TabIndex = 74;
            this.lblBrojStednji.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(41, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 18);
            this.label10.TabIndex = 73;
            this.label10.Text = "Broj štednji:";
            // 
            // btnGlavniMeni
            // 
            this.btnGlavniMeni.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGlavniMeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGlavniMeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlavniMeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGlavniMeni.Image = ((System.Drawing.Image)(resources.GetObject("btnGlavniMeni.Image")));
            this.btnGlavniMeni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGlavniMeni.Location = new System.Drawing.Point(756, 371);
            this.btnGlavniMeni.Name = "btnGlavniMeni";
            this.btnGlavniMeni.Size = new System.Drawing.Size(105, 27);
            this.btnGlavniMeni.TabIndex = 72;
            this.btnGlavniMeni.Text = "Meni";
            this.btnGlavniMeni.UseVisualStyleBackColor = false;
            this.btnGlavniMeni.Click += new System.EventHandler(this.btnGlavniMeni_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(584, -29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 70;
            this.label7.Text = "Radnik";
            // 
            // txtIznosDO
            // 
            this.txtIznosDO.Location = new System.Drawing.Point(471, 54);
            this.txtIznosDO.Name = "txtIznosDO";
            this.txtIznosDO.Size = new System.Drawing.Size(104, 20);
            this.txtIznosDO.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(444, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "Do:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(444, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "Od:";
            // 
            // txtIznosOD
            // 
            this.txtIznosOD.Location = new System.Drawing.Point(471, 26);
            this.txtIznosOD.Name = "txtIznosOD";
            this.txtIznosOD.Size = new System.Drawing.Size(104, 20);
            this.txtIznosOD.TabIndex = 66;
            // 
            // Klijent
            // 
            this.Klijent.AutoSize = true;
            this.Klijent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Klijent.Location = new System.Drawing.Point(424, -29);
            this.Klijent.Name = "Klijent";
            this.Klijent.Size = new System.Drawing.Size(42, 13);
            this.Klijent.TabIndex = 65;
            this.Klijent.Text = "Klijent";
            // 
            // cbxStatusi
            // 
            this.cbxStatusi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxStatusi.FormattingEnabled = true;
            this.cbxStatusi.Items.AddRange(new object[] {
            "-Odaberite uspjesnost-",
            "Uspjesno",
            "Neuspjesno"});
            this.cbxStatusi.Location = new System.Drawing.Point(151, 41);
            this.cbxStatusi.Name = "cbxStatusi";
            this.cbxStatusi.Size = new System.Drawing.Size(147, 21);
            this.cbxStatusi.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Status:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(630, 54);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(104, 20);
            this.txtPrezime.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(577, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Prezime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, -29);
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
            this.btnTrazi.Location = new System.Drawing.Point(745, 25);
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
            this.label3.Location = new System.Drawing.Point(307, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Do:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Od:";
            // 
            // dtpDO
            // 
            this.dtpDO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDO.Location = new System.Drawing.Point(333, 54);
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
            this.dtpOD.Location = new System.Drawing.Point(333, 27);
            this.dtpOD.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dtpOD.MinDate = new System.DateTime(1989, 1, 1, 0, 0, 0, 0);
            this.dtpOD.Name = "dtpOD";
            this.dtpOD.Size = new System.Drawing.Size(106, 20);
            this.dtpOD.TabIndex = 55;
            this.dtpOD.Value = new System.DateTime(1989, 1, 1, 0, 0, 0, 0);
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.AutoSize = true;
            this.lblImePrezime.Location = new System.Drawing.Point(597, 26);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(27, 13);
            this.lblImePrezime.TabIndex = 53;
            this.lblImePrezime.Text = "Ime:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(630, 26);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(104, 20);
            this.txtIme.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, -29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Status:";
            // 
            // dgvStednje
            // 
            this.dgvStednje.AllowUserToAddRows = false;
            this.dgvStednje.AllowUserToDeleteRows = false;
            this.dgvStednje.AllowUserToOrderColumns = true;
            this.dgvStednje.AllowUserToResizeColumns = false;
            this.dgvStednje.AllowUserToResizeRows = false;
            this.dgvStednje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStednje.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStednje.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStednje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStednje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.JMBG,
            this.BrojRacuna,
            this.IznosOrocenja,
            this.IznosNaGlavnicu,
            this.DatumKreiranja,
            this.KrajStednje,
            this.Status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStednje.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStednje.Location = new System.Drawing.Point(26, 88);
            this.dgvStednje.Name = "dgvStednje";
            this.dgvStednje.ReadOnly = true;
            this.dgvStednje.RowHeadersVisible = false;
            this.dgvStednje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStednje.Size = new System.Drawing.Size(942, 277);
            this.dgvStednje.TabIndex = 78;
            // 
            // ImePrezime
            // 
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.HeaderText = "Ime i prezime";
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            // 
            // JMBG
            // 
            this.JMBG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.JMBG.DataPropertyName = "JMBG";
            this.JMBG.HeaderText = "JMBG";
            this.JMBG.Name = "JMBG";
            this.JMBG.ReadOnly = true;
            // 
            // BrojRacuna
            // 
            this.BrojRacuna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BrojRacuna.DataPropertyName = "BrojRacuna";
            this.BrojRacuna.HeaderText = "Broj računa";
            this.BrojRacuna.Name = "BrojRacuna";
            this.BrojRacuna.ReadOnly = true;
            this.BrojRacuna.Width = 114;
            // 
            // IznosOrocenja
            // 
            this.IznosOrocenja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IznosOrocenja.DataPropertyName = "IznosOrocenja";
            this.IznosOrocenja.HeaderText = "Iznos oročenja";
            this.IznosOrocenja.Name = "IznosOrocenja";
            this.IznosOrocenja.ReadOnly = true;
            this.IznosOrocenja.Width = 113;
            // 
            // IznosNaGlavnicu
            // 
            this.IznosNaGlavnicu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IznosNaGlavnicu.DataPropertyName = "IznosNaGlavnicu";
            this.IznosNaGlavnicu.HeaderText = "Iznos na glavnicu";
            this.IznosNaGlavnicu.Name = "IznosNaGlavnicu";
            this.IznosNaGlavnicu.ReadOnly = true;
            this.IznosNaGlavnicu.Width = 158;
            // 
            // DatumKreiranja
            // 
            this.DatumKreiranja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DatumKreiranja.DataPropertyName = "DatumKreiranja";
            this.DatumKreiranja.HeaderText = "Početak štednje";
            this.DatumKreiranja.Name = "DatumKreiranja";
            this.DatumKreiranja.ReadOnly = true;
            this.DatumKreiranja.Width = 113;
            // 
            // KrajStednje
            // 
            this.KrajStednje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.KrajStednje.DataPropertyName = "KrajStednje";
            this.KrajStednje.HeaderText = "Kraj štednje";
            this.KrajStednje.Name = "KrajStednje";
            this.KrajStednje.ReadOnly = true;
            this.KrajStednje.Width = 114;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 113;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(468, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 79;
            this.label12.Text = "Iznos oročenja:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(330, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 80;
            this.label13.Text = "Period štednje:";
            // 
            // lblFoc
            // 
            this.lblFoc.AutoSize = true;
            this.lblFoc.Location = new System.Drawing.Point(926, 43);
            this.lblFoc.Name = "lblFoc";
            this.lblFoc.Size = new System.Drawing.Size(0, 13);
            this.lblFoc.TabIndex = 81;
            // 
            // btnIspis
            // 
            this.btnIspis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIspis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIspis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIspis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIspis.Image = ((System.Drawing.Image)(resources.GetObject("btnIspis.Image")));
            this.btnIspis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIspis.Location = new System.Drawing.Point(863, 371);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(105, 27);
            this.btnIspis.TabIndex = 82;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = false;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // frmStednje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(995, 409);
            this.ControlBox = false;
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.lblFoc);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvStednje);
            this.Controls.Add(this.lblFocus);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblBrojStednji);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnGlavniMeni);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIznosDO);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIznosOD);
            this.Controls.Add(this.Klijent);
            this.Controls.Add(this.cbxStatusi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDO);
            this.Controls.Add(this.dtpOD);
            this.Controls.Add(this.lblImePrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmStednje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eBanking";
            this.Load += new System.EventHandler(this.frmStednje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStednje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFocus;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblBrojStednji;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGlavniMeni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIznosDO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIznosOD;
        private System.Windows.Forms.Label Klijent;
        private System.Windows.Forms.ComboBox cbxStatusi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDO;
        private System.Windows.Forms.DateTimePicker dtpOD;
        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStednje;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn JMBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojRacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn IznosOrocenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn IznosNaGlavnicu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumKreiranja;
        private System.Windows.Forms.DataGridViewTextBoxColumn KrajStednje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblFoc;
        private System.Windows.Forms.Button btnIspis;
    }
}