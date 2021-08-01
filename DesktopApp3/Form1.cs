using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DesktopApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {


        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = DesktopApp3.Properties.Resources.close2;

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = DesktopApp3.Properties.Resources.close1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;

    
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (panel4.Visible == true)
            {

                panel3.Visible = true;
                panel4.Visible = false;
             

            }
            else
            {
                person p = db.people.Where(per => per.email.Equals(Email_Login.Text) && per.password.Equals(Password_Login.Text)).FirstOrDefault();
                if (p != null)
                {

                    this.Hide();
                    Form2 frm = new Form2(this,p,db);
                    frm.Show();
                    this.Email_Login.Text = "";
                    this.Password_Login.Text = "";

                }
                else {
                    this.label4.Visible = true;
                    
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {


            Email_Login.ForeColor = Color.DodgerBlue;
            panel1.BackColor = Color.DodgerBlue;
            pictureBox3.Image = Properties.Resources.icons8_user_64;

            Password_Login.ForeColor = Color.White;
            panel2.BackColor = Color.White;
            pictureBox4.Image = Properties.Resources.pass1_64;



        }

        private void textBox2_Click(object sender, EventArgs e)
        {


            Password_Login.ForeColor = Color.DodgerBlue;
            panel2.BackColor = Color.DodgerBlue;
            pictureBox4.Image = Properties.Resources.pass2_64;

            Email_Login.ForeColor = Color.White;
            panel1.BackColor = Color.White;
            pictureBox3.Image = Properties.Resources.user_80pxw;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (Email_Login.Text != "" && Email_Login.ForeColor == Color.DodgerBlue)
            {


            }
            else if (Email_Login.Text == "" || Email_Login.ForeColor != Color.DodgerBlue)
            {
                Email_Login.Text = "Email";
            }




        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            if (Email_Login.Text == "Email")
            {

                Email_Login.Clear();

            }
           

        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            if (Password_Login.Text == "Password")
            {

                Password_Login.Clear();

            }

        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            if (Password_Login.Text == "")
            {
                Password_Login.Text = "Password";
            }
        }

        private CoursemanagmentEntities2 db = new CoursemanagmentEntities2();
        
        private void button2_Click(object sender, EventArgs e)
        {


            if (panel3.Visible == true)
            {
                panel4.Visible = true;
                panel3.Visible = false;
            }
            else
            {

                if (Username.Text != "" && Email.Text != "" && Password.Text != "" && Grade.Text != "" && Phone.Text != "" && Age.Text != "" && Address.Text != "")
                {
                    person p = db.people.Where(x => x.name.Equals(Username.Text) || x.email.Equals(Email.Text)).FirstOrDefault();

                    if (p != null)
                    {
                        MessageBox.Show("This Name or Email is Already Used !");

                    }
                    else
                    {
                      
                        try
                        {
                            person student = new person();
                            student.name = Username.Text;
                            student.email = Email.Text;
                            student.password = Password.Text;
                            student.grade = int.Parse(Grade.Text);
                            student.phone = Phone.Text;
                            student.age = int.Parse(Age.Text);
                            student.adress = Address.Text;
                            student.C_isadmin = false;
                            student.C_isstudent = true;
                            student.C_isteacher = false;
                            if (male.Checked) { student.gender = true; } else { student.gender = false; }
                            db.people.Add(student);
                            db.SaveChanges();
                        }
                        catch (FormatException er)
                        {
                            MessageBox.Show("the grade and age feilds just take numbers !");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        MessageBox.Show("Register success !");


                    }
                }
                else
                {
                    MessageBox.Show("Please Fill All fields ");
                }
            }



        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_MouseEnter(object sender, EventArgs e)
        {
            if (Username.Text == "Username")
            {

                Username.Clear();

            }

        }

        private void textBox7_MouseLeave(object sender, EventArgs e)
        {
            if (Username.Text == "")
            {
                Username.Text = "Username";
            }

        }

        private void textBox6_MouseLeave(object sender, EventArgs e)
        {

            if (Email.Text == "")
            {
                Email.Text = "Email";

            }

        }

        private void textBox6_MouseEnter(object sender, EventArgs e)
        {

            if (Email.Text == "Email")
            {

                Email.Clear();

            }
        }

        private void textBox5_MouseEnter(object sender, EventArgs e)
        {

            if (Password.Text == "Password")
            {

                Password.Clear();

            }
        }

        private void textBox5_MouseLeave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Text = "Password";
            }

        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            if (Grade.Text == "")
            {
                Grade.Text = "Grade";
            }
        }

        private void textBox3_MouseEnter(object sender, EventArgs e)
        {

            if (Grade.Text == "Grade")
            {

                Grade.Clear();

            }
        }

        private void textBox4_MouseEnter(object sender, EventArgs e)
        {
  
            if (Phone.Text == "Phone")
            {

                Phone.Clear();

            }
        }

        private void textBox4_MouseLeave(object sender, EventArgs e)
        {
          if (Phone.Text == "")
            {
                Phone.Text = "Phone";
            }
        }

        private void textBox8_MouseEnter(object sender, EventArgs e)
        {

            if (Age.Text == "Age")
            {

                Age.Clear();

            }
        }

        private void textBox8_MouseLeave(object sender, EventArgs e)
        {

            if (Age.Text == "")
            {
                Age.Text = "Age";
            }
        }

        private void textBox9_MouseEnter(object sender, EventArgs e)
        {
 
            if (Address.Text == "Address")
            {

                Address.Clear();

            }
        }

        private void textBox9_MouseLeave(object sender, EventArgs e)
        {

           if (Address.Text == "")
            {
                Address.Text = "Address";
            }

        }
        private void textBox7_Click(object sender, EventArgs e)
        {
            Username.ForeColor = Color.DodgerBlue;
            panel9.BackColor = Color.DodgerBlue;
            pictureBox10.Image = Properties.Resources.icons8_autograph;

            Email.ForeColor = Color.White;
            panel8.BackColor = Color.White;
            pictureBox9.Image = Properties.Resources.user_80pxw;


            Password.ForeColor = Color.White;
            panel5.BackColor = Color.White;
            pictureBox5.Image = Properties.Resources.pass1_64;


            Grade.ForeColor = Color.White;
            panel7.BackColor = Color.White;
            pictureBox8.Image = Properties.Resources.icons8_student_male;


            Phone.ForeColor = Color.White;
            panel6.BackColor = Color.White;
            pictureBox7.Image = Properties.Resources.icons8_phone_filled;


            Age.ForeColor = Color.White;
            panel10.BackColor = Color.White;
            pictureBox12.Image = Properties.Resources.icons8_lifecycle_1;


            Address.ForeColor = Color.White;
            panel11.BackColor = Color.White;
            pictureBox13.Image = Properties.Resources.icons8_address_1;
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            Email.ForeColor = Color.DodgerBlue;
            panel8.BackColor = Color.DodgerBlue;
            pictureBox9.Image = Properties.Resources.icons8_user_64;

            Username.ForeColor = Color.White;
            panel9.BackColor = Color.White;
            pictureBox10.Image = Properties.Resources.icons8_autograph_1;


            Password.ForeColor = Color.White;
            panel5.BackColor = Color.White;
            pictureBox5.Image = Properties.Resources.pass1_64;


            Grade.ForeColor = Color.White;
            panel7.BackColor = Color.White;
            pictureBox8.Image = Properties.Resources.icons8_student_male;


            Phone.ForeColor = Color.White;
            panel6.BackColor = Color.White;
            pictureBox7.Image = Properties.Resources.icons8_phone_filled;


            Age.ForeColor = Color.White;
            panel10.BackColor = Color.White;
            pictureBox12.Image = Properties.Resources.icons8_lifecycle_1;


            Address.ForeColor = Color.White;
            panel11.BackColor = Color.White;
            pictureBox13.Image = Properties.Resources.icons8_address_1;


        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            Password.ForeColor = Color.DodgerBlue;
            panel5.BackColor = Color.DodgerBlue;
            pictureBox5.Image = Properties.Resources.pass2_64;

            Username.ForeColor = Color.White;
            panel9.BackColor = Color.White;
            pictureBox10.Image = Properties.Resources.icons8_autograph_1;

            Email.ForeColor = Color.White;
            panel8.BackColor = Color.White;
            pictureBox9.Image = Properties.Resources.user_80pxw;



            Grade.ForeColor = Color.White;
            panel7.BackColor = Color.White;
            pictureBox8.Image = Properties.Resources.icons8_student_male;


            Phone.ForeColor = Color.White;
            panel6.BackColor = Color.White;
            pictureBox7.Image = Properties.Resources.icons8_phone_filled;


            Age.ForeColor = Color.White;
            panel10.BackColor = Color.White;
            pictureBox12.Image = Properties.Resources.icons8_lifecycle_1;


            Address.ForeColor = Color.White;
            panel11.BackColor = Color.White;
            pictureBox13.Image = Properties.Resources.icons8_address_1;

        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            Grade.ForeColor = Color.DodgerBlue;
            panel7.BackColor = Color.DodgerBlue;
            pictureBox8.Image = Properties.Resources.icons8_student_male_1;

            Username.ForeColor = Color.White;
            panel9.BackColor = Color.White;
            pictureBox10.Image = Properties.Resources.icons8_autograph_1;

            Email.ForeColor = Color.White;
            panel8.BackColor = Color.White;
            pictureBox9.Image = Properties.Resources.user_80pxw;


            Password.ForeColor = Color.White;
            panel5.BackColor = Color.White;
            pictureBox5.Image = Properties.Resources.pass1_64;


            Phone.ForeColor = Color.White;
            panel6.BackColor = Color.White;
            pictureBox7.Image = Properties.Resources.icons8_phone_filled;


            Age.ForeColor = Color.White;
            panel10.BackColor = Color.White;
            pictureBox12.Image = Properties.Resources.icons8_lifecycle_1;


            Address.ForeColor = Color.White;
            panel11.BackColor = Color.White;
            pictureBox13.Image = Properties.Resources.icons8_address_1;

        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            Phone.ForeColor = Color.DodgerBlue;
            panel6.BackColor = Color.DodgerBlue;
            pictureBox7.Image = Properties.Resources.icons8_phone_filled_1;

            Username.ForeColor = Color.White;
            panel9.BackColor = Color.White;
            pictureBox10.Image = Properties.Resources.icons8_autograph_1;

            Email.ForeColor = Color.White;
            panel8.BackColor = Color.White;
            pictureBox9.Image = Properties.Resources.user_80pxw;


            Password.ForeColor = Color.White;
            panel5.BackColor = Color.White;
            pictureBox5.Image = Properties.Resources.pass1_64;


            Grade.ForeColor = Color.White;
            panel7.BackColor = Color.White;
            pictureBox8.Image = Properties.Resources.icons8_student_male;



            Age.ForeColor = Color.White;
            panel10.BackColor = Color.White;
            pictureBox12.Image = Properties.Resources.icons8_lifecycle_1;


            Address.ForeColor = Color.White;
            panel11.BackColor = Color.White;
            pictureBox13.Image = Properties.Resources.icons8_address_1;


        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            Age.ForeColor = Color.DodgerBlue;
            panel10.BackColor = Color.DodgerBlue;
            pictureBox12.Image = Properties.Resources.icons8_lifecycle;

            Username.ForeColor = Color.White;
            panel9.BackColor = Color.White;
            pictureBox10.Image = Properties.Resources.icons8_autograph_1;

            Email.ForeColor = Color.White;
            panel8.BackColor = Color.White;
            pictureBox9.Image = Properties.Resources.user_80pxw;


            Password.ForeColor = Color.White;
            panel5.BackColor = Color.White;
            pictureBox5.Image = Properties.Resources.pass1_64;


            Grade.ForeColor = Color.White;
            panel7.BackColor = Color.White;
            pictureBox8.Image = Properties.Resources.icons8_student_male;


            Phone.ForeColor = Color.White;
            panel6.BackColor = Color.White;
            pictureBox7.Image = Properties.Resources.icons8_phone_filled;


            Address.ForeColor = Color.White;
            panel11.BackColor = Color.White;
            pictureBox13.Image = Properties.Resources.icons8_address_1;

        }

        private void textBox9_Click(object sender, EventArgs e)
        {
            Address.ForeColor = Color.DodgerBlue;
            panel11.BackColor = Color.DodgerBlue;
            pictureBox13.Image = Properties.Resources.icons8_address;

            Username.ForeColor = Color.White;
            panel9.BackColor = Color.White;
            pictureBox10.Image = Properties.Resources.icons8_autograph_1;

            Email.ForeColor = Color.White;
            panel8.BackColor = Color.White;
            pictureBox9.Image = Properties.Resources.user_80pxw;


            Password.ForeColor = Color.White;
            panel5.BackColor = Color.White;
            pictureBox5.Image = Properties.Resources.pass1_64;


            Grade.ForeColor = Color.White;
            panel7.BackColor = Color.White;
            pictureBox8.Image = Properties.Resources.icons8_student_male;


            Phone.ForeColor = Color.White;
            panel6.BackColor = Color.White;
            pictureBox7.Image = Properties.Resources.icons8_phone_filled;


            Age.ForeColor = Color.White;
            panel10.BackColor = Color.White;
            pictureBox12.Image = Properties.Resources.icons8_lifecycle_1;


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {



        }
    }
    }
