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
    public partial class FrmHomeDetail : Form
    {
        public FrmHomeDetail()
        {
            InitializeComponent();
        }

        DbConnection connection = new DbConnection();

        void StockGetAll()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select URUNAD, sum(ADET) as 'ADET' from TBL_URUNLER " +
                "group by URUNAD having sum(ADET) <= 20", connection.connection());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        } 

        void AjandaGetAll()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select top 5 TARIH, SAAT, BASLIK from TBL_NOTLAR order by ID desc", connection.connection());
            da.Fill(dt);
            gridControl3.DataSource = dt;
        }

        void GetAllCompany()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("FirmaHareket2", connection.connection());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }

        void FihristGetAll()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select AD, TELEFON1 from TBL_FIRMALAR order by AD asc", connection.connection());
            da.Fill(dt);
            gridControl4.DataSource = dt;
        }

        private void FrmHomeDetail_Load(object sender, EventArgs e)
        {
            StockGetAll();
            AjandaGetAll();
            GetAllCompany();
            FihristGetAll();

            webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/today.xml");
        }
    }
}
