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
    public partial class Profile : UserControl
    {
        Form2 frm;
        person p;
        public Profile(person p,Form2 frm)
        {
            InitializeComponent();
            this.p = p;
            this.frm = frm;
            this.name_profile.Text = this.p.name;
            this.Age_Profile.Text = this.p.age.ToString();
            this.Phone_Profile.Text = this.p.phone;
            this.Address_profile.Text = this.p.adress;
            this.Email_Profile.Text = this.p.email;
            this.Password_Profile.Text = this.p.password;
            this.Grade_profile.Text = this.p.grade.ToString();
          

        }

        private void login1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

            

        }

        private void bunifuButton2_Click_1(object sender, EventArgs e)
        {
            if (bunifuButton2.Text == "   Edit Info" )
            {
                this.bunifuButton2.Text = "   Save Info";
               this.name_profile.ReadOnly =  false;
                this.Email_Profile.ReadOnly = false;
                this.Age_Profile.ReadOnly = false;
                this.Address_profile.ReadOnly = false;
                this.Phone_Profile.ReadOnly = false;
                this.Grade_profile.ReadOnly = false;
                this.male.Enabled = true;
                this.Female.Enabled = true;
                this.Password_Profile.ReadOnly = false;
            }
            else
            {
                this.bunifuButton2.Text = "   Edit Info";

                p.name = name_profile.Text;
                p.password = Password_Profile.Text;
                p.grade = int.Parse(Grade_profile.Text);
                p.age = int.Parse(Age_Profile.Text);
                p.phone = Phone_Profile.Text;
                p.email = Email_Profile.Text;
                p.adress = Address_profile.Text;
                try {
                    frm.db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                frm.db.SaveChanges();
                } catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                
                if(male.Checked)
                {
                    p.gender = true;
                }
                else
                {
                    p.gender = false;
                }
                
                this.name_profile.ReadOnly = true;
                this.Email_Profile.ReadOnly = true;
                this.Age_Profile.ReadOnly = true;
                this.Address_profile.ReadOnly = true;
                this.Phone_Profile.ReadOnly = true;
                this.Grade_profile.ReadOnly = true;
                this.male.Enabled = false;
                this.Female.Enabled = false;
                this.Password_Profile.ReadOnly = true; 
            }
        }

        private void name_profile_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Password_Profile_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_Profile_TextChanged(object sender, EventArgs e)
        {

        }

        private void Address_profile_TextChanged(object sender, EventArgs e)
        {

        }

        private void Phone_Profile_TextChanged(object sender, EventArgs e)
        {

        }

        private void Age_Profile_TextChanged(object sender, EventArgs e)
        {

        }

        private void Grade_profile_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
