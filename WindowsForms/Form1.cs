using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Bu alanda form1 yüklenirken çalışır , burada veri tabanına bağlanıpdb deki kayıtları çekip ekrana göndeririz
            trackBar1.Minimum = 10;
            trackBar1.Maximum = 25;
            trackBar1.TickFrequency = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Butona tıkladığımızda bu metot çalışır ve burada veritabanı işlemleri veya ekranla alakalı işlemler gerçekleştirebiliriz.
            butonAdi.Text = "MARABA";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Urunekle urunekle = new Urunekle();  // Urunekle formundan bir nesne oluştur.
          // urunekle.Show(); // Oluşan nesneyi ekrana getir
            urunekle.ShowDialog(); // ekrana sadece 1 tane Urunekle penceresi açabilmesini istiyorsak
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("İki Tarih Arasında" + (dateTimePicker2.Value - dateTimePicker1.Value).Days.ToString() + "Gün Fark Vardır."); // mbox tab tab kısayol
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Lütfen bir sayı giriniz");
            }
            else
            {
                int sayi = Convert.ToInt32(textBox1.Text);
                progressBar1.Maximum = sayi;
                for (int i = 0; i < sayi; i++)
                {
                    progressBar1.Value = i;
                }
            }
        }

        private void yeniEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  menüye tıklayıp işlem yaptırabileceğimiz metot
            Urunekle urunekle = new Urunekle();
            urunekle.ShowDialog();

        }

        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();   // RichTextBox deki tüm içeriği seç
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();    // RichTextBox deki tüm içeriği kopyala
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();   // RichTextBox deki tüm içeriği Yapıştır
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();   // RichTextBox deki tüm içeriği Kes
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // ekrandaki trackBar1 kaydırma çubuğu hareket ettiğinde bu metot tetiklenir. 
            richTextBox1.Font = new Font("Tahoma", trackBar1.Value);
        }
    }
}
