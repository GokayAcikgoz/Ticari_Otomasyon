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
    public partial class FrmAction : Form
    {
        public FrmAction()
        {
            InitializeComponent();
        }

        DbConnection connection = new DbConnection();

        void GetAllEmployee()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("MusteriHareketler", connection.connection());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void GetAllCompany()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("FirmaHareketler", connection.connection());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }

        private void FrmAction_Load(object sender, EventArgs e)
        {
            GetAllEmployee();
            GetAllCompany();
        }
    }
}
