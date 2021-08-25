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
    public partial class GridShow : Form
    {
        public GridShow()
        {
            InitializeComponent();
        }

        private void GridShow_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'finalProjectDBDataSet.SimpleRegistration'. Você pode movê-la ou removê-la conforme necessário.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.simpleRegistrationTableAdapter.Fill(this.finalProjectDBDataSet.SimpleRegistration);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fn1 = new Form1();
            fn1.Closed += (s, args) => this.Close();
            fn1.Show();
            
        }
    }
}
