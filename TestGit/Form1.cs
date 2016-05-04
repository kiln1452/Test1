using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mATCHING_SOURCE_TABLEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mATCHING_SOURCE_TABLEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aCQUISITION_MATCHING_MAINDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aCQUISITION_MATCHING_MAINDataSet.MATCHING_SOURCE_TABLE' table. You can move, or remove it, as needed.
            this.mATCHING_SOURCE_TABLETableAdapter.Fill(this.aCQUISITION_MATCHING_MAINDataSet.MATCHING_SOURCE_TABLE);

        }
    }
}
