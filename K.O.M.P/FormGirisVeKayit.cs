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

namespace FinalProjesi
{
    public partial class FormGirisVeKayit : Form
    {
        public FormGirisVeKayit()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-751HG1A\\SQLEXPRESS01;Initial Catalog=OyunVeriTabani;Integrated Security=True; MultipleActiveResultSets=True");
        SqlCommand komut;
        SqlDataReader reader;
        private string kullanici, ad;
        private int kod;
        private float fiyat;

        private void buttonCalisanUyeGirisi_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            try
            {
                komut = new SqlCommand("SELECT * FROM CalisanBilgiler WHERE KullaniciAdi='" + textBoxKullanici.Text + "' AND Sifre='" + textBoxSifre.Text + "' ", baglanti);
                reader = komut.ExecuteReader();   // Kayıtlı çalışanların giriş yaparken kullanıcı ad ve şifrelerini doğru girip girmediğini kontrol ediyoruz.

                if (reader.Read())
                {
                    Depo sayfa = new Depo();  // Bilgiler doğruysa depo sayfasını açıyoruz.
                    sayfa.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatali kullanıcı adı veya şifre girdiniz!", "UYARI!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            reader.Close();
            baglanti.Close();
        }

        private void FormGirisVeKayit_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void buttonKayitOl_Click(object sender, EventArgs e)
        {
            KayitFormu sayfa = new KayitFormu();
            sayfa.ShowDialog();

        }

        private void FormGirisVeKayit_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void buttonKullaniciUyeGirisi_Click(object sender, EventArgs e)
        {
            baglanti.Open();


            try
            {
                komut = new SqlCommand("SELECT * FROM KullaniciBilgiler WHERE Giris='" + 1 + "' ", baglanti);
                reader = komut.ExecuteReader(); // Eğer sistemde zaten kayıtlı bir kişi varsa onu tespit etmeye çalışıyoruz.

                if (reader.Read())
                {
                    MessageBox.Show("Şu an sistemde kayıtlı biri gözükmektedir. Lütfen önce çıkış yapınız!", "UYARI");
                }
                else
                {
                    komut = new SqlCommand("SELECT * FROM KullaniciBilgiler WHERE KullaniciAdi='" + textBoxKullanici.Text + "' AND Sifre='" + textBoxSifre.Text + "' ", baglanti);
                    reader = komut.ExecuteReader();

                    // Kayıtlı kullanıcıların kullanıcı ad ve şifrelerini doğru girip girmediğini kontrol ediyoruz.
                    if (reader.Read())
                    {
                        komut = new SqlCommand("UPDATE KullaniciBilgiler SET Giris='" + 1 + "' WHERE KullaniciAdi='" + textBoxKullanici.Text + "' ", baglanti);
                        komut.ExecuteNonQuery();
                        komut = new SqlCommand("UPDATE SepetBilgileri SET Giris='" + 1 + "' WHERE KullaniciAdi='" + textBoxKullanici.Text + "' ", baglanti);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Girişiniz başarıyla yapılmıştır!");
                    }
                    else
                    {
                        MessageBox.Show("Hatalı kullanıcı adı veya şifre girdiniz!", "UYARI");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            reader.Close();
            baglanti.Close();

        }

    }
}
