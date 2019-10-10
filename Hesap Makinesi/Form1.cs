using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int toplam = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
                MessageBox.Show("İşlemin sonucu = " + toplam.ToString(), "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int toplam = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text);
                MessageBox.Show("İşlemin sonucu = " + toplam.ToString(), "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int toplam = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
                MessageBox.Show("İşlemin sonucu = " + toplam.ToString(), "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int toplam = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text);
                MessageBox.Show("İşlemin sonucu = " + toplam.ToString(), "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
