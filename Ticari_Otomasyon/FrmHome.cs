using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        FrmProduct frmProduct;

        private void btnProducts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmProduct == null || frmProduct.IsDisposed)
            {
                frmProduct = new FrmProduct();
                frmProduct.MdiParent = this;
                frmProduct.Show();
            }
                       
        }

        

        FrmCustomer frmCustomer;
        private void btnCustomers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (frmCustomer == null || frmCustomer.IsDisposed)
            {
                frmCustomer = new FrmCustomer();
                frmCustomer.MdiParent = this;
                frmCustomer.Show();
            }
            
        }

        FrmCompany frmCompany;
        private void btnCompanies_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmCompany == null || frmCompany.IsDisposed)
            {
                frmCompany = new FrmCompany();
                frmCompany.MdiParent = this;
                frmCompany.Show();

            }
        }

        FrmEmployee frmEmployee;
        private void btnEmployees_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmEmployee == null || frmEmployee.IsDisposed)
            {
                frmEmployee = new FrmEmployee();
                frmEmployee.MdiParent = this;
                frmEmployee.Show();
            }
        }

        FrmDirectory frmDirectory;
        private void btnDirectory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmDirectory == null || frmDirectory.IsDisposed)
            {
                frmDirectory = new FrmDirectory();
                frmDirectory.MdiParent = this;
                frmDirectory.Show();
            }
        }

        FrmExpense frmExpense;
        private void btnExpenses_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmExpense == null || frmExpense.IsDisposed)
            {
                frmExpense = new FrmExpense();
                frmExpense.MdiParent = this;
                frmExpense.Show();
            }
        }

        FrmBank frmBank;
        private void btnBanks_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmBank == null || frmBank.IsDisposed)
            {
                frmBank = new FrmBank();
                frmBank.MdiParent = this;
                frmBank.Show();
            }
        }

        FrmBill frmBill;
        private void btnInvoice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmBill == null || frmBill.IsDisposed)
            {
                frmBill = new FrmBill();
                frmBill.MdiParent = this;
                frmBill.Show();
            }
        }

        FrmNote frmNote;
        private void btnNotes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmNote == null || frmNote.IsDisposed)
            {
                frmNote = new FrmNote();
                frmNote.MdiParent = this;
                frmNote.Show();
            }
        }

        FrmAction frmAction;
        private void btnAction_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmAction == null || frmAction.IsDisposed)
            {
                frmAction = new FrmAction();
                frmAction.MdiParent = this;
                frmAction.Show();
            }
        }

        private void FrmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        FrmReport frmReport;
        
        private void btnReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmReport == null || frmReport.IsDisposed)
            {
                frmReport = new FrmReport();
                frmReport.MdiParent = this;
                frmReport.Show();
            }
        }

        
        FrmStock frmStock;
        private void btnStocks_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmStock == null || frmStock.IsDisposed)
            {
                frmStock = new FrmStock();
                frmStock.MdiParent = this;
                frmStock.Show();
            }
        }

        FrmSettings frmSettings;
        private void btnSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmSettings == null || frmSettings.IsDisposed)
            {
                frmSettings = new FrmSettings();
                frmSettings.Show();
            }
        }


        FrmTill frmTill;
        private void btnSafe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmTill == null || frmTill.IsDisposed)
            {
                frmTill = new FrmTill();
                frmTill.ad = kullanici;
                frmTill.MdiParent = this;
                frmTill.Show();
            }
        }

        public string kullanici;
        

        FrmHomeDetail frmHomeDetail;
        private void btnHome_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmHomeDetail == null || frmHomeDetail.IsDisposed)
            {
                frmHomeDetail = new FrmHomeDetail();
                frmHomeDetail.MdiParent = this;
                frmHomeDetail.Show();
            }
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            if (frmHomeDetail == null || frmHomeDetail.IsDisposed)
            {
                frmHomeDetail = new FrmHomeDetail();
                frmHomeDetail.MdiParent = this;
                frmHomeDetail.Show();
            }
        }
    }
}
