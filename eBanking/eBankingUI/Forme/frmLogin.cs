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
    public partial class frmLogin : Form
    {

        DSRadnik dsRadnik = new DSRadnik();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            lblFoc.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblFoc.Focus();
            DARadnik.Login(dsRadnik.Radniks, txtUsername.Text.Trim(), txtLozinka.Text.Trim());
            if (dsRadnik.Radniks.Count() == 0)
            {
                lblGreska.Visible = true;
                lblError.Visible = true;
            }
            else if(dsRadnik.Radniks.Rows[0]["Username"].ToString() == txtUsername.Text.Trim() && dsRadnik.Radniks.Rows[0]["PasswordHash"].ToString() == txtLozinka.Text.Trim() && !(bool)dsRadnik.Radniks.Rows[0]["IsDeleted"])
            {
                this.Hide();
                new frmMain().ShowDialog();
            }
            else
            {
                lblGreska.Visible = true;
                lblError.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.MessageLoop)
                Application.Exit();
            else
                Environment.Exit(1);
        }
    }
}
