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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-751HG1A\\SQLEXPRESS01;Initial Catalog=OyunVeriTabani;Integrated Security=True; MultipleActiveResultSets=True");  //Globalde private şeklinde Sqlconnection,SqlDataReader ve SqlCommand sınıflarını tanımladık.
        SqlDataReader reader;
        SqlCommand komut;

        private string kullanici, ad, adet, kod;
        
         
        private void Form1_Load(object sender, EventArgs e)
        {
            listele(); //Listele metodu yardımıyla tüm oyunlar sayfayı açtığımız anda datagridview'da gösterilmektedir. (listele metodu aşağıda daha detaylı açıklanmaktadır.)
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            if(textBoxAra.Text==string.Empty) //Müşteri arama kısmını boş bırakırsa program uyarı veriyor.
            {
                MessageBox.Show("Lütfen alanı boş bırakmayın", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();

                komut = new SqlCommand("SELECT * FROM Oyunlar WHERE OyunAdi like '%" + textBoxAra.Text + "%' ", baglanti); //  "like" komutu yardımıyla, müşteri oyunun tam adını yazmasa bile istediği oyunu kolaylıkla bulabilecek.
                komut.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(komut);  // Müşterinin arama kısmına yazdığı oyun adına benzer oyunları SqlDataAdapter yardımıyla datagridview 'a yazdırıyoruz.
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();
                textBoxAra.Clear();

            }
        }

        private void buttonTumOyunlar_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            komut = new SqlCommand("SELECT * FROM Oyunlar", baglanti); // Müşteri tüm oyunlara, başka aramalar yaptıktan sonra tekrar ulaşmak isterse bu buton yardımıyla ulaşabilecek.
            komut.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();

        }

        private void listele()
        {
            baglanti.Open();   // Müşteri sayfayı açtığı anda herhangi bir butona basmasa bile tüm oyunlar datagridview'da gösterilecek. listele metodunu bunun için kullandık.

            komut = new SqlCommand("SELECT * FROM Oyunlar", baglanti);
            komut.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        
        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("SELECT * FROM KullaniciBilgiler WHERE Giris='" + 1 + "' ", baglanti);
            reader= komut.ExecuteReader();

            if(reader.Read())   // Sisteme giriş yapan ve çıkış yapan kullanıcıları tespit etmek için veri tabanında bulunann "KullaniciBilgileri" adlı table'da 'Giris' adlı bir sütun oluşturdum. 
            {                   // Sisteme giriş yapan ve sistemda hala bulunan kullanıcıları "1" ya da "true" şeklinde tutuyor. Buna göre kim sistemde şu an kayıtlı bulabiliyoruz.
                MessageBox.Show("Sistemde şu an zaten kayıtlı biri gözükmektedir !", "UYARI");
            }
            else
            {
                FormGirisVeKayit sayfa= new FormGirisVeKayit();  // Eğer müşterinin zaten bir hesabı varsa "Giris Yap" butonuyla onu kullanıcı adı ve şifre bilgilerini gireceği "FormGirişveKAyit" sayfasına (formuna) yönlendiriyoruz.
                sayfa.ShowDialog();
            }

            reader.Close();
            baglanti.Close() ;
        }

        private void buttonSepetiGoruntule_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            komut = new SqlCommand("SELECT * FROM KullaniciBilgiler WHERE Giris='" + 1 + "' ", baglanti); // Sisteme giriş yapan ya da hala sistemde bulunan biri varsa sepetini görüntelemesini bu buton yardımıyla sağlayabiliyoruz.
            reader= komut.ExecuteReader();

            if(reader.Read())
            {
                KisiselSayfa sayfa = new KisiselSayfa();
                sayfa.Show();
                this.Hide();
            }
            else // Sistemde aktif olarak bulunan (hesabı açık diyebileceğimiz) biri yoksa önce giriş yapmasıyla ilgili bir uyarı mesajı veriyoruz.
            {
                MessageBox.Show("Önce sisteme giriş yapınız", "UYARI"); 

            }
            reader.Close() ;
            baglanti.Close() ;
        }

            

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM KullaniciBilgiler WHERE Giris='" + 1 + "' ", baglanti);  
            SqlDataReader reader = komut.ExecuteReader();


            if (reader.Read())  // Eğer sistemde aktif biri bulunuyorsabu if döngüsü çalışır
            {
                string kullanici = reader.GetValue(1).ToString();
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Sistemden çıkılsın mı?", "ÇIKIŞ", MessageBoxButtons.YesNo); // Kullanıcıya sistemden çıkılsın mı diğer bir deyişle siteye girdiğinde tekrardan giriş yapmak istiyor mu diye sorulur.
                if (dialog == DialogResult.Yes)
                {
                        // Eğer cevabı evet ise 
                        komut = new SqlCommand("UPDATE KullaniciBilgiler SET Giris='" + 0 + "' WHERE KullaniciAdi='" + kullanici + "'  ", baglanti);
                        komut.ExecuteNonQuery();
                        komut = new SqlCommand("UPDATE SepetBilgileri SET Giris='" + 0 + "' WHERE KullaniciAdi='" + kullanici + "' ", baglanti);
                        komut.ExecuteNonQuery();


                }
                else
                {
                    MessageBox.Show("Çıkış yapılmadı");
                }

            }
           
                reader.Close();
                baglanti.Close();

            Environment.Exit(0);

        }
            
            

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            komut = new SqlCommand("SELECT * FROM KullaniciBilgiler WHERE Giris='" + 1 + "' ", baglanti);  // Sistemdeki kullanıcının hesabından çıkış yapıp yapmak istemediği sorulur.
            reader = komut.ExecuteReader();

            if(reader.Read())  // Cevabı evet ise veri tabanında bulunan "KullaniciBilgiler" ve "SepetBilgiler" table'larındaki 'Giriş' sütunun değeri "0" olarak update edilir.
            {
                kullanici=reader.GetValue(1).ToString();
                komut = new SqlCommand("UPDATE KullaniciBilgiler SET Giris='" + 0 + "' WHERE KullaniciAdi='" + kullanici + "' ", baglanti);
                komut.ExecuteNonQuery();

                komut = new SqlCommand("UPDATE SepetBilgileri SET Giris='" + 0 + "' WHERE KullaniciAdi='" + kullanici + "' ", baglanti);
                komut.ExecuteNonQuery();

                MessageBox.Show("Sistemden çıkış yapılmıştır", "UYARI"); // Cevabı hayır ise hesap açık tutulur.

            }
            else // Sistemde hesabı açık olan kimse yoksa aşağıdaki uyarı mesajı verilir.
            {
                MessageBox.Show("Şu an sistemde kayıtlı biri gözükmemektedir.", "UYARI");
            }
            baglanti.Close ();
        }

        
        private void buttonKayitOl_Click(object sender, EventArgs e)
        {
            KayitFormu sayfa =new KayitFormu(); // Kayıt formu sayfası açılır.
            sayfa.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            richTextBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();     // Datagridview ' da seçilen oyunun bilgileri textboxlara yazılır.
            richTextBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            richTextBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            richTextBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            richTextBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            richTextBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void buttonSepeteEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            // Datagridview' da seçili (sepete eklenmek istenen ürünün ) bazı bilgileri değişkenlere atanır. 
            kod = dataGridView1.CurrentRow.Cells[0].Value.ToString();    // OyunKodu bilgisi oyuna özeldir.Set Primary Key olarak ayarlanmıştır.
            ad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string fiyat = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            var fiyat2 = fiyat.Replace(",", "."); // Veritabanında fiyat sütunu float şeklinde tanımlanmıştır. fakat Datagridview'daki fiyat sütunundan alınan bilgiler string türündedir. 
                                                  // String türündeki bu verileri float veri tipine çevirsek bile "virgül" float tipine döndürülememektedir.
                                                  // Bu yüzden biz de virgülleri "Replace" komutu ile noktalara dönüştürdük.



            komut = new SqlCommand("SELECT * FROM KullaniciBilgiler WHERE Giris='" + 1 + "' ", baglanti); //Hesabı açık olan kullanıcının sepetine ürünü eklemek için önce o kullanıcııyı tespit ettilk.
            reader = komut.ExecuteReader();

            if(reader.Read())
            {
                kullanici = reader.GetValue(1).ToString();

                komut = new SqlCommand("SELECT Stok FROM DepoBilgileri WHERE OyunKodu='" + kod + "' ", baglanti);
                komut.ExecuteNonQuery();

                int stok = Convert.ToInt16(komut.ExecuteScalar());

                if(stok==0)  // Eğer seçilen ürün stokta değilse müşeriyi uyarı mesajı ile bilgilendirmektedir.
                {
                    MessageBox.Show("Şu an stokta bulunmamaktadır!", "UYARI");
                }
                else // Stokta varsa seçilen ürün sepeteeklenmektedir.
                {
                    komut = new SqlCommand("INSERT INTO SepetBilgileri(KullaniciAdi,OyunKodu,OyunAdi,Fiyat,Adet,Giris) VALUES ('" + kullanici + "' , '" + Convert.ToInt16(kod) + "' , '" + ad + "' , '" + fiyat2 + "'  ,'" + 1 + "', '" + 1 + "')  ", baglanti);
                    reader = komut.ExecuteReader();
                }
                

            }
            else
            {
                MessageBox.Show("Lütfen önce sisteme giriş yapınız!", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Sistemde aktif bir kullanıcı yoksa aşağıdaki uyarı mesajı verilmektedirç

                FormGirisVeKayit sayfa= new FormGirisVeKayit();
                sayfa.ShowDialog();
                
            }

            reader.Close();
            baglanti.Close();
                
            


        }
    }
}
