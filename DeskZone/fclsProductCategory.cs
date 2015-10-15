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
    public partial class fclsProductCategory : Form
    {
        public fclsProductCategory()
        {
            InitializeComponent();
        }

        private void dgvAttributes_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (Convert.ToString(dgvAttributes.SelectedCells[0].Value) == "")
                {
                    dgvAttributes.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
                }
            }
        }

        private void dgvProcesses_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (Convert.ToString(dgvProcesses.SelectedCells[0].Value) == "")
                {
                    dgvProcesses.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
                }
            }
        }

       
       
        
    }
}
