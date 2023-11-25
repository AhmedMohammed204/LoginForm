using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void lblMainMessage_MouseEnter(object sender, EventArgs e)
        {

            lblMainMessage.BackColor = Color.Orange;
        }

        private void lblMainMessage_MouseLeave(object sender, EventArgs e)
        {

            lblMainMessage.BackColor = Color.DarkOrange;
        }
    }
}
