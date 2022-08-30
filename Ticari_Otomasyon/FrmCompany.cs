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
    public partial class FrmCompany : Form
    {
        public FrmCompany()
        {
            InitializeComponent();
        }

        DbConnection connection = new DbConnection();

        void GetAll()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_FIRMALAR", connection.connection());
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

        

        private void FrmCompany_Load(object sender, EventArgs e)
        {
            GetAll();
            CityGetAll();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            txtId.Text = dr["ID"].ToString();
            txtName.Text = dr["AD"].ToString();
            txtAuthorizedDuty.Text = dr["YETKILISTATU"].ToString();
            txtAuthorized.Text = dr["YETKILIADSOYAD"].ToString();
            mskIdentityNo.Text = dr["YETKILITC"].ToString();
            txtSector.Text = dr["SEKTOR"].ToString();
            mskPhoneOne.Text = dr["TELEFON1"].ToString();
            mskPhoneTwo.Text = dr["TELEFON2"].ToString();
            mskPhoneThree.Text = dr["TELEFON3"].ToString();
            txtMail.Text = dr["MAIL"].ToString();
            mskFax.Text = dr["FAX"].ToString();
            cmbCity.Text = dr["IL"].ToString();
            cmbDistrict.Text = dr["ILCE"].ToString();
            txtTaxOffice.Text = dr["VERGIDAIRE"].ToString();
            rchAddress.Text = dr["ADRES"].ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into TBL_FIRMALAR (AD, YETKILISTATU, YETKILIADSOYAD, YETKILITC, SEKTOR," +
                "TELEFON1, TELEFON2, TELEFON3, MAIL, FAX, IL, ILCE, VERGIDAIRE, ADRES, OZELKOD1, OZELKOD2, OZELKOD3) values " +
                "(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13, @p14, @p15, @p16, @p17)", connection.connection());

            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", txtAuthorizedDuty.Text);
            command.Parameters.AddWithValue("@p3", txtAuthorized.Text);
            command.Parameters.AddWithValue("@p4", mskIdentityNo.Text);
            command.Parameters.AddWithValue("@p5", txtSector.Text);
            command.Parameters.AddWithValue("@p6", mskPhoneOne.Text);
            command.Parameters.AddWithValue("@p7", mskPhoneTwo.Text);
            command.Parameters.AddWithValue("@p8", mskPhoneThree.Text);
            command.Parameters.AddWithValue("@p9", txtMail.Text);
            command.Parameters.AddWithValue("@p10", mskFax.Text);
            command.Parameters.AddWithValue("@p11", cmbCity.Text);
            command.Parameters.AddWithValue("@p12", cmbDistrict.Text);
            command.Parameters.AddWithValue("@p13", txtTaxOffice.Text);
            command.Parameters.AddWithValue("@p14", rchAddress.Text);


            command.ExecuteNonQuery();

            connection.connection().Close();

            MessageBox.Show("Firma Eklendi", "Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GetAll();
        }

        private void btnCleaner_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtAuthorizedDuty.Text = "";
            txtAuthorized.Text = "";
            mskIdentityNo.Text = "";
            txtSector.Text = "";
            mskPhoneOne.Text = "";
            mskPhoneTwo.Text = "";
            mskPhoneThree.Text = "";
            txtMail.Text = "";
            mskFax.Text = "";
            cmbCity.Text = "";
            cmbDistrict.Text = "";
            txtTaxOffice.Text = "";
            rchAddress.Text = "";

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
   

            DialogResult dialogResult = new DialogResult();

            dialogResult = MessageBox.Show("Firma Kaydınız Silinecek. Emin Misiniz?", "Firma Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand command = new SqlCommand("delete from TBL_FIRMALAR where ID = @p1", connection.connection());
                command.Parameters.AddWithValue("@p1", txtId.Text);
                command.ExecuteNonQuery();
                connection.connection().Close();
                MessageBox.Show("Firma Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAll();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update TBL_FIRMALAR set AD = @p1, YETKILISTATU = @p2, YETKILIADSOYAD =@p3, " +
                "YETKILITC = @p4, SEKTOR = @p5, TELEFON1 = @p6, TELEFON2 = @p7, TELEFON3 = @p8, MAIL = @p9, FAX = @p10, IL = @p11, ILCE = @p12, VERGIDAIRE = @p13, ADRES = @p14, " +
                " where ID = @p18", connection.connection());

            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", txtAuthorizedDuty.Text);
            command.Parameters.AddWithValue("@p3", txtAuthorized.Text);
            command.Parameters.AddWithValue("@p4", mskIdentityNo.Text);
            command.Parameters.AddWithValue("@p5", txtSector.Text);
            command.Parameters.AddWithValue("@p6", mskPhoneOne.Text);
            command.Parameters.AddWithValue("@p7", mskPhoneTwo.Text);
            command.Parameters.AddWithValue("@p8", mskPhoneThree.Text);
            command.Parameters.AddWithValue("@p9", txtMail.Text);
            command.Parameters.AddWithValue("@p10", mskFax.Text);
            command.Parameters.AddWithValue("@p11", cmbCity.Text);
            command.Parameters.AddWithValue("@p12", cmbDistrict.Text);
            command.Parameters.AddWithValue("@p13", txtTaxOffice.Text);
            command.Parameters.AddWithValue("@p14", rchAddress.Text);
            command.Parameters.AddWithValue("@p18", txtId.Text);

            command.ExecuteNonQuery();

            connection.connection().Close();

            MessageBox.Show("Firma Güncellendi", "Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GetAll();

        }
    }
}
