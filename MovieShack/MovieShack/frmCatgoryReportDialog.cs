using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MovieShack
{
    public partial class frmCatgoryReportDialog : Form
    {
        public string category;

        public frmCatgoryReportDialog()
        {
            InitializeComponent();
        }

        private void frmCatgoryReportDialog_Load(object sender, EventArgs e)
        {
            cmbCategoryReportDialogCategory.SelectedIndex = 1;
        }

        private void btnCategoryReportSubmit_Click(object sender, EventArgs e)
        {
            category = cmbCategoryReportDialogCategory.SelectedItem.ToString();
            this.Close();
        }
    }
}
