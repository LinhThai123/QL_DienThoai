
namespace QuanLyCuaHangBanDienThoai
{
    partial class ThongKeSLĐT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeSLĐT));
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.crvTTSL = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnHien = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Chưa Được Bán",
            "Bán Hết Hàng",
            "Sắp hết"});
            this.cbTrangThai.Location = new System.Drawing.Point(99, 33);
            this.cbTrangThai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(160, 24);
            this.cbTrangThai.TabIndex = 1;
            // 
            // crvTTSL
            // 
            this.crvTTSL.ActiveViewIndex = -1;
            this.crvTTSL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvTTSL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvTTSL.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvTTSL.Location = new System.Drawing.Point(16, 87);
            this.crvTTSL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.crvTTSL.Name = "crvTTSL";
            this.crvTTSL.Size = new System.Drawing.Size(1034, 451);
            this.crvTTSL.TabIndex = 1;
            this.crvTTSL.ToolPanelWidth = 267;
            // 
            // btnHien
            // 
            this.btnHien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHien.BackgroundImage")));
            this.btnHien.FlatAppearance.BorderSize = 0;
            this.btnHien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHien.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHien.Location = new System.Drawing.Point(311, 30);
            this.btnHien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHien.Name = "btnHien";
            this.btnHien.Size = new System.Drawing.Size(100, 28);
            this.btnHien.TabIndex = 2;
            this.btnHien.Text = "Hiện";
            this.btnHien.UseVisualStyleBackColor = true;
            this.btnHien.Click += new System.EventHandler(this.btnHien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Trạng thái :";
            // 
            // ThongKeSLĐT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHien);
            this.Controls.Add(this.crvTTSL);
            this.Controls.Add(this.cbTrangThai);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ThongKeSLĐT";
            this.Text = "Thống kê trạng thái số lượng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTrangThai;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvTTSL;
        private System.Windows.Forms.Button btnHien;
        private System.Windows.Forms.Label label1;
    }
}