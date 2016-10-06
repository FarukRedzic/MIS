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
    public partial class frmPorukaDetalji : Form
    {
        DSPoruke dsPoruke = new DSPoruke();
        int PorukaID;
        public frmPorukaDetalji(int PorukaID)
        {
            InitializeComponent();
            this.PorukaID = PorukaID;
        }

        private void frmPorukaDetalji_Load(object sender, EventArgs e)
        {
            if (PorukaID == 0)
            {
                MessageBox.Show("Potrebno je da označite poruku.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            DAPoruke.getPorukaByPorukaID(dsPoruke.Porukas, PorukaID);
            lblDatumVrijeme.Text = dsPoruke.Porukas.Rows[0]["DatumVrijeme"].ToString();
            lblNaslov.Text = dsPoruke.Porukas.Rows[0]["Naslov"].ToString();
            lblSadržaj.Text = dsPoruke.Porukas.Rows[0]["Sadrzaj"].ToString();
            lblKlijent.Text = dsPoruke.Porukas.Rows[0]["Klijentt"].ToString();
            lblOdgovorio.Text = dsPoruke.Porukas.Rows[0]["Odgovorio"].ToString();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
