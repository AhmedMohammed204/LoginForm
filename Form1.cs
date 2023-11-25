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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void ResetItems()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            lblUsername.ForeColor = Color.OrangeRed;

        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            lblUsername.ForeColor = Color.BlanchedAlmond;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            lblPassword.ForeColor = Color.OrangeRed;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            lblPassword.ForeColor = Color.BlanchedAlmond;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure about that you want to conitue?", "Confirm"
                , MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK )
            {


                if(txtUsername.Text == "Ahmed" && txtPassword.Text == "12345")
                {
                    Form frmMain = new MainForm();
                    frmMain.ShowDialog();
                    ResetItems();

                }
                else
                {
                    MessageBox.Show("Worng Username/Password", "Wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Form frmSignup = new SignupForm();
            frmSignup.ShowDialog();
        }
    }
}
