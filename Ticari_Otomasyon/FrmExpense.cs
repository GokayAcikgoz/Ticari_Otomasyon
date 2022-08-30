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
    public partial class FrmExpense : Form
    {
        public FrmExpense()
        {
            InitializeComponent();
        }

        DbConnection connection = new DbConnection();

        void GetAll()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_GIDERLER", connection.connection());           
            da.Fill(dt);
            gridControl1.DataSource = dt;


        }

        private void FrmExpense_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into TBL_GIDERLER (AY, YIL, ELEKTRIK, SU, DOGALGAZ, " +
                "INTERNET, MAASLAR, EKSTRA, NOTLAR) values(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)", connection.connection());

            command.Parameters.AddWithValue("@p1", cmbMonth.Text);
            command.Parameters.AddWithValue("@p2", cmbYear.Text);
            command.Parameters.AddWithValue("@p3", decimal.Parse(txtElectric.Text));
            command.Parameters.AddWithValue("@p4", decimal.Parse(txtWater.Text));
            command.Parameters.AddWithValue("@p5", decimal.Parse(txtGas.Text));
            command.Parameters.AddWithValue("@p6", decimal.Parse(txtInternet.Text));
            command.Parameters.AddWithValue("@p7", decimal.Parse(txtSalary.Text));
            command.Parameters.AddWithValue("@p8", decimal.Parse(txtExtra.Text));
            command.Parameters.AddWithValue("@p9", rchNote.Text);

            command.ExecuteNonQuery();

            connection.connection().Close();

            MessageBox.Show("Gider Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GetAll();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            txtId.Text = dr["ID"].ToString();
            cmbMonth.Text = dr["AY"].ToString();
            cmbYear.Text = dr["YIL"].ToString();
            txtElectric.Text = dr["ELEKTRIK"].ToString();
            txtWater.Text = dr["SU"].ToString();
            txtGas.Text = dr["DOGALGAZ"].ToString();
            txtInternet.Text = dr["INTERNET"].ToString();
            txtSalary.Text = dr["MAASLAR"].ToString();
            txtExtra.Text = dr["EKSTRA"].ToString();
            rchNote.Text = dr["NOTLAR"].ToString();
        }

        private void btnCleaner_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            cmbMonth.Text = "";
            cmbYear.Text = "";
            txtElectric.Text = "";
            txtWater.Text = "";
            txtGas.Text = "";
            txtInternet.Text = "";
            txtSalary.Text = "";
            txtExtra.Text = "";
            rchNote.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Gider Kaydı Silinecek. Emin Misiniz?", "Gider Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand command = new SqlCommand("delete from TBL_GIDERLER where ID = @p1", connection.connection());
                command.Parameters.AddWithValue("@p1", txtId.Text);
                command.ExecuteNonQuery();
                connection.connection().Close();

                MessageBox.Show("Gider silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetAll();
            }

            

            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update TBL_GIDERLER set AY = @p1, YIL = @p2, ELEKTRIK = @p3, " +
                "SU = @p4, DOGALGAZ = @p5, INTERNET = @p6, MAASLAR = @p7, EKSTRA = @p8, NOTLAR = @p9 where ID = @p10", connection.connection());

            command.Parameters.AddWithValue("@p1", cmbMonth.Text);
            command.Parameters.AddWithValue("@p2", cmbYear.Text);
            command.Parameters.AddWithValue("@p3", decimal.Parse(txtElectric.Text));
            command.Parameters.AddWithValue("@p4", decimal.Parse(txtWater.Text));
            command.Parameters.AddWithValue("@p5", decimal.Parse(txtGas.Text));
            command.Parameters.AddWithValue("@p6", decimal.Parse(txtInternet.Text));
            command.Parameters.AddWithValue("@p7", decimal.Parse(txtSalary.Text));
            command.Parameters.AddWithValue("@p8", decimal.Parse(txtExtra.Text));
            command.Parameters.AddWithValue("@p9", rchNote.Text);
            command.Parameters.AddWithValue("@p10", txtId.Text);

            command.ExecuteNonQuery();

            connection.connection().Close();

            MessageBox.Show("Gider Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GetAll();
        }
    }
}
