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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int selectedIndex = cmbSubject1.SelectedIndex;
            //cmbSubject2.SelectedIndex = selectedIndex;
            //MessageBox.Show(cmbSubject1.SelectedItem.ToString());


            String item = cmbSubject1.SelectedItem.ToString();

            cmbSubject2.SelectedItem = item;

            MessageBox.Show($"Selected Subject: {item}");

            //try 
            //{
            //    MessageBox.Show(cmbSubject1.SelectedIndex.ToString());

            //}
            //catch
            //{
            //    MessageBox.Show("Error");
            //}

        }
    }
}
