
namespace QuanLyCuaHangBanDienThoai
{
    partial class FindByPrice
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
            this.crystalReportFindPrice = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportFindPrice
            // 
            this.crystalReportFindPrice.ActiveViewIndex = -1;
            this.crystalReportFindPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportFindPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportFindPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportFindPrice.Location = new System.Drawing.Point(0, 0);
            this.crystalReportFindPrice.Name = "crystalReportFindPrice";
            this.crystalReportFindPrice.Size = new System.Drawing.Size(800, 450);
            this.crystalReportFindPrice.TabIndex = 0;
            // 
            // FindByPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportFindPrice);
            this.Name = "FindByPrice";
            this.Text = "FindByPrice";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportFindPrice;
    }
}