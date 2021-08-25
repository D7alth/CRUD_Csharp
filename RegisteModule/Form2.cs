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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             dataBases.Validation validation = new dataBases.Validation();
              if (validation.verification(txbName.Text, txbLogin.Text, txbEmail.Text, txbPass.Text, txbRePass.Text, cbSector.Text, cbControlLevel.Text) == true)
              {
                  dataBases.SendDataForm2 sendData = new dataBases.SendDataForm2(
                      txbName.Text,
                      txbLogin.Text,
                      txbEmail.Text,
                      txbPass.Text,
                      cbSector.Text,
                      cbControlLevel.Text);

                  MessageBox.Show(sendData.message);
              }
              else
              {
                  MessageBox.Show("Fill in all forms");
              }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
