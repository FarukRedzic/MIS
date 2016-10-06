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
    public partial class frmUplatniceDetalji : Form
    {
        DSUplatnice dsUplatnice = new DSUplatnice();
        int KlijentID;
        public frmUplatniceDetalji(int KlijentID)
        {
            InitializeComponent();
            this.KlijentID = KlijentID;
        }

        private void frmUplatniceDetalji_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


            DAUplatnice.getStatusi(dsUplatnice.Statusi);
            cbxStatus.DataSource = dsUplatnice.Statusi;
            cbxStatus.DisplayMember = "Naziv";
            cbxStatus.ValueMember = "StatusId";

            DAUplatnice.getUplatniceByID(dsUplatnice.Uplatnicas, KlijentID, txtIme.Text.Trim(), txtPrezime.Text.Trim(), Convert.ToInt32(cbxStatus.SelectedValue), dtpOD.Value, dtpDO.Value,null,null);
            dgvUplatnice.AutoGenerateColumns = false;
            dgvUplatnice.DataSource = dsUplatnice.Uplatnicas;
            lblBrojUplatnica.Text = dsUplatnice.Uplatnicas.Count.ToString();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmKlijenti().Show();
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            lblFocus.Focus();
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtIznosOD.Text = "";
            txtIznosDO.Text = "";
            dtpOD.Value = dtpOD.MinDate;
            dtpDO.Value = dtpDO.MaxDate;
            cbxStatus.SelectedIndex = 0;

            DAUplatnice.getUplatniceByID(dsUplatnice.Uplatnicas, KlijentID, txtIme.Text.Trim(), txtPrezime.Text.Trim(), Convert.ToInt32(cbxStatus.SelectedValue), dtpOD.Value, dtpDO.Value, null, null);
            dgvUplatnice.AutoGenerateColumns = false;
            dgvUplatnice.DataSource = dsUplatnice.Uplatnicas;
            lblBrojUplatnica.Text = dsUplatnice.Uplatnicas.Count.ToString();
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            lblFocus.Focus();
            if (dtpOD.Value > dtpDO.Value)
            {
                MessageBox.Show("\"Početni datum\" ne može biti poslije \"Krajnji datum\".", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtIznosOD.Text.Trim() == "" && txtIznosDO.Text.Trim() == "")
            {
                DAUplatnice.getUplatniceByID(dsUplatnice.Uplatnicas, KlijentID, txtIme.Text.Trim(), txtPrezime.Text.Trim(), Convert.ToInt32(cbxStatus.SelectedValue), dtpOD.Value, dtpDO.Value, null, null);
                dgvUplatnice.AutoGenerateColumns = false;
                dgvUplatnice.DataSource = dsUplatnice.Uplatnicas;
                lblBrojUplatnica.Text = dsUplatnice.Uplatnicas.Count.ToString();
            }
            else if (!IznosInputValidacija(txtIznosOD.Text.Trim(), txtIznosDO.Text.Trim()))
            {
                MessageBox.Show("Vrijednosti za iznos uplate \"OD\" i \"DO\" moraju biti cijeli brojevi. \n Vrijednost \"OD\" mora biti manja od vrijednosti \"DO\".", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DAUplatnice.getUplatniceByID(dsUplatnice.Uplatnicas, KlijentID, txtIme.Text.Trim(), txtPrezime.Text.Trim(), Convert.ToInt32(cbxStatus.SelectedValue), dtpOD.Value, dtpDO.Value, Convert.ToInt32(txtIznosOD.Text.Trim()), Convert.ToInt32(txtIznosDO.Text.Trim()));
                dgvUplatnice.AutoGenerateColumns = false;
                dgvUplatnice.DataSource = dsUplatnice.Uplatnicas;
                lblBrojUplatnica.Text = dsUplatnice.Uplatnicas.Count.ToString();
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

        private void btnIspis_Click(object sender, EventArgs e)
        {
            lblFocus.Focus();
            if (dtpOD.Value > dtpDO.Value)
            {
                MessageBox.Show("\"Početni datum\" ne može biti poslije \"Krajnji datum\".", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtIznosOD.Text.Trim() == "" && txtIznosDO.Text.Trim() == "")
            {
                Reports.frmReports frm = new Reports.frmReports("UplatniceByKlijentID", KlijentID, txtIme.Text.Trim(), txtPrezime.Text.Trim(), Convert.ToInt32(cbxStatus.SelectedValue), dtpOD.Value, dtpDO.Value, int.MinValue, int.MaxValue);
                frm.Show();
            }
            else if (!IznosInputValidacija(txtIznosOD.Text.Trim(), txtIznosDO.Text.Trim()))
            {
                MessageBox.Show("Vrijednosti za iznos uplate \"OD\" i \"DO\" moraju biti cijeli brojevi. \n Vrijednost \"OD\" mora biti manja od vrijednosti \"DO\".", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Reports.frmReports frm = new Reports.frmReports("UplatniceByKlijentID", KlijentID, txtIme.Text.Trim(), txtPrezime.Text.Trim(), Convert.ToInt32(cbxStatus.SelectedValue), dtpOD.Value, dtpDO.Value, Convert.ToInt32(txtIznosOD.Text.Trim()), Convert.ToInt32(txtIznosDO.Text.Trim()));
                frm.Show();
            }
        }
    }
}
