using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.Views
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxUser_Enter(object sender, EventArgs e)
        {
            
        }

        private void rb_funcionario_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_funcionario.Checked)
            {
                gb_funcionario.Enabled = true;
            }else
            {
                gb_funcionario.Enabled=false;
                txt_user.Clear();
                
            }
        }

        private void rb_cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_cliente.Checked)
            {
                gb_cliente.Enabled = true;
            }
            else
            {
                gb_cliente.Enabled = false;
                rb_professor.Checked = false;
                rb_estudante.Checked = false;
                txt_professor.Clear();
                txt_estudante.Clear();

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_professor.Checked)
            {
                txt_professor.Enabled = true;
            }
            else
            {
                txt_professor.Enabled = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_estudante.Checked)
            {
                txt_estudante.Enabled = true;
            }
            else
            {
                txt_estudante.Enabled = false;
            }
        }
    }
}
