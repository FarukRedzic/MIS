using eBankingDAL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace eBankingUI.Forme
{
    public partial class frmLogovi : Form
    {
        private DSLogovi dsLogovi = new DSLogovi();

        public frmLogovi()
        {
            InitializeComponent();
        }

        private void frmLogovi_Load(object sender, EventArgs e)
        {
            lblFocus.Focus();
            cbxUspjeh.SelectedIndex = 0;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            DALogovi.getLogovi(dsLogovi.LogPrijavas, null, txtIPAdresa.Text.Trim(), txtIme.Text.Trim(),txtPrezime.Text.Trim() ,dtpOD.Value, dtpDO.Value);
            dgvLogovi.AutoGenerateColumns = false;
            dgvLogovi.DataSource = dsLogovi.LogPrijavas;
            lblBroj.Text = dsLogovi.LogPrijavas.Count.ToString();
        }

        private void btnGlavniMeni_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmMain().Show();
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            lblFocus.Focus();
            if (dtpOD.Value > dtpDO.Value)
            {
                MessageBox.Show("\"Početni datum\" ne može biti poslije \"Krajnji datum\".", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbxUspjeh.SelectedIndex == 0)
            {
                DALogovi.getLogovi(dsLogovi.LogPrijavas, null, txtIPAdresa.Text.Trim(), txtIme.Text.Trim(), txtPrezime.Text.Trim(), dtpOD.Value, dtpDO.Value);
            }
            else if (cbxUspjeh.SelectedIndex == 1)
            {
                DALogovi.getLogovi(dsLogovi.LogPrijavas, true, txtIPAdresa.Text.Trim(), txtIme.Text.Trim(), txtPrezime.Text.Trim(), dtpOD.Value, dtpDO.Value);
            }
            else
            {
                DALogovi.getLogovi(dsLogovi.LogPrijavas, false, txtIPAdresa.Text.Trim(), txtIme.Text.Trim(), txtPrezime.Text.Trim(), dtpOD.Value, dtpDO.Value);
            }
            dgvLogovi.AutoGenerateColumns = false;
            dgvLogovi.DataSource = dsLogovi.LogPrijavas;
            lblBroj.Text = dsLogovi.LogPrijavas.Count().ToString();
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            lblFocus.Focus();
            cbxUspjeh.SelectedIndex = 0;
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtIPAdresa.Text = "";
            dtpOD.Value = dtpOD.MinDate;
            dtpDO.Value = dtpDO.MaxDate;
            cbxUspjeh.SelectedIndex = 0;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            DALogovi.getLogovi(dsLogovi.LogPrijavas, null, "", "", "", null,null);
            dgvLogovi.AutoGenerateColumns = false;
            dgvLogovi.DataSource = dsLogovi.LogPrijavas;
            lblBroj.Text = dsLogovi.LogPrijavas.Count.ToString();
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            lblFocus.Focus();
            if (dtpOD.Value > dtpDO.Value)
            {
                MessageBox.Show("\"Početni datum\" ne može biti poslije \"Krajnji datum\".", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbxUspjeh.SelectedIndex == 0)
            {
                Reports.frmReports frm = new Reports.frmReports("Logovi", null, txtIPAdresa.Text.Trim(), txtIme.Text.Trim(), txtPrezime.Text.Trim(), dtpOD.Value, dtpDO.Value);
                frm.Show();
            }
            else if (cbxUspjeh.SelectedIndex == 1)
            {
                Reports.frmReports frm = new Reports.frmReports("Logovi", true, txtIPAdresa.Text.Trim(), txtIme.Text.Trim(), txtPrezime.Text.Trim(), dtpOD.Value, dtpDO.Value);
                frm.Show();
            }
            else
            {
                Reports.frmReports frm = new Reports.frmReports("Logovi", false, txtIPAdresa.Text.Trim(), txtIme.Text.Trim(), txtPrezime.Text.Trim(), dtpOD.Value, dtpDO.Value);
                frm.Show();
            }

        }
    }
}