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
    public partial class Add_Course : UserControl
    {
        Form2 frm2;
        person p;
        CoursemanagmentEntities2 db;

        public Add_Course(Form2 frm2, person p, CoursemanagmentEntities2 db)
        {
            InitializeComponent();
            this.frm2 = frm2;
            this.p = p;
            this.db = db;
        }
       
        private void bunifuDatePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.DodgerBlue;

        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Silver;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.frm2.flowLayoutPanel1.Controls.Clear();
            this.frm2.flowLayoutPanel1.Controls.Add(new Add_C_info(this.frm2,this.p,this.db));

        }
    }
}
