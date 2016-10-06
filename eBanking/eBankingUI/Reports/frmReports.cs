using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBankingUI.Reports
{
    public partial class frmReports : Form
    {
        private string rptName = "";
        private int AktivanID;
        private string Ime = "";
        private string Prezime = "";
        private int RacunID;
        private int KlijentID;
        private int StatusID;
        private DateTime DatumOd;
        private DateTime DatumDo;
        private int IznosOd;
        private int IznosDo;
        private string PrezimeRadnik = "";
        private string ImeRadnik = "";
        private int TipZahtjeva;
        private bool? Uspjeh;
        private string IPAdresa = "";
        private string Naslov = "";
        private int StatusPorukeID;

        //Defaultni konstruktor
        public frmReports()
        {
            InitializeComponent();
        }

        //Klijent konstruktor
        public frmReports(string rptName, int AktivanID, string Ime, string Prezime)
        {
            InitializeComponent();
            this.rptName = rptName;
            this.AktivanID = AktivanID;
            this.Ime = Ime;
            this.Prezime = Prezime;
        }

        //TransakcijeByRacunID konstruktor
        public frmReports(string rptName, int RacunID)
        {
            InitializeComponent();
            this.rptName = rptName;
            this.RacunID = RacunID;
        }

        //UplatniceByKlijentID konstruktor
        public frmReports(string rptName, int KlijentID, string Ime, string Prezime, int StatusID, DateTime OD, DateTime DO, int IznosOD, int IznosDO)
        {
            InitializeComponent();
            this.rptName = rptName;
            this.KlijentID = KlijentID;
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.StatusID = StatusID;
            this.DatumOd = OD;
            this.DatumDo = DO;
            this.IznosOd = IznosOD;
            this.IznosDo = IznosDO;
        }
        
        public frmReports(string rptName, string Ime, string Prezime, DateTime OD, DateTime DO, int StatusID, int IznosOD, int IznosDO)
        {
            InitializeComponent();
            this.rptName = rptName;
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.StatusID = StatusID;
            this.DatumOd = OD;
            this.DatumDo = DO;
            this.IznosOd = IznosOD;
            this.IznosDo = IznosDO;
        }
        //Zahtjevi konstruktor
        public frmReports(string rptName, string Ime, string Prezime, string ImeRadnika, string PrezimeRadnika, DateTime OD, DateTime DO, int StatusID, int TipZahtjeva)
        {
            InitializeComponent();
            this.rptName = rptName;
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.ImeRadnik = ImeRadnika;
            this.PrezimeRadnik = PrezimeRadnika;
            this.StatusID = StatusID;
            this.DatumOd = OD;
            this.DatumDo = DO;
            this.StatusID = StatusID;
            this.TipZahtjeva = TipZahtjeva;
        }

        public frmReports(string rptName,  bool? Uspjeh, string IPAdresa, string Ime, string Prezime, DateTime OD, DateTime DO)
        {
            InitializeComponent();
            this.rptName = rptName;
            this.Uspjeh = Uspjeh;
            this.IPAdresa = IPAdresa;
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.DatumOd = OD;
            this.DatumDo = DO;
        }

        public frmReports(string rptName,string Ime, string Prezime,string Naslov ,DateTime OD, DateTime DO)
        {
            InitializeComponent();
            this.rptName = rptName;
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.Naslov = Naslov;
            this.DatumOd = OD;
            this.DatumDo = DO;
        }
   
        //getPoruke konstruktor
        public frmReports(string rptName, string Ime, string Prezime, string ImeRadnika, string PrezimeRadnika, DateTime OD, DateTime DO, int StatusPorukeID)
        {
            InitializeComponent();
            this.rptName = rptName;
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.ImeRadnik = ImeRadnika;
            this.PrezimeRadnik = PrezimeRadnika;
            this.DatumOd = OD;
            this.DatumDo = DO;
            this.StatusPorukeID = StatusPorukeID;
        }
        private void frmReports_Load(object sender, EventArgs e)
        {
            if (rptName == "Klijenti")
            {
                reportViewer.ServerReport.ReportPath = "/eBankingReports/Klijenti";
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("AktivanID", AktivanID.ToString()));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Ime", Ime));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Prezime", Prezime));
            }
            else if (rptName == "TransakcijeByRacun")
            {
                reportViewer.ServerReport.ReportPath = "/eBankingReports/TransakcijeByRacun";
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("RacunID", RacunID.ToString()));
            }
            else if (rptName == "UplatniceByKlijentID")
            {
                reportViewer.ServerReport.ReportPath = "/eBankingReports/UplatniceByKlijentID";
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("KlijentID", KlijentID.ToString()));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Ime", Ime));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Prezime", Prezime));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("StatusID", StatusID.ToString()));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DatumOD",DatumOd.ToString()));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DatumDO", DatumDo.ToString()));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("IznosOD", IznosOd.ToString()));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("IznosDO", IznosDo.ToString()));
            }

            else if (rptName == "Stednje")
            {
                reportViewer.ServerReport.ReportPath = "/eBankingReports/Stednje";
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Ime", Ime,false));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Prezime", Prezime));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("StatusID", StatusID.ToString()));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DatumOD", DatumOd.ToString()));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DatumDO", DatumDo.ToString()));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("IznosOD", IznosOd.ToString()));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("IznosDO", IznosDo.ToString()));
            }

            else if (rptName == "Zahtjevi")
            {
                reportViewer.ServerReport.ReportPath = "/eBankingReports/Zahtjevi";
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ImeKlijenta", Ime));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("PrezimeKlijenta", Prezime));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ImeRadnika", ImeRadnik));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("PrezimeRadnika", PrezimeRadnik));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Status", StatusID.ToString()));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Pocetak", DatumOd.ToString()));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Kraj", DatumDo.ToString()));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("TipZahtjeva", TipZahtjeva.ToString()));
            }

            else if (rptName == "Logovi")
            {
                reportViewer.ServerReport.ReportPath = "/eBankingReports/Logovi";

                if (Uspjeh == null)
                {
                    string tempNULL = null;
                    reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Uspjeh", tempNULL));
                }
                else
                {
                    reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Uspjeh", Uspjeh.ToString()));
                }
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("IPAdresa", IPAdresa));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Ime", Ime));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Prezime", Prezime));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Pocetak", DatumOd.ToString()));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Kraj", DatumDo.ToString()));
            }

            else if (rptName == "Obavijesti")
            {
                reportViewer.ServerReport.ReportPath = "/eBankingReports/Obavijesti";

                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Naslov", Naslov));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Ime", Ime));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Prezime", Prezime));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Pocetak", DatumOd.ToString()));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Kraj", DatumDo.ToString()));
            }

            else if (rptName == "Poruke")
            {
                reportViewer.ServerReport.ReportPath = "/eBankingReports/Poruke";
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ImeKlijenta", Ime));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("PrezimeKlijenta", Prezime));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ImeRadnika", ImeRadnik));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("PrezimeRadnika", PrezimeRadnik));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Pocetak", DatumOd.ToString()));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Kraj", DatumDo.ToString()));
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("OdgovorenaID", StatusPorukeID.ToString()));
            }
            else if (rptName == "Matrica")
            {
                reportViewer.ServerReport.ReportPath = "/eBankingReports/Matrica";
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("RacunID", RacunID.ToString()));
            }
            else if (rptName == "Graf")
            {
                reportViewer.ServerReport.ReportPath = "/eBankingReports/Graf";
                reportViewer.ServerReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("RacunID", RacunID.ToString()));
            }

            this.reportViewer.RefreshReport();
        }
    }
}
