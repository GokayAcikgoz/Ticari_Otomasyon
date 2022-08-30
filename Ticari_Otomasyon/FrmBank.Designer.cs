namespace Ticari_Otomasyon
{
    partial class FrmBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBank));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.txtAccountType = new DevExpress.XtraEditors.TextEdit();
            this.cmbDistrict = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbCity = new DevExpress.XtraEditors.ComboBoxEdit();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblAccountType = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookupCompany = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCompany = new DevExpress.XtraEditors.LabelControl();
            this.txtAuthorized = new DevExpress.XtraEditors.TextEdit();
            this.mskDate = new System.Windows.Forms.MaskedTextBox();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.lblAuthorized = new DevExpress.XtraEditors.LabelControl();
            this.lblAccountNo = new DevExpress.XtraEditors.LabelControl();
            this.mskAccountNo = new System.Windows.Forms.MaskedTextBox();
            this.btnCleaner = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lblDistrict = new DevExpress.XtraEditors.LabelControl();
            this.lblCity = new DevExpress.XtraEditors.LabelControl();
            this.txtBranch = new DevExpress.XtraEditors.TextEdit();
            this.lblBranch = new DevExpress.XtraEditors.LabelControl();
            this.lblIban = new DevExpress.XtraEditors.LabelControl();
            this.lblPhone = new DevExpress.XtraEditors.LabelControl();
            this.txtBankName = new DevExpress.XtraEditors.TextEdit();
            this.lblBankName = new DevExpress.XtraEditors.LabelControl();
            this.mskIban = new System.Windows.Forms.MaskedTextBox();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.lblId = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDistrict.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorized.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Azure;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.LightCyan;
            this.gridView1.Appearance.Row.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(10, 11);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1166, 619);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // txtAccountType
            // 
            this.txtAccountType.Location = new System.Drawing.Point(136, 402);
            this.txtAccountType.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccountType.Name = "txtAccountType";
            this.txtAccountType.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAccountType.Properties.Appearance.Options.UseFont = true;
            this.txtAccountType.Size = new System.Drawing.Size(188, 28);
            this.txtAccountType.TabIndex = 10;
            // 
            // cmbDistrict
            // 
            this.cmbDistrict.Location = new System.Drawing.Point(136, 141);
            this.cmbDistrict.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDistrict.Name = "cmbDistrict";
            this.cmbDistrict.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.cmbDistrict.Properties.Appearance.Options.UseFont = true;
            this.cmbDistrict.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDistrict.Size = new System.Drawing.Size(188, 28);
            this.cmbDistrict.TabIndex = 3;
            // 
            // cmbCity
            // 
            this.cmbCity.Location = new System.Drawing.Point(136, 105);
            this.cmbCity.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.cmbCity.Properties.Appearance.Options.UseFont = true;
            this.cmbCity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCity.Size = new System.Drawing.Size(188, 28);
            this.cmbCity.TabIndex = 2;
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // mskPhone
            // 
            this.mskPhone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskPhone.Location = new System.Drawing.Point(136, 322);
            this.mskPhone.Margin = new System.Windows.Forms.Padding(4);
            this.mskPhone.Mask = "(999) 000-0000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(188, 32);
            this.mskPhone.TabIndex = 8;
            // 
            // lblAccountType
            // 
            this.lblAccountType.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAccountType.Appearance.Options.UseFont = true;
            this.lblAccountType.Location = new System.Drawing.Point(12, 405);
            this.lblAccountType.Margin = new System.Windows.Forms.Padding(4);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(103, 22);
            this.lblAccountType.TabIndex = 25;
            this.lblAccountType.Text = "Hesap Türü :";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lookupCompany);
            this.groupControl1.Controls.Add(this.lblCompany);
            this.groupControl1.Controls.Add(this.txtAuthorized);
            this.groupControl1.Controls.Add(this.mskDate);
            this.groupControl1.Controls.Add(this.lblDate);
            this.groupControl1.Controls.Add(this.lblAuthorized);
            this.groupControl1.Controls.Add(this.lblAccountNo);
            this.groupControl1.Controls.Add(this.mskAccountNo);
            this.groupControl1.Controls.Add(this.txtAccountType);
            this.groupControl1.Controls.Add(this.cmbDistrict);
            this.groupControl1.Controls.Add(this.cmbCity);
            this.groupControl1.Controls.Add(this.mskPhone);
            this.groupControl1.Controls.Add(this.lblAccountType);
            this.groupControl1.Controls.Add(this.btnCleaner);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.lblDistrict);
            this.groupControl1.Controls.Add(this.lblCity);
            this.groupControl1.Controls.Add(this.txtBranch);
            this.groupControl1.Controls.Add(this.lblBranch);
            this.groupControl1.Controls.Add(this.lblIban);
            this.groupControl1.Controls.Add(this.lblPhone);
            this.groupControl1.Controls.Add(this.txtBankName);
            this.groupControl1.Controls.Add(this.lblBankName);
            this.groupControl1.Controls.Add(this.mskIban);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.lblId);
            this.groupControl1.Location = new System.Drawing.Point(1194, 11);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(377, 619);
            this.groupControl1.TabIndex = 5;
            // 
            // lookupCompany
            // 
            this.lookupCompany.Location = new System.Drawing.Point(135, 438);
            this.lookupCompany.Margin = new System.Windows.Forms.Padding(4);
            this.lookupCompany.Name = "lookupCompany";
            this.lookupCompany.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lookupCompany.Properties.Appearance.Options.UseFont = true;
            this.lookupCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupCompany.Size = new System.Drawing.Size(188, 28);
            this.lookupCompany.TabIndex = 11;
            // 
            // lblCompany
            // 
            this.lblCompany.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCompany.Appearance.Options.UseFont = true;
            this.lblCompany.Location = new System.Drawing.Point(60, 442);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(4);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(55, 22);
            this.lblCompany.TabIndex = 38;
            this.lblCompany.Text = "Firma :";
            // 
            // txtAuthorized
            // 
            this.txtAuthorized.Location = new System.Drawing.Point(136, 286);
            this.txtAuthorized.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthorized.Name = "txtAuthorized";
            this.txtAuthorized.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAuthorized.Properties.Appearance.Options.UseFont = true;
            this.txtAuthorized.Size = new System.Drawing.Size(188, 28);
            this.txtAuthorized.TabIndex = 7;
            // 
            // mskDate
            // 
            this.mskDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskDate.Location = new System.Drawing.Point(135, 362);
            this.mskDate.Margin = new System.Windows.Forms.Padding(4);
            this.mskDate.Mask = "00/00/0000";
            this.mskDate.Name = "mskDate";
            this.mskDate.Size = new System.Drawing.Size(188, 32);
            this.mskDate.TabIndex = 9;
            this.mskDate.ValidatingType = typeof(System.DateTime);
            // 
            // lblDate
            // 
            this.lblDate.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Appearance.Options.UseFont = true;
            this.lblDate.Location = new System.Drawing.Point(63, 369);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 22);
            this.lblDate.TabIndex = 35;
            this.lblDate.Text = "Tarih :";
            // 
            // lblAuthorized
            // 
            this.lblAuthorized.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAuthorized.Appearance.Options.UseFont = true;
            this.lblAuthorized.Location = new System.Drawing.Point(57, 289);
            this.lblAuthorized.Margin = new System.Windows.Forms.Padding(4);
            this.lblAuthorized.Name = "lblAuthorized";
            this.lblAuthorized.Size = new System.Drawing.Size(58, 22);
            this.lblAuthorized.TabIndex = 34;
            this.lblAuthorized.Text = "Yetkili :";
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAccountNo.Appearance.Options.UseFont = true;
            this.lblAccountNo.Location = new System.Drawing.Point(27, 256);
            this.lblAccountNo.Margin = new System.Windows.Forms.Padding(4);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(88, 22);
            this.lblAccountNo.TabIndex = 32;
            this.lblAccountNo.Text = "Hesap No :";
            // 
            // mskAccountNo
            // 
            this.mskAccountNo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskAccountNo.Location = new System.Drawing.Point(136, 246);
            this.mskAccountNo.Margin = new System.Windows.Forms.Padding(4);
            this.mskAccountNo.Name = "mskAccountNo";
            this.mskAccountNo.Size = new System.Drawing.Size(188, 32);
            this.mskAccountNo.TabIndex = 6;
            this.mskAccountNo.ValidatingType = typeof(int);
            // 
            // btnCleaner
            // 
            this.btnCleaner.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCleaner.Appearance.Options.UseFont = true;
            this.btnCleaner.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCleaner.ImageOptions.Image")));
            this.btnCleaner.Location = new System.Drawing.Point(180, 554);
            this.btnCleaner.Margin = new System.Windows.Forms.Padding(4);
            this.btnCleaner.Name = "btnCleaner";
            this.btnCleaner.Size = new System.Drawing.Size(143, 37);
            this.btnCleaner.TabIndex = 23;
            this.btnCleaner.Text = "Temizle";
            this.btnCleaner.Click += new System.EventHandler(this.btnCleaner_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(180, 486);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(143, 37);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(13, 554);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 37);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Sil";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(13, 486);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 37);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDistrict
            // 
            this.lblDistrict.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDistrict.Appearance.Options.UseFont = true;
            this.lblDistrict.Location = new System.Drawing.Point(75, 144);
            this.lblDistrict.Margin = new System.Windows.Forms.Padding(4);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(40, 22);
            this.lblDistrict.TabIndex = 18;
            this.lblDistrict.Text = "İlçe :";
            // 
            // lblCity
            // 
            this.lblCity.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCity.Appearance.Options.UseFont = true;
            this.lblCity.Location = new System.Drawing.Point(92, 110);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(23, 22);
            this.lblCity.TabIndex = 15;
            this.lblCity.Text = "İl :";
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(135, 177);
            this.txtBranch.Margin = new System.Windows.Forms.Padding(4);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBranch.Properties.Appearance.Options.UseFont = true;
            this.txtBranch.Size = new System.Drawing.Size(188, 28);
            this.txtBranch.TabIndex = 4;
            // 
            // lblBranch
            // 
            this.lblBranch.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBranch.Appearance.Options.UseFont = true;
            this.lblBranch.Location = new System.Drawing.Point(64, 180);
            this.lblBranch.Margin = new System.Windows.Forms.Padding(4);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(51, 22);
            this.lblBranch.TabIndex = 13;
            this.lblBranch.Text = "Şube :";
            // 
            // lblIban
            // 
            this.lblIban.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIban.Appearance.Options.UseFont = true;
            this.lblIban.Location = new System.Drawing.Point(67, 218);
            this.lblIban.Margin = new System.Windows.Forms.Padding(4);
            this.lblIban.Name = "lblIban";
            this.lblIban.Size = new System.Drawing.Size(48, 22);
            this.lblIban.TabIndex = 9;
            this.lblIban.Text = "Iban :";
            // 
            // lblPhone
            // 
            this.lblPhone.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhone.Appearance.Options.UseFont = true;
            this.lblPhone.Location = new System.Drawing.Point(44, 328);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(71, 22);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Telefon :";
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(135, 69);
            this.txtBankName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBankName.Properties.Appearance.Options.UseFont = true;
            this.txtBankName.Size = new System.Drawing.Size(188, 28);
            this.txtBankName.TabIndex = 1;
            // 
            // lblBankName
            // 
            this.lblBankName.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankName.Appearance.Options.UseFont = true;
            this.lblBankName.Location = new System.Drawing.Point(24, 66);
            this.lblBankName.Margin = new System.Windows.Forms.Padding(4);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(91, 22);
            this.lblBankName.TabIndex = 3;
            this.lblBankName.Text = "Banka Adı :";
            // 
            // mskIban
            // 
            this.mskIban.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskIban.Location = new System.Drawing.Point(136, 211);
            this.mskIban.Margin = new System.Windows.Forms.Padding(4);
            this.mskIban.Name = "mskIban";
            this.mskIban.Size = new System.Drawing.Size(188, 32);
            this.mskIban.TabIndex = 5;
            this.mskIban.ValidatingType = typeof(int);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(136, 33);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId.Properties.Appearance.Options.UseFont = true;
            this.txtId.Properties.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(188, 28);
            this.txtId.TabIndex = 100;
            // 
            // lblId
            // 
            this.lblId.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblId.Appearance.Options.UseFont = true;
            this.lblId.Location = new System.Drawing.Point(78, 36);
            this.lblId.Margin = new System.Windows.Forms.Padding(4);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(37, 22);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID : ";
            // 
            // FrmBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 636);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Font = new System.Drawing.Font("Corbel", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bankalar";
            this.Load += new System.EventHandler(this.FrmBank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDistrict.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorized.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.TextEdit txtAccountType;
        private DevExpress.XtraEditors.ComboBoxEdit cmbDistrict;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCity;
        private System.Windows.Forms.MaskedTextBox mskPhone;
        private DevExpress.XtraEditors.LabelControl lblAccountType;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnCleaner;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl lblDistrict;
        private DevExpress.XtraEditors.LabelControl lblCity;
        private DevExpress.XtraEditors.TextEdit txtBranch;
        private DevExpress.XtraEditors.LabelControl lblBranch;
        private DevExpress.XtraEditors.LabelControl lblIban;
        private DevExpress.XtraEditors.LabelControl lblPhone;
        private DevExpress.XtraEditors.TextEdit txtBankName;
        private DevExpress.XtraEditors.LabelControl lblBankName;
        private System.Windows.Forms.MaskedTextBox mskIban;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl lblId;
        private DevExpress.XtraEditors.LabelControl lblAuthorized;
        private DevExpress.XtraEditors.LabelControl lblAccountNo;
        private System.Windows.Forms.MaskedTextBox mskAccountNo;
        private DevExpress.XtraEditors.LabelControl lblCompany;
        private DevExpress.XtraEditors.TextEdit txtAuthorized;
        private System.Windows.Forms.MaskedTextBox mskDate;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.LookUpEdit lookupCompany;
    }
}