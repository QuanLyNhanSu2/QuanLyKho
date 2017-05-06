namespace QuanLyKho.View
{
    partial class frmlaylaimatkhau
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
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnlaymatkhau = new System.Windows.Forms.Button();
            this.txtnhapemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttendangnhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(283, 126);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 15;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // btnlaymatkhau
            // 
            this.btnlaymatkhau.Location = new System.Drawing.Point(161, 126);
            this.btnlaymatkhau.Name = "btnlaymatkhau";
            this.btnlaymatkhau.Size = new System.Drawing.Size(92, 23);
            this.btnlaymatkhau.TabIndex = 14;
            this.btnlaymatkhau.Text = "Lấy lại mật khẩu";
            this.btnlaymatkhau.UseVisualStyleBackColor = true;
            // 
            // txtnhapemail
            // 
            this.txtnhapemail.Location = new System.Drawing.Point(131, 90);
            this.txtnhapemail.Name = "txtnhapemail";
            this.txtnhapemail.Size = new System.Drawing.Size(282, 20);
            this.txtnhapemail.TabIndex = 13;
            this.txtnhapemail.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nhập lại email";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(131, 57);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(282, 20);
            this.txtemail.TabIndex = 11;
            this.txtemail.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email";
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.Location = new System.Drawing.Point(131, 24);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(282, 20);
            this.txttendangnhap.TabIndex = 9;
            this.txttendangnhap.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên đăng nhập";
            // 
            // frmlaylaimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 164);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnlaymatkhau);
            this.Controls.Add(this.txtnhapemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttendangnhap);
            this.Controls.Add(this.label1);
            this.Name = "frmlaylaimatkhau";
            this.Text = "Lấy lại Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnlaymatkhau;
        private System.Windows.Forms.TextBox txtnhapemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttendangnhap;
        private System.Windows.Forms.Label label1;
    }
}