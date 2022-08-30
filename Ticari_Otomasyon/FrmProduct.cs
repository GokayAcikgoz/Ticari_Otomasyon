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

namespace Ticari_Otomasyon
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        DbConnection connection = new DbConnection();

        void GetAll()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_URUNLER", connection.connection());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

      
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            GetAll();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("insert into TBL_URUNLER(URUNAD, MARKA, MODEL, YIL, ADET, " +
                "ALISFIYAT, SATISFIYAT, DETAY) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)", connection.connection());

                command.Parameters.AddWithValue("@p1", txtName.Text);
                command.Parameters.AddWithValue("@p2", txtBrand.Text);
                command.Parameters.AddWithValue("@p3", txtModel.Text);
                command.Parameters.AddWithValue("@p4", mskYear.Text);
                command.Parameters.AddWithValue("@p5", int.Parse((numTotal.Value).ToString()));
                command.Parameters.AddWithValue("@p6", decimal.Parse(txtBuy.Text));
                command.Parameters.AddWithValue("@p7", decimal.Parse(txtSell.Text));
                command.Parameters.AddWithValue("@p8", rchDetail.Text);

                command.ExecuteNonQuery();

                connection.connection().Close();

                MessageBox.Show("Ürün Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetAll();
            }
            catch (Exception)
            {

                MessageBox.Show("Ürün Eklenemedi. Doğru Formatta Giriniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Ürün Kaydınız Sileceksiniz. Emin Misiniz?", "Ürün Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand("delete from TBL_URUNLER where ID = @p1", connection.connection());

                    command.Parameters.AddWithValue("@p1", txtId.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Ürün Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    GetAll();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ürün Silinemedi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtId.Text = dr["ID"].ToString();
            txtName.Text = dr["URUNAD"].ToString();
            txtBrand.Text = dr["MARKA"].ToString();
            txtModel.Text = dr["MODEL"].ToString();
            mskYear.Text = dr["YIL"].ToString();
            numTotal.Text = dr["ADET"].ToString();
            txtBuy.Text = dr["ALISFIYAT"].ToString();
            txtSell.Text = dr["SATISFIYAT"].ToString();
            rchDetail.Text = dr["DETAY"].ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("update TBL_URUNLER set URUNAD = @p1, MARKA = @p2, MODEL = @p3, " +
                "YIL = @p4, ADET = @p5, ALISFIYAT = @p6, SATISFIYAT = @p7, DETAY = @p8 where ID = @p9", connection.connection());

                command.Parameters.AddWithValue("@p1", txtName.Text);
                command.Parameters.AddWithValue("@p2", txtBrand.Text);
                command.Parameters.AddWithValue("@p3", txtModel.Text);
                command.Parameters.AddWithValue("@p4", mskYear.Text);
                command.Parameters.AddWithValue("@p5", int.Parse((numTotal.Value).ToString()));
                command.Parameters.AddWithValue("@p6", decimal.Parse(txtBuy.Text));
                command.Parameters.AddWithValue("@p7", decimal.Parse(txtSell.Text));
                command.Parameters.AddWithValue("@p8", rchDetail.Text);
                command.Parameters.AddWithValue("@p9", txtId.Text);

                command.ExecuteNonQuery();
                connection.connection().Close();

                MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAll();
            }
            catch (Exception)
            {

                MessageBox.Show("Ürün Güncellenemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtBrand.Text = "";
            txtModel.Text = "";
            mskYear.Text = "";
            numTotal.Text = "";
            txtBuy.Text = "";
            txtSell.Text = "";
            rchDetail.Text = "";
        }
    }
}
