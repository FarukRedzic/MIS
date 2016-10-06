namespace eBankingUI.Forme
{
    partial class frmRacuniDetalji
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRacuniDetalji));
            this.dgvRacuniDetalji = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumOtvaranja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojRacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipRacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Limit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTransakcije = new System.Windows.Forms.DataGridView();
            this.DatumVrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IznosPoreza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValutaNovca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKlijent = new System.Windows.Forms.Label();
            this.lblBrojRacuna = new System.Windows.Forms.Label();
            this.btnIspis = new System.Windows.Forms.Button();
            this.lblFocus = new System.Windows.Forms.Label();
            this.btnGraf = new System.Windows.Forms.Button();
            this.btnMatrica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuniDetalji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransakcije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRacuniDetalji
            // 
            this.dgvRacuniDetalji.AllowUserToAddRows = false;
            this.dgvRacuniDetalji.AllowUserToDeleteRows = false;
            this.dgvRacuniDetalji.AllowUserToOrderColumns = true;
            this.dgvRacuniDetalji.AllowUserToResizeColumns = false;
            this.dgvRacuniDetalji.AllowUserToResizeRows = false;
            this.dgvRacuniDetalji.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRacuniDetalji.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRacuniDetalji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacuniDetalji.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DatumOtvaranja,
            this.BrojRacuna,
            this.TipRacuna,
            this.Valuta,
            this.Stanje,
            this.Limit});
            this.dgvRacuniDetalji.Location = new System.Drawing.Point(18, 82);
            this.dgvRacuniDetalji.Name = "dgvRacuniDetalji";
            this.dgvRacuniDetalji.ReadOnly = true;
            this.dgvRacuniDetalji.RowHeadersVisible = false;
            this.dgvRacuniDetalji.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRacuniDetalji.Size = new System.Drawing.Size(735, 139);
            this.dgvRacuniDetalji.TabIndex = 0;
            this.dgvRacuniDetalji.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRacuniDetalji_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // DatumOtvaranja
            // 
            this.DatumOtvaranja.DataPropertyName = "DatumOtvaranja";
            this.DatumOtvaranja.HeaderText = "Datum otvaranja";
            this.DatumOtvaranja.Name = "DatumOtvaranja";
            this.DatumOtvaranja.ReadOnly = true;
            // 
            // BrojRacuna
            // 
            this.BrojRacuna.DataPropertyName = "BrojRacuna";
            this.BrojRacuna.HeaderText = "Broj računa";
            this.BrojRacuna.Name = "BrojRacuna";
            this.BrojRacuna.ReadOnly = true;
            // 
            // TipRacuna
            // 
            this.TipRacuna.DataPropertyName = "TipRacuna";
            this.TipRacuna.HeaderText = "Tip računa";
            this.TipRacuna.Name = "TipRacuna";
            this.TipRacuna.ReadOnly = true;
            // 
            // Valuta
            // 
            this.Valuta.DataPropertyName = "Valuta";
            this.Valuta.HeaderText = "Valuta";
            this.Valuta.Name = "Valuta";
            this.Valuta.ReadOnly = true;
            // 
            // Stanje
            // 
            this.Stanje.DataPropertyName = "Stanje";
            this.Stanje.HeaderText = "Stanje";
            this.Stanje.Name = "Stanje";
            this.Stanje.ReadOnly = true;
            // 
            // Limit
            // 
            this.Limit.DataPropertyName = "Limit";
            this.Limit.HeaderText = "Limit";
            this.Limit.Name = "Limit";
            this.Limit.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Računi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Transakcije odabranog računa:";
            // 
            // dgvTransakcije
            // 
            this.dgvTransakcije.AllowUserToAddRows = false;
            this.dgvTransakcije.AllowUserToDeleteRows = false;
            this.dgvTransakcije.AllowUserToOrderColumns = true;
            this.dgvTransakcije.AllowUserToResizeColumns = false;
            this.dgvTransakcije.AllowUserToResizeRows = false;
            this.dgvTransakcije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransakcije.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTransakcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransakcije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DatumVrijeme,
            this.Iznos,
            this.IznosPoreza,
            this.ValutaNovca,
            this.Opis});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransakcije.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransakcije.Location = new System.Drawing.Point(75, 259);
            this.dgvTransakcije.Name = "dgvTransakcije";
            this.dgvTransakcije.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransakcije.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransakcije.RowHeadersVisible = false;
            this.dgvTransakcije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransakcije.Size = new System.Drawing.Size(614, 185);
            this.dgvTransakcije.TabIndex = 3;
            // 
            // DatumVrijeme
            // 
            this.DatumVrijeme.DataPropertyName = "DatumVrijeme";
            this.DatumVrijeme.HeaderText = "Datum vrijeme";
            this.DatumVrijeme.Name = "DatumVrijeme";
            this.DatumVrijeme.ReadOnly = true;
            // 
            // Iznos
            // 
            this.Iznos.DataPropertyName = "Iznos";
            this.Iznos.HeaderText = "Iznos";
            this.Iznos.MaxInputLength = 15;
            this.Iznos.Name = "Iznos";
            this.Iznos.ReadOnly = true;
            // 
            // IznosPoreza
            // 
            this.IznosPoreza.DataPropertyName = "IznosPoreza";
            this.IznosPoreza.HeaderText = "Iznos poreza";
            this.IznosPoreza.Name = "IznosPoreza";
            this.IznosPoreza.ReadOnly = true;
            // 
            // ValutaNovca
            // 
            this.ValutaNovca.DataPropertyName = "ValutaNovca";
            this.ValutaNovca.HeaderText = "Valuta";
            this.ValutaNovca.Name = "ValutaNovca";
            this.ValutaNovca.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(142, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Nazad";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Klijent:";
            // 
            // lblKlijent
            // 
            this.lblKlijent.AutoSize = true;
            this.lblKlijent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKlijent.Location = new System.Drawing.Point(79, 23);
            this.lblKlijent.Name = "lblKlijent";
            this.lblKlijent.Size = new System.Drawing.Size(60, 24);
            this.lblKlijent.TabIndex = 6;
            this.lblKlijent.Text = "label4";
            // 
            // lblBrojRacuna
            // 
            this.lblBrojRacuna.AutoSize = true;
            this.lblBrojRacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojRacuna.Location = new System.Drawing.Point(297, 234);
            this.lblBrojRacuna.Name = "lblBrojRacuna";
            this.lblBrojRacuna.Size = new System.Drawing.Size(0, 18);
            this.lblBrojRacuna.TabIndex = 7;
            // 
            // btnIspis
            // 
            this.btnIspis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIspis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIspis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIspis.Image = ((System.Drawing.Image)(resources.GetObject("btnIspis.Image")));
            this.btnIspis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIspis.Location = new System.Drawing.Point(499, 450);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(116, 27);
            this.btnIspis.TabIndex = 8;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = false;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // lblFocus
            // 
            this.lblFocus.AutoSize = true;
            this.lblFocus.Location = new System.Drawing.Point(420, 23);
            this.lblFocus.Name = "lblFocus";
            this.lblFocus.Size = new System.Drawing.Size(0, 13);
            this.lblFocus.TabIndex = 9;
            // 
            // btnGraf
            // 
            this.btnGraf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGraf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGraf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraf.Image = ((System.Drawing.Image)(resources.GetObject("btnGraf.Image")));
            this.btnGraf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGraf.Location = new System.Drawing.Point(261, 450);
            this.btnGraf.Name = "btnGraf";
            this.btnGraf.Size = new System.Drawing.Size(116, 27);
            this.btnGraf.TabIndex = 90;
            this.btnGraf.Text = "Grafički prikaz";
            this.btnGraf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGraf.UseVisualStyleBackColor = false;
            this.btnGraf.Click += new System.EventHandler(this.btnGraf_Click);
            // 
            // btnMatrica
            // 
            this.btnMatrica.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMatrica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMatrica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatrica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatrica.Image = ((System.Drawing.Image)(resources.GetObject("btnMatrica.Image")));
            this.btnMatrica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMatrica.Location = new System.Drawing.Point(380, 450);
            this.btnMatrica.Name = "btnMatrica";
            this.btnMatrica.Size = new System.Drawing.Size(116, 27);
            this.btnMatrica.TabIndex = 89;
            this.btnMatrica.Text = "Matrični prikaz";
            this.btnMatrica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMatrica.UseVisualStyleBackColor = false;
            this.btnMatrica.Click += new System.EventHandler(this.btnMatrica_Click);
            // 
            // frmRacuniDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(772, 493);
            this.ControlBox = false;
            this.Controls.Add(this.btnGraf);
            this.Controls.Add(this.btnMatrica);
            this.Controls.Add(this.lblFocus);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.lblBrojRacuna);
            this.Controls.Add(this.lblKlijent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvTransakcije);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRacuniDetalji);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRacuniDetalji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eBanking";
            this.Load += new System.EventHandler(this.frmRacuniDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuniDetalji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransakcije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRacuniDetalji;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTransakcije;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumOtvaranja;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojRacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipRacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumVrijeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iznos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IznosPoreza;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValutaNovca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKlijent;
        private System.Windows.Forms.Label lblBrojRacuna;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Label lblFocus;
        private System.Windows.Forms.Button btnGraf;
        private System.Windows.Forms.Button btnMatrica;
    }
}