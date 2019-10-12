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
    public partial class SettingForm : Form
    {
        public bool topMost = false;
        public SettingForm(bool top)
        {
            checkBox1.Checked = topMost = top;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            topMost = checkBox1.Checked;
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
