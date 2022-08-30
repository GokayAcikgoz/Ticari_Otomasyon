namespace Ticari_Otomasyon
{
    partial class FrmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomer));
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
            this.txtSurname = new DevExpress.XtraEditors.TextEdit();
            this.lblSurname = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.mskPhoneTwo = new System.Windows.Forms.MaskedTextBox();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.lblId = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtTaxOffice = new DevExpress.XtraEditors.TextEdit();
            this.cmbDistrict = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbCity = new DevExpress.XtraEditors.ComboBoxEdit();
            this.mskIdentityNo = new System.Windows.Forms.MaskedTextBox();
            this.mskPhoneOne = new System.Windows.Forms.MaskedTextBox();
            this.lblTaxOffice = new DevExpress.XtraEditors.LabelControl();
            this.lblAddress = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxOffice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDistrict.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCleaner
            // 
            this.btnCleaner.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCleaner.Appearance.Options.UseFont = true;
            this.btnCleaner.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCleaner.ImageOptions.Image")));
            this.btnCleaner.Location = new System.Drawing.Point(168, 559);
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
            this.btnUpdate.Location = new System.Drawing.Point(168, 505);
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
            this.btnDelete.Location = new System.Drawing.Point(13, 559);
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
            this.btnSave.Location = new System.Drawing.Point(13, 505);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 37);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rchAddress
            // 
            this.rchAddress.Location = new System.Drawing.Point(110, 384);
            this.rchAddress.Name = "rchAddress";
            this.rchAddress.Size = new System.Drawing.Size(200, 105);
            this.rchAddress.TabIndex = 10;
            this.rchAddress.Text = "";
            // 
            // lblDistrict
            // 
            this.lblDistrict.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDistrict.Appearance.Options.UseFont = true;
            this.lblDistrict.Location = new System.Drawing.Point(64, 319);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(40, 22);
            this.lblDistrict.TabIndex = 18;
            this.lblDistrict.Text = "İlçe :";
            // 
            // lblCity
            // 
            this.lblCity.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCity.Appearance.Options.UseFont = true;
            this.lblCity.Location = new System.Drawing.Point(81, 279);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(23, 22);
            this.lblCity.TabIndex = 15;
            this.lblCity.Text = "İl :";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(111, 248);
            this.txtMail.Name = "txtMail";
            this.txtMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Properties.Appearance.Options.UseFont = true;
            this.txtMail.Size = new System.Drawing.Size(200, 28);
            this.txtMail.TabIndex = 6;
            // 
            // lblMail
            // 
            this.lblMail.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.Appearance.Options.UseFont = true;
            this.lblMail.Location = new System.Drawing.Point(61, 251);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(43, 22);
            this.lblMail.TabIndex = 13;
            this.lblMail.Text = "Mail :";
            // 
            // lblIdentityNo
            // 
            this.lblIdentityNo.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIdentityNo.Appearance.Options.UseFont = true;
            this.lblIdentityNo.Location = new System.Drawing.Point(70, 215);
            this.lblIdentityNo.Name = "lblIdentityNo";
            this.lblIdentityNo.Size = new System.Drawing.Size(34, 22);
            this.lblIdentityNo.TabIndex = 11;
            this.lblIdentityNo.Text = "TC :";
            // 
            // lblPhoneTwo
            // 
            this.lblPhoneTwo.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhoneTwo.Appearance.Options.UseFont = true;
            this.lblPhoneTwo.Location = new System.Drawing.Point(23, 177);
            this.lblPhoneTwo.Name = "lblPhoneTwo";
            this.lblPhoneTwo.Size = new System.Drawing.Size(81, 22);
            this.lblPhoneTwo.TabIndex = 9;
            this.lblPhoneTwo.Text = "Telefon2 :";
            // 
            // lblPhoneOne
            // 
            this.lblPhoneOne.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhoneOne.Appearance.Options.UseFont = true;
            this.lblPhoneOne.Location = new System.Drawing.Point(23, 138);
            this.lblPhoneOne.Name = "lblPhoneOne";
            this.lblPhoneOne.Size = new System.Drawing.Size(81, 22);
            this.lblPhoneOne.TabIndex = 7;
            this.lblPhoneOne.Text = "Telefon1 :";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(111, 99);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSurname.Properties.Appearance.Options.UseFont = true;
            this.txtSurname.Size = new System.Drawing.Size(200, 28);
            this.txtSurname.TabIndex = 2;
            // 
            // lblSurname
            // 
            this.lblSurname.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSurname.Appearance.Options.UseFont = true;
            this.lblSurname.Location = new System.Drawing.Point(44, 102);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(60, 22);
            this.lblSurname.TabIndex = 5;
            this.lblSurname.Text = "Soyad :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 65);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Size = new System.Drawing.Size(200, 28);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Appearance.Options.UseFont = true;
            this.lblName.Location = new System.Drawing.Point(71, 68);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 22);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Ad :";
            // 
            // mskPhoneTwo
            // 
            this.mskPhoneTwo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskPhoneTwo.Location = new System.Drawing.Point(111, 172);
            this.mskPhoneTwo.Mask = "(999) 000-0000";
            this.mskPhoneTwo.Name = "mskPhoneTwo";
            this.mskPhoneTwo.Size = new System.Drawing.Size(200, 32);
            this.mskPhoneTwo.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(111, 31);
            this.txtId.Name = "txtId";
            this.txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId.Properties.Appearance.Options.UseFont = true;
            this.txtId.Properties.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(200, 28);
            this.txtId.TabIndex = 100;
            // 
            // lblId
            // 
            this.lblId.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblId.Appearance.Options.UseFont = true;
            this.lblId.Location = new System.Drawing.Point(67, 34);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(37, 22);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID : ";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtTaxOffice);
            this.groupControl1.Controls.Add(this.cmbDistrict);
            this.groupControl1.Controls.Add(this.cmbCity);
            this.groupControl1.Controls.Add(this.mskIdentityNo);
            this.groupControl1.Controls.Add(this.mskPhoneOne);
            this.groupControl1.Controls.Add(this.lblTaxOffice);
            this.groupControl1.Controls.Add(this.lblAddress);
            this.groupControl1.Controls.Add(this.btnCleaner);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.rchAddress);
            this.groupControl1.Controls.Add(this.lblDistrict);
            this.groupControl1.Controls.Add(this.lblCity);
            this.groupControl1.Controls.Add(this.txtMail);
            this.groupControl1.Controls.Add(this.lblMail);
            this.groupControl1.Controls.Add(this.lblIdentityNo);
            this.groupControl1.Controls.Add(this.lblPhoneTwo);
            this.groupControl1.Controls.Add(this.lblPhoneOne);
            this.groupControl1.Controls.Add(this.txtSurname);
            this.groupControl1.Controls.Add(this.lblSurname);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.lblName);
            this.groupControl1.Controls.Add(this.mskPhoneTwo);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.lblId);
            this.groupControl1.Location = new System.Drawing.Point(1195, 9);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(334, 619);
            this.groupControl1.TabIndex = 3;
            // 
            // txtTaxOffice
            // 
            this.txtTaxOffice.Location = new System.Drawing.Point(111, 350);
            this.txtTaxOffice.Name = "txtTaxOffice";
            this.txtTaxOffice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTaxOffice.Properties.Appearance.Options.UseFont = true;
            this.txtTaxOffice.Size = new System.Drawing.Size(200, 28);
            this.txtTaxOffice.TabIndex = 9;
            // 
            // cmbDistrict
            // 
            this.cmbDistrict.Location = new System.Drawing.Point(111, 316);
            this.cmbDistrict.Name = "cmbDistrict";
            this.cmbDistrict.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.cmbDistrict.Properties.Appearance.Options.UseFont = true;
            this.cmbDistrict.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDistrict.Size = new System.Drawing.Size(200, 28);
            this.cmbDistrict.TabIndex = 8;
            // 
            // cmbCity
            // 
            this.cmbCity.Location = new System.Drawing.Point(111, 282);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.cmbCity.Properties.Appearance.Options.UseFont = true;
            this.cmbCity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCity.Size = new System.Drawing.Size(200, 28);
            this.cmbCity.TabIndex = 7;
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // mskIdentityNo
            // 
            this.mskIdentityNo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskIdentityNo.Location = new System.Drawing.Point(111, 210);
            this.mskIdentityNo.Mask = "00000000000";
            this.mskIdentityNo.Name = "mskIdentityNo";
            this.mskIdentityNo.Size = new System.Drawing.Size(200, 32);
            this.mskIdentityNo.TabIndex = 5;
            this.mskIdentityNo.ValidatingType = typeof(int);
            // 
            // mskPhoneOne
            // 
            this.mskPhoneOne.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskPhoneOne.Location = new System.Drawing.Point(111, 133);
            this.mskPhoneOne.Mask = "(999) 000-0000";
            this.mskPhoneOne.Name = "mskPhoneOne";
            this.mskPhoneOne.Size = new System.Drawing.Size(200, 32);
            this.mskPhoneOne.TabIndex = 3;
            // 
            // lblTaxOffice
            // 
            this.lblTaxOffice.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaxOffice.Appearance.Options.UseFont = true;
            this.lblTaxOffice.Location = new System.Drawing.Point(34, 347);
            this.lblTaxOffice.Name = "lblTaxOffice";
            this.lblTaxOffice.Size = new System.Drawing.Size(70, 22);
            this.lblTaxOffice.TabIndex = 25;
            this.lblTaxOffice.Text = "Vergi D :";
            // 
            // lblAddress
            // 
            this.lblAddress.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddress.Appearance.Options.UseFont = true;
            this.lblAddress.Location = new System.Drawing.Point(48, 375);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 22);
            this.lblAddress.TabIndex = 24;
            this.lblAddress.Text = "Adres :";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(8, 9);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1166, 619);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 636);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Font = new System.Drawing.Font("Corbel", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxOffice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDistrict.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private DevExpress.XtraEditors.TextEdit txtSurname;
        private DevExpress.XtraEditors.LabelControl lblSurname;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl lblName;
        private System.Windows.Forms.MaskedTextBox mskPhoneTwo;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl lblId;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtTaxOffice;
        private DevExpress.XtraEditors.ComboBoxEdit cmbDistrict;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCity;
        private System.Windows.Forms.MaskedTextBox mskIdentityNo;
        private System.Windows.Forms.MaskedTextBox mskPhoneOne;
        private DevExpress.XtraEditors.LabelControl lblTaxOffice;
        private DevExpress.XtraEditors.LabelControl lblAddress;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}