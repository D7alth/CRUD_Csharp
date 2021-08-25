using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.SubMenuForms
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataManipulation.VerifyUserExistence verify = new DataManipulation.VerifyUserExistence();
            DataManipulation.QueryDelete queryDelete = new DataManipulation.QueryDelete();

            if (verify.verifyUserExistence(textBox1.Text) == true)
            {
                queryDelete.delete(textBox1.Text);
                MessageBox.Show("successfully deleted");
            }
            else
            {
                MessageBox.Show(verify.message);
                MessageBox.Show(queryDelete.message);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
