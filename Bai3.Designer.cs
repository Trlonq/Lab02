namespace Lab2
{
    partial class Bai3
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
            btnXoa = new Button();
            richTextBox1 = new RichTextBox();
            btnGhi = new Button();
            btnDoc = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(63, 309);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(222, 84);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "XÓA";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(340, 47);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(531, 522);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // btnGhi
            // 
            btnGhi.Location = new Point(63, 196);
            btnGhi.Name = "btnGhi";
            btnGhi.Size = new Size(222, 84);
            btnGhi.TabIndex = 5;
            btnGhi.Text = "GHI FILE";
            btnGhi.UseVisualStyleBackColor = true;
            btnGhi.Click += btnGhi_Click;
            // 
            // btnDoc
            // 
            btnDoc.Location = new Point(63, 83);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(222, 84);
            btnDoc.TabIndex = 4;
            btnDoc.Text = "ĐỌC FILE";
            btnDoc.UseVisualStyleBackColor = true;
            btnDoc.Click += btnDoc_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(63, 438);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(222, 84);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 654);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(richTextBox1);
            Controls.Add(btnGhi);
            Controls.Add(btnDoc);
            Name = "Bai3";
            Text = "Bai3";
            ResumeLayout(false);
        }

        #endregion

        private Button btnXoa;
        private RichTextBox richTextBox1;
        private Button btnGhi;
        private Button btnDoc;
        private Button btnThoat;
    }
}