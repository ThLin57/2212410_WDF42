using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212410_WDF41
{
    public partial class frmSubmit : Form
    {
        public frmSubmit()
        {
            InitializeComponent();
        }

 

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Information box with an OK button", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtPassWord_PasswordChars(object sender, EventArgs e)
        {
            txtPassWord.PasswordChar = '*';
        }
    }
}
