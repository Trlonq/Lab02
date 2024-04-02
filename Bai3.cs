using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Lab2
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            // đọc file readtoend và đưa nội dung vào richtextbox
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            //lưu richtextbox thành từng dòng sau đó tính từng dòng bằng hàm Tinh
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string[] lines = richTextBox1.Lines;
                FileStream fs2 = new FileStream(sfd.FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs2);
                foreach (string line in lines)
                {
                    double kq = Tinh(line);
                    sw.WriteLine($"{line} = {kq}");
                    
                    
                }
                sw.Flush();
                fs2.Close();
            }
        }

        static double Tinh(string nd)
        {
            // Tách các phép tính bằng các dấu cộng trừ 
            string[] parts = nd.Split(new char[] { '+', '-' }, StringSplitOptions.RemoveEmptyEntries);

            // lưu kq là ptử đầu tiên sau đó dùng vòng lặp để tính từng phép tính trong hàng đó
            double kq = double.Parse(parts[0]);
            for (int i = 1; i < parts.Length; i++)
            {
                char operation = nd[parts[i - 1].Length];
                double operand = double.Parse(parts[i]);
                if (operation == '+')
                    kq += operand;
                else if (operation == '-')
                    kq -= operand;
            }

            return kq;
        }





    }
}
