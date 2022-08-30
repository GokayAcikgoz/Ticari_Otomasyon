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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        DbConnection connection = new DbConnection();

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("select * from TBL_ADMIN where KULLANICIADI = @p1 and SIFRE = @p2", connection.connection());
                command.Parameters.AddWithValue("@p1", txtUser.Text);
                command.Parameters.AddWithValue("@p2", txtPass.Text);

                SqlDataReader dr = command.ExecuteReader();

                if (dr.Read())
                {
                    FrmHome frmHome = new FrmHome();
                    frmHome.kullanici = txtUser.Text;
                    frmHome.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Yanlış kullanıcı adı veya şifre.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.connection().Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik bir sorun oluştu. Yeniden deneyiniz veya yetkili ile iletişime geçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
