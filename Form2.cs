using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnFillData_Click(object sender, EventArgs e)
        {
            //String firstname = txtfname.Text;
            //String lastname = txtlname.Text;
            //String Fullname = $"{firstname} {lastname}";
            //DateTime dob = dtdob.Value;
            //String address = txtaddress.Text;
            //String telephone = txttel.Text;
            //String gender = "";
            //String nic = txtnic.Text;

            lblfname.Text = "";
            lbllname.Text = "";
            lbldob.Text = "";
            lbladdress.Text = "";
            lbltel.Text = "";
            lblgender.Text = "";
            lblnic.Text = "";



            String firstname = txtfname.Text.Trim();

            if (String.IsNullOrEmpty(firstname))
            {
                lblfname.Text = "Please enter your first name.";
                txtfname.Focus();
                timer1.Stop();
                timer1.Start();
                return;
            }
            else 
            {
                firstname = char.ToUpper(firstname[0]) + firstname.Substring(1).ToLower();
            }


                String lastname = txtlname.Text.Trim();

            if (String.IsNullOrEmpty(lastname))
            {
                lbllname.Text = "Please enter your last name.";
                txtlname.Focus();
                timer1.Stop();
                timer1.Start();
                return;
            }
            else
            {
                lastname = char.ToUpper(lastname[0]) + lastname.Substring(1).ToLower();
            }


            String fullname = $"{firstname} {lastname}";
            txtfullname.Text = fullname;


            DateTime dob = dtdob.Value;

            String address = txtaddress.Text.Trim();

            if (String.IsNullOrEmpty(address))
            {
                lbladdress.Text = "Please enter your address.";
                txtaddress.Focus();
                timer1.Stop();
                timer1.Start();
                return;
            }


            String telephone = txttel.Text.Trim();

            if (String.IsNullOrEmpty(telephone))
            {
                lbltel.Text = "Please enter your telephone number.";
                txttel.Focus();
                timer1.Stop();
                timer1.Start();
                return;
            }

            String gender = "";

            if (rdomale.Checked)
            {
                gender = "Male";
            }
            else if (rdofemale.Checked)
            {
                gender = "Female";
            }
            else
            {
                lblgender.Text = "Please select your gender.";
                rdomale.Focus();
                timer1.Stop();
                timer1.Start();
                return;
            }


            String nic = txtnic.Text.Trim();

            if (String.IsNullOrEmpty(nic))
            {
                lblnic.Text = "Please enter your NIC number.";
                txtnic.Focus();
                timer1.Stop();
                timer1.Start();
                return;
            }

            txtfname2.Text = firstname;
            txtlname2.Text = lastname;
            //txtfullname2.Text = fullname;
            dtdob2.Value = dob;
            txtaddress2.Text = address;
            txttel2.Text = telephone;
            txtnic2.Text = nic;

            rdomale2.Checked = false;
            rdofemale2.Checked = false;

            if (gender == "Male")
            {
                rdomale2.Checked = true;
            }
            else if (gender == "Female")
            {
                rdofemale2.Checked = true;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfname.Text = "";
            lbllname.Text = "";
            lbldob.Text = "";
            lbladdress.Text = "";
            lbltel.Text = "";
            lblgender.Text = "";
            lblnic.Text = "";
            timer1.Stop();
        }
    }
}
