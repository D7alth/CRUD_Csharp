using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisteModule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dataBases.Validation validation = new dataBases.Validation();
            if (string.IsNullOrEmpty(txbName.Text) && string.IsNullOrEmpty(txbLogin.Text) && string.IsNullOrEmpty(txbEmail.Text) && string.IsNullOrEmpty(txbPass.Text) && string.IsNullOrEmpty(txbRePass.Text) && string.IsNullOrEmpty(cbSector.Text) == true)
            {
                MessageBox.Show("Fill in all forms");
               
            }
            else
            {
                dataBases.SendData sendData = new dataBases.SendData(txbName.Text, txbLogin.Text, txbEmail.Text, txbPass.Text, cbSector.Text);
                MessageBox.Show(sendData.message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
