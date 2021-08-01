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
    public partial class Teacher_Actions : UserControl
    {
        Form1 frm1;
        Form2 frm2;
        person p;
        CoursemanagmentEntities2 db;
        public Teacher_Actions(Form1 frm1 , Form2 frm2 , person p, CoursemanagmentEntities2 db)
        {
            InitializeComponent();
            this.frm1 = frm1;
            this.frm2 = frm2;
            this.p = p;
            this.db = db;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.frm2.flowLayoutPanel1.Controls.Clear();

            List<course> courses = db.Teaacher_course.Where(p => p.person_id == this.p.id).Select(pr => pr.course).ToList();
                              
                                   
            foreach (course i in courses)
            {
                this.frm2.flowLayoutPanel1.Controls.Add(new course_Data(i, frm2, this.p,this.db));
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            this.frm2.flowLayoutPanel1.Controls.Clear();
            this.frm2.flowLayoutPanel1.Controls.Add(new Profile(this.p,this.frm2));
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
