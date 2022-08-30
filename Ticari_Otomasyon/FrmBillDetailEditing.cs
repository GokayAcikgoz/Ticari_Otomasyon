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
    public partial class FrmBillDetailEditing : Form
    {
        public FrmBillDetailEditing()
        {
            InitializeComponent();
        }

        DbConnection connection = new DbConnection();

        public string urunId;
        
        private void FrmBillDetailEditing_Load(object sender, EventArgs e)
        {
            txtProductId.Text = urunId;
            SqlCommand command = new SqlCommand("select * from TBL_FATURADETAY where FATURAURUNID = @p1", connection.connection());
            command.Parameters.AddWithValue("@p1", urunId);
            SqlDataReader dr = command.ExecuteReader();
    

            while (dr.Read())
            {

                txtPrice.Text = dr[3].ToString();
                txtQuantity.Text = dr[2].ToString();
                txtAmount.Text = dr[4].ToString();
                txtProductName.Text = dr[1].ToString();

                connection.connection().Close();
            }

        }

        
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            double miktar, tutar, fiyat;

            fiyat = Convert.ToDouble(txtPrice.Text);
            miktar = Convert.ToDouble(txtQuantity.Text);
            tutar = miktar * fiyat;

            txtAmount.Text = tutar.ToString();

            SqlCommand command = new SqlCommand("update TBL_FATURADETAY set URUNAD = @p1, MIKTAR = @p2, FIYAT = @p3, " +
                "TUTAR = @p4 where FATURAURUNID = @p5", connection.connection());
            command.Parameters.AddWithValue("@p1", txtProductName.Text);
            command.Parameters.AddWithValue("@p2", txtQuantity.Text);
            command.Parameters.AddWithValue("@p3", decimal.Parse(txtPrice.Text));
            command.Parameters.AddWithValue("@p4", decimal.Parse(txtAmount.Text));
            command.Parameters.AddWithValue("@p5", txtProductId.Text);

            command.ExecuteNonQuery();

            connection.connection().Close();

            MessageBox.Show("Değişiklikler Kayıt Edildi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            

        }

        
        private void FrmBillDetailEditing_FormClosed(object sender, FormClosedEventArgs e)
        {          
                FrmBillDetail frmBillDetail = (FrmBillDetail)Application.OpenForms["FrmBillDetail"];
                frmBillDetail.GetAll();
                
                frmBillDetail.ControlBox = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();

            dialogResult = MessageBox.Show("Fatura Detayı Silinecek. Emin Misiniz?", "Fatura Detay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand command = new SqlCommand("delete from TBL_FATURADETAY where FATURAURUNID = @p1", connection.connection());
                command.Parameters.AddWithValue("@p1", txtProductId.Text);
                command.ExecuteNonQuery();
                connection.connection().Close();

                MessageBox.Show("Fatura Detayı Silindi", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            

           
        }
    }
}
