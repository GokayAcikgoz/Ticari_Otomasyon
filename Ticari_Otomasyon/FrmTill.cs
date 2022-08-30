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
using DevExpress.Charts;

namespace Ticari_Otomasyon
{
    public partial class FrmTill : Form
    {
        public FrmTill()
        {
            InitializeComponent();
        }

        DbConnection connection = new DbConnection();

        void CustomerGetAll()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("MusteriHareketler", connection.connection());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void CompanyGetAll()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("FirmaHareketler", connection.connection());
            da.Fill(dt);
            gridControl3.DataSource = dt;
        }

        public string ad;

        private void FrmTill_Load(object sender, EventArgs e)
        {
            lblUser.Text = ad;

            CustomerGetAll();
            CompanyGetAll();

            //Total Amount
            SqlCommand command1 = new SqlCommand("select sum(TUTAR) from TBL_FATURADETAY", connection.connection());
            SqlDataReader dr1 = command1.ExecuteReader();
            while (dr1.Read())
            {
                lblTillSum.Text = dr1[0].ToString() + " TL";
            }
            connection.connection().Close();

            //son ayin faturalari
            SqlCommand command2 = new SqlCommand("select top 1 (ELEKTRIK + SU + DOGALGAZ + INTERNET + EKSTRA) from TBL_GIDERLER order by ID desc", connection.connection());
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                lblPayment.Text = dr2[0].ToString() + " TL";
            }
            connection.connection().Close();


            //son ayin personel maaslari
            SqlCommand command3 = new SqlCommand("select top 1 MAASLAR from TBL_GIDERLER order by ID desc", connection.connection());
            SqlDataReader dr3 = command3.ExecuteReader();
            while (dr3.Read())
            {
                lblSalary.Text = dr3[0].ToString() + " TL";
            }
            connection.connection().Close();


            //Toplam Musteri sayisi
            SqlCommand command4 = new SqlCommand("select Count(*) from TBL_MUSTERILER", connection.connection());
            SqlDataReader dr4 = command4.ExecuteReader();
            while (dr4.Read())
            {
                lblCustomer.Text = dr4[0].ToString();
            }
            connection.connection().Close();


            //Toplam Firma sayisi
            SqlCommand command5 = new SqlCommand("select Count(*) from TBL_FIRMALAR", connection.connection());
            SqlDataReader dr5 = command5.ExecuteReader();
            while (dr5.Read())
            {
                lblCompany.Text = dr5[0].ToString();
            }
            connection.connection().Close();


            //Firma sehir sayisi
            SqlCommand command6 = new SqlCommand("select count(distinct(IL)) from TBL_FIRMALAR", connection.connection());
            SqlDataReader dr6 = command6.ExecuteReader();
            while (dr6.Read())
            {
                lblCompanyCity.Text = dr6[0].ToString();
            }
            connection.connection().Close();


            //Musteri sehir sayisi
            SqlCommand command7 = new SqlCommand("select count(distinct(IL)) from TBL_MUSTERILER", connection.connection());
            SqlDataReader dr7 = command7.ExecuteReader();
            while (dr7.Read())
            {
                lblCustomerCity.Text = dr7[0].ToString();
            }
            connection.connection().Close();


            //Personel sayisi
            SqlCommand command8 = new SqlCommand("select count(*) from TBL_PERSONELLER", connection.connection());
            SqlDataReader dr8 = command8.ExecuteReader();
            while (dr8.Read())
            {
                lblEmployee.Text = dr8[0].ToString();
            }
            connection.connection().Close();


            //Stok sayisi
            SqlCommand command9 = new SqlCommand("select sum(ADET) from TBL_URUNLER", connection.connection());
            SqlDataReader dr9 = command9.ExecuteReader();
            while (dr9.Read())
            {
                lblStockAmount.Text = dr9[0].ToString();
            }
            connection.connection().Close();



            
        }

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac > 0 && sayac <=5)
            {
                groupControl10.Text = "Elektrik";
                chartControl1.Series["Aylar"].Points.Clear();
                //1.chart controle son 4 ay elektrik faturası
                SqlCommand command10 = new SqlCommand("select top 4 AY,ELEKTRIK from TBL_GIDERLER order by ID desc", connection.connection());
                SqlDataReader dr10 = command10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));

                }
                connection.connection().Close();


                
            }

            if (sayac > 5 && sayac <= 10)
            {
                groupControl10.Text = "Su";
                chartControl1.Series["Aylar"].Points.Clear();
                //2.chart controle son 4 ay su faturası
                SqlCommand command11 = new SqlCommand("select top 4 AY,SU from TBL_GIDERLER order by ID desc", connection.connection());
                SqlDataReader dr11 = command11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));

                }
                connection.connection().Close();
            }


            if (sayac > 10 && sayac <= 15)
            {
                groupControl10.Text = "Doğalgaz";
                chartControl1.Series["Aylar"].Points.Clear();
                //2.chart controle son 4 ay su faturası
                SqlCommand command11 = new SqlCommand("select top 4 AY,DOGALGAZ from TBL_GIDERLER order by ID desc", connection.connection());
                SqlDataReader dr11 = command11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));

                }
                connection.connection().Close();
            }

            if (sayac > 10 && sayac <= 20)
            {
                groupControl10.Text = "İnternet";
                chartControl1.Series["Aylar"].Points.Clear();
                //2.chart controle son 4 ay su faturası
                SqlCommand command11 = new SqlCommand("select top 4 AY,INTERNET from TBL_GIDERLER order by ID desc", connection.connection());
                SqlDataReader dr11 = command11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));

                }
                connection.connection().Close();
            }

            if (sayac > 20 && sayac <= 25)
            {
                groupControl10.Text = "Ekstra";
                chartControl1.Series["Aylar"].Points.Clear();
                //2.chart controle son 4 ay su faturası
                SqlCommand command11 = new SqlCommand("select top 4 AY,EKSTRA from TBL_GIDERLER order by ID desc", connection.connection());
                SqlDataReader dr11 = command11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));

                }
                connection.connection().Close();
            }

            if (sayac == 26)
            {
                sayac = 0;
            }
        }

        int sayac2 = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac2++;
            if (sayac2 > 0 && sayac2 <= 5)
            {
                groupControl11.Text = "Elektrik";
                chartControl2.Series["Aylar"].Points.Clear();
                //1.chart controle son 4 ay elektrik faturası
                SqlCommand command10 = new SqlCommand("select top 4 AY,ELEKTRIK from TBL_GIDERLER order by ID desc", connection.connection());
                SqlDataReader dr10 = command10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));

                }
                connection.connection().Close();



            }

            if (sayac2 > 5 && sayac2 <= 10)
            {
                groupControl11.Text = "Su";
                chartControl2.Series["Aylar"].Points.Clear();
                //2.chart controle son 4 ay su faturası
                SqlCommand command11 = new SqlCommand("select top 4 AY,SU from TBL_GIDERLER order by ID desc", connection.connection());
                SqlDataReader dr11 = command11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));

                }
                connection.connection().Close();
            }


            if (sayac2 > 10 && sayac2 <= 15)
            {
                groupControl11.Text = "Doğalgaz";
                chartControl2.Series["Aylar"].Points.Clear();
                //2.chart controle son 4 ay su faturası
                SqlCommand command11 = new SqlCommand("select top 4 AY,DOGALGAZ from TBL_GIDERLER order by ID desc", connection.connection());
                SqlDataReader dr11 = command11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));

                }
                connection.connection().Close();
            }

            if (sayac2 > 10 && sayac2 <= 20)
            {
                groupControl11.Text = "İnternet";
                chartControl2.Series["Aylar"].Points.Clear();
                //2.chart controle son 4 ay su faturası
                SqlCommand command11 = new SqlCommand("select top 4 AY,INTERNET from TBL_GIDERLER order by ID desc", connection.connection());
                SqlDataReader dr11 = command11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));

                }
                connection.connection().Close();
            }

            if (sayac2 > 20 && sayac2 <= 25)
            {
                groupControl11.Text = "Ekstra";
                chartControl2.Series["Aylar"].Points.Clear();
                //2.chart controle son 4 ay su faturası
                SqlCommand command11 = new SqlCommand("select top 4 AY,EKSTRA from TBL_GIDERLER order by ID desc", connection.connection());
                SqlDataReader dr11 = command11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));

                }
                connection.connection().Close();
            }

            if (sayac2 == 26)
            {
                sayac2 = 0;
            }
        }
    }
}
