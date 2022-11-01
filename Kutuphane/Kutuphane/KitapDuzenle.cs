using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class KitapDuzenle : Form
    {
        AnaEkran anaEkran;

        public KitapDuzenle(AnaEkran parametredenGelenAnaEkran, Kitap kitap)
        {
            InitializeComponent();

            anaEkran = parametredenGelenAnaEkran;

            textBox1.Text = kitap.Ad;
            comboBox1.Text = kitap.Yazar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap(textBox1.Text, comboBox1.Text);
            anaEkran.kitapDuzenle(kitap);
            anaEkran.Show();
            this.Hide();
        }

        private void KitapDuzenle_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaEkran.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                if (comboBox1.Items.Contains(textBox2.Text) == false)
                {
                    comboBox1.Items.Add(textBox2.Text);
                    textBox2.Text = "";
                }
                else if (comboBox1.Items.Contains(textBox2.Text) == true)
                {
                    MessageBox.Show("Zaten var olan yazarı tekrar ekleyemezsiniz!!");
                    textBox2.Text = "";
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }

        private void KitapDuzenle_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }
    }
}
