using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            errCustomerForm.SetError(textBox1, "");
            errCustomerForm.SetError(textBox2, "");
            errCustomerForm.SetError(textBox3, "");
            errCustomerForm.SetError(textBox4, "");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool flag;
            flag = true;
            if (textBox1.Text == "")
            {
                errCustomerForm.SetError(textBox1, "Please specify a valid car number.");
                flag = false;
            }
            else
                errCustomerForm.SetError(textBox1, "");
            if (textBox2.Text == "")
            {
                errCustomerForm.SetError(textBox2, "Please specify a valid Name.");
                flag = false;
            }
            else
                errCustomerForm.SetError(textBox2, "");
            if (textBox3.Text == "")
            {
                errCustomerForm.SetError(textBox3, "Please specify a valid Address.");
                flag = false;
            }
            else
                errCustomerForm.SetError(textBox3, "");
            if (textBox4.Text == "")
            {
                errCustomerForm.SetError(textBox4, "Please specify a valid make.");
                flag = false;
            }
            else
                errCustomerForm.SetError(textBox4, "");
            if (flag == false)
                return;
            else
            {
                //sql语句
            }
        }
    }
}
