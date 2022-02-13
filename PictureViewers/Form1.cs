using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewers {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }


        private void showBT_Click(object sender, EventArgs e) {
            // 사진 표시 버튼을 누르면 파일 목록을 보여준다. 사진을 클릭하고 ok 하면 사진을 load 합니다.
            if (openFileDialog1.ShowDialog() == DialogResult.OK) { 
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clearBT_Click(object sender, EventArgs e) {
            pictureBox1.Image = null; 
        }

        private void backgroundBT_Click(object sender, EventArgs e) {
            if(colorDialog1.ShowDialog() == DialogResult.OK) {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void closeBT_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if (checkBox1.Checked) {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            } else {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;

            }
        }
    }
}
