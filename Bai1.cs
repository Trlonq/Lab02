using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.Security.Cryptography;

namespace Lab2
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            // Tạo đói tượng mới, điều kiện để mở thành công dialog và hiện nội dung vào richtextbox.
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs1 = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs1);
                string str = sr.ReadToEnd();
                richTextBox1.Text = str;
                fs1.Close();
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            // Lưu nội dung từ richtextbox vào file mới và dùng hàm toupper để chuyển thành in hoa.
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs2 = new FileStream(sfd.FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs2);
                sw.Write(richTextBox1.Text.ToUpper());
                sw.Flush();
                fs2.Close();
            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
