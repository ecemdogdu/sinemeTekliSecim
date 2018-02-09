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
    public partial class Form1 : Form
    {
        string KoltukNo;
    
        public Form1()
        {
            InitializeComponent();
          
        }


        
      
        private void chbKoltukA1_CheckedChanged(object sender, EventArgs e)
        {
            SatinAlma sa = new SatinAlma(this,"A1");
            sa.ShowDialog();

        }
        public void A1BackGround()
        {
            chbKoltukA1.BackColor = Color.Red;
            chbKoltukA1.Enabled = false;
        }

        private void chbKoltukA2_CheckedChanged(object sender, EventArgs e)
        {
            SatinAlma sa = new SatinAlma(this, "A2");
            sa.ShowDialog();
        }
        public void A2BackGround()
        {
            chbKoltukA2.BackColor = Color.Red;
            chbKoltukA2.Enabled = false;
        }

        private void chbKoltukA3_CheckedChanged(object sender, EventArgs e)
        {
            SatinAlma sa = new SatinAlma(this, "A3");
            sa.ShowDialog();

        }
        public void A3BackGround()
        {
            chbKoltukA3.BackColor = Color.Red;
            chbKoltukA3.Enabled = false;
        }

        private void chbKoltukA4_CheckedChanged(object sender, EventArgs e)
        {
            SatinAlma sa = new SatinAlma(this, "A4");
            sa.ShowDialog();
        }
        public void A4BackGround()
        {
            chbKoltukA4.BackColor = Color.Red;
            chbKoltukA4.Enabled = false;
        }

        private void chbKoltukA5_CheckedChanged(object sender, EventArgs e)
        {
            SatinAlma sa = new SatinAlma(this, "A5");
            sa.ShowDialog();
        }
        public void A5BackGround()
        {
            chbKoltukA5.BackColor = Color.Red;
            chbKoltukA5.Enabled = false;
        }

        private void chbB1_CheckedChanged(object sender, EventArgs e)
        {
            SatinAlma sa = new SatinAlma(this, "B1");
            sa.ShowDialog();
        }
        public void B1BackGround()
        {
            chbB1.BackColor = Color.Red;
            chbB1.Enabled = false;
        }

        private void chbB2_CheckedChanged(object sender, EventArgs e)
        {
            SatinAlma sa = new SatinAlma(this, "B2");
            sa.ShowDialog();
        }
        public void B2BackGround()
        {
            chbB2.BackColor = Color.Red;
            chbB2.Enabled = false;
        }

        private void chbB3_CheckedChanged(object sender, EventArgs e)
        {
            SatinAlma sa = new SatinAlma(this, "B3");
            sa.ShowDialog();
        }
        public void B3BackGround()
        {
            chbB3.BackColor = Color.Red;
            chbB3.Enabled = false;
        }

        private void chbB4_CheckedChanged(object sender, EventArgs e)
        {
            SatinAlma sa = new SatinAlma(this, "B4");
            sa.ShowDialog();
        }
        public void B4BackGround()
        {
            chbB4.BackColor = Color.Red;
            chbB4.Enabled = false;
        }

        private void chbB5_CheckedChanged(object sender, EventArgs e)
        {

            SatinAlma sa = new SatinAlma(this, "B5");
            sa.ShowDialog();
        }
        public void B5BackGround()
        {
            chbB5.BackColor = Color.Red;
            chbB5.Enabled = false;
        }

        private void chbC1_CheckedChanged(object sender, EventArgs e)
        {

            SatinAlma sa = new SatinAlma(this, "C1");
            sa.ShowDialog();
        }
        public void C1BackGround()
        {
            chbC1.BackColor = Color.Red;
            chbC1.Enabled = false;
        }

        private void chbC2_CheckedChanged(object sender, EventArgs e)
        {
            SatinAlma sa = new SatinAlma(this, "C2");
            sa.ShowDialog();
        }
        public void C2BackGround()
        {
            chbC2.BackColor = Color.Red;
            chbC2.Enabled = false;
        }

        private void chbC3_CheckedChanged(object sender, EventArgs e)
        {
            SatinAlma sa = new SatinAlma(this, "C3");
            sa.ShowDialog();
        }
        public void C3BackGround()
        {
            chbC3.BackColor = Color.Red;
            chbC3.Enabled = false;
        }
        private void chbC4_CheckedChanged(object sender, EventArgs e)
        {
            SatinAlma sa = new SatinAlma(this, "C4");
            sa.ShowDialog();
        }
        public void C4BackGround()
        {
            chbC4.BackColor = Color.Red;
            chbC4.Enabled = false;
        }

        private void chbC5_CheckedChanged(object sender, EventArgs e)
        {
            SatinAlma sa = new SatinAlma(this, "C5");
            sa.ShowDialog();
        }
        public void C5BackGround()
        {
            chbC5.BackColor = Color.Red;
            chbC5.Enabled = false;
        }

        private void chbD1_CheckedChanged(object sender, EventArgs e)
        {
            SatinAlma sa = new SatinAlma(this, "D1");
            sa.ShowDialog();
        }
        public void D1BackGround()
        {
            chbD1.BackColor = Color.Red;
            chbD1.Enabled = false;
        }
        private void chbD2_CheckedChanged(object sender, EventArgs e)
        {
            SatinAlma sa = new SatinAlma(this, "D2");
            sa.ShowDialog();
        }
        public void D2BackGround()
        {
            chbD2.BackColor = Color.Red;
            chbD2.Enabled = false;
        }

        private void chbD3_CheckedChanged(object sender, EventArgs e)
        {
            SatinAlma sa = new SatinAlma(this, "D3");
            sa.ShowDialog();
        }
        public void D3BackGround()
        {
            chbD3.BackColor = Color.Red;
            chbD3.Enabled = false;
        }
        private void chbD4_CheckedChanged(object sender, EventArgs e)
        {
            SatinAlma sa = new SatinAlma(this, "D4");
            sa.ShowDialog();
        }
        public void D4BackGround()
        {
            chbD4.BackColor = Color.Red;
            chbD4.Enabled = false;
        }

        private void chbD5_CheckedChanged(object sender, EventArgs e)
        {
            SatinAlma sa = new SatinAlma(this, "D5");
            sa.ShowDialog();
        }
        public void D5BackGround()
        {
            chbD5.BackColor = Color.Red;
            chbD5.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
