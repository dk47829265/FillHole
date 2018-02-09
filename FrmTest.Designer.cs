namespace BilateralFilter
{
    partial class FrmTest
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
            this.CmdOpen = new System.Windows.Forms.Button();
            this.SrcPic = new System.Windows.Forms.PictureBox();
            this.CmdFillHoleFore = new System.Windows.Forms.Button();
            this.CmdFillHoleBack = new System.Windows.Forms.Button();
            this.DestPic = new System.Windows.Forms.PictureBox();
            this.CmdRestore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SrcPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestPic)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdOpen
            // 
            this.CmdOpen.Location = new System.Drawing.Point(12, 17);
            this.CmdOpen.Name = "CmdOpen";
            this.CmdOpen.Size = new System.Drawing.Size(68, 30);
            this.CmdOpen.TabIndex = 36;
            this.CmdOpen.Text = "打开图像";
            this.CmdOpen.UseVisualStyleBackColor = true;
            this.CmdOpen.Click += new System.EventHandler(this.CmdOpen_Click);
            // 
            // SrcPic
            // 
            this.SrcPic.Location = new System.Drawing.Point(12, 68);
            this.SrcPic.Name = "SrcPic";
            this.SrcPic.Size = new System.Drawing.Size(521, 381);
            this.SrcPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SrcPic.TabIndex = 33;
            this.SrcPic.TabStop = false;
            // 
            // CmdFillHoleFore
            // 
            this.CmdFillHoleFore.Location = new System.Drawing.Point(190, 17);
            this.CmdFillHoleFore.Name = "CmdFillHoleFore";
            this.CmdFillHoleFore.Size = new System.Drawing.Size(102, 30);
            this.CmdFillHoleFore.TabIndex = 38;
            this.CmdFillHoleFore.Text = "填充前景孔洞";
            this.CmdFillHoleFore.UseVisualStyleBackColor = true;
            this.CmdFillHoleFore.Click += new System.EventHandler(this.CmdFillHole_Click);
            // 
            // CmdFillHoleBack
            // 
            this.CmdFillHoleBack.Location = new System.Drawing.Point(309, 17);
            this.CmdFillHoleBack.Name = "CmdFillHoleBack";
            this.CmdFillHoleBack.Size = new System.Drawing.Size(150, 30);
            this.CmdFillHoleBack.TabIndex = 39;
            this.CmdFillHoleBack.Text = "填充背景孔洞";
            this.CmdFillHoleBack.UseVisualStyleBackColor = true;
            this.CmdFillHoleBack.Click += new System.EventHandler(this.CmdFillHoleBack_Click);
            // 
            // DestPic
            // 
            this.DestPic.Location = new System.Drawing.Point(553, 68);
            this.DestPic.Name = "DestPic";
            this.DestPic.Size = new System.Drawing.Size(521, 381);
            this.DestPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DestPic.TabIndex = 40;
            this.DestPic.TabStop = false;
            // 
            // CmdRestore
            // 
            this.CmdRestore.Location = new System.Drawing.Point(103, 17);
            this.CmdRestore.Name = "CmdRestore";
            this.CmdRestore.Size = new System.Drawing.Size(68, 30);
            this.CmdRestore.TabIndex = 41;
            this.CmdRestore.Text = "恢复";
            this.CmdRestore.UseVisualStyleBackColor = true;
            this.CmdRestore.Click += new System.EventHandler(this.CmdRestore_Click);
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 460);
            this.Controls.Add(this.CmdRestore);
            this.Controls.Add(this.DestPic);
            this.Controls.Add(this.CmdFillHoleBack);
            this.Controls.Add(this.CmdFillHoleFore);
            this.Controls.Add(this.CmdOpen);
            this.Controls.Add(this.SrcPic);
            this.MaximizeBox = false;
            this.Name = "FrmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "基于直方图的全局二值化算法";
            this.Load += new System.EventHandler(this.FrmTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SrcPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SrcPic;
        private System.Windows.Forms.Button CmdOpen;
        private System.Windows.Forms.Button CmdFillHoleFore;
        private System.Windows.Forms.Button CmdFillHoleBack;
        private System.Windows.Forms.PictureBox DestPic;
        private System.Windows.Forms.Button CmdRestore;
    }
}