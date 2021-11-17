using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteuerrechnerV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdBerechnen_Click(object sender, EventArgs e)
        {
            bool Ksf = CheckBoxKs.Checked;
            double ksw = 0;
            if (Ksf == true)
            {
                ksw = 0.09;
            }


            double pvw = 0.017;
            double avw = 0.012;
            double kvw = 0.073;
            double rvw = 0.093;
            string eingabe = TxtEingabe.Text;
            double Brutto = Convert.ToDouble(eingabe);
            double Ls = Brutto * 0.25;
            double pv = Brutto * pvw;
            double av = Brutto * avw;
            double kv = Brutto * kvw;
            double rv = Brutto * rvw;
            double ks = Brutto * ksw;
            double Ergebnis = Brutto - Ls - pv - av - kv - rv - ks;
            LblAusgabe.Text = "Nettolohn:" + Ergebnis + "€" + "\n" +
                "Lohnsteuer:" + + Ls + "€" + "\n" +
                "Pflegeversicherung:" + pv + "€" + "\n" +
                "Arbeitslosenversicherung:" + av + "€" + "\n" +
                "Krankenversicherung:" + kv + "€" + "\n" +
                "Kirchensteuer:" + ks + "€";






        
        
        }
    }
}
