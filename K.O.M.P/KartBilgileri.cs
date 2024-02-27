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
    public partial class KartBilgileri : Form
    {
        public KartBilgileri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-751HG1A\\SQLEXPRESS01;Initial Catalog=OyunVeriTabani;Integrated Security=True; MultipleActiveResultSets=True");

        private void KartBilgileri_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)    
            {   // 1'den 12'ye kadar ayları ekliyoruz.       
                comboBoxAy.Items.Add(i.ToString());
            }

            for (int i = 2023; i <= 2030; i++)
            {   //2023'ten 2030'a kadar yılları ekliyoruz
                comboBoxYil.Items.Add(i.ToString());
            }

            textBox1.Visible = false;     //textBox1'deki değere göre aşağıda bulunan al butonunu komtrol edeceğiz. Görünmez yaptık çünkü tasarım dışı bir textbox
            textBox1.Text = 1.ToString(); //Eğer textBox1 içindeki değer "1" ise müşteri "Al" butonuna basınca program uyarı vermeyecek.
            
        }


        private void buttonAl_Click(object sender, EventArgs e)
        {
             
            string t1 = textBoxAdiSoyadi.Text;    //textboxlara yazılan kart bilgilerini değişkenlere atıyoruz.
            string t2=textBoxKartNumarasi.Text;
            string t3 = textBoxCVV2.Text;
            string t4 = comboBoxAy.Text;
            string t5= comboBoxYil.Text;

            if(t1!=null && ( t2!=null && t2.Length==16) && t3!=null && t4!=null && t5!=null && t3.Length==3)  // textbox'larda bulunan bilgiler için kontrol mekanizması kullandık.
            {

                if( textBox1.Text==1.ToString())  // Müşteri daha önce "Al" butonuna basmadığı için textBox1'in değeri "1". Bu yüzden işlemin başarılı olduğuna dair bir mesaj gösteriliyor.
                {
                    MessageBox.Show("İşleminiz başarıyla yapılmıştır!");  
                    textBox1.Text=0.ToString();
                }
                else  // Müşteri daha önce "Al" butonuna basmıştır. Ve ürünler zaten alınmıştır. Bu yüzden textBox1'in değeri=0 olmuştur.
                {     // Sistem ikinci kez "Al" butonuna basıldığında uyarı verir.
                    MessageBox.Show("Sepetiniz boş gözükmektedri!", "UYARI");
                }

              
                baglanti.Close();
               
            }
            else
            {
                MessageBox.Show("Alanları lütfen doğru bir şekilde doldurunuz!", " UYARI ");
            }
            
                    
        }

        private void KartBilgileri_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = new DialogResult();                                              
            dialog = MessageBox.Show("Sistemden çıkılsın mı?", "ÇIKIŞ", MessageBoxButtons.YesNo);  //Müşteriye hesabından çıkış yapmak isteyip istemediği sorulur.
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

            Environment.Exit(0);  //this.Hide() komutunu kullandığımız için uygulamanın arka planda çalışmasını durdurmamız lazım. Bunu  Environment.Exit(0) ile yaptık
        }

        private void buttonAnaSayfa_Click(object sender, EventArgs e)
        {
            Form1 sayfa= new Form1();  //Form1'e dönüş sağlanır.
            sayfa.Show();
            this.Hide();
        }

        private void KartBilgileri_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            
        }
    }
}
