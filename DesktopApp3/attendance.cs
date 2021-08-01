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
    public partial class attendance : UserControl
    {
        CoursemanagmentEntities2 db;
        Form2 frm;
        int courseid;
        int studentid;
        public attendance(CoursemanagmentEntities2 db, Form2 frm)
        {
            InitializeComponent();
            this.db = db;
            this.frm = frm;
        }

        private void attendance_Load(object sender, EventArgs e)
        {
            List<course> crs = db.courses.ToList();
            foreach(course i in crs)
            {
                this.bunifuDropdown3.Items.Add(i.name);
            }
         
        }

        private void bunifuDropdown2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string courseselectes = bunifuDropdown3.SelectedItem.ToString();
             courseid = db.courses.Where(x => x.name.Equals(courseselectes)).Select(c=>c.id).FirstOrDefault();
            List<person> persons = db.student_course.Where(x => x.course_id.Equals(courseid)).Select(pre=>pre.person).ToList();
            foreach (person i in persons) {
                bunifuDropdown1.Items.Add(i.name);
            }
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            try
            {
                db_Attendance sc = new db_Attendance();
                sc.studID = studentid;
                sc.courseID = courseid;
                db.db_Attendance.Add(sc);
                db.SaveChanges();
                bunifuDropdown1.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentid = db.people.Where(x => x.name.Equals(bunifuDropdown1.SelectedItem.ToString())).Select(per=> per.id).FirstOrDefault();
            


        }
    }
}
