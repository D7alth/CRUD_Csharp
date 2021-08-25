using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegisteModule;

namespace FinalProject
{
    public partial class Form2 : Form
    {
        public Form2(string login)
        {
            InitializeComponent();

            DataManipulation.QueryShowDates dates = new DataManipulation.QueryShowDates();
            if (dates.queryShowDates(login) == true)
            {

                lblName.Text = dates.txtNameText;
                lblEmail.Text = dates.txtEmailText;
                lblSector.Text = dates.txtSectorText;
            }
            else
            {
                MessageBox.Show(dates.message); 
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gradient1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Form1 fn1 = new Form1();
            fn1.Closed += (s, args) => this.Close();
            fn1.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisteModule.Form1 fn1 = new RegisteModule.Form1();
            fn1.Closed += (s, args) => this.Close();
            fn1.Show();
        }

        private void administratorRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisteModule.Form2 fn2 = new RegisteModule.Form2();
            fn2.Closed += (s, args) => this.Close();
            fn2.Show();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            SubMenuForms.GridShow gridShow = new SubMenuForms.GridShow();
            gridShow.Closed += (s, args) => this.Close();
            gridShow.Show(); 
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubMenuForms.Delete delete = new SubMenuForms.Delete();
            delete.Closed += (s, args) => this.Close();
            delete.Show();
        }

        private void alterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubMenuForms.UpdateDatas up = new SubMenuForms.UpdateDatas();
            up.Closed += (s, args) => this.Close();
            up.Show();
        }

        private void sendReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("under construction");
        }

        private void filesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("under construction");
        }
    }
}
