namespace Lab2
{
    partial class Bai1
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
            btnGhi = new Button();
            richTextBox1 = new RichTextBox();
            btnXoa = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // btnDoc
            // 
            btnDoc.Location = new Point(73, 71);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(222, 84);
            btnDoc.TabIndex = 0;
            btnDoc.Text = "ĐỌC FILE";
            btnDoc.UseVisualStyleBackColor = true;
            btnDoc.Click += btnDoc_Click;
            // 
            // btnGhi
            // 
            btnGhi.Location = new Point(73, 184);
            btnGhi.Name = "btnGhi";
            btnGhi.Size = new Size(222, 84);
            btnGhi.TabIndex = 1;
            btnGhi.Text = "GHI FILE";
            btnGhi.UseVisualStyleBackColor = true;
            btnGhi.Click += btnGhi_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(350, 35);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(531, 522);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(73, 297);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(222, 84);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "XÓA";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(73, 415);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(222, 84);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 614);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(richTextBox1);
            Controls.Add(btnGhi);
            Controls.Add(btnDoc);
            Name = "Bai1";
            Text = "Bai1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDoc;
        private Button btnGhi;
        private RichTextBox richTextBox1;
        private Button btnXoa;
        private Button btnThoat;
    }
}