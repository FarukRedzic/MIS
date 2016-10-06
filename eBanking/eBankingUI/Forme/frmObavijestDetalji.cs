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
    public partial class frmObavijestDetalji : Form
    {
        DSObavijesti dsObavijesti = new DSObavijesti();
        int ObavijestID;
        public frmObavijestDetalji(int ObavijestID)
        {
            InitializeComponent();
            this.ObavijestID = ObavijestID;
        }

        private void frmObavijestDetalji_Load(object sender, EventArgs e)
        {
            if (ObavijestID == 0)
            {
                MessageBox.Show("Potrebno je da označite obavijest.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            DAObavijesti.getObavijestByID(dsObavijesti.Obavijests, ObavijestID);
            lblDatumVrijeme.Text = dsObavijesti.Obavijests.Rows[0]["DatumVrijeme"].ToString();
            lblNaslov.Text = dsObavijesti.Obavijests.Rows[0]["Naslov"].ToString();
            lblSadrzaj.Text = dsObavijesti.Obavijests.Rows[0]["Sadrzaj"].ToString();
            lblObavijestPostavio.Text = dsObavijesti.Obavijests.Rows[0]["PostavioObavijest"].ToString();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
