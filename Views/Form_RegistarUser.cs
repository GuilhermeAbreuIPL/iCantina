using iCantina.Controllers;
using iCantina.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.Views
{
    public partial class Form_RegistarUser : Form
    {
        private CantinaContext _cantinaContext;
        public Form_RegistarUser()
        {
            InitializeComponent();
            
            _cantinaContext = Program.DbContext;
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
                txt_email.Clear();
                txt_numEstudante.Clear();

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_professor.Checked)
            {
                txt_email.Enabled = true;
            }
            else
            {
                txt_email.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_estudante.Checked)
            {
                txt_numEstudante.Enabled = true;
            }
            else
            {
                txt_numEstudante.Enabled = false;
            }
        }

        private void btn_introduzir_Click(object sender, EventArgs e)
        {
            
            if(UserController.addUser(_cantinaContext, txt_nome.Text, txt_nif.Text))
            {
                lbl_avisos.Text = "Utilizador adicionado com sucesso!";
            }
            else
            {
                lbl_avisos.Text = "Erro ao adicionar utilizador!";
            }
        }
    }
}
