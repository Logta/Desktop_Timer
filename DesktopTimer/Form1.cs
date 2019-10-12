using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopTimer
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            TopMost = Properties.Settings.Default.TopMost;
            //タイマー起動
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 現在時を取得
            DateTime datetime = DateTime.Now;

            label1.Text = datetime.ToLongTimeString();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            var f = new SettingForm(Properties.Settings.Default.TopMost);
            f.ShowDialog(this);
            TopMost = f.topMost;
            Properties.Settings.Default.TopMost = f.TopMost;
            Properties.Settings.Default.Save();
        }

        //マウスのクリック位置を記憶
        private Point mousePoint;

        //Form1のMouseDownイベントハンドラ
        private void Form1_MouseDown(object sender,
            System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                //位置を記憶する
                mousePoint = new Point(e.X, e.Y);
            }
        }

        private void Form1_MouseMove(object sender,
            System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
