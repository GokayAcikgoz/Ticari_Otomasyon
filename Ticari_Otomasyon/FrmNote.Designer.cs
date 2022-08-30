namespace Ticari_Otomasyon
{
    partial class FrmNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNote));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.mskDate = new System.Windows.Forms.MaskedTextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtWho = new DevExpress.XtraEditors.TextEdit();
            this.btnCleaner = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.rchDetail = new System.Windows.Forms.RichTextBox();
            this.lblDetail = new DevExpress.XtraEditors.LabelControl();
            this.lblWho = new DevExpress.XtraEditors.LabelControl();
            this.lblAuthor = new DevExpress.XtraEditors.LabelControl();
            this.LblHeader = new DevExpress.XtraEditors.LabelControl();
            this.txtHeader = new DevExpress.XtraEditors.TextEdit();
            this.lblClock = new DevExpress.XtraEditors.LabelControl();
            this.txtAuthor = new DevExpress.XtraEditors.TextEdit();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.mskClock = new System.Windows.Forms.MaskedTextBox();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.lblId = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeader.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthor.Properties)).BeginInit();
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
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
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
            // mskDate
            // 
            this.mskDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskDate.Location = new System.Drawing.Point(101, 66);
            this.mskDate.Mask = "00/00/0000";
            this.mskDate.Name = "mskDate";
            this.mskDate.Size = new System.Drawing.Size(210, 32);
            this.mskDate.TabIndex = 1;
            this.mskDate.ValidatingType = typeof(System.DateTime);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtWho);
            this.groupControl1.Controls.Add(this.mskDate);
            this.groupControl1.Controls.Add(this.btnCleaner);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.rchDetail);
            this.groupControl1.Controls.Add(this.lblDetail);
            this.groupControl1.Controls.Add(this.lblWho);
            this.groupControl1.Controls.Add(this.lblAuthor);
            this.groupControl1.Controls.Add(this.LblHeader);
            this.groupControl1.Controls.Add(this.txtHeader);
            this.groupControl1.Controls.Add(this.lblClock);
            this.groupControl1.Controls.Add(this.txtAuthor);
            this.groupControl1.Controls.Add(this.lblDate);
            this.groupControl1.Controls.Add(this.mskClock);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.lblId);
            this.groupControl1.Location = new System.Drawing.Point(1197, 9);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(334, 619);
            this.groupControl1.TabIndex = 5;
            // 
            // txtWho
            // 
            this.txtWho.Location = new System.Drawing.Point(101, 214);
            this.txtWho.Name = "txtWho";
            this.txtWho.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtWho.Properties.Appearance.Options.UseFont = true;
            this.txtWho.Size = new System.Drawing.Size(210, 28);
            this.txtWho.TabIndex = 5;
            // 
            // btnCleaner
            // 
            this.btnCleaner.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCleaner.Appearance.Options.UseFont = true;
            this.btnCleaner.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCleaner.ImageOptions.Image")));
            this.btnCleaner.Location = new System.Drawing.Point(168, 485);
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
            this.btnUpdate.Location = new System.Drawing.Point(168, 431);
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
            this.btnDelete.Location = new System.Drawing.Point(13, 485);
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
            this.btnSave.Location = new System.Drawing.Point(13, 431);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 37);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rchDetail
            // 
            this.rchDetail.Location = new System.Drawing.Point(101, 249);
            this.rchDetail.Name = "rchDetail";
            this.rchDetail.Size = new System.Drawing.Size(210, 149);
            this.rchDetail.TabIndex = 6;
            this.rchDetail.Text = "";
            // 
            // lblDetail
            // 
            this.lblDetail.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDetail.Appearance.Options.UseFont = true;
            this.lblDetail.Location = new System.Drawing.Point(38, 253);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(57, 22);
            this.lblDetail.TabIndex = 13;
            this.lblDetail.Text = "Detay :";
            // 
            // lblWho
            // 
            this.lblWho.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWho.Appearance.Options.UseFont = true;
            this.lblWho.Location = new System.Drawing.Point(42, 217);
            this.lblWho.Name = "lblWho";
            this.lblWho.Size = new System.Drawing.Size(53, 22);
            this.lblWho.TabIndex = 11;
            this.lblWho.Text = "Hitap :";
            // 
            // lblAuthor
            // 
            this.lblAuthor.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAuthor.Appearance.Options.UseFont = true;
            this.lblAuthor.Location = new System.Drawing.Point(7, 182);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(88, 22);
            this.lblAuthor.TabIndex = 9;
            this.lblAuthor.Text = "Oluşturan :";
            // 
            // LblHeader
            // 
            this.LblHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblHeader.Appearance.Options.UseFont = true;
            this.LblHeader.Location = new System.Drawing.Point(38, 147);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(57, 22);
            this.LblHeader.TabIndex = 7;
            this.LblHeader.Text = "Başlık :";
            // 
            // txtHeader
            // 
            this.txtHeader.Location = new System.Drawing.Point(101, 144);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHeader.Properties.Appearance.Options.UseFont = true;
            this.txtHeader.Size = new System.Drawing.Size(210, 28);
            this.txtHeader.TabIndex = 3;
            // 
            // lblClock
            // 
            this.lblClock.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblClock.Appearance.Options.UseFont = true;
            this.lblClock.Location = new System.Drawing.Point(49, 109);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(46, 22);
            this.lblClock.TabIndex = 5;
            this.lblClock.Text = "Saat :";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(101, 179);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAuthor.Properties.Appearance.Options.UseFont = true;
            this.txtAuthor.Size = new System.Drawing.Size(210, 28);
            this.txtAuthor.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Appearance.Options.UseFont = true;
            this.lblDate.Location = new System.Drawing.Point(43, 70);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 22);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Tarih :";
            // 
            // mskClock
            // 
            this.mskClock.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskClock.Location = new System.Drawing.Point(101, 105);
            this.mskClock.Mask = "00:00";
            this.mskClock.Name = "mskClock";
            this.mskClock.Size = new System.Drawing.Size(210, 32);
            this.mskClock.TabIndex = 2;
            this.mskClock.ValidatingType = typeof(System.DateTime);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(101, 31);
            this.txtId.Name = "txtId";
            this.txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId.Properties.Appearance.Options.UseFont = true;
            this.txtId.Properties.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(210, 28);
            this.txtId.TabIndex = 100;
            // 
            // lblId
            // 
            this.lblId.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblId.Appearance.Options.UseFont = true;
            this.lblId.Location = new System.Drawing.Point(58, 34);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(37, 22);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID : ";
            // 
            // FrmNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 636);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notlar";
            this.Load += new System.EventHandler(this.FrmNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeader.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.MaskedTextBox mskDate;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnCleaner;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.RichTextBox rchDetail;
        private DevExpress.XtraEditors.LabelControl lblDetail;
        private DevExpress.XtraEditors.LabelControl lblWho;
        private DevExpress.XtraEditors.LabelControl lblAuthor;
        private DevExpress.XtraEditors.LabelControl LblHeader;
        private DevExpress.XtraEditors.TextEdit txtHeader;
        private DevExpress.XtraEditors.LabelControl lblClock;
        private DevExpress.XtraEditors.TextEdit txtAuthor;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private System.Windows.Forms.MaskedTextBox mskClock;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl lblId;
        private DevExpress.XtraEditors.TextEdit txtWho;
    }
}