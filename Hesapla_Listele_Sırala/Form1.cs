using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesapla_Listele_Sırala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] sayilar = new int[5];
        int i = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                sayilar[i] = Convert.ToInt32(textBox3.Text);
                i++;
                textBox3.Clear();
                label5.Text = i + ". index numarası";

                if (i == 5)
                {
                    textBox3.Enabled = false;

                    MessageBox.Show("Sayı sınırı aşıldı");
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                double tp = 0;

                for (int i = 0; i < sayilar.Length; i++) // toplam
                {
                    tp = tp + sayilar[i];

                }

                double ort = 0; // ort
                ort = tp / i;

                textBox5.Text = ort.ToString();
                textBox4.Text = tp.ToString();


                text_kapa();
                textBox6.Text = sayilar.Max().ToString();
                textBox7.Text = sayilar.Min().ToString();

                // buyuk_kucuk();
            }
            catch
            {

                MessageBox.Show("Eksik veya Boş Bırakılamaz");
            }
        }
        void text_kapa()
        {
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
        }
        void text_ac()
        {
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Array.Sort(sayilar); // küçükte büyüğe

            for (int i = 0; i < 5; i++)
            {
                listBox2.Items.Add(sayilar[i]);
            }

            /* int gecici; Uzun Yol                              
             for (int i = 0; i < sayilar.Length; i++)                
             {                                                       
                 for (int j = 0; j < sayilar.Length; j++)            
                 {                                                   
                     gecici = sayilar[i];                            

                     sayilar[i] = sayilar[j];                        

                     sayilar[j] = gecici;                            
                 }
             }
                 listBox2.Items.Add(i);
            */
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Array.Reverse(sayilar); // büyükten küçüğe
            for (int i = 0; i < 5; i++)
            {
                listBox3.Items.Add(sayilar[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            text_ac();

        }
    }
}
