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
    public partial class adminactions : UserControl
    {
        Form1 frm1;    
        Form2 frm2;
        person p;
        CoursemanagmentEntities2 db;
        public adminactions(Form2 frm, Form1 frm1,person p , CoursemanagmentEntities2 db )
        {
            InitializeComponent();
            this.frm2 = frm;
            this.p = p;
            this.frm1 = frm1;
            this.db = db;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.frm2.flowLayoutPanel1.Controls.Clear();
            List<course> courses = db.courses.ToList();
            foreach(course i in courses)
            {
                this.frm2.flowLayoutPanel1.Controls.Add(new course_Data(i,frm2,this.p,this.db));
            }
            this.frm2.flowLayoutPanel1.Controls.Add(new Add_Course(this.frm2,this.p,this.db));
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            this.frm2.flowLayoutPanel1.Controls.Clear();
            this.frm2.flowLayoutPanel1.Controls.Add(new Profile(this.p,frm2));
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

            frm2.Hide();
            frm1.Show();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            this.frm2.flowLayoutPanel1.Controls.Clear();
            List<person> persons = db.people.Where(x=> x.C_isstudent==true).ToList();
            this.frm2.flowLayoutPanel1.Controls.Add(new Show_Students());
            foreach (person i in persons)
            {
                this.frm2.flowLayoutPanel1.Controls.Add(new Show_Students(i));
            }
          
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            this.frm2.flowLayoutPanel1.Controls.Clear();
            List<person> persons = db.people.Where(x => x.C_isteacher == true).ToList();
            this.frm2.flowLayoutPanel1.Controls.Add(new Show_Teachers());
            foreach (person i in persons)
            {
                this.frm2.flowLayoutPanel1.Controls.Add(new Show_Teachers(i));
            }


        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {

            this.frm2.flowLayoutPanel1.Controls.Clear();
            this.frm2.flowLayoutPanel1.Controls.Add(new attendance(this.db , this.frm2));

        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {

            this.frm2.flowLayoutPanel1.Controls.Clear();
            this.frm2.flowLayoutPanel1.Controls.Add(new Search());

        }

        private void bunifuButton9_Click_1(object sender, EventArgs e)
        {
            this.frm2.flowLayoutPanel1.Controls.Clear();
            this.frm2.flowLayoutPanel1.Controls.Add(new attendance(this.db , this.frm2));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
