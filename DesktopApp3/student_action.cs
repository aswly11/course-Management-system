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
    public partial class student_action : UserControl
    {
        Form1 frm1;
        Form2 frm2;
        person p;
        CoursemanagmentEntities2 db;
        public student_action(Form1 frm1, Form2 frm2, person p, CoursemanagmentEntities2 db)
        {
            InitializeComponent();
            this.frm1 = frm1;
            this.frm2 = frm2;
            this.p = p;
            this.db = db;
            InitializeComponent();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.frm2.Hide();
            this.frm1.Show();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.frm2.flowLayoutPanel1.Controls.Clear();
            List<course> courses = db.courses.ToList();
            foreach (course i in courses)
            {
                this.frm2.flowLayoutPanel1.Controls.Add(new course_Data(i, frm2,this.p,this.db));
            }

        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            this.frm2.flowLayoutPanel1.Controls.Clear();
            this.frm2.flowLayoutPanel1.Controls.Add(new Profile(this.p,this.frm2));
         
        }
    }
}
