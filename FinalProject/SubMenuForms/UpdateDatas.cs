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
    public partial class UpdateDatas : Form
    {
        public UpdateDatas()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataManipulation.VerifyUserExistence verify = new DataManipulation.VerifyUserExistence(); 
            if(verify.verifyUserExistence(txtOldLogin.Text) == true)
            {
                if(string.IsNullOrEmpty(txtOldLogin.Text) && string.IsNullOrEmpty(txbEmail.Text) && string.IsNullOrEmpty(txbName.Text) && string.IsNullOrEmpty(txbPass.Text) && string.IsNullOrEmpty(cbSector.Text) && string.IsNullOrEmpty(txtNewLogin.Text))
                {
                    MessageBox.Show("complete all fields");
                }else{
                    DataManipulation.UpdateData updateData = new DataManipulation.UpdateData();
                    updateData.update(txbName.Text, txtNewLogin.Text, txbEmail.Text, txbPass.Text, cbSector.Text); 
                    MessageBox.Show(updateData.message);
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
