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
    public partial class FrmBillDetail : Form
    {
        public FrmBillDetail()
        {
            InitializeComponent();
        }

        DbConnection connection = new DbConnection();


        public string id;
        public void GetAll()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_FATURADETAY where FATURAID = '" + id + "'", connection.connection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }


        private void FrmBillDetail_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmBillDetailEditing frmBillDetailEditing = new FrmBillDetailEditing();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                frmBillDetailEditing.urunId = dr["FATURAURUNID"].ToString();
            }
            frmBillDetailEditing.Show();
            this.ControlBox = false;
            
        }
    }
}
