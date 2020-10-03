namespace EvdeCalisma
{
    partial class frmGider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGider));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gider_yil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gider_ay = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gider_not = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gider_maas = new DevExpress.XtraEditors.TextEdit();
            this.gider_id = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.gider_inter = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gider_elek = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gider_su = new DevExpress.XtraEditors.TextEdit();
            this.gider_dogal = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gider_yil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gider_ay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gider_maas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gider_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gider_inter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gider_elek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gider_su.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gider_dogal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-1, 61);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(676, 386);
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
            this.groupControl1.Controls.Add(this.gider_yil);
            this.groupControl1.Controls.Add(this.gider_ay);
            this.groupControl1.Controls.Add(this.gider_not);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.gider_maas);
            this.groupControl1.Controls.Add(this.gider_id);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.gider_inter);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.gider_elek);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.gider_su);
            this.groupControl1.Controls.Add(this.gider_dogal);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Location = new System.Drawing.Point(690, 61);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(239, 426);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // gider_yil
            // 
            this.gider_yil.Location = new System.Drawing.Point(87, 94);
            this.gider_yil.Name = "gider_yil";
            this.gider_yil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gider_yil.Properties.Items.AddRange(new object[] {
            "2017",
            "2018"});
            this.gider_yil.Size = new System.Drawing.Size(144, 20);
            this.gider_yil.TabIndex = 42;
            // 
            // gider_ay
            // 
            this.gider_ay.Location = new System.Drawing.Point(87, 63);
            this.gider_ay.Name = "gider_ay";
            this.gider_ay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gider_ay.Properties.Items.AddRange(new object[] {
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
            this.gider_ay.Size = new System.Drawing.Size(144, 20);
            this.gider_ay.TabIndex = 41;
            // 
            // gider_not
            // 
            this.gider_not.Location = new System.Drawing.Point(69, 311);
            this.gider_not.Name = "gider_not";
            this.gider_not.Size = new System.Drawing.Size(165, 96);
            this.gider_not.TabIndex = 40;
            this.gider_not.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Id";
            // 
            // gider_maas
            // 
            this.gider_maas.Location = new System.Drawing.Point(87, 267);
            this.gider_maas.Name = "gider_maas";
            this.gider_maas.Size = new System.Drawing.Size(144, 20);
            this.gider_maas.TabIndex = 39;
            // 
            // gider_id
            // 
            this.gider_id.Location = new System.Drawing.Point(87, 26);
            this.gider_id.Name = "gider_id";
            this.gider_id.Size = new System.Drawing.Size(144, 20);
            this.gider_id.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Notlar";
            // 
            // gider_inter
            // 
            this.gider_inter.Location = new System.Drawing.Point(87, 241);
            this.gider_inter.Name = "gider_inter";
            this.gider_inter.Size = new System.Drawing.Size(144, 20);
            this.gider_inter.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Ay";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Maaslar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Yıl";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "İnternet";
            // 
            // gider_elek
            // 
            this.gider_elek.Location = new System.Drawing.Point(87, 129);
            this.gider_elek.Name = "gider_elek";
            this.gider_elek.Size = new System.Drawing.Size(144, 20);
            this.gider_elek.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Elektrik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Doğalgaz";
            // 
            // gider_su
            // 
            this.gider_su.Location = new System.Drawing.Point(87, 168);
            this.gider_su.Name = "gider_su";
            this.gider_su.Size = new System.Drawing.Size(144, 20);
            this.gider_su.TabIndex = 29;
            // 
            // gider_dogal
            // 
            this.gider_dogal.Location = new System.Drawing.Point(87, 204);
            this.gider_dogal.Name = "gider_dogal";
            this.gider_dogal.Size = new System.Drawing.Size(144, 20);
            this.gider_dogal.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Su";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(147, 42);
            this.simpleButton1.TabIndex = 43;
            this.simpleButton1.Text = "Kaydet";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(165, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(147, 42);
            this.simpleButton2.TabIndex = 44;
            this.simpleButton2.Text = "Update";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(318, 12);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(147, 42);
            this.simpleButton3.TabIndex = 45;
            this.simpleButton3.Text = "Delete";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // frmGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 501);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmGider";
            this.Text = "frmGider";
            this.Load += new System.EventHandler(this.frmGider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gider_yil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gider_ay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gider_maas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gider_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gider_inter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gider_elek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gider_su.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gider_dogal.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ComboBoxEdit gider_yil;
        private DevExpress.XtraEditors.ComboBoxEdit gider_ay;
        private System.Windows.Forms.RichTextBox gider_not;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit gider_maas;
        private DevExpress.XtraEditors.TextEdit gider_id;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit gider_inter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit gider_elek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit gider_su;
        private DevExpress.XtraEditors.TextEdit gider_dogal;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}