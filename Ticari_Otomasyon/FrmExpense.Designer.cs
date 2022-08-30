namespace Ticari_Otomasyon
{
    partial class FrmExpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExpense));
            this.txtExtra = new DevExpress.XtraEditors.TextEdit();
            this.cmbYear = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbMonth = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblExtra = new DevExpress.XtraEditors.LabelControl();
            this.lblNote = new DevExpress.XtraEditors.LabelControl();
            this.btnCleaner = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.rchNote = new System.Windows.Forms.RichTextBox();
            this.lblSalary = new DevExpress.XtraEditors.LabelControl();
            this.lblInternet = new DevExpress.XtraEditors.LabelControl();
            this.txtGas = new DevExpress.XtraEditors.TextEdit();
            this.lblGas = new DevExpress.XtraEditors.LabelControl();
            this.lblIWater = new DevExpress.XtraEditors.LabelControl();
            this.lblElectric = new DevExpress.XtraEditors.LabelControl();
            this.txtElectric = new DevExpress.XtraEditors.TextEdit();
            this.lblYear = new DevExpress.XtraEditors.LabelControl();
            this.txtWater = new DevExpress.XtraEditors.TextEdit();
            this.lblMonth = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.lblId = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtSalary = new DevExpress.XtraEditors.TextEdit();
            this.txtInternet = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtExtra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtElectric.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWater.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInternet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(111, 311);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtExtra.Properties.Appearance.Options.UseFont = true;
            this.txtExtra.Size = new System.Drawing.Size(200, 28);
            this.txtExtra.TabIndex = 8;
            // 
            // cmbYear
            // 
            this.cmbYear.Location = new System.Drawing.Point(111, 99);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.cmbYear.Properties.Appearance.Options.UseFont = true;
            this.cmbYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbYear.Properties.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024"});
            this.cmbYear.Size = new System.Drawing.Size(200, 28);
            this.cmbYear.TabIndex = 2;
            // 
            // cmbMonth
            // 
            this.cmbMonth.Location = new System.Drawing.Point(111, 65);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.cmbMonth.Properties.Appearance.Options.UseFont = true;
            this.cmbMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMonth.Properties.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.cmbMonth.Size = new System.Drawing.Size(200, 28);
            this.cmbMonth.TabIndex = 1;
            // 
            // lblExtra
            // 
            this.lblExtra.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExtra.Appearance.Options.UseFont = true;
            this.lblExtra.Location = new System.Drawing.Point(45, 314);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(60, 22);
            this.lblExtra.TabIndex = 25;
            this.lblExtra.Text = "Ekstra :";
            // 
            // lblNote
            // 
            this.lblNote.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNote.Appearance.Options.UseFont = true;
            this.lblNote.Location = new System.Drawing.Point(65, 343);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(40, 22);
            this.lblNote.TabIndex = 24;
            this.lblNote.Text = "Not :";
            // 
            // btnCleaner
            // 
            this.btnCleaner.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCleaner.Appearance.Options.UseFont = true;
            this.btnCleaner.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCleaner.ImageOptions.Image")));
            this.btnCleaner.Location = new System.Drawing.Point(168, 535);
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
            this.btnUpdate.Location = new System.Drawing.Point(168, 481);
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
            this.btnDelete.Location = new System.Drawing.Point(13, 535);
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
            this.btnSave.Location = new System.Drawing.Point(13, 481);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 37);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rchNote
            // 
            this.rchNote.Location = new System.Drawing.Point(110, 345);
            this.rchNote.Name = "rchNote";
            this.rchNote.Size = new System.Drawing.Size(200, 105);
            this.rchNote.TabIndex = 9;
            this.rchNote.Text = "";
            // 
            // lblSalary
            // 
            this.lblSalary.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSalary.Appearance.Options.UseFont = true;
            this.lblSalary.Location = new System.Drawing.Point(34, 280);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(71, 22);
            this.lblSalary.TabIndex = 18;
            this.lblSalary.Text = "Maaşlar :";
            // 
            // lblInternet
            // 
            this.lblInternet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInternet.Appearance.Options.UseFont = true;
            this.lblInternet.Location = new System.Drawing.Point(29, 246);
            this.lblInternet.Name = "lblInternet";
            this.lblInternet.Size = new System.Drawing.Size(75, 22);
            this.lblInternet.TabIndex = 15;
            this.lblInternet.Text = "İnternet :";
            // 
            // txtGas
            // 
            this.txtGas.Location = new System.Drawing.Point(110, 209);
            this.txtGas.Name = "txtGas";
            this.txtGas.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGas.Properties.Appearance.Options.UseFont = true;
            this.txtGas.Size = new System.Drawing.Size(200, 28);
            this.txtGas.TabIndex = 5;
            // 
            // lblGas
            // 
            this.lblGas.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGas.Appearance.Options.UseFont = true;
            this.lblGas.Location = new System.Drawing.Point(21, 212);
            this.lblGas.Name = "lblGas";
            this.lblGas.Size = new System.Drawing.Size(84, 22);
            this.lblGas.TabIndex = 13;
            this.lblGas.Text = "Doğalgaz :";
            // 
            // lblIWater
            // 
            this.lblIWater.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIWater.Appearance.Options.UseFont = true;
            this.lblIWater.Location = new System.Drawing.Point(73, 176);
            this.lblIWater.Name = "lblIWater";
            this.lblIWater.Size = new System.Drawing.Size(32, 22);
            this.lblIWater.TabIndex = 11;
            this.lblIWater.Text = "Su :";
            // 
            // lblElectric
            // 
            this.lblElectric.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblElectric.Appearance.Options.UseFont = true;
            this.lblElectric.Location = new System.Drawing.Point(36, 138);
            this.lblElectric.Name = "lblElectric";
            this.lblElectric.Size = new System.Drawing.Size(69, 22);
            this.lblElectric.TabIndex = 7;
            this.lblElectric.Text = "Elektrik :";
            // 
            // txtElectric
            // 
            this.txtElectric.Location = new System.Drawing.Point(111, 135);
            this.txtElectric.Name = "txtElectric";
            this.txtElectric.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtElectric.Properties.Appearance.Options.UseFont = true;
            this.txtElectric.Size = new System.Drawing.Size(200, 28);
            this.txtElectric.TabIndex = 3;
            // 
            // lblYear
            // 
            this.lblYear.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYear.Appearance.Options.UseFont = true;
            this.lblYear.Location = new System.Drawing.Point(75, 102);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(30, 22);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "Yıl :";
            // 
            // txtWater
            // 
            this.txtWater.Location = new System.Drawing.Point(111, 175);
            this.txtWater.Name = "txtWater";
            this.txtWater.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtWater.Properties.Appearance.Options.UseFont = true;
            this.txtWater.Size = new System.Drawing.Size(200, 28);
            this.txtWater.TabIndex = 4;
            // 
            // lblMonth
            // 
            this.lblMonth.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMonth.Appearance.Options.UseFont = true;
            this.lblMonth.Location = new System.Drawing.Point(73, 68);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(32, 22);
            this.lblMonth.TabIndex = 3;
            this.lblMonth.Text = "Ay :";
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
            this.lblId.Location = new System.Drawing.Point(68, 34);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(37, 22);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID : ";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtSalary);
            this.groupControl1.Controls.Add(this.txtInternet);
            this.groupControl1.Controls.Add(this.txtExtra);
            this.groupControl1.Controls.Add(this.cmbYear);
            this.groupControl1.Controls.Add(this.cmbMonth);
            this.groupControl1.Controls.Add(this.lblExtra);
            this.groupControl1.Controls.Add(this.lblNote);
            this.groupControl1.Controls.Add(this.btnCleaner);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.rchNote);
            this.groupControl1.Controls.Add(this.lblSalary);
            this.groupControl1.Controls.Add(this.lblInternet);
            this.groupControl1.Controls.Add(this.txtGas);
            this.groupControl1.Controls.Add(this.lblGas);
            this.groupControl1.Controls.Add(this.lblIWater);
            this.groupControl1.Controls.Add(this.lblElectric);
            this.groupControl1.Controls.Add(this.txtElectric);
            this.groupControl1.Controls.Add(this.lblYear);
            this.groupControl1.Controls.Add(this.txtWater);
            this.groupControl1.Controls.Add(this.lblMonth);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.lblId);
            this.groupControl1.Location = new System.Drawing.Point(1197, 9);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(334, 619);
            this.groupControl1.TabIndex = 7;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(111, 277);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSalary.Properties.Appearance.Options.UseFont = true;
            this.txtSalary.Size = new System.Drawing.Size(200, 28);
            this.txtSalary.TabIndex = 7;
            // 
            // txtInternet
            // 
            this.txtInternet.Location = new System.Drawing.Point(111, 243);
            this.txtInternet.Name = "txtInternet";
            this.txtInternet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtInternet.Properties.Appearance.Options.UseFont = true;
            this.txtInternet.Size = new System.Drawing.Size(200, 28);
            this.txtInternet.TabIndex = 6;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(8, 9);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1166, 619);
            this.gridControl1.TabIndex = 6;
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
            // FrmExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 636);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Font = new System.Drawing.Font("Corbel", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmExpense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.FrmExpense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtExtra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtElectric.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWater.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInternet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtExtra;
        private DevExpress.XtraEditors.ComboBoxEdit cmbYear;
        private DevExpress.XtraEditors.ComboBoxEdit cmbMonth;
        private DevExpress.XtraEditors.LabelControl lblExtra;
        private DevExpress.XtraEditors.LabelControl lblNote;
        private DevExpress.XtraEditors.SimpleButton btnCleaner;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.RichTextBox rchNote;
        private DevExpress.XtraEditors.LabelControl lblSalary;
        private DevExpress.XtraEditors.LabelControl lblInternet;
        private DevExpress.XtraEditors.TextEdit txtGas;
        private DevExpress.XtraEditors.LabelControl lblGas;
        private DevExpress.XtraEditors.LabelControl lblIWater;
        private DevExpress.XtraEditors.LabelControl lblElectric;
        private DevExpress.XtraEditors.TextEdit txtElectric;
        private DevExpress.XtraEditors.LabelControl lblYear;
        private DevExpress.XtraEditors.TextEdit txtWater;
        private DevExpress.XtraEditors.LabelControl lblMonth;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl lblId;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtSalary;
        private DevExpress.XtraEditors.TextEdit txtInternet;
    }
}