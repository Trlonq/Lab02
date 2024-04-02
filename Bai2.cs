using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs1 = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs1);

                //hiển thị trong richtb
                string str = sr.ReadToEnd();
                richTextBox1.Text = str;

                //tên file như gợi ý
                txtTenfile.Text = ofd.SafeFileName.ToString();

                //kích thước
                txtKichthuoc.Text = richTextBox1.TextLength.ToString() + " bytes";

                //url
                txtUrl.Text = fs1.Name.ToString();

                /* tách nội dung từ những chỗ /n xuống dòng sau đó đếm bằng hàm Line */
                string text = richTextBox1.Text;
                string[] lines = text.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                int linesCount = lines.Length;
                txtSodong.Text = linesCount.ToString() + " dòng";

                /* tách nd từ những chỗ có khoảng trắng, tab, xuống dòng, đưa con trỏ về đầu dòng 
                 * Sau đó đếm chiều dài */
                string[] words = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                int wordCount = words.Length;
                txtSotu.Text = (wordCount + " từ");


                //đếm ký tự bằng length
                txtSokytu.Text = (text.Length + " ký tự");


                fs1.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
