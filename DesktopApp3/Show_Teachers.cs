using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp3
{
    public partial class Show_Teachers : UserControl
    {
        person p;
        public Show_Teachers(person p)
        {
            InitializeComponent();
            this.p = p;
            label1.Text = p.id.ToString();
            label2.Text = p.name.ToString();
            label3.Text = p.phone.ToString();
        }
        public Show_Teachers()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
