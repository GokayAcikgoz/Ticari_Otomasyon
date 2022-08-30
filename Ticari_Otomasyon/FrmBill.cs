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
    public partial class FrmBill : Form
    {
        public FrmBill()
        {
            InitializeComponent();
        }

        DbConnection connection = new DbConnection();

        void GetAll()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_FATURABILGI", connection.connection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void FrmBill_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            txtId.Text = dr["FATURABILGIID"].ToString();
            txtSerialNo.Text = dr["SERI"].ToString();
            txtRowNo.Text = dr["SIRANO"].ToString();
            mskDate.Text = dr["TARIH"].ToString();
            mskClock.Text = dr["SAAT"].ToString();
            txtTaxOffice.Text = dr["VERGIDAIRE"].ToString();
            txtReceiver.Text = dr["ALICI"].ToString();
            txtSubmitter.Text = dr["TESLIMEDEN"].ToString();
            txtDeliveryArea.Text = dr["TESLIMALAN"].ToString();

        }

       

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Fatura Silinecek. Emin Misiniz?", "Fatura Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand command = new SqlCommand("Delete from TBL_FATURABILGI where FATURABILGIID = @p1", connection.connection());
                command.Parameters.AddWithValue("@p1", txtId.Text);
                command.ExecuteNonQuery();
                connection.connection().Close();

                MessageBox.Show("Fatura Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                GetAll();
            }

            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update TBL_FATURABILGI set SERI = @p1, SIRANO = @p2, TARIH = @p3," +
                "SAAT = @p4, VERGIDAIRE = @p5, ALICI = @p6, TESLIMEDEN = @p7, TESLIMALAN = @p8 where FATURABILGIID = @p9", connection.connection());

            command.Parameters.AddWithValue("@p1", txtSerialNo.Text);
            command.Parameters.AddWithValue("@p2", txtRowNo.Text);
            command.Parameters.AddWithValue("@p3", mskDate.Text);
            command.Parameters.AddWithValue("@p4", mskClock.Text);
            command.Parameters.AddWithValue("@p5", txtTaxOffice.Text);
            command.Parameters.AddWithValue("@p6", txtReceiver.Text);
            command.Parameters.AddWithValue("@p7", txtSubmitter.Text);
            command.Parameters.AddWithValue("@p8", txtDeliveryArea.Text);
            command.Parameters.AddWithValue("@p9", txtId.Text);
            command.ExecuteNonQuery();
            connection.connection().Close();
            MessageBox.Show("Fatura Bilgisi Güncellendi", "Fatura Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GetAll();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmBillDetail frmBillDetail = new FrmBillDetail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                frmBillDetail.id = dr["FATURABILGIID"].ToString();
            }

            frmBillDetail.Show();
        }

        private void btnCleaner_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtSerialNo.Text = "";
            txtRowNo.Text = "";
            mskDate.Text = "";
            mskClock.Text = "";
            txtTaxOffice.Text = "";
            txtReceiver.Text = "";
            txtSubmitter.Text = "";
            txtDeliveryArea.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select URUNAD, SATISFIYAT from TBL_URUNLER where ID = @p1 ", connection.connection());
            command.Parameters.AddWithValue("@p1", txtProductId.Text);

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                txtProductName.Text = dr[0].ToString();
                txtPrice.Text = dr[1].ToString();
            }
            connection.connection().Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Firma cari
            if (txtBillId.Text == "")
            {
                SqlCommand command = new SqlCommand("insert into TBL_FATURABILGI (SERI, SIRANO, TARIH, SAAT, VERGIDAIRE, " +
                    "ALICI, TESLIMEDEN, TESLIMALAN) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)", connection.connection());

                command.Parameters.AddWithValue("@p1", txtSerialNo.Text);
                command.Parameters.AddWithValue("@p2", txtRowNo.Text);
                command.Parameters.AddWithValue("@p3", mskDate.Text);
                command.Parameters.AddWithValue("@p4", mskClock.Text);
                command.Parameters.AddWithValue("@p5", txtTaxOffice.Text);
                command.Parameters.AddWithValue("@p6", txtReceiver.Text);
                command.Parameters.AddWithValue("@p7", txtSubmitter.Text);
                command.Parameters.AddWithValue("@p8", txtDeliveryArea.Text);
                command.ExecuteNonQuery();
                connection.connection().Close();
                MessageBox.Show("Fatura Bilgisi Eklendi", "Fatura Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetAll();
            }


            if (txtBillId.Text != "" && cmbCari.Text == "Firma")
            {
                double miktar, tutar, fiyat;

                fiyat = Convert.ToDouble(txtPrice.Text);
                miktar = Convert.ToDouble(txtQuantity.Text);
                tutar = miktar * fiyat;

                txtAmount.Text = tutar.ToString();

                SqlCommand command = new SqlCommand("insert into TBL_FATURADETAY (URUNAD, MIKTAR, FIYAT, TUTAR, FATURAID)" +
                    "values (@p1, @p2, @p3, @p4, @p5)", connection.connection());

                command.Parameters.AddWithValue("@p1", txtProductName.Text);
                command.Parameters.AddWithValue("@p2", txtQuantity.Text);
                command.Parameters.AddWithValue("@p3", decimal.Parse(txtPrice.Text));
                command.Parameters.AddWithValue("@p4", decimal.Parse(txtAmount.Text));
                command.Parameters.AddWithValue("@p5", txtBillId.Text);
                command.ExecuteNonQuery();
                connection.connection().Close();


                //Hareket Tablosuna Veri Girisi
                SqlCommand command2 = new SqlCommand("insert into TBL_FIRMAHAREKETLER (URUNID, ADET, PERSONEL, FIRMA, " +
                    "FIYAT, TOPLAM, FATURAID, TARIH) values (@h1, @h2, @h3, @h4, @h5, @h6, @h7, @h8)", connection.connection());
                command2.Parameters.AddWithValue("@h1", txtProductId.Text);
                command2.Parameters.AddWithValue("@h2", txtQuantity.Text);
                command2.Parameters.AddWithValue("@h3", txtEmployee.Text);
                command2.Parameters.AddWithValue("@h4", txtCompany.Text);
                command2.Parameters.AddWithValue("@h5", decimal.Parse(txtPrice.Text));
                command2.Parameters.AddWithValue("@h6", decimal.Parse(txtAmount.Text));
                command2.Parameters.AddWithValue("@h7", txtBillId.Text);
                command2.Parameters.AddWithValue("@h8", mskDate.Text);
                command2.ExecuteNonQuery();
                connection.connection().Close();


                //Stok sayisi azaltma
                SqlCommand command3 = new SqlCommand("update TBL_URUNLER set ADET = adet - @s1 where ID = @s2", connection.connection());
                command3.Parameters.AddWithValue("@s1", txtQuantity.Text);
                command3.Parameters.AddWithValue("@s2", txtProductId.Text);
                command3.ExecuteNonQuery();
                connection.connection().Close();

                MessageBox.Show("Faturaya Ait Ürün Eklendi", "Fatura Detay", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetAll();
            }



            //Müşteri Cari

            if (txtBillId.Text != "" && cmbCari.Text == "Müşteri")
            {
                double miktar, tutar, fiyat;

                fiyat = Convert.ToDouble(txtPrice.Text);
                miktar = Convert.ToDouble(txtQuantity.Text);
                tutar = miktar * fiyat;

                txtAmount.Text = tutar.ToString();

                SqlCommand command = new SqlCommand("insert into TBL_FATURADETAY (URUNAD, MIKTAR, FIYAT, TUTAR, FATURAID)" +
                    "values (@p1, @p2, @p3, @p4, @p5)", connection.connection());

                command.Parameters.AddWithValue("@p1", txtProductName.Text);
                command.Parameters.AddWithValue("@p2", txtQuantity.Text);
                command.Parameters.AddWithValue("@p3", decimal.Parse(txtPrice.Text));
                command.Parameters.AddWithValue("@p4", decimal.Parse(txtAmount.Text));
                command.Parameters.AddWithValue("@p5", txtBillId.Text);
                command.ExecuteNonQuery();
                connection.connection().Close();


                //Hareket Tablosuna Veri Girisi
                SqlCommand command2 = new SqlCommand("insert into TBL_MUSTERIHAREKETLER (URUNID, ADET, PERSONEL, MUSTERI, " +
                    "FIYAT, TOPLAM, FATURAID, TARIH) values (@h1, @h2, @h3, @h4, @h5, @h6, @h7, @h8)", connection.connection());
                command2.Parameters.AddWithValue("@h1", txtProductId.Text);
                command2.Parameters.AddWithValue("@h2", txtQuantity.Text);
                command2.Parameters.AddWithValue("@h3", txtEmployee.Text);
                command2.Parameters.AddWithValue("@h4", txtCompany.Text);
                command2.Parameters.AddWithValue("@h5", decimal.Parse(txtPrice.Text));
                command2.Parameters.AddWithValue("@h6", decimal.Parse(txtAmount.Text));
                command2.Parameters.AddWithValue("@h7", txtBillId.Text);
                command2.Parameters.AddWithValue("@h8", mskDate.Text);
                command2.ExecuteNonQuery();
                connection.connection().Close();


                //Stok sayisi azaltma
                SqlCommand command3 = new SqlCommand("update TBL_URUNLER set ADET = adet - @s1 where ID = @s2", connection.connection());
                command3.Parameters.AddWithValue("@s1", txtQuantity.Text);
                command3.Parameters.AddWithValue("@s2", txtProductId.Text);
                command3.ExecuteNonQuery();
                connection.connection().Close();

                MessageBox.Show("Faturaya Ait Ürün Eklendi", "Fatura Detay", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetAll();
            }

        }
    }
}
