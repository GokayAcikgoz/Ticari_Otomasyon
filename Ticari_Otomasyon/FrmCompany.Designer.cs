namespace Ticari_Otomasyon
{
    partial class FrmCompany
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompany));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.txtTaxOffice = new DevExpress.XtraEditors.TextEdit();
            this.cmbDistrict = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbCity = new DevExpress.XtraEditors.ComboBoxEdit();
            this.mskIdentityNo = new System.Windows.Forms.MaskedTextBox();
            this.mskPhoneOne = new System.Windows.Forms.MaskedTextBox();
            this.lblTaxOffice = new DevExpress.XtraEditors.LabelControl();
            this.lblAddress = new DevExpress.XtraEditors.LabelControl();
            this.btnCleaner = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.rchAddress = new System.Windows.Forms.RichTextBox();
            this.lblDistrict = new DevExpress.XtraEditors.LabelControl();
            this.lblCity = new DevExpress.XtraEditors.LabelControl();
            this.txtMail = new DevExpress.XtraEditors.TextEdit();
            this.lblMail = new DevExpress.XtraEditors.LabelControl();
            this.lblIdentityNo = new DevExpress.XtraEditors.LabelControl();
            this.lblPhoneTwo = new DevExpress.XtraEditors.LabelControl();
            this.lblPhoneOne = new DevExpress.XtraEditors.LabelControl();
            this.txtSector = new DevExpress.XtraEditors.TextEdit();
            this.lblSector = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.mskPhoneTwo = new System.Windows.Forms.MaskedTextBox();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.lblId = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.mskFax = new System.Windows.Forms.MaskedTextBox();
            this.lblFax = new DevExpress.XtraEditors.LabelControl();
            this.mskPhoneThree = new System.Windows.Forms.MaskedTextBox();
            this.lblPhoneThree = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txtAuthorizedDuty = new DevExpress.XtraEditors.TextEdit();
            this.lblAuthorizedDuty = new DevExpress.XtraEditors.LabelControl();
            this.txtAuthorized = new DevExpress.XtraEditors.TextEdit();
            this.lblAuthorized = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxOffice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDistrict.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSector.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorizedDuty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorized.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Azure;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.LightCyan;
            this.gridView1.Appearance.Row.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(8, 9);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1166, 619);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // txtTaxOffice
            // 
            this.txtTaxOffice.Location = new System.Drawing.Point(86, 73);
            this.txtTaxOffice.Name = "txtTaxOffice";
            this.txtTaxOffice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.txtTaxOffice.Properties.Appearance.Options.UseFont = true;
            this.txtTaxOffice.Size = new System.Drawing.Size(200, 28);
            this.txtTaxOffice.TabIndex = 13;
            // 
            // cmbDistrict
            // 
            this.cmbDistrict.Location = new System.Drawing.Point(86, 39);
            this.cmbDistrict.Name = "cmbDistrict";
            this.cmbDistrict.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.cmbDistrict.Properties.Appearance.Options.UseFont = true;
            this.cmbDistrict.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDistrict.Size = new System.Drawing.Size(200, 28);
            this.cmbDistrict.TabIndex = 12;
            // 
            // cmbCity
            // 
            this.cmbCity.Location = new System.Drawing.Point(86, 5);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.cmbCity.Properties.Appearance.Options.UseFont = true;
            this.cmbCity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCity.Size = new System.Drawing.Size(200, 28);
            this.cmbCity.TabIndex = 11;
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // mskIdentityNo
            // 
            this.mskIdentityNo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.mskIdentityNo.Location = new System.Drawing.Point(91, 73);
            this.mskIdentityNo.Mask = "00000000000";
            this.mskIdentityNo.Name = "mskIdentityNo";
            this.mskIdentityNo.Size = new System.Drawing.Size(200, 32);
            this.mskIdentityNo.TabIndex = 5;
            this.mskIdentityNo.ValidatingType = typeof(int);
            // 
            // mskPhoneOne
            // 
            this.mskPhoneOne.Font = new System.Drawing.Font("Tahoma", 12F);
            this.mskPhoneOne.Location = new System.Drawing.Point(91, 5);
            this.mskPhoneOne.Mask = "(999) 000-0000";
            this.mskPhoneOne.Name = "mskPhoneOne";
            this.mskPhoneOne.Size = new System.Drawing.Size(200, 32);
            this.mskPhoneOne.TabIndex = 6;
            // 
            // lblTaxOffice
            // 
            this.lblTaxOffice.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblTaxOffice.Appearance.Options.UseFont = true;
            this.lblTaxOffice.Location = new System.Drawing.Point(9, 76);
            this.lblTaxOffice.Name = "lblTaxOffice";
            this.lblTaxOffice.Size = new System.Drawing.Size(70, 22);
            this.lblTaxOffice.TabIndex = 25;
            this.lblTaxOffice.Text = "Vergi D :";
            // 
            // lblAddress
            // 
            this.lblAddress.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblAddress.Appearance.Options.UseFont = true;
            this.lblAddress.Location = new System.Drawing.Point(23, 107);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 22);
            this.lblAddress.TabIndex = 24;
            this.lblAddress.Text = "Adres :";
            // 
            // btnCleaner
            // 
            this.btnCleaner.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.btnCleaner.Appearance.Options.UseFont = true;
            this.btnCleaner.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCleaner.ImageOptions.Image")));
            this.btnCleaner.Location = new System.Drawing.Point(168, 286);
            this.btnCleaner.Name = "btnCleaner";
            this.btnCleaner.Size = new System.Drawing.Size(143, 37);
            this.btnCleaner.TabIndex = 23;
            this.btnCleaner.Text = "Temizle";
            this.btnCleaner.Click += new System.EventHandler(this.btnCleaner_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(168, 232);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(143, 37);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(13, 286);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 37);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Sil";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(13, 232);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 37);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rchAddress
            // 
            this.rchAddress.Location = new System.Drawing.Point(86, 107);
            this.rchAddress.Name = "rchAddress";
            this.rchAddress.Size = new System.Drawing.Size(200, 105);
            this.rchAddress.TabIndex = 14;
            this.rchAddress.Text = "";
            // 
            // lblDistrict
            // 
            this.lblDistrict.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblDistrict.Appearance.Options.UseFont = true;
            this.lblDistrict.Location = new System.Drawing.Point(39, 42);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(40, 22);
            this.lblDistrict.TabIndex = 18;
            this.lblDistrict.Text = "İlçe :";
            // 
            // lblCity
            // 
            this.lblCity.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblCity.Appearance.Options.UseFont = true;
            this.lblCity.Location = new System.Drawing.Point(56, 8);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(23, 22);
            this.lblCity.TabIndex = 15;
            this.lblCity.Text = "İl :";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(91, 158);
            this.txtMail.Name = "txtMail";
            this.txtMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.txtMail.Properties.Appearance.Options.UseFont = true;
            this.txtMail.Size = new System.Drawing.Size(200, 28);
            this.txtMail.TabIndex = 10;
            // 
            // lblMail
            // 
            this.lblMail.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblMail.Appearance.Options.UseFont = true;
            this.lblMail.Location = new System.Drawing.Point(41, 161);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(43, 22);
            this.lblMail.TabIndex = 13;
            this.lblMail.Text = "Mail :";
            // 
            // lblIdentityNo
            // 
            this.lblIdentityNo.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblIdentityNo.Appearance.Options.UseFont = true;
            this.lblIdentityNo.Location = new System.Drawing.Point(49, 78);
            this.lblIdentityNo.Name = "lblIdentityNo";
            this.lblIdentityNo.Size = new System.Drawing.Size(34, 22);
            this.lblIdentityNo.TabIndex = 11;
            this.lblIdentityNo.Text = "TC :";
            // 
            // lblPhoneTwo
            // 
            this.lblPhoneTwo.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblPhoneTwo.Appearance.Options.UseFont = true;
            this.lblPhoneTwo.Location = new System.Drawing.Point(3, 49);
            this.lblPhoneTwo.Name = "lblPhoneTwo";
            this.lblPhoneTwo.Size = new System.Drawing.Size(81, 22);
            this.lblPhoneTwo.TabIndex = 9;
            this.lblPhoneTwo.Text = "Telefon2 :";
            // 
            // lblPhoneOne
            // 
            this.lblPhoneOne.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblPhoneOne.Appearance.Options.UseFont = true;
            this.lblPhoneOne.Location = new System.Drawing.Point(3, 10);
            this.lblPhoneOne.Name = "lblPhoneOne";
            this.lblPhoneOne.Size = new System.Drawing.Size(81, 22);
            this.lblPhoneOne.TabIndex = 7;
            this.lblPhoneOne.Text = "Telefon1 :";
            // 
            // txtSector
            // 
            this.txtSector.Location = new System.Drawing.Point(92, 70);
            this.txtSector.Name = "txtSector";
            this.txtSector.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.txtSector.Properties.Appearance.Options.UseFont = true;
            this.txtSector.Size = new System.Drawing.Size(200, 28);
            this.txtSector.TabIndex = 2;
            // 
            // lblSector
            // 
            this.lblSector.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblSector.Appearance.Options.UseFont = true;
            this.lblSector.Location = new System.Drawing.Point(22, 73);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(62, 22);
            this.lblSector.TabIndex = 5;
            this.lblSector.Text = "Sektör :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(92, 36);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Size = new System.Drawing.Size(200, 28);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblName.Appearance.Options.UseFont = true;
            this.lblName.Location = new System.Drawing.Point(51, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 22);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Ad :";
            // 
            // mskPhoneTwo
            // 
            this.mskPhoneTwo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.mskPhoneTwo.Location = new System.Drawing.Point(91, 44);
            this.mskPhoneTwo.Mask = "(999) 000-0000";
            this.mskPhoneTwo.Name = "mskPhoneTwo";
            this.mskPhoneTwo.Size = new System.Drawing.Size(200, 32);
            this.mskPhoneTwo.TabIndex = 7;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(92, 2);
            this.txtId.Name = "txtId";
            this.txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.txtId.Properties.Appearance.Options.UseFont = true;
            this.txtId.Properties.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(200, 28);
            this.txtId.TabIndex = 420;
            // 
            // lblId
            // 
            this.lblId.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblId.Appearance.Options.UseFont = true;
            this.lblId.Location = new System.Drawing.Point(51, 5);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(37, 22);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID : ";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.groupControl5);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(332, 589);
            this.xtraTabPage2.Text = "Adres Bilgileri";
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.btnCleaner);
            this.groupControl5.Controls.Add(this.lblAddress);
            this.groupControl5.Controls.Add(this.btnUpdate);
            this.groupControl5.Controls.Add(this.btnDelete);
            this.groupControl5.Controls.Add(this.txtTaxOffice);
            this.groupControl5.Controls.Add(this.btnSave);
            this.groupControl5.Controls.Add(this.lblTaxOffice);
            this.groupControl5.Controls.Add(this.cmbCity);
            this.groupControl5.Controls.Add(this.cmbDistrict);
            this.groupControl5.Controls.Add(this.lblCity);
            this.groupControl5.Controls.Add(this.rchAddress);
            this.groupControl5.Controls.Add(this.lblDistrict);
            this.groupControl5.Location = new System.Drawing.Point(4, 4);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.ShowCaption = false;
            this.groupControl5.Size = new System.Drawing.Size(325, 582);
            this.groupControl5.TabIndex = 4;
            this.groupControl5.Text = "groupControl5";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupControl4);
            this.xtraTabPage1.Controls.Add(this.groupControl3);
            this.xtraTabPage1.Controls.Add(this.groupControl2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(332, 589);
            this.xtraTabPage1.Text = "Firma Bilgileri";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.mskFax);
            this.groupControl4.Controls.Add(this.lblFax);
            this.groupControl4.Controls.Add(this.mskPhoneThree);
            this.groupControl4.Controls.Add(this.lblPhoneThree);
            this.groupControl4.Controls.Add(this.mskPhoneOne);
            this.groupControl4.Controls.Add(this.mskPhoneTwo);
            this.groupControl4.Controls.Add(this.lblPhoneOne);
            this.groupControl4.Controls.Add(this.lblPhoneTwo);
            this.groupControl4.Controls.Add(this.txtMail);
            this.groupControl4.Controls.Add(this.lblMail);
            this.groupControl4.Location = new System.Drawing.Point(4, 250);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.ShowCaption = false;
            this.groupControl4.Size = new System.Drawing.Size(325, 330);
            this.groupControl4.TabIndex = 3;
            this.groupControl4.Text = "groupControl4";
            // 
            // mskFax
            // 
            this.mskFax.Font = new System.Drawing.Font("Tahoma", 12F);
            this.mskFax.Location = new System.Drawing.Point(91, 120);
            this.mskFax.Mask = "(999) 000-0000";
            this.mskFax.Name = "mskFax";
            this.mskFax.Size = new System.Drawing.Size(200, 32);
            this.mskFax.TabIndex = 9;
            // 
            // lblFax
            // 
            this.lblFax.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblFax.Appearance.Options.UseFont = true;
            this.lblFax.Location = new System.Drawing.Point(44, 125);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(39, 22);
            this.lblFax.TabIndex = 30;
            this.lblFax.Text = "Fax :";
            // 
            // mskPhoneThree
            // 
            this.mskPhoneThree.Font = new System.Drawing.Font("Tahoma", 12F);
            this.mskPhoneThree.Location = new System.Drawing.Point(91, 82);
            this.mskPhoneThree.Mask = "(999) 000-0000";
            this.mskPhoneThree.Name = "mskPhoneThree";
            this.mskPhoneThree.Size = new System.Drawing.Size(200, 32);
            this.mskPhoneThree.TabIndex = 8;
            // 
            // lblPhoneThree
            // 
            this.lblPhoneThree.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblPhoneThree.Appearance.Options.UseFont = true;
            this.lblPhoneThree.Location = new System.Drawing.Point(3, 87);
            this.lblPhoneThree.Name = "lblPhoneThree";
            this.lblPhoneThree.Size = new System.Drawing.Size(81, 22);
            this.lblPhoneThree.TabIndex = 28;
            this.lblPhoneThree.Text = "Telefon3 :";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.txtAuthorizedDuty);
            this.groupControl3.Controls.Add(this.lblAuthorizedDuty);
            this.groupControl3.Controls.Add(this.txtAuthorized);
            this.groupControl3.Controls.Add(this.mskIdentityNo);
            this.groupControl3.Controls.Add(this.lblAuthorized);
            this.groupControl3.Controls.Add(this.lblIdentityNo);
            this.groupControl3.Location = new System.Drawing.Point(4, 122);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.ShowCaption = false;
            this.groupControl3.Size = new System.Drawing.Size(325, 122);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "groupControl3";
            // 
            // txtAuthorizedDuty
            // 
            this.txtAuthorizedDuty.Location = new System.Drawing.Point(91, 39);
            this.txtAuthorizedDuty.Name = "txtAuthorizedDuty";
            this.txtAuthorizedDuty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.txtAuthorizedDuty.Properties.Appearance.Options.UseFont = true;
            this.txtAuthorizedDuty.Size = new System.Drawing.Size(200, 28);
            this.txtAuthorizedDuty.TabIndex = 4;
            // 
            // lblAuthorizedDuty
            // 
            this.lblAuthorizedDuty.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblAuthorizedDuty.Appearance.Options.UseFont = true;
            this.lblAuthorizedDuty.Location = new System.Drawing.Point(4, 42);
            this.lblAuthorizedDuty.Name = "lblAuthorizedDuty";
            this.lblAuthorizedDuty.Size = new System.Drawing.Size(79, 22);
            this.lblAuthorizedDuty.TabIndex = 9;
            this.lblAuthorizedDuty.Text = "Y. Görev :";
            // 
            // txtAuthorized
            // 
            this.txtAuthorized.Location = new System.Drawing.Point(91, 5);
            this.txtAuthorized.Name = "txtAuthorized";
            this.txtAuthorized.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.txtAuthorized.Properties.Appearance.Options.UseFont = true;
            this.txtAuthorized.Size = new System.Drawing.Size(200, 28);
            this.txtAuthorized.TabIndex = 3;
            // 
            // lblAuthorized
            // 
            this.lblAuthorized.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblAuthorized.Appearance.Options.UseFont = true;
            this.lblAuthorized.Location = new System.Drawing.Point(25, 8);
            this.lblAuthorized.Name = "lblAuthorized";
            this.lblAuthorized.Size = new System.Drawing.Size(58, 22);
            this.lblAuthorized.TabIndex = 7;
            this.lblAuthorized.Text = "Yetkili :";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lblId);
            this.groupControl2.Controls.Add(this.txtId);
            this.groupControl2.Controls.Add(this.lblName);
            this.groupControl2.Controls.Add(this.txtName);
            this.groupControl2.Controls.Add(this.txtSector);
            this.groupControl2.Controls.Add(this.lblSector);
            this.groupControl2.Location = new System.Drawing.Point(3, 5);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(326, 111);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(1195, 9);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(334, 619);
            this.xtraTabControl1.TabIndex = 6;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // FrmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 636);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.gridControl1);
            this.Font = new System.Drawing.Font("Corbel", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firmalar";
            this.Load += new System.EventHandler(this.FrmCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxOffice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDistrict.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSector.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorizedDuty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorized.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.TextEdit txtTaxOffice;
        private DevExpress.XtraEditors.ComboBoxEdit cmbDistrict;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCity;
        private System.Windows.Forms.MaskedTextBox mskIdentityNo;
        private System.Windows.Forms.MaskedTextBox mskPhoneOne;
        private DevExpress.XtraEditors.LabelControl lblTaxOffice;
        private DevExpress.XtraEditors.LabelControl lblAddress;
        private DevExpress.XtraEditors.SimpleButton btnCleaner;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.RichTextBox rchAddress;
        private DevExpress.XtraEditors.LabelControl lblDistrict;
        private DevExpress.XtraEditors.LabelControl lblCity;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private DevExpress.XtraEditors.LabelControl lblMail;
        private DevExpress.XtraEditors.LabelControl lblIdentityNo;
        private DevExpress.XtraEditors.LabelControl lblPhoneTwo;
        private DevExpress.XtraEditors.LabelControl lblPhoneOne;
        private DevExpress.XtraEditors.TextEdit txtSector;
        private DevExpress.XtraEditors.LabelControl lblSector;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl lblName;
        private System.Windows.Forms.MaskedTextBox mskPhoneTwo;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl lblId;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.MaskedTextBox mskFax;
        private DevExpress.XtraEditors.LabelControl lblFax;
        private System.Windows.Forms.MaskedTextBox mskPhoneThree;
        private DevExpress.XtraEditors.LabelControl lblPhoneThree;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit txtAuthorizedDuty;
        private DevExpress.XtraEditors.LabelControl lblAuthorizedDuty;
        private DevExpress.XtraEditors.TextEdit txtAuthorized;
        private DevExpress.XtraEditors.LabelControl lblAuthorized;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraEditors.GroupControl groupControl5;
    }
}