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
    public partial class FrmBank : Form
    {
        public FrmBank()
        {
            InitializeComponent();
        }

        DbConnection connection = new DbConnection();

        void GetAll()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("BankaBilgileri", connection.connection());
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


        void CompanyGetAll()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select ID,AD from TBL_FIRMALAR", connection.connection());
            da.Fill(dt);
            lookupCompany.Properties.NullText = "Lütfen Bir Firma Seçiniz.";
            lookupCompany.Properties.ValueMember = "ID";
            lookupCompany.Properties.DisplayMember = "AD";
            lookupCompany.Properties.DataSource = dt;
        }

        private void FrmBank_Load(object sender, EventArgs e)
        {
            GetAll();
            CityGetAll();
            CompanyGetAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into TBL_BANKALAR (BANKAADI, IL, ILCE, SUBE, IBAN, HESAPNO," +
                "YETKILI, TELEFON, TARIH, HESAPTURU, FIRMAID) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8," +
                "@p9, @p10, @p11)", connection.connection());
            command.Parameters.AddWithValue("@p1", txtBankName.Text);
            command.Parameters.AddWithValue("@p2", cmbCity.Text);
            command.Parameters.AddWithValue("@p3", cmbDistrict.Text);
            command.Parameters.AddWithValue("@p4", txtBranch.Text);
            command.Parameters.AddWithValue("@p5", mskIban.Text);
            command.Parameters.AddWithValue("@p6", mskAccountNo.Text);
            command.Parameters.AddWithValue("@p7", txtAuthorized.Text);
            command.Parameters.AddWithValue("@p8", mskPhone.Text);
            command.Parameters.AddWithValue("@p9", mskDate.Text);
            command.Parameters.AddWithValue("@p10", txtAccountType.Text);
            command.Parameters.AddWithValue("@p11", lookupCompany.EditValue);

            command.ExecuteNonQuery();

            connection.connection().Close();

            MessageBox.Show("Banka Eklendi", "Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GetAll();
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtId.Text = dr["ID"].ToString();
            txtBankName.Text = dr["BANKAADI"].ToString();
            cmbCity.Text = dr["IL"].ToString();
            cmbDistrict.Text = dr["ILCE"].ToString();
            txtBranch.Text = dr["SUBE"].ToString();
            mskIban.Text = dr["IBAN"].ToString();
            mskAccountNo.Text = dr["HESAPNO"].ToString();
            txtAuthorized.Text = dr["YETKILI"].ToString();
            mskPhone.Text = dr["TELEFON"].ToString();
            mskDate.Text = dr["TARIH"].ToString();
            txtAccountType.Text = dr["HESAPTURU"].ToString();
            lookupCompany.Text = dr["AD"].ToString();

        }

        private void btnCleaner_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtBankName.Text = "";
            cmbCity.Text = "";
            cmbDistrict.Text = "";
            txtBranch.Text = "";
            mskIban.Text = "";
            mskAccountNo.Text = "";
            txtAuthorized.Text = "";
            mskPhone.Text = "";
            mskDate.Text = "";
            txtAccountType.Text = "";
            lookupCompany.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show("Banka Silinecek. Emin Misiniz?", "Banka Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand("delete from TBL_BANKALAR where ID = @p1", connection.connection());
                    command.Parameters.AddWithValue("@p1", txtId.Text);
                    command.ExecuteNonQuery();
                    connection.connection().Close();

                    MessageBox.Show("Banka Kaydı Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetAll();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Banka Kaydı Silinemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("update TBL_BANKALAR set BANKAADI = @p1, IL = @p2, ILCE = @p3, " +
                "SUBE = @p4, IBAN = @p5, HESAPNO = @p6, YETKILI = @p7, TELEFON = @p8, " +
                "TARIH = @p9, HESAPTURU = @p10, FIRMAID = @p11 where ID = @p12", connection.connection());


                command.Parameters.AddWithValue("@p1", txtBankName.Text);
                command.Parameters.AddWithValue("@p2", cmbCity.Text);
                command.Parameters.AddWithValue("@p3", cmbDistrict.Text);
                command.Parameters.AddWithValue("@p4", txtBranch.Text);
                command.Parameters.AddWithValue("@p5", mskIban.Text);
                command.Parameters.AddWithValue("@p6", mskAccountNo.Text);
                command.Parameters.AddWithValue("@p7", txtAuthorized.Text);
                command.Parameters.AddWithValue("@p8", mskPhone.Text);
                command.Parameters.AddWithValue("@p9", mskDate.Text);
                command.Parameters.AddWithValue("@p10", txtAccountType.Text);
                command.Parameters.AddWithValue("@p11", lookupCompany.EditValue);
                command.Parameters.AddWithValue("@p12", txtId.Text);

                command.ExecuteNonQuery();

                connection.connection().Close();

                MessageBox.Show("Banka Güncellendi", "Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetAll();
            }
            catch (Exception)
            {

                MessageBox.Show("Banka Güncellenemedi", "Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
