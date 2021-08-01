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
    public partial class course_Data : UserControl
    {
        course c;
        Form2 frm;
        person p;
        CoursemanagmentEntities2 db;
        public course_Data(course c,Form2 frm, person p, CoursemanagmentEntities2 db)
        {
            InitializeComponent();
            this.c = c;
            this.db = db;
            this.frm = frm;

            this.p = p;
            this.label1.Text = this.c.name;
            this.label2.Text = this.c.Teaacher_course.Where(x => x.course_id.Equals(c.id)).Select(pre => pre.person.name).FirstOrDefault();
            this.bunifuDatePicker2.Value = this.c.sdate;
            this.bunifuDatePicker1.Value = this.c.edate;
            this.bunifuDatePicker1.Enabled = false;
            this.bunifuDatePicker2.Enabled = false;

            if(p.C_isstudent)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                label3.Visible = true;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          

        }

        private void bunifuDatePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frm.flowLayoutPanel1.Controls.Clear();
            frm.flowLayoutPanel1.Controls.Add(new Add_C_info(frm,c));
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.frm.flowLayoutPanel1.Controls.Clear();
            this.frm.flowLayoutPanel1.Controls.Add(new Show_Student_of_Course(this.db , this.p , this.c , this.frm));

        }

        private void label3_Click(object sender, EventArgs e)
        {
            try
            {

                person temp = db.student_course.Where(x => x.person_id.Equals(p.id)).Select(pre=> pre.person).FirstOrDefault();
                if(temp != null)
                {
                    MessageBox.Show("you are already Registed !");
                    return;
                }

         student_course sc = new student_course();
            sc.person_id = p.id;
            sc.course_id = c.id;
            db.student_course.Add(sc);
            db.SaveChanges();
                MessageBox.Show("Register Success !");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

   
        }

        private void label3_Enter(object sender, EventArgs e)
        { 
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        
        {
            label3.ForeColor = Color.DodgerBlue;

        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Gainsboro;
        }
    }
}
