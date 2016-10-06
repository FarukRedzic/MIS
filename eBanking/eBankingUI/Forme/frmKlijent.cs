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
    public partial class frmKlijent : Form
    {
        DSKlijent dsKlijent = new DSKlijent();
        public frmKlijent()
        {
            InitializeComponent();
        }

        private void frmKlijent_Load(object sender, EventArgs e)
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

        private void btnMeni_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmMain().Show();
        }
    }
}
