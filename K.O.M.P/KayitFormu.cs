using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;
using System.Text.RegularExpressions;

namespace FinalProjesi
{
    public partial class KayitFormu : Form
    {
        public KayitFormu()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-751HG1A\\SQLEXPRESS01;Initial Catalog=OyunVeriTabani;Integrated Security=True; MultipleActiveResultSets=True");
        SqlCommand komut;

        private void KayitFormu_Load(object sender, EventArgs e)
        {
            groupBoxCalisan.Visible = false;
            groupBoxMusteri.Visible = false;


        }

        private void buttonMusteri_Click(object sender, EventArgs e)
        {
            if (groupBoxCalisan.Visible == true)
            {
                groupBoxCalisan.Visible = false;  //Müşteri sadece "Müşteri kayıt formunu" görüyor
                groupBoxMusteri.Visible = true;
            }
            else
            {
                groupBoxMusteri.Visible = true;
            }
        }

        private void buttonCalisan_Click(object sender, EventArgs e)
        {
            if (groupBoxMusteri.Visible == true)
            {
                groupBoxMusteri.Visible = false;     // Çalışanlar "Çalışan kayıt formunu" görüyor
                groupBoxCalisan.Visible = true;
            }
            else
            {
                groupBoxCalisan.Visible = true;
            }
        }

        private void buttonMusteriKayit_Click(object sender, EventArgs e)
        {
            string AdiSoyadi = textBoxAdiSoyadi.Text;
            string KullaniciAdi = textBoxKullaniciAdi.Text;   // Müşteriyi veri tabanına kaydetmek için bazı bilgiler alıyoruz.
            string Sifre = textBoxSifre.Text;
            string Eposta = textBoxEposta.Text;
            string Telefon = textBoxTelefon.Text;
            string Adres = richTextBox1.Text;
            baglanti.Open();

            Regex rgx = new Regex("@hotmail.com");
            Regex rgx1 = new Regex("@gmail.com");



            try
            {

                if (rgx.Match(Eposta).Success || rgx1.Match(Eposta).Success)
                {
                    komut = new SqlCommand("INSERT INTO KullaniciBilgiler (AdiSoyadi, KullaniciAdi, Sifre, Eposta, Telefon, Adres,Giris) VALUES ('" + AdiSoyadi + "' , '" + KullaniciAdi + "', '" + Sifre + "' , '" + Eposta + "', '" + Telefon + "', '" + Adres + "', '" + 0 + "' )", baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kaydınız başarıyla yapılmıştır. Giriş sayfasına geri gidip lütfen tekrar giriş yapınız!");
                }
                else
                {
                    MessageBox.Show("Lütfen e-posta adresinizi doğru giriniz!", "UYARI");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }






            baglanti.Close();

        }

        private void buttonCalisanKayit_Click(object sender, EventArgs e)
        {
            string AdiSoyadi = textBox1.Text;
            string KullaniciAdi = textBox2.Text;
            string Sifre = textBox3.Text;
            string Kod = textBox4.Text;
            baglanti.Open();
            try
            {
                if (Kod == "7548961003")  //Herkesin çalışan olarak kaydolmasını engellemek için çalışanlara bir kod veriliyor. Çalışanlar bu kodu doğru girebilirse kayıt olabiliyor.
                {
                    komut = new SqlCommand("INSERT INTO CalisanBilgiler (AdiSoyadi, KullaniciAdi, Sifre) VALUES ('" + AdiSoyadi + "' , '" + KullaniciAdi + "' , '" + Sifre + "' )", baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarıyla oluşturulmuştur !");
                }
                else
                {
                    MessageBox.Show("Kodu yanlış girdiniz!", "UYARI");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void buttonGirisSayfasi_Click(object sender, EventArgs e)
        {
            FormGirisVeKayit sayfa = new FormGirisVeKayit();   // Giriş sayfasına dönmeyi sağlıyor.
            sayfa.Show();
            this.Close();
        }

        private void KayitFormu_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void buttonAnaSayfa_Click(object sender, EventArgs e)
        {

        }
    }
}
