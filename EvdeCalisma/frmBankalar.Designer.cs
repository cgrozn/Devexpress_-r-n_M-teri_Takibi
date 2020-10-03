namespace EvdeCalisma
{
    partial class frmBankalar
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.banka_firma = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label11 = new System.Windows.Forms.Label();
            this.banka_tel = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.banka_ilce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.banka_il = new DevExpress.XtraEditors.ComboBoxEdit();
            this.banka_ad = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.banka_id = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.banka_yet = new DevExpress.XtraEditors.TextEdit();
            this.banka_hesap = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.banka_hesapturu = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.banka_sube = new DevExpress.XtraEditors.TextEdit();
            this.banka_iban = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banka_firma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banka_ilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banka_il.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banka_ad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banka_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banka_yet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banka_hesap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banka_hesapturu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banka_sube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banka_iban.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-6, 56);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 489);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.banka_firma);
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Controls.Add(this.banka_tel);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.banka_ilce);
            this.groupControl1.Controls.Add(this.banka_il);
            this.groupControl1.Controls.Add(this.banka_ad);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.banka_id);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.banka_yet);
            this.groupControl1.Controls.Add(this.banka_hesap);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.banka_hesapturu);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.banka_sube);
            this.groupControl1.Controls.Add(this.banka_iban);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Location = new System.Drawing.Point(823, 27);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(231, 452);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // banka_firma
            // 
            this.banka_firma.Location = new System.Drawing.Point(87, 388);
            this.banka_firma.Name = "banka_firma";
            this.banka_firma.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.banka_firma.Properties.NullText = "Lütfen Firma Adı Giriniz";
            this.banka_firma.Properties.View = this.gridLookUpEdit1View;
            this.banka_firma.Size = new System.Drawing.Size(144, 20);
            this.banka_firma.TabIndex = 54;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 391);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Firma";
            // 
            // banka_tel
            // 
            this.banka_tel.Location = new System.Drawing.Point(87, 206);
            this.banka_tel.Mask = "(999) 000-0000";
            this.banka_tel.Name = "banka_tel";
            this.banka_tel.Size = new System.Drawing.Size(139, 21);
            this.banka_tel.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Telefon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "İLÇE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "İL";
            // 
            // banka_ilce
            // 
            this.banka_ilce.Location = new System.Drawing.Point(87, 92);
            this.banka_ilce.Name = "banka_ilce";
            this.banka_ilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.banka_ilce.Size = new System.Drawing.Size(139, 20);
            this.banka_ilce.TabIndex = 46;
            // 
            // banka_il
            // 
            this.banka_il.Location = new System.Drawing.Point(87, 62);
            this.banka_il.Name = "banka_il";
            this.banka_il.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.banka_il.Size = new System.Drawing.Size(139, 20);
            this.banka_il.TabIndex = 45;
            this.banka_il.SelectedIndexChanged += new System.EventHandler(this.banka_il_SelectedIndexChanged);
            // 
            // banka_ad
            // 
            this.banka_ad.Location = new System.Drawing.Point(87, 129);
            this.banka_ad.Name = "banka_ad";
            this.banka_ad.Size = new System.Drawing.Size(139, 20);
            this.banka_ad.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Id";
            // 
            // banka_id
            // 
            this.banka_id.Location = new System.Drawing.Point(87, 26);
            this.banka_id.Name = "banka_id";
            this.banka_id.Size = new System.Drawing.Size(139, 20);
            this.banka_id.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Hesap Turu";
            // 
            // banka_yet
            // 
            this.banka_yet.Location = new System.Drawing.Point(87, 311);
            this.banka_yet.Name = "banka_yet";
            this.banka_yet.Size = new System.Drawing.Size(139, 20);
            this.banka_yet.TabIndex = 23;
            // 
            // banka_hesap
            // 
            this.banka_hesap.Location = new System.Drawing.Point(87, 274);
            this.banka_hesap.Name = "banka_hesap";
            this.banka_hesap.Size = new System.Drawing.Size(139, 20);
            this.banka_hesap.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Banka Adı";
            // 
            // banka_hesapturu
            // 
            this.banka_hesapturu.Location = new System.Drawing.Point(87, 354);
            this.banka_hesapturu.Name = "banka_hesapturu";
            this.banka_hesapturu.Size = new System.Drawing.Size(139, 20);
            this.banka_hesapturu.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Sube";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Iban";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Yetkili";
            // 
            // banka_sube
            // 
            this.banka_sube.Location = new System.Drawing.Point(87, 168);
            this.banka_sube.Name = "banka_sube";
            this.banka_sube.Size = new System.Drawing.Size(139, 20);
            this.banka_sube.TabIndex = 29;
            // 
            // banka_iban
            // 
            this.banka_iban.Location = new System.Drawing.Point(87, 241);
            this.banka_iban.Name = "banka_iban";
            this.banka_iban.Size = new System.Drawing.Size(139, 20);
            this.banka_iban.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Hesap No";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(32, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(107, 38);
            this.simpleButton1.TabIndex = 43;
            this.simpleButton1.Text = "Kaydet";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(145, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(107, 38);
            this.simpleButton2.TabIndex = 44;
            this.simpleButton2.Text = "Silme";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(258, 12);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(107, 38);
            this.simpleButton3.TabIndex = 45;
            this.simpleButton3.Text = "Update";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // frmBankalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 561);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.simpleButton1);
            this.Name = "frmBankalar";
            this.Text = "frmBankalar";
            this.Load += new System.EventHandler(this.frmBankalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banka_firma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banka_ilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banka_il.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banka_ad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banka_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banka_yet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banka_hesap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banka_hesapturu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banka_sube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banka_iban.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox banka_tel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.ComboBoxEdit banka_ilce;
        private DevExpress.XtraEditors.ComboBoxEdit banka_il;
        private DevExpress.XtraEditors.TextEdit banka_ad;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit banka_id;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit banka_yet;
        private DevExpress.XtraEditors.TextEdit banka_hesap;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit banka_hesapturu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit banka_sube;
        private DevExpress.XtraEditors.TextEdit banka_iban;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.GridLookUpEdit banka_firma;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}