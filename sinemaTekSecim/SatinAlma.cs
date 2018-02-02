using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace sinemaTekSecim
{
    public partial class SatinAlma : Form
    {
        Form1 AnaForm;
        string KoltukNo;
        string gözlükSecim;
        string MenuSecim;
        int hasilat = 0;
        int ucret = 0;
        public SatinAlma(Form1 frm,string koltukNo)
        {
            AnaForm = frm;
            InitializeComponent();
            txtKoltukNo.Text = koltukNo;
            txtKoltukNo.Enabled = false;
            cmbIndirim.Items.Add("tam");
            cmbIndirim.Items.Add("ogrenci");
            txtKoltukNo.Enabled = false;
        }

        private void SatinAlma_Load(object sender, EventArgs e)
        {

        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {

            if (cmbIndirim.Text == "ogrenci")
            {
                ucret += 15;
                if (chbMenü.Checked || chbGözlük.Checked)
                {
                    MenuSecim = "EvEt";
                    gözlükSecim = "Evet";
                    ucret += 15;
                }
                else if (chbMenü.Checked)
                {
                    MenuSecim = "EvEt";
                    ucret += 10;
                }
                else if (chbGözlük.Checked)
                {
                    gözlükSecim = "Evet";
                    ucret += 5;
                }
            }
            else if (cmbIndirim.Text == "tam")
            {
                ucret = 20;
                if (chbMenü.Checked || chbGözlük.Checked)
                {
                    MenuSecim = "EvEt";

                    gözlükSecim = "Evet";
                    ucret += 15;
                }
                else if (chbMenü.Checked)
                {
                    MenuSecim = "EvEt";
                    ucret += 10;
                }
                else if (chbGözlük.Checked)
                {
                    gözlükSecim = "Evet";
                    ucret += 5;
                }
            }
            hasilat += ucret;
         


            listBox1.Items.Add("KOLTUK NO:"+txtKoltukNo.Text);
            listBox1.Items.Add("INDIRIMLİ Mİ:" + cmbIndirim.Text);
            listBox1.Items.Add("GOZLUK SECİM:" + gözlükSecim);
            listBox1.Items.Add("MENÜ SECİM:" +MenuSecim);
            listBox1.Items.Add(" UCRET:" + ucret);
            lblUcret.Text = hasilat.ToString();

            switch (txtKoltukNo.Text)
            {
                case "A1":
                    AnaForm.A1BackGround();
                    break;
                case "A2":
                    AnaForm.A2BackGround();
                    break;
                case "A3":
                    AnaForm.A3BackGround();
                    break;
                case "A4":
                    AnaForm.A4BackGround();
                    break;
                case "A5":
                    AnaForm.A5BackGround();
                    break;
                case "B1":
                    AnaForm.B1BackGround();
                    break;
                case "B2":
                    AnaForm.B2BackGround();
                    break;
                case "B3":
                    AnaForm.B3BackGround();
                    break;
                case "B4":
                    AnaForm.B4BackGround();
                    break;
                case "B5":
                    AnaForm.B5BackGround();
                    break;
                case "C1":
                    AnaForm.C1BackGround();
                    break;
                case "C2":
                    AnaForm.C2BackGround();
                    break;
                case "C3":
                    AnaForm.C3BackGround();
                    break;
                case "C4":
                    AnaForm.C4BackGround();
                    break;
                case "C5":
                    AnaForm.C5BackGround();
                    break;
                case "D1":
                    AnaForm.D1BackGround();
                    break;
                case "D2":
                    AnaForm.D2BackGround();
                    break;
                case "D3":
                    AnaForm.D3BackGround();
                    break;
                case "D4":
                    AnaForm.D4BackGround();
                    break;
                case "D5":
                    AnaForm.D5BackGround();
                    break;
                default:
                    break;
            }

           

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
        }
    }
}
