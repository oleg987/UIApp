using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIApp
{
    public partial class FormMain : Form
    {
        static User currentUser;

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //this.Close();
            MessageBox.Show("Click");
        }

        private void btnExit_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Mouse Click");
        }

        private void FormMain_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.Text = "Enter";
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            //Random r = new Random();
            //btnExit.Location = new Point(r.Next(ClientSize.Width - 50), r.Next(ClientSize.Height - 50));
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.Text = "Exit";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //    if (txtInput.Text == "")
            //    {
            //        MessageBox.Show("No text=(");
            //    }
            //    else
            //    {
            //        MessageBox.Show(txtInput.Text);
            //    }
            if (currentUser != null)
            {
                MessageBox.Show(currentUser.ToString());
            }
            else
            {
                MessageBox.Show("no user");
            }            
        }

        private void txtInput_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            int age = -1;
            if (!Int32.TryParse(txtAge.Text, out age))
            {
                MessageBox.Show("Incorrect age");
            }

            if (age > 0)
            {
                currentUser = new User(txtFirstName.Text, txtLastName.Text, age);
                MessageBox.Show(currentUser.ToString());
            }
        }


    }
}
