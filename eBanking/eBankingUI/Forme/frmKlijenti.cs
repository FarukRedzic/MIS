using eBankingDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBankingUI.Forme
{
    public partial class frmKlijenti : Form
    {
        DSKlijent dsKlijent = new DSKlijent();

        public frmKlijenti()
        {
            InitializeComponent();
        }

        private void frmKlijenti_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            DAKlijent.getStatusi(dsKlijent.Aktivan);
            cbxStatus.DataSource = dsKlijent.Aktivan;
            cbxStatus.DisplayMember = "Status";
            cbxStatus.ValueMember = "AktivanID";

            DAKlijent.getKlijenti(dsKlijent.Klijents, Convert.ToInt32(cbxStatus.SelectedValue), txtIme.Text.Trim(), txtPrezime.Text.Trim());
            dgvKlijenti.AutoGenerateColumns = false;
            dgvKlijenti.DataSource = dsKlijent.Klijents;

            lblBroj.Text = dsKlijent.Klijents.Count().ToString();
            dgvKlijenti.Rows[0].Selected = false;

        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            lblfoc.Focus();
            DAKlijent.getKlijenti(dsKlijent.Klijents, Convert.ToInt32(cbxStatus.SelectedValue), txtIme.Text.Trim(), txtPrezime.Text.Trim());
            dgvKlijenti.AutoGenerateColumns = false;
            dgvKlijenti.DataSource = dsKlijent.Klijents;
            lblBroj.Text = dsKlijent.Klijents.Count.ToString();
        }

        private void btnRacuni_Click(object sender, EventArgs e)
        {
            if (!ValidacijaSelectedRow())
            {
                MessageBox.Show("Potrebno je da označite klijenta.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int KlijentID = Convert.ToInt32(dgvKlijenti.SelectedRows[0].Cells[0].Value);
                new frmRacuniDetalji(KlijentID).ShowDialog();
            }
        }

        private void btnMeni_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmMain().Show();
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            lblfoc.Focus();
            txtIme.Text = "";
            txtPrezime.Text = "";
            cbxStatus.SelectedIndex = 0;
            DAKlijent.getKlijenti(dsKlijent.Klijents, Convert.ToInt32(cbxStatus.SelectedValue), txtIme.Text.Trim(), txtPrezime.Text.Trim());
            dgvKlijenti.AutoGenerateColumns = false;
            dgvKlijenti.DataSource = dsKlijent.Klijents;

            lblBroj.Text = dsKlijent.Klijents.Count().ToString();
        }
        private bool ValidacijaSelectedRow()
        {
            for (int i = 0; i < dgvKlijenti.RowCount; i++)
            {
                if (dgvKlijenti.Rows[i].Selected)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnUplatnice_Click(object sender, EventArgs e)
        {
            if (!ValidacijaSelectedRow())
            {
                MessageBox.Show("Potrebno je da označite klijenta.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int KlijentID = Convert.ToInt32(dgvKlijenti.SelectedRows[0].Cells[0].Value);
                this.Close();
                new frmUplatniceDetalji(KlijentID).Show();
            }
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            Reports.frmReports frm = new Reports.frmReports("Klijenti", Convert.ToInt32(cbxStatus.SelectedValue), txtIme.Text.Trim(), txtPrezime.Text.Trim());
            frm.Show();
        }
    }
}
