using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeskZone
{
    public partial class fclsMain : Form
    {
        public fclsMain()
        {
            InitializeComponent();
        }

        private void fclsMain_Load(object sender, EventArgs e)
        {

        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fclsCompany fcls = new fclsCompany();
            fcls.MdiParent = this;
            fcls.Show();
        }

        private void productCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fclsProductCategoryMaster fcls = new fclsProductCategoryMaster();
            fcls.MdiParent = this;
            fcls.Show();
        }

        private void workOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fclsJobCard fcls = new fclsJobCard();
            fcls.MdiParent = this;
            fcls.Show();
        }
    }
}
