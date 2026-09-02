using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Drawing;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtnum1.Text))
                {
                    MessageBox.Show("Please enter Number 1.");
                    txtnum1.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtnum2.Text))
                {
                    MessageBox.Show("Please enter Number 2.");
                    txtnum2.Focus();
                    return;
                }

                double number1 = Convert.ToDouble(txtnum1.Text);
                double number2 = Convert.ToDouble(txtnum2.Text);

                double result = number1 + number2;

                txtresult.Text = result.ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Please enter valid numbers only.",
                    "Format Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            catch (DivideByZeroException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Math Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            catch (InvalidOperationException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Operator Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            catch (OverflowException)
            {
                MessageBox.Show(
                    "Number is too large or too small.",
                    "Overflow Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unknown Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            finally
            {
                txtnum1.Focus();
            }
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtnum1.Text))
                {
                    MessageBox.Show("Please enter Number 1.");
                    txtnum1.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtnum2.Text))
                {
                    MessageBox.Show("Please enter Number 2.");
                    txtnum2.Focus();
                    return;
                }

                double number1 = Convert.ToDouble(txtnum1.Text);
                double number2 = Convert.ToDouble(txtnum2.Text);

                double result = number1 - number2;

                txtresult.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Please enter valid numbers only.",
                    "Format Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            catch (DivideByZeroException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Math Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            catch (InvalidOperationException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Operator Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            catch (OverflowException)
            {
                MessageBox.Show(
                    "Number is too large or too small.",
                    "Overflow Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unknown Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            finally
            {
                txtnum1.Focus();
            }
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtnum1.Text))
                {
                    MessageBox.Show("Please enter Number 1.");
                    txtnum1.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtnum2.Text))
                {
                    MessageBox.Show("Please enter Number 2.");
                    txtnum2.Focus();
                    return;
                }

                double number1 = Convert.ToDouble(txtnum1.Text);
                double number2 = Convert.ToDouble(txtnum2.Text);

                double result = number1 * number2;

                txtresult.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Please enter valid numbers only.",
                    "Format Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            catch (DivideByZeroException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Math Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            catch (InvalidOperationException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Operator Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            catch (OverflowException)
            {
                MessageBox.Show(
                    "Number is too large or too small.",
                    "Overflow Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unknown Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            finally
            {
                txtnum1.Focus();
            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtnum1.Text))
                {
                    MessageBox.Show("Please enter Number 1.");
                    txtnum1.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtnum2.Text))
                {
                    MessageBox.Show("Please enter Number 2.");
                    txtnum2.Focus();
                    return;
                }

                double number1 = Convert.ToDouble(txtnum1.Text);
                double number2 = Convert.ToDouble(txtnum2.Text);

                double result = number1 / number2;

                txtresult.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Please enter valid numbers only.",
                    "Format Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            catch (DivideByZeroException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Math Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            catch (InvalidOperationException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Operator Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            catch (OverflowException)
            {
                MessageBox.Show(
                    "Number is too large or too small.",
                    "Overflow Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unknown Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            finally
            {
                txtnum1.Focus();
            }
        }
    }
}
