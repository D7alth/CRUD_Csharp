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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region verificationWithSQL

            
            Verification vf = new Verification();
            if (vf.verification(txbLogin.Text, txbPass.Text))
            {
                DataManipulation.QuerySelect querySelect = new DataManipulation.QuerySelect();
                if(querySelect.queryLogin(txbLogin.Text,txbPass.Text) ==true)
                {
                   
                   

                    this.Hide();
                    Form2 fm2 = new Form2(txbLogin.Text);
                    fm2.Closed += (s, args) => this.Close();
                    fm2.Show();
                }
                else
                {
                    MessageBox.Show(querySelect.message);
                }
                
            }
            else
            {
                MessageBox.Show("login before");
            }
            #endregion


        }

  
        private void simpleRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //chamar a verificação pelo SQL
            #region Block
           
         
                MessageBox.Show("login before");
            
            #endregion
        }

        private void administratorRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Block


            MessageBox.Show("login before");

            #endregion
        }
    }
}
