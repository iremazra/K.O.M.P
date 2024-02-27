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
using System.Web;
using System.Text.RegularExpressions;

namespace FinalProjesi
{
    public partial class KisiselSayfa : Form
    {
        public KisiselSayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-751HG1A\\SQLEXPRESS01;Initial Catalog=OyunVeriTabani;Integrated Security=True; MultipleActiveResultSets=True");
        SqlCommand komut;
        SqlDataReader reader;
        
        private string kullanici, ad,toplamOdeme;
        private int kod, adet;
        private void KisiselSayfa_Load(object sender, EventArgs e)
        {
            listele();
            Hesapla();
            baglanti.Open();
            komut = new SqlCommand("SELECT * FROM KullaniciBilgiler WHERE Giris='" + 1 + "' ", baglanti);
            reader = komut.ExecuteReader();

            if (reader.Read())
            {
                textBoxAdiSoyadi.Text = reader.GetValue(0).ToString();       //Kullanici bilgilerini textboxlara aktarıyor.
                textBoxEposta.Text = reader.GetValue(3).ToString();
                textBoxTelefon.Text = reader.GetValue(4).ToString();
                richTextBoxAdres.Text = reader.GetValue(5).ToString();
            }
            reader.Close();
            baglanti.Close();

            toplamOdeme = textBoxFiyat.Text;
        }

        public void listele()
        {
            baglanti.Open();
            komut = new SqlCommand("SELECT OyunKodu,OyunAdi,Fiyat, count(*) as 'Adet' FROM SepetBilgileri WHERE Giris='" + 1 + "' GROUP BY OyunKodu,OyunAdi,Fiyat  ", baglanti);  
            //Sepette bulunan oyunları Oyun adı,kodu ve fiyatına göre gruplayıp kaç adet bulunduğunu datagridview'a yazdırıyor.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void buttonArti_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            komut = new SqlCommand("SELECT * FROM KullaniciBilgiler WHERE Giris='" + 1 + "' ", baglanti);
            reader=komut.ExecuteReader();

            if(reader.Read())
            {
                kullanici= reader.GetValue(1).ToString();
                kod = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                ad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string fiyat = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                var fiyat2 = fiyat.Replace(",", ".");// Veritabanında fiyat sütunu float şeklinde tanımlanmıştır. fakat Datagridview'daki fiyat sütunundan alınan bilgiler string türündedir. 
                                                     // String türündeki bu verileri float veri tipine çevirsek bile "virgül" float tipine döndürülememektedir.
                                                     // Bu yüzden biz de virgülleri "Replace" komutu ile noktalara dönüştürdük.

                komut = new SqlCommand("INSERT INTO SepetBilgileri (KullaniciAdi,OyunKodu,OyunAdi,Fiyat,Adet,Giris) VALUES ('" + kullanici + "' , '" + kod + "', '" + ad + "' , '" + fiyat2 + "' , '" + 1 + "', '" + 1 + "' )", baglanti);
                komut.ExecuteNonQuery();
                //datagridview'da seçili olan oyunu bilgileriyle birlikte veri tabanına ekliyoruz.                
            }
           
            reader.Close();
            baglanti.Close() ;
            listele(); //Sepet eklemesinden sonra adetin arttığını dinamik olarak görmek için tekrardan "listele" metodunu çağırıyoruz.
            Hesapla(); //Yine aynı şekilde artan adet sayısından dolayı toplam fiyatı tekrar hesaplamak için "Hesapla" metodunu çağırıyoruz.
        }

        private void buttonAlısveriseDevam_Click(object sender, EventArgs e)
        {
            Form1 sayfa = new Form1();
            sayfa.Show();
            this.Hide();
        }

        private void KisiselSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Sistemden çıkılsın mı?", "ÇIKIŞ", MessageBoxButtons.YesNo);  //Kullanıcının hesabından çıkış yapıp yapmak istemedği soruluyor.
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM KullaniciBilgiler WHERE Giris='" + 1 + "' ", baglanti);
                SqlDataReader reader = komut.ExecuteReader();


                if (reader.Read())
                {
                    string kullanici = reader.GetValue(1).ToString();
                    komut = new SqlCommand("UPDATE KullaniciBilgiler SET Giris='" + 0 + "' WHERE KullaniciAdi='" + kullanici + "'  ", baglanti);
                    komut.ExecuteNonQuery();
                    komut = new SqlCommand("UPDATE SepetBilgileri SET Giris='" + 0 + "' WHERE KullaniciAdi='" + kullanici + "' ", baglanti);
                    komut.ExecuteNonQuery();


                }
                reader.Close();
                baglanti.Close();



            }
            else
            {
                MessageBox.Show("Çıkış yapılmadı");
            }

            Environment.Exit(0);
        }

        private void buttonBilgileriDeğistir_Click(object sender, EventArgs e)
        {
            string AdiSoyadi = textBoxAdiSoyadi.Text;
            string Eposta = textBoxEposta.Text;
            string Telefon = textBoxTelefon.Text;
            string Adres = richTextBoxAdres.Text;
            baglanti.Open();

            //Kullanıcı bilgilerini güncellemek isterse istediği bilgileri textbox'lardan değiştirip veri tabanına ekleyebilir.

            try
            {
                komut = new SqlCommand("UPDATE KullaniciBilgiler SET AdiSoyadi='" + AdiSoyadi + "' , Eposta='" + Eposta + "' , Telefon='" + Telefon + "', Adres='" + Adres + "' WHERE Giris='" + 1 + "' ", baglanti);
                komut.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            baglanti.Close();
        }   

        private void buttonAl_Click(object sender, EventArgs e)
        {
            if(textBoxFiyat.Text==0.ToString())
            {
                MessageBox.Show("Sepetiniz boş gözükmektedir!", "UYARI");
            }
            else
            {
                AlveBitir();
                Temizle();
                KartBilgileri sayfa = new KartBilgileri();
                sayfa.Show();
                this.Hide();
                
            }
           
         
        }

        private void buttonEksi_Click(object sender, EventArgs e)
        {
            baglanti.Open() ;

            adet= Convert.ToInt16(dataGridView1.CurrentRow.Cells[3].Value);
            kod = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            ad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string fiyat = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            var fiyat2 = fiyat.Replace(",", ".");

            if (adet==1) //Adet 0 kalacağı için kaydı direkt veri tabanından siliyor.
            {
                komut = new SqlCommand("DELETE FROM SepetBilgileri WHERE Giris='" + 1 + "' AND OyunKodu='"+kod+"'  ", baglanti);
                komut.ExecuteNonQuery();
            }
            else
            {
                komut = new SqlCommand("DELETE FROM SepetBilgileri WHERE Giris='" + 1 + "' AND OyunKodu='" + kod + "' ", baglanti);
                komut.ExecuteNonQuery();

                komut = new SqlCommand("SELECT * FROM KullaniciBilgiler WHERE Giris='" + 1 + "' ", baglanti);
                reader = komut.ExecuteReader();

                if(reader.Read())
                {
                    kullanici = reader.GetValue(1).ToString();

                    for(int i=adet-1; i>0;i--) //Silme işleminde aynı bilgileri içeren kayıtlardan sadece bir tanesini silemediğimiz için hepsini sildik.
                    {                          //Daha sonra silmeden önceki adet sayısının bir eksiği kadarını for döngüsüyle , aynı bilgilerlerle veri tabanına tekrardan kaydettirdik.
                        komut = new SqlCommand("INSERT INTO SepetBilgileri (KullaniciAdi, OyunKodu,OyunAdi,Fiyat,Adet,Giris) VALUES ('" + kullanici + "', '" + kod + "', '" + ad + "' , '" + fiyat2 + "' , '" + 1 + "' , '" + 1 + "' ) ", baglanti);
                        komut.ExecuteNonQuery();
                    }
                }
            }
           
            reader.Close();
            baglanti.Close();
            listele();   //Yapılan değişikliğin fiyat ve listeleme üzerindeki etkisini görmek için tekrardan "listele ve Hesapla" metodlarını çağırdık
            Hesapla();
           

          

        }

        private void Hesapla()
        {

            baglanti.Open(); //Sepette bulunan ürünlerin toplam fiyatını hesaplar

            komut = new SqlCommand("SELECT * FROM SepetBilgileri WHERE Giris='" + 1 + "' ", baglanti);
            reader = komut.ExecuteReader();

            if( reader.Read())
            {
                komut = new SqlCommand("SELECT SUM(Fiyat) FROM SepetBilgileri WHERE Giris='" + 1 + "' ", baglanti);
                komut.ExecuteNonQuery();

                toplamOdeme = komut.ExecuteScalar().ToString();
                textBoxFiyat.Text=toplamOdeme;
            }
            else // Sepette ürün yoksa  textBoxFiyat'a "0" yazdırır.
            { 
                textBoxFiyat.Text = 0.ToString();
            }
           
            baglanti.Close() ;

        }

            

        public void AlveBitir()
        {
            
            int[] kodlar = new int[31];
            

            for (int i = 0; i < (dataGridView1.Rows.Count); i++)
            {
                kodlar[i] = Convert.ToInt16(dataGridView1.Rows[i].Cells["OyunKodu"].Value); //Sepette bulunup datagridview'da gösterilen tüm oyunların kodlarını bir diziye atadık.
            }
            baglanti.Open();


            for (int i = 0; i < (dataGridView1.Rows.Count); i++)
            {
                int kod1 = kodlar[i];
                int adet = Convert.ToInt16(dataGridView1.Rows[i].Cells["Adet"].Value);

                komut = new SqlCommand("SELECT Stok FROM DepoBilgileri WHERE OyunKodu='" + kod1 + "' ", baglanti);
                komut.ExecuteNonQuery();

                int stok = Convert.ToInt16(komut.ExecuteScalar()); //Oyunların adetlerine göre stoktan eksiltme yaptık.

                komut = new SqlCommand("UPDATE DepoBilgileri SET Stok='" + (stok - adet) + "' WHERE OyunKodu='" + kod1 + "' ", baglanti);
                komut.ExecuteNonQuery();


            }

            

            baglanti.Close();
            Array.Clear(kodlar, 0, kodlar.Length); 


            
            
        }

        public void Temizle()
        {

            int[] kodlar = new int[31];


            for (int i = 0; i < (dataGridView1.Rows.Count); i++)  //Sepette bulunup datagridview'da gösterilen tüm oyunların kodlarını bir diziye atadık.
            {
                kodlar[i] = Convert.ToInt16(dataGridView1.Rows[i].Cells["OyunKodu"].Value);
            }
            baglanti.Open();
            for (int i = 0; i < (dataGridView1.Rows.Count); i++)
            {
                int kod2 = kodlar[i];

                komut = new SqlCommand("DELETE FROM SepetBilgileri WHERE OyunKodu='" + kod2 + "' AND Giris='" + 1 + "' ", baglanti); // Al butonuna bastıktan sonra  müşterinin sepetini temizledik.
                komut.ExecuteNonQuery();
            }

            baglanti.Close();
            Array.Clear(kodlar, 0, kodlar.Length);

          
           

        }
    }
}
