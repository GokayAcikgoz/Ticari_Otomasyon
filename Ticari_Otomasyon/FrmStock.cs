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
using DevExpress.XtraCharts;

namespace Ticari_Otomasyon
{
    public partial class FrmStock : Form
    {
        public FrmStock()
        {
            InitializeComponent();
        }

        DbConnection connection = new DbConnection();
        private void FrmStock_Load(object sender, EventArgs e)
        {
            chartControl1.Series["Series 1"].LegendTextPattern = "{A}";
            chartControl2.Series["Series 1"].LegendTextPattern = "{A}";


            SqlDataAdapter da = new SqlDataAdapter("select URUNAD, sum(ADET) as 'MIKTAR' from TBL_URUNLER group by URUNAD", connection.connection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

            SqlCommand command = new SqlCommand("select URUNAD, sum(ADET) as 'MIKTAR' from TBL_URUNLER group by URUNAD", connection.connection());

            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }

            connection.connection().Close();

            SqlCommand command2 = new SqlCommand("select Il, Count(*) from TBL_FIRMALAR group by IL", connection.connection());
            SqlDataReader dr2 = command2.ExecuteReader();

            while (dr2.Read())
            {
                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            connection.connection().Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmStockDetail frmStockDetail = new FrmStockDetail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                frmStockDetail.ad = dr["URUNAD"].ToString();
            }
            frmStockDetail.Show();
        }
    }
}
