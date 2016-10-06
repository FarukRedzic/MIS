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
    public partial class frmPoruke : Form
    {
        DSPoruke dsPoruke = new DSPoruke();
        public frmPoruke()
        {
            InitializeComponent();
        }

        private void frmPoruke_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            DAPoruke.getStatusiPoruke(dsPoruke.OdgovorStatus);
            cbxStatusPoruke.DataSource = dsPoruke.OdgovorStatus;
            cbxStatusPoruke.DisplayMember = "Odgovorena";
            cbxStatusPoruke.ValueMember = "Id";

            DAPoruke.getPoruke(dsPoruke.Porukas, txtImeKlijent.Text.Trim(), txtPrezimeKlijent.Text.Trim(), txtImeRadnik.Text.Trim(), txtPrezimeRadnik.Text.Trim(),
                                   dtpOD.Value, dtpDO.Value, Convert.ToInt32(cbxStatusPoruke.SelectedValue));
            dgvPoruke.AutoGenerateColumns = false;
            dgvPoruke.DataSource = dsPoruke.Porukas;
            lblBrojPoruka.Text = dsPoruke.Porukas.Count.ToString();
            dgvPoruke.Rows[0].Selected = false;
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
                DAPoruke.getPoruke(dsPoruke.Porukas, txtImeKlijent.Text.Trim(), txtPrezimeKlijent.Text.Trim(), txtImeRadnik.Text.Trim(), txtPrezimeRadnik.Text.Trim(),
                                   dtpOD.Value, dtpDO.Value, Convert.ToInt32(cbxStatusPoruke.SelectedValue));
                dgvPoruke.AutoGenerateColumns = false;
                dgvPoruke.DataSource = dsPoruke.Porukas;
                lblBrojPoruka.Text = dsPoruke.Porukas.Count.ToString();
            }
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            lblFocus.Focus();
            cbxStatusPoruke.SelectedIndex = 0;
            txtImeKlijent.Text = "";
            txtPrezimeKlijent.Text = "";
            txtImeRadnik.Text = "";
            txtPrezimeRadnik.Text = "";
            dtpOD.Value = dtpOD.MinDate;
            dtpDO.Value = dtpDO.MaxDate;
            DAPoruke.getPoruke(dsPoruke.Porukas, txtImeKlijent.Text.Trim(), txtPrezimeKlijent.Text.Trim(), txtImeRadnik.Text.Trim(), txtPrezimeRadnik.Text.Trim(),
                                   dtpOD.Value, dtpDO.Value, Convert.ToInt32(cbxStatusPoruke.SelectedValue));
            dgvPoruke.AutoGenerateColumns = false;
            dgvPoruke.DataSource = dsPoruke.Porukas;
            lblBrojPoruka.Text = dsPoruke.Porukas.Count.ToString();
        }
        private void btnProcitajPoruku_Click(object sender, EventArgs e)
        {
            lblFocus.Focus();
            if (!ValidacijaSelectedRow())
            {
                MessageBox.Show("Potrebno je da označite poruku.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int PorukaID = Convert.ToInt32(dgvPoruke.SelectedRows[0].Cells[0].Value);
                new frmPorukaDetalji(PorukaID).ShowDialog();
            }
        }
        private bool ValidacijaSelectedRow()
        {
            for (int i = 0; i < dgvPoruke.RowCount; i++)
            {
                if (dgvPoruke.Rows[i].Selected)
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
                Reports.frmReports frm = new Reports.frmReports("Poruke", txtImeKlijent.Text.Trim(), txtPrezimeKlijent.Text.Trim(), txtImeRadnik.Text.Trim(), txtPrezimeRadnik.Text.Trim(),
                                   dtpOD.Value, dtpDO.Value, Convert.ToInt32(cbxStatusPoruke.SelectedValue));
                frm.Show();
            }
        }
    }
}
