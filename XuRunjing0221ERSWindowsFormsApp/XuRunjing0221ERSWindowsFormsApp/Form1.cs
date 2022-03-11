using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XuRunjing0221ERSWindowsFormsApp
{
    public partial class EmployeeRecordsFrom : Form
    {
        private TreeNode tvRootNode;

        public EmployeeRecordsFrom()
        {
            InitializeComponent();
            PopulateTreeView();
        }

       

        private void EmpolyeeRecordsForm_Load(object sender, EventArgs e)
        {
         
        }
        private void PopulateTreeView()
        {
            statusBarPanel1.Tag = "Refeshing Empolyee Code. Please Wait...";
            this.Cursor = Cursors.WaitCursor;
            treeView1.Nodes.Clear();
            tvRootNode = new TreeNode("Empolyee Records");
            this.Cursor=Cursors.Default;
            treeView1.Nodes.Add(tvRootNode);

            TreeNodeCollection nodeCollection = tvRootNode.Nodes;
            XmlTextReader reader = new XmlTextReader("E:\\系统默认\\桌面\\CASE_2021-22\\MyRepos\\XuRunjing0221ERSWindowsFormsApp\\XuRunjing0221ERSWindowsFormsApp\\EmpRec.xml");
            reader.MoveToElement();
            try
            {
                while (reader.Read())
                {
                    if(reader.HasAttributes && reader.NodeType == XmlNodeType.Element)
                    {
                        reader.MoveToElement();//<EmpRecordsData>
                        reader.MoveToElement();//<Ecode

                        reader.MoveToAttribute("Id");//Id="E001"
                        String strVal = reader.Value;

                        reader.Read();
                        reader.Read();
                        if (reader.Name == "Dept")
                        {
                            reader.Read();
                        }
                        //create a child node
                        TreeNode EcodeNode = new TreeNode(strVal);
                        //add the node
                        nodeCollection.Add(EcodeNode);
                    }
                }
                statusBarPanel1.Tag = "Click on an empolyee code to see their record.";
            }
            catch(XmlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//end
        protected void InitalizeListControl()
        {
            listView1.Clear();
            listView1.Columns.Add("Empolyee Name",255,HorizontalAlignment.Left);
            listView1.Columns.Add("Date of Join",70,HorizontalAlignment.Right);
            listView1.Columns.Add("Gread",105,HorizontalAlignment.Left);
            listView1.Columns.Add("Salary",105,HorizontalAlignment.Left);
        }
        protected void PopulateListView(TreeNode crrNode)
        {
            InitalizeListControl();
            XmlTextReader listRead = new XmlTextReader("E:\\系统默认\\桌面\\CASE_2021-22\\MyRepos\\XuRunjing0221ERSWindowsFormsApp\\XuRunjing0221ERSWindowsFormsApp\\EmpRec.xml");
            listRead.MoveToElement();
            while (listRead.Read())
            {
                string strNodeName;
                string strNodePath;
                string name;
                string gread;
                string doj;
                string sal;
                string[] strItmsArr=new string[4];
                listRead.MoveToFirstAttribute();
                strNodeName = listRead.Value;
                strNodePath = crrNode.FullPath.Remove(0, 17);
                if (strNodePath == strNodeName)
                {
                    ListViewItem lvi;

                    listRead.MoveToNextAttribute();
                    name = listRead.Value;
                    lvi = listView1.Items.Add(listRead.Value);

                    listRead.Read();
                    listRead.Read();

                    listRead.MoveToFirstAttribute();
                    doj= listRead.Value;
                    lvi.SubItems.Add(doj);

                    listRead.MoveToNextAttribute();
                    gread= listRead.Value;
                    lvi.SubItems.Add(gread);

                    listRead.MoveToNextAttribute();
                    sal= listRead.Value;
                    lvi.SubItems.Add(sal);

                    listRead.MoveToNextAttribute();
                    listRead.MoveToElement();
                    listRead.ReadString();
                }
            }
        }//end

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode currNode=e.Node;
            if (tvRootNode == currNode)
            {
                InitalizeListControl();
                statusBarPanel1.Text = "Double Click the Empolyee Records";
                return;
            }
            else
            {
                statusBarPanel1.Text = "Click an Empolyee code to view individual record";
            }
            PopulateListView(currNode);
        }
    }
}
