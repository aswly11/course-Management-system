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
    public partial class Add_C_info : UserControl
    {
        person p;
        Form2 frm2;
        CoursemanagmentEntities2 db;
        public Add_C_info(Form2 frm2, person p, CoursemanagmentEntities2 db)
        {
            InitializeComponent();
            this.frm2 = frm2;
            this.p = p;
            this.db = db;
        }
        course crs;
        public Add_C_info(Form2 frm2, course c)
        {
            InitializeComponent();
            this.frm2 = frm2;
            this.crs = c;
            this.bunifuButton8.Text = "Edit";
            name_profile.Text = c.name;
            bunifuDatePicker2.Value = c.sdate;
            bunifuDatePicker1.Value = c.edate;
            int TeacherID = frm2.db.Teaacher_course.Where(x => x.course_id == c.id).Select(x => x.person_id).FirstOrDefault();
            person p = frm2.db.people.Where(x => x.id == TeacherID).FirstOrDefault();

            List<person> persons = frm2.db.people.Where(x => x.C_isteacher == true).ToList();
            foreach (person i in persons)
            {
                Teachersdropdown.Items.Add(i.name);
                if (i.name==p.name)
                {
                    Teachersdropdown.SelectedItem = i.name;

                }
            }
           


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {

            if(bunifuButton8.Text== "Edit")
            {
                crs.name = name_profile.Text;
                person p = frm2.db.people.Where(x => x.name.Equals(Teachersdropdown.SelectedItem.ToString())).FirstOrDefault();
                crs.sdate = bunifuDatePicker2.Value;
                crs.edate = bunifuDatePicker1.Value;
                frm2.db.Entry(crs).State = System.Data.Entity.EntityState.Modified;
                frm2.db.SaveChanges();

                course temp = frm2.db.courses.Where(x => x.name.Equals(name_profile.Text)).FirstOrDefault();
                Teaacher_course tc = frm2.db.Teaacher_course.Where(x => x.course_id.Equals(crs.id)).FirstOrDefault();
                tc.course_id = temp.id;
                string teachername = Teachersdropdown.SelectedItem.ToString();
                person per = frm2.db.people.Where(x => x.name.Equals(teachername)).FirstOrDefault();

                tc.person_id = per.id;
                 frm2.db.Entry(tc).State = System.Data.Entity.EntityState.Modified;
                frm2.db.SaveChanges();

            }
            else {
                try
                {

                    course c = new course();
                    c.name = name_profile.Text;
                    person p = frm2.db.people.Where(x => x.name.Equals(Teachersdropdown.SelectedItem.ToString())).FirstOrDefault();
                    c.sdate = bunifuDatePicker2.Value;
                    c.edate = bunifuDatePicker1.Value;
                    frm2.db.courses.Add(c);
                    frm2.db.SaveChanges();
                    course temp = frm2.db.courses.Where(x => x.name.Equals(name_profile.Text)).FirstOrDefault();
                    Teaacher_course tc = new Teaacher_course();
                    tc.course_id = temp.id;
                    tc.person_id = p.id;
                    frm2.db.Teaacher_course.Add(tc);
                    frm2.db.SaveChanges();
                    this.frm2.flowLayoutPanel1.Controls.Clear();
                    List<course> courses = frm2.db.courses.ToList();
                    foreach (course i in courses)
                    {
                        this.frm2.flowLayoutPanel1.Controls.Add(new course_Data(i, frm2,this.p,this.db));
                    }
                    this.frm2.flowLayoutPanel1.Controls.Add(new Add_Course(this.frm2,this.p,this.db));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Add_C_info_Load(object sender, EventArgs e)
        {
            Teachersdropdown.Items.Clear();
            List<person> persons = frm2.db.people.Where(x => x.C_isteacher == true).ToList();
            foreach(person i in persons)
            {
                Teachersdropdown.Items.Add(i.name);
                
            }
            
        }
    }
}
