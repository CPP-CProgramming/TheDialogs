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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        public string UserName
        {
            get
            {
                return txtBxName.Text;
            }

        }

        public string UserAge
        {
            get { return txtBxAge.Text; }
        }
    }
}
