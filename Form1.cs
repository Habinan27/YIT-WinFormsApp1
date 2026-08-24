namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFillData_Click(object sender, EventArgs e)
        {
            //String Firstname = txtfname.Text;
            //String Lastname = txtlname.Text;
            //String Fullname = $"{Firstname} {Lastname}";
            //txtfullname.Text = Fullname;
            //MessageBox.Show($"FullName: {Fullname}","Fullname",MessageBoxButtons.OK,MessageBoxIcon.Information);


            String Firstname = txtfname.Text.Trim();
            String Lastname = txtlname.Text.Trim();
            String Fullname = $"{Firstname} {Lastname}";

            //lblError01.Text = "";
            //lblError02.Text = "";
            lblError03.Text = "";

            if (string.IsNullOrEmpty(Firstname))
            {
                lblError03.Text = "Please enter your first name.";
                txtfname.Focus();
                timer1.Stop();
                timer1.Start();
                return;
            }

            else if (string.IsNullOrEmpty(Lastname))
            {
                lblError03.Text = "Please enter your last name.";
                txtlname.Focus();
                timer1.Stop();
                timer1.Start(); ;
                return;
            }
            else
            {
                txtfullname.Text = Fullname;
                lblError03.Text = $"Full Name is {Fullname}.";
                timer1.Stop();
                timer1.Start();
            }
        }

        private void dtdob_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblError03.Text = "";
            timer1.Stop();
        }
    }

}
