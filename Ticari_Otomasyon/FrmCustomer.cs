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
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        DbConnection connection = new DbConnection();

        void GetAll()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_MUSTERILER", connection.connection());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        void CityGetAll()
        {
            SqlCommand command = new SqlCommand("select SEHIR from TBL_ILLER" , connection.connection());
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                cmbCity.Properties.Items.Add(dr[0]);
            }
            connection.connection().Close();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            GetAll();
            CityGetAll();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtId.Text = dr["ID"].ToString();
            txtName.Text = dr["AD"].ToString();
            txtSurname.Text = dr["SOYAD"].ToString();
            mskPhoneOne.Text = dr["TELEFON"].ToString();
            mskPhoneTwo.Text = dr["TELEFON2"].ToString();
            mskIdentityNo.Text = dr["TC"].ToString();
            txtMail.Text = dr["MAIL"].ToString();
            cmbCity.Text = dr["IL"].ToString();
            cmbDistrict.Text = dr["ILCE"].ToString();
            rchAddress.Text = dr["ADRES"].ToString();
            txtTaxOffice.Text = dr["VERGIDAIRE"].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into TBL_MUSTERILER(AD, SOYAD, TELEFON, TELEFON2, TC, MAIL," +
                "IL, ILCE, ADRES, VERGIDAIRE) values(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10)", connection.connection());

            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", txtSurname.Text);
            command.Parameters.AddWithValue("@p3", mskPhoneOne.Text);
            command.Parameters.AddWithValue("@p4", mskPhoneTwo.Text);
            command.Parameters.AddWithValue("@p5", mskIdentityNo.Text);
            command.Parameters.AddWithValue("@p6", txtMail.Text);
            command.Parameters.AddWithValue("@p7", cmbCity.Text);
            command.Parameters.AddWithValue("@p8", cmbDistrict.Text);
            command.Parameters.AddWithValue("@p9", rchAddress.Text);
            command.Parameters.AddWithValue("@p10", txtTaxOffice.Text);

            command.ExecuteNonQuery();

            connection.connection().Close();

            MessageBox.Show("Müşteri Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GetAll();
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDistrict.Text = "";
            cmbDistrict.Properties.Items.Clear();

            SqlCommand command = new SqlCommand("select ILCE from TBL_ILCELER where SEHIR = @p1", connection.connection());
            command.Parameters.AddWithValue("@p1", cmbCity.SelectedIndex+1);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                cmbDistrict.Properties.Items.Add(dr[0]);
            }
        }

        private void btnCleaner_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            mskPhoneOne.Text = "";
            mskPhoneTwo.Text = "";
            mskIdentityNo.Text = "";
            txtMail.Text = "";
            cmbCity.Text = "";
            cmbDistrict.Text = "";
            rchAddress.Text = "";
            txtTaxOffice.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update TBL_MUSTERILER set AD = @p1, SOYAD = @p2, TELEFON = @p3," +
                "TELEFON2 = @p4, TC = @p5, MAIL = @p6, IL = @p7, ILCE = @p8, ADRES = @p9, VERGIDAIRE = @p10 where ID = @p11", connection.connection());

            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", txtSurname.Text);
            command.Parameters.AddWithValue("@p3", mskPhoneOne.Text);
            command.Parameters.AddWithValue("@p4", mskPhoneTwo.Text);
            command.Parameters.AddWithValue("@p5", mskIdentityNo.Text);
            command.Parameters.AddWithValue("@p6", txtMail.Text);
            command.Parameters.AddWithValue("@p7", cmbCity.Text);
            command.Parameters.AddWithValue("@p8", cmbDistrict.Text);
            command.Parameters.AddWithValue("@p9", rchAddress.Text);
            command.Parameters.AddWithValue("@p10", txtTaxOffice.Text);
            command.Parameters.AddWithValue("@p11", txtId.Text);

            command.ExecuteNonQuery();

            connection.connection().Close();

            MessageBox.Show("Müşteri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GetAll();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Müşteri Kaydınız Sileceksiniz. Emin Misiniz?", "Müşteri Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                SqlCommand command = new SqlCommand("delete from TBL_MUSTERILER where ID = @p1", connection.connection());
                command.Parameters.AddWithValue("@p1", txtId.Text);

                command.ExecuteNonQuery();

                MessageBox.Show("Müşteri Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                GetAll();
            }


            
        }
    }
}
