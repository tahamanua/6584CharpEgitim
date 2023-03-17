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
    public partial class Urunekle : Form
    {
        public Urunekle()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult sonuc; // MessageBox.Show metodunu geri dönüş türü DialogResult tır.
            sonuc = MessageBox.Show("Kapatmak istiyor musunuz?", "UYARI", MessageBoxButtons.OKCancel);
            if (sonuc == DialogResult.OK)
            this.Close(); // Bu Formu Kapat
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kapatmak istiyor musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) // MessageBoxIcon.Exclamation pencereye ikon ekleyebilmemizi sağlar
            {
                Application.Exit(); // uygulamadan çık
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // burada Ürün bilgileri veri tabanına kaydedilir 
            if (string.IsNullOrEmpty(textBox1.Text)) // eğer txtUrunAdi.Text boşsa 
            {
                MessageBox.Show("Ürün Adı Boş Geçilmez"); // ekrana mesaj penceresi ile uyarı vermemizi sağlar
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lblResim.Font = new Font("Arial", (float)numericUpDown1.Value); // Oklarla sayıları değştirdiğimizde labelın yazı boyutu değişir
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            lblResim.Font = new Font(domainUpDown1.SelectedItem.ToString(), (float)numericUpDown1.Value);
        }

        private void Urunekle_Load(object sender, EventArgs e) //  Formda ki her hangi bir boş alana çift tılayarak load eventini oluşturabiliriz bu olay form yüklenirken  işlmeler yapabilmemizi sağlar    
        {
            // Form Yüklenirken domainUpDown1 e for un içinde ki verileri ekle 
            for (int i = 0; i < 50; i++)
            {
                domainUpDown1.Items.Add(FontFamily.Families[i].Name); // sistemde ki fontlardan domainUpDown1 e ekleme yaptık 
            }
            domainUpDown1.Wrap = true; // liste sonunda  başa dön 
        }

        private void lblResim_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
