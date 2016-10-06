using System;
using System.Windows.Forms;
using eBankingDAL;

namespace eBankingUI.Forme
{
    public partial class frmZahtjevi : Form
    {
        DSZahtjevi dsZahtjevi = new DSZahtjevi();
        public frmZahtjevi()
        {
            InitializeComponent();
        }

        private void Zahtjevi_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            DAZahtjevi.getZahtjeve(dsZahtjevi.Zahtjevs,txtImeKlijent.Text.Trim(), txtPrezimeKlijent.Text.Trim(), txtImeRadnik.Text.Trim(), txtPrezimeRadnik.Text.Trim(),
                                   dtpOD.Value, dtpDO.Value,Convert.ToInt32(cbxStatus.SelectedValue), Convert.ToInt32(cbxTipZahtjevi.SelectedValue));
            dgvZahtjevi.AutoGenerateColumns = false;
            dgvZahtjevi.DataSource = dsZahtjevi.Zahtjevs;
            lblBrojZahtjeva.Text = dsZahtjevi.Zahtjevs.Count.ToString();

            DAZahtjevi.getStatusiZahtjeva(dsZahtjevi.Statusi);
            cbxStatus.DataSource = dsZahtjevi.Statusi;
            cbxStatus.DisplayMember = "Naziv";
            cbxStatus.ValueMember = "StatusId";

            DAZahtjevi.getTipoviZahtjeva(dsZahtjevi.TipZahtjevas);
            cbxTipZahtjevi.DataSource = dsZahtjevi.TipZahtjevas;
            cbxTipZahtjevi.DisplayMember = "Naziv";
            cbxTipZahtjevi.ValueMember = "Id";
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
            else
            {
                DAZahtjevi.getZahtjeve(dsZahtjevi.Zahtjevs, txtImeKlijent.Text.Trim(), txtPrezimeKlijent.Text.Trim(), txtImeRadnik.Text.Trim(), txtPrezimeRadnik.Text.Trim(),
                                      dtpOD.Value, dtpDO.Value, Convert.ToInt32(cbxStatus.SelectedValue), Convert.ToInt32(cbxTipZahtjevi.SelectedValue));
                dgvZahtjevi.AutoGenerateColumns = false;
                dgvZahtjevi.DataSource = dsZahtjevi.Zahtjevs;
                lblBrojZahtjeva.Text = dsZahtjevi.Zahtjevs.Count.ToString();
            }
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            lblFocus.Focus();
            cbxStatus.SelectedIndex = 0;
            cbxTipZahtjevi.SelectedIndex = 0;
            txtImeKlijent.Text = "";
            txtPrezimeKlijent.Text = "";
            txtImeRadnik.Text = "";
            txtPrezimeRadnik.Text = "";
            dtpOD.Value = dtpOD.MinDate;
            dtpDO.Value = dtpDO.MaxDate;
            DAZahtjevi.getZahtjeve(dsZahtjevi.Zahtjevs, txtImeKlijent.Text.Trim(), txtPrezimeKlijent.Text.Trim(), txtImeRadnik.Text.Trim(), txtPrezimeRadnik.Text.Trim(),
                                   dtpOD.Value, dtpDO.Value, Convert.ToInt32(cbxStatus.SelectedValue), Convert.ToInt32(cbxTipZahtjevi.SelectedValue));
            dgvZahtjevi.AutoGenerateColumns = false;
            dgvZahtjevi.DataSource = dsZahtjevi.Zahtjevs;
            lblBrojZahtjeva.Text = dsZahtjevi.Zahtjevs.Count.ToString();
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            lblFocus.Focus();
            if (dtpOD.Value > dtpDO.Value)
            {
                MessageBox.Show("\"Početni datum\" ne može biti poslije \"Krajnji datum\".", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Reports.frmReports frm = new Reports.frmReports("Zahtjevi", txtImeKlijent.Text.Trim(), txtPrezimeKlijent.Text.Trim(), txtImeRadnik.Text.Trim(), txtPrezimeRadnik.Text.Trim(),
                                      dtpOD.Value, dtpDO.Value, Convert.ToInt32(cbxStatus.SelectedValue), Convert.ToInt32(cbxTipZahtjevi.SelectedValue));
                frm.Show();
            }
        }
    }
}
