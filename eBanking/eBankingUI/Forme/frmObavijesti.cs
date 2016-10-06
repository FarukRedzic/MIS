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
    public partial class frmObavijesti : Form
    {
        DSObavijesti dsObavijesti = new DSObavijesti();
        public frmObavijesti()
        {
            InitializeComponent();
        }

        private void frmObavijesti_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            DAObavijesti.getObavijesti(dsObavijesti.Obavijests,txtIme.Text.Trim(),txtPrezime.Text.Trim(),txtNaslov.Text.Trim(),dtpOD.Value, dtpDO.Value);

            dgvObavijesti.AutoGenerateColumns = false;
            dgvObavijesti.DataSource = dsObavijesti.Obavijests;
            lblBrojObavijesti.Text = dsObavijesti.Obavijests.Count.ToString();
            dgvObavijesti.Rows[0].Selected = false;
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
                DAObavijesti.getObavijesti(dsObavijesti.Obavijests, txtIme.Text.Trim(), txtPrezime.Text.Trim(), txtNaslov.Text.Trim(), dtpOD.Value, dtpDO.Value);

                dgvObavijesti.AutoGenerateColumns = false;
                dgvObavijesti.DataSource = dsObavijesti.Obavijests;
                lblBrojObavijesti.Text = dsObavijesti.Obavijests.Count.ToString();
            }
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            lblFocus.Focus();
            txtNaslov.Text = "";
            txtIme.Text = "";
            txtPrezime.Text = "";
            dtpOD.Value = dtpOD.MinDate;
            dtpDO.Value = dtpDO.MaxDate;
            DAObavijesti.getObavijesti(dsObavijesti.Obavijests, txtIme.Text.Trim(), txtPrezime.Text.Trim(), txtNaslov.Text.Trim(), dtpOD.Value, dtpDO.Value);

            dgvObavijesti.AutoGenerateColumns = false;
            dgvObavijesti.DataSource = dsObavijesti.Obavijests;
            lblBrojObavijesti.Text = dsObavijesti.Obavijests.Count.ToString();
        }

        private void btnProcitajObavijest_Click(object sender, EventArgs e)
        {
            lblFocus.Focus();
            if (!ValidacijaSelectedRow())
            {
                MessageBox.Show("Potrebno je da označite obavijest.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int ObavijestID = Convert.ToInt32(dgvObavijesti.SelectedRows[0].Cells[0].Value);
                new frmObavijestDetalji(ObavijestID).ShowDialog();
            }
        }
        private bool ValidacijaSelectedRow()
        {
            for (int i = 0; i < dgvObavijesti.RowCount; i++)
            {
                if (dgvObavijesti.Rows[i].Selected)
                {
                    return true;
                }
            }
            return false;
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
                Reports.frmReports frm = new Reports.frmReports("Obavijesti", txtIme.Text.Trim(), txtPrezime.Text.Trim(), txtNaslov.Text.Trim(), dtpOD.Value, dtpDO.Value);
                frm.Show();
            }
        }
    }
}
