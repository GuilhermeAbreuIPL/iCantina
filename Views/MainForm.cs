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
            openNewForm(new Form_RegistarUser());

        }
        private void button3_Click(object sender, EventArgs e)
        {
            openNewForm(new Form_Cliente());
        }

        private void btn_reservas_Click(object sender, EventArgs e)
        {
            openNewForm(new Form_Reservas());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openNewForm(new Form_Pratos());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openNewForm(new Form_Extras());
        }

        private void openNewForm(Form form)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();

            
            
        }

        
    } 
}
