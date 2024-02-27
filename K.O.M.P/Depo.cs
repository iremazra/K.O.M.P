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
    public partial class Depo : Form
    {
        public Depo()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-751HG1A\\SQLEXPRESS01;Initial Catalog=OyunVeriTabani;Integrated Security=True; MultipleActiveResultSets=True");
        SqlCommand komut;
        SqlDataReader reader;
        private int kod, stok, tedarik;

        private void Depo_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void listele()
        {
            baglanti.Open();  // tüm depo bilgilerini listele metodu yardımıyla, sayfayı açtığımızda datagridview'da görmekteyiz.

            komut = new SqlCommand("SELECT * FROM DepoBilgileri", baglanti);
            komut.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();

            textBoxOyunKodu.Clear();
            textBoxStok.Clear();
            textBoxTedarikSuresi.Clear();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            kod = Convert.ToInt16(textBoxOyunKodu.Text); //Silmek istediğimiz oyunun kod bilgisini datagridview'dan alıyoruz.

            try
            {
                komut = new SqlCommand("DELETE FROM DepoBilgileri WHERE OyunKodu='" + kod + "' ", baglanti);
                komut.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Lütfen bİlgileri doğru bir şekilde giriniz!", "UYARI"); // Çalışan textboxlardaki bilgileri yanlışlıkla silerse veya yürütme esnasında herhangi bir hata veirse diye try-catch kullandık.
            }
            finally
            {
                baglanti.Close();
            }
            listele();

        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            kod = Convert.ToInt16(textBoxOyunKodu.Text);         // Güncellemek istediğimiz veriyi textboxlar yardımıyla güncelliyoruz.
            stok=Convert.ToInt16(textBoxStok.Text);
            tedarik = Convert.ToInt16(textBoxTedarikSuresi.Text);
            baglanti.Open();
            try
            {
                komut = new SqlCommand("UPDATE DepoBilgileri SET Stok='" + stok + "' , TedarikSuresi='" + tedarik + "' WHERE OyunKodu='" + kod + "' ",baglanti);
                komut.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Lütfen bİlgileri doğru bir şekilde giriniz!", "UYARI");
            }
            finally
            {
                baglanti.Close();
            }
            listele();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxOyunKodu.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();   // Datagridview'ın "Selection Mode'unu =FullRowSelect " yapmıştık.
            textBoxStok.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();       // Bu sayede datagridview üzerinde bulunan seçtiğimiz satırdaki bilgileri textbox'lara aktarabiliyoruz
            textBoxTedarikSuresi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            kod = Convert.ToInt16(textBoxOyunKodu.Text);       // Eklemek istediğimiz oyunun depo bilgilerini textbox'lara yazıp ekle butonuyla veri tabanımıza ekliyoruz.
            stok = Convert.ToInt16(textBoxStok.Text); 
            tedarik = Convert.ToInt16(textBoxTedarikSuresi.Text);

            try
            {
                komut = new SqlCommand("INSERT INTO DepoBilgileri (OyunKodu,Stok,TedarikSuresi) VALUES ('" + kod + "' , '" + stok + "' , '" + tedarik + "') ", baglanti);
                komut.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Lütfen bİlgileri doğru bir şekilde giriniz!", "UYARI");
            }
            finally
            {
                baglanti.Close();
            }
            listele();

        }
    }
}
