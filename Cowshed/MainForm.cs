using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Cowshed
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SerBtn_Click(object sender, EventArgs e)
        {
            treeView.Nodes.Clear();

            string xmlFile = @"../../XMLFile.xml";
            //string jsonFile = @"../../jsconfig.json";  c json файлом не получилось

            if (File.Exists(xmlFile))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlFile);

                TreeNode xmlNode = new TreeNode(xmlDoc.DocumentElement.Name);
                treeView.Nodes.Add(xmlNode);

                AddNodeXml(xmlDoc.DocumentElement, xmlNode);
            }

        }

        private void AddNodeXml(XmlNode xmlNode, TreeNode treeNode)
        {
            foreach (XmlNode childNode in xmlNode.ChildNodes)
            {
                TreeNode childTreeNode = new TreeNode(childNode.Name);
                treeNode.Nodes.Add(childTreeNode);

                if (childNode.HasChildNodes)
                {
                    AddNodeXml(childNode, childTreeNode);
                }
                else
                {
                    childTreeNode.Text = $"{childNode.Name}: {childNode.InnerText}";
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(@"../../XMLFile.xml");
            dataGridView.DataSource = ds.Tables[0];
        }

        private void DeserBtn_Click(object sender, EventArgs e)
        {
            ShowInfForm infForm = new ShowInfForm();
            infForm.Show();
        }
    }
}
