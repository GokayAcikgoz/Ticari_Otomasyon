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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        DbConnection connection = new DbConnection();

        void GetAll()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_ADMIN", connection.connection());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void FrmSettings_Load(object sender, EventArgs e)
        {
            GetAll();
            txtUserName.Text = "";
            txtPass.Text = "";
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (btnProcess.Text == "KAYDET")
            {
                SqlCommand command = new SqlCommand("insert into TBL_ADMIN(KULLANICIADI, SIFRE) values(@p1, @p2)", connection.connection());
                command.Parameters.AddWithValue("@p1", txtUserName.Text);
                command.Parameters.AddWithValue("@p2", txtPass.Text);

                command.ExecuteNonQuery();
                connection.connection().Close();

                MessageBox.Show("Yeni Kullanıcı Kayıt Edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAll();
            }

            if (btnProcess.Text == "GÜNCELLE")
            {
                SqlCommand command = new SqlCommand("update TBL_ADMIN set SIFRE = @p1, KULLANICIADI = @p2 where ID = @p3", connection.connection());
                command.Parameters.AddWithValue("@p2", txtUserName.Text);
                command.Parameters.AddWithValue("@p1", txtPass.Text);
                command.Parameters.AddWithValue("@p3", textBox1.Text);
                command.ExecuteNonQuery();
                connection.connection().Close();

                MessageBox.Show("Kayıt Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAll();
            }
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                txtUserName.Text = dr["KULLANICIADI"].ToString();
                txtPass.Text = dr["SIFRE"].ToString();
                textBox1.Text = dr["ID"].ToString();

                btnProcess.Text = "GÜNCELLE";

                
            }

            
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                btnProcess.Text = "KAYDET";
            }
        }
    }
}
