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
    public partial class frmStednje : Form
    {
        DSStednje dsStednje = new DSStednje();

        public frmStednje()
        {
            InitializeComponent();
        }

        private void frmStednje_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            DAStednje.getStatusiStednje(dsStednje.Aktivan);
            cbxStatusi.DataSource = dsStednje.Aktivan;
            cbxStatusi.DisplayMember = "Status";
            cbxStatusi.ValueMember = "AktivanID";

            DAStednje.getStednje(dsStednje.Stednjas, txtIme.Text.Trim(), txtPrezime.Text.Trim(), dtpOD.Value, dtpDO.Value, Convert.ToInt32(cbxStatusi.SelectedValue),null,null);
            dgvStednje.AutoGenerateColumns = false;
            dgvStednje.DataSource = dsStednje.Stednjas;
            lblBrojStednji.Text = dsStednje.Stednjas.Count.ToString();
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            lblFoc.Focus();
            if (dtpOD.Value > dtpDO.Value)
            {
                MessageBox.Show("\"Početni datum\" ne može biti poslije \"Krajnji datum\".", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtIznosOD.Text.Trim() == "" && txtIznosDO.Text.Trim() == "")
            {
                DAStednje.getStednje(dsStednje.Stednjas, txtIme.Text.Trim(), txtPrezime.Text.Trim(), dtpOD.Value, dtpDO.Value, Convert.ToInt32(cbxStatusi.SelectedValue), null, null);
                dgvStednje.AutoGenerateColumns = false;
                dgvStednje.DataSource = dsStednje.Stednjas;
                lblBrojStednji.Text = dsStednje.Stednjas.Count.ToString();
            }
            else if (!IznosInputValidacija(txtIznosOD.Text.Trim(), txtIznosDO.Text.Trim()))
            {
                MessageBox.Show("Vrijednosti za iznos oročenja \"OD\" i \"DO\" moraju biti cijeli brojevi. \n Vrijednost \"OD\" mora biti manja od vrijednosti \"DO\".", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DAStednje.getStednje(dsStednje.Stednjas, txtIme.Text.Trim(), txtPrezime.Text.Trim(), dtpOD.Value, dtpDO.Value, Convert.ToInt32(cbxStatusi.SelectedValue), Convert.ToInt32(txtIznosOD.Text.Trim()), Convert.ToInt32(txtIznosDO.Text.Trim()));
                dgvStednje.AutoGenerateColumns = false;
                dgvStednje.DataSource = dsStednje.Stednjas;
                lblBrojStednji.Text = dsStednje.Stednjas.Count.ToString();
            }
        }
        private bool IznosInputValidacija(string start, string end)
        {
                int OD = 0, DO = 0;
            if (int.TryParse(start, out OD) && int.TryParse(end, out DO))
                if ((OD >= 0 && DO >= 0) && (OD <= DO))
                    return true;
            return false;
        }
        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            lblFoc.Focus();
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtIznosOD.Text = "";
            txtIznosDO.Text = "";
            dtpOD.Value = dtpOD.MinDate;
            dtpDO.Value = dtpDO.MaxDate;
            cbxStatusi.SelectedIndex = 0;
            DAStednje.getStednje(dsStednje.Stednjas, txtIme.Text.Trim(), txtPrezime.Text.Trim(), dtpOD.Value, dtpDO.Value, Convert.ToInt32(cbxStatusi.SelectedValue), null, null);
            dgvStednje.AutoGenerateColumns = false;
            dgvStednje.DataSource = dsStednje.Stednjas;
            lblBrojStednji.Text = dsStednje.Stednjas.Count.ToString();
        }

        private void btnGlavniMeni_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmMain().Show();
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            lblFoc.Focus();
            if (dtpOD.Value > dtpDO.Value)
            {
                MessageBox.Show("\"Početni datum\" ne može biti poslije \"Krajnji datum\".", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtIznosOD.Text.Trim() == "" && txtIznosDO.Text.Trim() == "")
            {
                Reports.frmReports frm = new Reports.frmReports("Stednje", txtIme.Text.Trim(), txtPrezime.Text.Trim(), dtpOD.Value, dtpDO.Value, Convert.ToInt32(cbxStatusi.SelectedValue), int.MinValue, int.MaxValue);
                frm.Show();
            }
            else if (!IznosInputValidacija(txtIznosOD.Text.Trim(), txtIznosDO.Text.Trim()))
            {
                MessageBox.Show("Vrijednosti za iznos oročenja \"OD\" i \"DO\" moraju biti cijeli brojevi. \n Vrijednost \"OD\" mora biti manja od vrijednosti \"DO\".", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Reports.frmReports frm = new Reports.frmReports("Stednje", txtIme.Text.Trim(), txtPrezime.Text.Trim(), dtpOD.Value, dtpDO.Value, Convert.ToInt32(cbxStatusi.SelectedValue), Convert.ToInt32(txtIznosOD.Text.Trim()), Convert.ToInt32(txtIznosDO.Text.Trim()));
                frm.Show();
            }
        }
    }
}
