using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class FormATM : Form
    {
        public FormATM()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            pnlBottom.Controls.Clear();
            FormMoney f = new FormMoney{TopLevel = false, FormBorderStyle = FormBorderStyle.None};
            pnlBottom.Controls.Add(f); 
            f.Show();
        }
    }
}
