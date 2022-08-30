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
    public partial class FrmNote : Form
    {
        public FrmNote()
        {
            InitializeComponent();
        }

        DbConnection connection = new DbConnection();

        void GetAll()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_NOTLAR", connection.connection());     
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void FrmNote_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into TBL_NOTLAR (TARIH, SAAT, BASLIK, DETAY, OLUSTURAN, HITAP)" +
                " values (@p1, @p2, @p3, @p4, @p5, @p6)", connection.connection());
            command.Parameters.AddWithValue("@p1", mskDate.Text);
            command.Parameters.AddWithValue("@p2", mskClock.Text);
            command.Parameters.AddWithValue("@p3", txtHeader.Text);
            command.Parameters.AddWithValue("@p4", rchDetail.Text);
            command.Parameters.AddWithValue("@p5", txtAuthor.Text);
            command.Parameters.AddWithValue("@p6", txtWho.Text);
            command.ExecuteNonQuery();

            connection.connection().Close();

            MessageBox.Show("Yeni Not Eklendi", "Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GetAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update TBL_NOTLAR set TARIH = @p1, SAAT = @p2, BASLIK = @p3, " +
                "DETAY = @p4, OLUSTURAN = @p5, HITAP = @p6 where ID = @p7", connection.connection());

            command.Parameters.AddWithValue("@p1", mskDate.Text);
            command.Parameters.AddWithValue("@p2", mskClock.Text);
            command.Parameters.AddWithValue("@p3", txtHeader.Text);
            command.Parameters.AddWithValue("@p4", rchDetail.Text);
            command.Parameters.AddWithValue("@p5", txtAuthor.Text);
            command.Parameters.AddWithValue("@p6", txtWho.Text);
            command.Parameters.AddWithValue("@p7", txtId.Text);
            command.ExecuteNonQuery();

            connection.connection().Close();

            MessageBox.Show("Not Güncellendi", "Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GetAll();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Not Silinecek. Emin Misiniz?", "Emin Misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand command = new SqlCommand("delete from TBL_NOTLAR where ID = @p1", connection.connection());
                command.Parameters.AddWithValue("@p1", txtId.Text);
                command.ExecuteNonQuery();
                connection.connection().Close();
                MessageBox.Show("Not Silindi", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAll();
            }

            
        }

        private void btnCleaner_Click(object sender, EventArgs e)
        {
            mskDate.Text = "";
            mskClock.Text = "";
            txtHeader.Text = "";
            rchDetail.Text = "";
            txtAuthor.Text = "";
            txtWho.Text = "";
            txtId.Text = "";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            mskDate.Text = dr["TARIH"].ToString();
            mskClock.Text = dr["SAAT"].ToString();
            txtHeader.Text = dr["BASLIK"].ToString();
            rchDetail.Text = dr["DETAY"].ToString();
            txtAuthor.Text = dr["OLUSTURAN"].ToString();
            txtWho.Text = dr["HITAP"].ToString();
            txtId.Text = dr["ID"].ToString();
        }
        
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            
            FrmNoteDetail frmNoteDetail = new FrmNoteDetail();

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                frmNoteDetail.message = dr["DETAY"].ToString();
            }
            frmNoteDetail.Show();
            
        }
    }
}
