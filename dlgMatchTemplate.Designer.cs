namespace VisionProcessor
{
    partial class dlgMatchTemplate
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
            this.listMode = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picTempl = new System.Windows.Forms.PictureBox();
            this.chkRotate = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAngleStart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAngleEnd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTempl)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(287, 378);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(86, 378);
            // 
            // listMode
            // 
            this.listMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listMode.FormattingEnabled = true;
            this.listMode.Items.AddRange(new object[] {
            "SHT",
            "MHT",
            "PPHT"});
            this.listMode.Location = new System.Drawing.Point(102, 20);
            this.listMode.Name = "listMode";
            this.listMode.Size = new System.Drawing.Size(272, 28);
            this.listMode.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "模式";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "模板";
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(102, 63);
            this.txtImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(272, 26);
            this.txtImage.TabIndex = 30;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(381, 63);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(59, 26);
            this.btnBrowse.TabIndex = 31;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picTempl
            // 
            this.picTempl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTempl.Location = new System.Drawing.Point(86, 106);
            this.picTempl.Name = "picTempl";
            this.picTempl.Size = new System.Drawing.Size(301, 198);
            this.picTempl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTempl.TabIndex = 32;
            this.picTempl.TabStop = false;
            // 
            // chkRotate
            // 
            this.chkRotate.AutoSize = true;
            this.chkRotate.Location = new System.Drawing.Point(40, 325);
            this.chkRotate.Name = "chkRotate";
            this.chkRotate.Size = new System.Drawing.Size(56, 24);
            this.chkRotate.TabIndex = 33;
            this.chkRotate.Text = "旋转";
            this.chkRotate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "起始角度";
            // 
            // txtAngleStart
            // 
            this.txtAngleStart.Location = new System.Drawing.Point(173, 323);
            this.txtAngleStart.Name = "txtAngleStart";
            this.txtAngleStart.Size = new System.Drawing.Size(68, 26);
            this.txtAngleStart.TabIndex = 35;
            this.txtAngleStart.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "终止角度";
            // 
            // txtAngleEnd
            // 
            this.txtAngleEnd.Location = new System.Drawing.Point(318, 323);
            this.txtAngleEnd.Name = "txtAngleEnd";
            this.txtAngleEnd.Size = new System.Drawing.Size(69, 26);
            this.txtAngleEnd.TabIndex = 35;
            this.txtAngleEnd.Text = "0";
            // 
            // dlgMatchTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 430);
            this.Controls.Add(this.txtAngleEnd);
            this.Controls.Add(this.txtAngleStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkRotate);
            this.Controls.Add(this.picTempl);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.listMode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Name = "dlgMatchTemplate";
            this.Text = "模板匹配";
            this.Load += new System.EventHandler(this.dlgMatchTemplate_Load);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.listMode, 0);
            this.Controls.SetChildIndex(this.txtImage, 0);
            this.Controls.SetChildIndex(this.btnBrowse, 0);
            this.Controls.SetChildIndex(this.picTempl, 0);
            this.Controls.SetChildIndex(this.chkRotate, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtAngleStart, 0);
            this.Controls.SetChildIndex(this.txtAngleEnd, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picTempl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listMode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox picTempl;
        private System.Windows.Forms.CheckBox chkRotate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAngleStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAngleEnd;
    }
}