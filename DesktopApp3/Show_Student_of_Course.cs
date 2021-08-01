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
    public partial class Show_Student_of_Course : UserControl
    {
        CoursemanagmentEntities2 db;
        Form2 frm;
        course c;
        person p;

        public Show_Student_of_Course(CoursemanagmentEntities2 db , person p , course c,Form2 frm)
        {
            InitializeComponent();
            this.db = db;
            this.p = p;
            this.c = c;
            this.frm = frm;

            this.label1.Text = this.c.name;
            this.label2.Text = this.c.Teaacher_course.Where(x => x.course_id.Equals(c.id)).Select(pre => pre.person.name).FirstOrDefault();
            this.bunifuDatePicker2.Value = c.sdate;
            this.bunifuDatePicker1.Value = c.edate;
        }

        private void Show_Student_of_Course_Load(object sender, EventArgs e)
        {
            List<person> studs = db.student_course.Where(x => x.course_id == this.c.id).Select(prs => prs.person).ToList();
            foreach(person i in studs)
            {
                this.flowLayoutPanel1.Controls.Add(new Show_Students(i));


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
