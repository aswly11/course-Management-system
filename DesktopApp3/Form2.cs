using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp3
{
    public partial class Form2 : Form
    {
        Form1 frm;
        person p;
        public CoursemanagmentEntities2 db;
            
        public Form2(Form1 frm ,person p, CoursemanagmentEntities2 db)
        {
            InitializeComponent();
            this.frm = frm;
            this.p = p;
            this.db = db;
            if(p.C_isadmin)
            {
                flowLayoutPanel2.Controls.Clear();
                flowLayoutPanel2.Controls.Add(new adminactions(this,this.frm,this.p,this.db));
                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel1.Controls.Add(new Profile(this.p,this));
            }
            if (p.C_isteacher)
            {
                flowLayoutPanel2.Controls.Clear();
                flowLayoutPanel2.Controls.Add(new Teacher_Actions(this.frm, this, this.p, this.db));
                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel1.Controls.Add(new Profile(this.p, this));

            }
            if (p.C_isstudent)
            {
                flowLayoutPanel2.Controls.Clear();
                flowLayoutPanel2.Controls.Add(new student_action(this.frm,this, this.p, this.db));
                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel1.Controls.Add(new Profile(this.p, this));

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void Show_All_Courses_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(new Profile(this.p,this));
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

            Form1 far1 = new Form1();
            far1.Show();
            this.Hide();


        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
