using eBankingUI.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBankingUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            lblFoc.Focus();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmLogin().Show();
        }

        private void btnKlijenti_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmKlijenti().Show();
        }

        private void btnLogovi_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmLogovi().Show();
        }
        private void btnZahtjevi_Click_1(object sender, EventArgs e)
        {
            this.Close();
            new frmZahtjevi().Show();
        }

        private void btnStednje_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmStednje().Show();
        }

        private void btnPoruke_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmPoruke().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmObavijesti().Show();
        }
    }
}
