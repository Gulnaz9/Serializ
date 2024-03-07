using System;
using System.Data;
using System.Windows.Forms;

namespace Cowshed
{
    public partial class ShowInfForm : Form
    {
        public ShowInfForm()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CowBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(@"../../XMLFile.xml");
            ShowInfDataGridView.DataSource = ds.Tables[0];
        }

        private void FarmerBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(@"../../XMLFile.xml");
            ShowInfDataGridView.DataSource = ds.Tables[1];
        }

        private void ShedBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(@"../../XMLFile.xml");
            ShowInfDataGridView.DataSource = ds.Tables[2];
        }
    }
}
