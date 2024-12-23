using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_BasitMenuUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_hesapla_Click(object sender, EventArgs e)
        {
            int tutar = 0;
            if (checkBox1_cay.Checked)
            {
                tutar += 25;
            }
            if (checkBox2_Kahve.Checked)
            {
                tutar += 80;
            }
            if (checkBox3_milkshake.Checked)
            {
                tutar += 100;
            }
            if (checkBox4_kola.Checked)
            {
                tutar += 55;
            }
            if (checkBox5_fanta.Checked)
            {
                tutar += 50;
            }
            if (checkBox6_gazoz.Checked)
            {
                tutar += 40;
            }

            label2_tutar.Text = tutar.ToString();
        }

        private void button2_TEMİZLE_Click(object sender, EventArgs e)
        {
            checkBox1_cay.Checked = false;
            checkBox2_Kahve.Checked = false;
            checkBox3_milkshake.Checked = false;
            checkBox4_kola.Checked = false;
            checkBox5_fanta.Checked = false;
            checkBox6_gazoz.Checked = false;
            label2_tutar.Text = "";
        }

        private void button3_ONAYLA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siparişiniz onaylanmıştır.", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}
