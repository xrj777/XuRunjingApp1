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
    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            InitializeComponent();
        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cMSDatabaseDataSet.tblWorker' table. You can move, or remove it, as needed.
            this.tblWorkerTableAdapter.Fill(this.cMSDatabaseDataSet.tblWorker);
            // TODO: This line of code loads data into the 'cMSDatabaseDataSet.tblCustomer' table. You can move, or remove it, as needed.
            this.tblCustomerTableAdapter.Fill(this.cMSDatabaseDataSet.tblCustomer);

        }
    }
}
