using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheDialogs
{
    public partial class FrmTheDialogs : Form
    {
        public FrmTheDialogs()
        {
            InitializeComponent();
        }

        private void btnDialogs_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you understand this?", "Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                MessageBox.Show("You pressed yes");
            }
            else if (r == DialogResult.No)
            {
                MessageBox.Show("You pressed no");
            }
        }

        private void btnCustm_Click(object sender, EventArgs e)
        {
            frmUser f = new frmUser();
            DialogResult r = f.ShowDialog();
            if (r == DialogResult.OK)
            {
                MessageBox.Show("Your name is " + f.UserName);
                MessageBox.Show("Your age is " + f.UserAge);
            }
            else
            {
                MessageBox.Show("Your pressed cancel");

            }
        }
    }
}
