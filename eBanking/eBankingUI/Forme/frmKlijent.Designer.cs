namespace eBankingUI.Forme
{
    partial class frmKlijent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKlijent));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnUplatnice = new System.Windows.Forms.Button();
            this.lblfoc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBroj = new System.Windows.Forms.Label();
            this.btnMeni = new System.Windows.Forms.Button();
            this.btnRacuni = new System.Windows.Forms.Button();
            this.dgvKlijenti = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnouUtroseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUplatnice
            // 
            this.btnUplatnice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUplatnice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUplatnice.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUplatnice.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUplatnice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUplatnice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUplatnice.Image = ((System.Drawing.Image)(resources.GetObject("btnUplatnice.Image")));
            this.btnUplatnice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUplatnice.Location = new System.Drawing.Point(738, 322);
            this.btnUplatnice.Name = "btnUplatnice";
            this.btnUplatnice.Size = new System.Drawing.Size(119, 30);
            this.btnUplatnice.TabIndex = 31;
            this.btnUplatnice.Text = "Pregled uplatnica";
            this.btnUplatnice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUplatnice.UseVisualStyleBackColor = false;
            // 
            // lblfoc
            // 
            this.lblfoc.AutoSize = true;
            this.lblfoc.Location = new System.Drawing.Point(865, 14);
            this.lblfoc.Name = "lblfoc";
            this.lblfoc.Size = new System.Drawing.Size(35, 13);
            this.lblfoc.TabIndex = 30;
            this.lblfoc.Text = "label6";
            this.lblfoc.Visible = false;
            // 
            // label4
            // 
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(13, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 23);
            this.label4.TabIndex = 29;
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOsvjezi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOsvjezi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOsvjezi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOsvjezi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOsvjezi.Image = ((System.Drawing.Image)(resources.GetObject("btnOsvjezi.Image")));
            this.btnOsvjezi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOsvjezi.Location = new System.Drawing.Point(735, 9);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(65, 25);
            this.btnOsvjezi.TabIndex = 28;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOsvjezi.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Broj klijenata:";
            // 
            // lblBroj
            // 
            this.lblBroj.AutoSize = true;
            this.lblBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBroj.Location = new System.Drawing.Point(122, 330);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(52, 18);
            this.lblBroj.TabIndex = 26;
            this.lblBroj.Text = "label4";
            // 
            // btnMeni
            // 
            this.btnMeni.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMeni.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMeni.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeni.Image = ((System.Drawing.Image)(resources.GetObject("btnMeni.Image")));
            this.btnMeni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMeni.Location = new System.Drawing.Point(615, 322);
            this.btnMeni.Name = "btnMeni";
            this.btnMeni.Size = new System.Drawing.Size(119, 30);
            this.btnMeni.TabIndex = 25;
            this.btnMeni.Text = "Meni";
            this.btnMeni.UseVisualStyleBackColor = false;
            this.btnMeni.Click += new System.EventHandler(this.btnMeni_Click);
            // 
            // btnRacuni
            // 
            this.btnRacuni.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRacuni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRacuni.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRacuni.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRacuni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRacuni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRacuni.Image = ((System.Drawing.Image)(resources.GetObject("btnRacuni.Image")));
            this.btnRacuni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRacuni.Location = new System.Drawing.Point(860, 322);
            this.btnRacuni.Name = "btnRacuni";
            this.btnRacuni.Size = new System.Drawing.Size(119, 30);
            this.btnRacuni.TabIndex = 24;
            this.btnRacuni.Text = "Pregled računa";
            this.btnRacuni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRacuni.UseVisualStyleBackColor = false;
            // 
            // dgvKlijenti
            // 
            this.dgvKlijenti.AllowUserToAddRows = false;
            this.dgvKlijenti.AllowUserToDeleteRows = false;
            this.dgvKlijenti.AllowUserToOrderColumns = true;
            this.dgvKlijenti.AllowUserToResizeColumns = false;
            this.dgvKlijenti.AllowUserToResizeRows = false;
            this.dgvKlijenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKlijenti.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKlijenti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ImePrezime,
            this.Naziv,
            this.JMBG,
            this.DatumRodjenja,
            this.Email,
            this.Telefon,
            this.Status,
            this.UkupnouUtroseno});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKlijenti.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKlijenti.Location = new System.Drawing.Point(12, 39);
            this.dgvKlijenti.Name = "dgvKlijenti";
            this.dgvKlijenti.ReadOnly = true;
            this.dgvKlijenti.RowHeadersVisible = false;
            this.dgvKlijenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKlijenti.Size = new System.Drawing.Size(967, 277);
            this.dgvKlijenti.TabIndex = 23;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // ImePrezime
            // 
            this.ImePrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.HeaderText = "Ime i prezime";
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            this.ImePrezime.Width = 114;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Naziv.DataPropertyName = "Opstina";
            this.Naziv.HeaderText = "Opština";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // JMBG
            // 
            this.JMBG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.JMBG.DataPropertyName = "JMBG";
            this.JMBG.HeaderText = "JMBG";
            this.JMBG.Name = "JMBG";
            this.JMBG.ReadOnly = true;
            this.JMBG.Width = 114;
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DatumRodjenja.DataPropertyName = "DatumRodjenja";
            this.DatumRodjenja.HeaderText = "Datum rođenja";
            this.DatumRodjenja.Name = "DatumRodjenja";
            this.DatumRodjenja.ReadOnly = true;
            this.DatumRodjenja.Width = 113;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 158;
            // 
            // Telefon
            // 
            this.Telefon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            this.Telefon.Width = 113;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 114;
            // 
            // UkupnouUtroseno
            // 
            this.UkupnouUtroseno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UkupnouUtroseno.DataPropertyName = "UkupnouUtroseno";
            this.UkupnouUtroseno.HeaderText = "Ukupno utrošio";
            this.UkupnouUtroseno.Name = "UkupnouUtroseno";
            this.UkupnouUtroseno.ReadOnly = true;
            this.UkupnouUtroseno.Width = 113;
            // 
            // btnTrazi
            // 
            this.btnTrazi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTrazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrazi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTrazi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrazi.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnTrazi.Image = ((System.Drawing.Image)(resources.GetObject("btnTrazi.Image")));
            this.btnTrazi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrazi.Location = new System.Drawing.Point(665, 9);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(65, 25);
            this.btnTrazi.TabIndex = 22;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrazi.UseVisualStyleBackColor = false;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(551, 13);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 21;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(392, 13);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(501, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Prezime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Status:";
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(236, 12);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(121, 21);
            this.cbxStatus.TabIndex = 16;
            // 
            // frmKlijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 389);
            this.Controls.Add(this.btnUplatnice);
            this.Controls.Add(this.lblfoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBroj);
            this.Controls.Add(this.btnMeni);
            this.Controls.Add(this.btnRacuni);
            this.Controls.Add(this.dgvKlijenti);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxStatus);
            this.Name = "frmKlijent";
            this.Text = "frmKlijent";
            this.Load += new System.EventHandler(this.frmKlijent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUplatnice;
        private System.Windows.Forms.Label lblfoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBroj;
        private System.Windows.Forms.Button btnMeni;
        private System.Windows.Forms.Button btnRacuni;
        private System.Windows.Forms.DataGridView dgvKlijenti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn JMBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnouUtroseno;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxStatus;
    }
}