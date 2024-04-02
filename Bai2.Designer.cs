namespace Lab2
{
    partial class Bai2
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
            btnDoc = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtKichthuoc = new TextBox();
            txtTenfile = new TextBox();
            txtUrl = new TextBox();
            txtSodong = new TextBox();
            txtSotu = new TextBox();
            txtSokytu = new TextBox();
            btnThoat = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btnDoc
            // 
            btnDoc.Location = new Point(31, 31);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(611, 94);
            btnDoc.TabIndex = 0;
            btnDoc.Text = "ĐỌC FILE";
            btnDoc.UseVisualStyleBackColor = true;
            btnDoc.Click += btnDoc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(31, 172);
            label1.Name = "label1";
            label1.Size = new Size(100, 37);
            label1.TabIndex = 1;
            label1.Text = "Tên file";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(31, 246);
            label2.Name = "label2";
            label2.Size = new Size(142, 37);
            label2.TabIndex = 2;
            label2.Text = "Kích thước";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(31, 327);
            label3.Name = "label3";
            label3.Size = new Size(193, 37);
            label3.TabIndex = 3;
            label3.Text = "Đường dẫn Url";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(31, 409);
            label4.Name = "label4";
            label4.Size = new Size(117, 37);
            label4.TabIndex = 4;
            label4.Text = "Số dòng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(31, 489);
            label5.Name = "label5";
            label5.Size = new Size(79, 37);
            label5.TabIndex = 5;
            label5.Text = "Số từ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(31, 567);
            label6.Name = "label6";
            label6.Size = new Size(112, 37);
            label6.TabIndex = 6;
            label6.Text = "Số ký tự";
            // 
            // txtKichthuoc
            // 
            txtKichthuoc.Location = new Point(229, 247);
            txtKichthuoc.Name = "txtKichthuoc";
            txtKichthuoc.Size = new Size(412, 39);
            txtKichthuoc.TabIndex = 7;
            // 
            // txtTenfile
            // 
            txtTenfile.Location = new Point(230, 170);
            txtTenfile.Name = "txtTenfile";
            txtTenfile.Size = new Size(412, 39);
            txtTenfile.TabIndex = 8;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(230, 328);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(412, 39);
            txtUrl.TabIndex = 9;
            // 
            // txtSodong
            // 
            txtSodong.Location = new Point(230, 410);
            txtSodong.Name = "txtSodong";
            txtSodong.Size = new Size(412, 39);
            txtSodong.TabIndex = 10;
            // 
            // txtSotu
            // 
            txtSotu.Location = new Point(229, 487);
            txtSotu.Name = "txtSotu";
            txtSotu.Size = new Size(412, 39);
            txtSotu.TabIndex = 11;
            // 
            // txtSokytu
            // 
            txtSokytu.Location = new Point(229, 565);
            txtSokytu.Name = "txtSokytu";
            txtSokytu.Size = new Size(412, 39);
            txtSokytu.TabIndex = 12;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1224, 628);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(254, 64);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(714, 31);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(764, 573);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "";
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1553, 721);
            Controls.Add(richTextBox1);
            Controls.Add(btnThoat);
            Controls.Add(txtSokytu);
            Controls.Add(txtSotu);
            Controls.Add(txtSodong);
            Controls.Add(txtUrl);
            Controls.Add(txtTenfile);
            Controls.Add(txtKichthuoc);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDoc);
            Name = "Bai2";
            Text = "Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDoc;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtKichthuoc;
        private TextBox txtTenfile;
        private TextBox txtUrl;
        private TextBox txtSodong;
        private TextBox txtSotu;
        private TextBox txtSokytu;
        private Button btnThoat;
        private RichTextBox richTextBox1;
    }
}