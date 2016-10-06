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
    public partial class frmRacuniDetalji : Form
    {
        DSKlijent dsKlijent = new DSKlijent();
        int KlijentID;
        public frmRacuniDetalji(int KlijentID)
        {
            InitializeComponent();
            this.KlijentID = KlijentID;
        }

        private void frmRacuniDetalji_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            DAKlijent.getRacuneByKlijentID(dsKlijent.Racuns, KlijentID);
            lblKlijent.Text = dsKlijent.Racuns.Rows[0]["KlijentImePrezime"].ToString();
            dgvRacuniDetalji.AutoGenerateColumns = false;
            dgvRacuniDetalji.DataSource = dsKlijent.Racuns;

            dgvRacuniDetalji_CellContentClick(null, null); //da odmah prikaze transakcije na load-u
        }

        private void dgvRacuniDetalji_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int RacunID = Convert.ToInt32(dgvRacuniDetalji.SelectedRows[0].Cells[0].Value);
            DAKlijent.getTransakcijeByRacunID(dsKlijent.Transakcijas, RacunID);

            lblBrojRacuna.Text = dsKlijent.Racuns.Rows[dgvRacuniDetalji.CurrentCell.RowIndex]["BrojRacuna"].ToString();
            dgvTransakcije.AutoGenerateColumns = false;
            dgvTransakcije.DataSource = dsKlijent.Transakcijas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            lblFocus.Focus();
            int RacunID = Convert.ToInt32(dgvRacuniDetalji.SelectedRows[0].Cells[0].Value);
            Reports.frmReports frm = new Reports.frmReports("TransakcijeByRacun", RacunID);
            frm.Show();
        }

        private void btnMatrica_Click(object sender, EventArgs e)
        {
            lblFocus.Focus();
            int RacunID = Convert.ToInt32(dgvRacuniDetalji.SelectedRows[0].Cells[0].Value);
            Reports.frmReports frm = new Reports.frmReports("Matrica", RacunID);
            frm.Show();
        }

        private void btnGraf_Click(object sender, EventArgs e)
        {
            lblFocus.Focus();
            int RacunID = Convert.ToInt32(dgvRacuniDetalji.SelectedRows[0].Cells[0].Value);
            Reports.frmReports frm = new Reports.frmReports("Graf", RacunID);
            frm.Show();
        }
    }
}
