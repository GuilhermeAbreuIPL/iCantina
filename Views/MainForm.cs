using iCantina.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User formToShow = new User();
            formToShow.MdiParent = this;
            formToShow.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Funcionarios formToShow = new Form_Funcionarios();
            formToShow.MdiParent = this;
            formToShow.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            Form_Cliente formToShow = new Form_Cliente();
            formToShow.MdiParent = this;
            formToShow.Show();
        }
    }
}
