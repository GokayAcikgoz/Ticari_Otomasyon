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
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        DbConnection connection = new DbConnection();

        void GetAll()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_PERSONELLER", connection.connection());
            DataTable dt = new DataTable(); 
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        void CityGetAll()
        {
            SqlCommand command = new SqlCommand("select SEHIR from TBL_ILLER", connection.connection());
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                cmbCity.Properties.Items.Add(dr[0]);
            }
            connection.connection().Close();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            GetAll();
            CityGetAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into TBL_PERSONELLER (AD, SOYAD, TELEFON, TC, MAIL, IL, ILCE," +
                "ADRES, GOREV) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)", connection.connection());

            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", txtSurname.Text);
            command.Parameters.AddWithValue("@p3", mskPhone.Text);
            command.Parameters.AddWithValue("@p4", mskIdentityNo.Text);
            command.Parameters.AddWithValue("@p5", txtMail.Text);
            command.Parameters.AddWithValue("@p6", cmbCity.Text);
            command.Parameters.AddWithValue("@p7", cmbDistrict.Text);
            command.Parameters.AddWithValue("@p8", rchAddress.Text);
            command.Parameters.AddWithValue("@p9", txtTask.Text);

            command.ExecuteNonQuery();

            connection.connection().Close();

            MessageBox.Show("Personel Eklendi", "Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GetAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update TBL_PERSONELLER set AD = @p1, SOYAD = @p2, TELEFON = @p3, " +
                "TC = @p4, MAIL = @p5, IL = @p6, ILCE = @p7, ADRES = @p8, GOREV = @p9 where ID = @p10", connection.connection());

            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", txtSurname.Text);
            command.Parameters.AddWithValue("@p3", mskPhone.Text);
            command.Parameters.AddWithValue("@p4", mskIdentityNo.Text);
            command.Parameters.AddWithValue("@p5", txtMail.Text);
            command.Parameters.AddWithValue("@p6", cmbCity.Text);
            command.Parameters.AddWithValue("@p7", cmbDistrict.Text);
            command.Parameters.AddWithValue("@p8", rchAddress.Text);
            command.Parameters.AddWithValue("@p9", txtTask.Text);
            command.Parameters.AddWithValue("@p10", txtId.Text);

            command.ExecuteNonQuery();

            connection.connection().Close();

            MessageBox.Show("Personel Güncellendi", "Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Personel Kaydı Silinecek. Emin Misiniz?", "Personel Silme" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand command = new SqlCommand("delete from TBL_PERSONELLER where ID = @p1", connection.connection());
                command.Parameters.AddWithValue("@p1", txtId.Text);

                command.ExecuteNonQuery();

                MessageBox.Show("Personel Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAll();
            }
        }

        private void btnCleaner_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            mskPhone.Text = "";
            mskIdentityNo.Text = "";
            txtMail.Text = "";
            cmbCity.Text = "";
            cmbDistrict.Text = "";
            rchAddress.Text = "";
            txtTask.Text = "";
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            txtId.Text = dr["ID"].ToString();
            txtName.Text = dr["AD"].ToString();
            txtSurname.Text = dr["SOYAD"].ToString();
            mskPhone.Text = dr["TELEFON"].ToString();
            mskIdentityNo.Text = dr["TC"].ToString();
            txtMail.Text = dr["MAIL"].ToString();
            cmbCity.Text = dr["IL"].ToString();
            cmbDistrict.Text = dr["ILCE"].ToString();
            rchAddress.Text = dr["ADRES"].ToString();
            txtTask.Text = dr["GOREV"].ToString();

        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDistrict.Text = "";
            cmbDistrict.Properties.Items.Clear();

            SqlCommand command = new SqlCommand("select ILCE from TBL_ILCELER where SEHIR = @p1", connection.connection());
            command.Parameters.AddWithValue("@p1", cmbCity.SelectedIndex + 1);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                cmbDistrict.Properties.Items.Add(dr[0]);
            }
        }
    }
}
