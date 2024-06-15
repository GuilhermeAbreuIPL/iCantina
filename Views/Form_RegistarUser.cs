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
        
        public Form_RegistarUser()
        {
            InitializeComponent();
            
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
            //TODO : Implementar controlador e remover linha de teste.

            //Campos utilizador
            string nome;
            int nif;

            //Campos Funcionário
            string username;

            //Professor
            string email;

            //Estudante

            int num_estudante;
            //Campos Cliente
            decimal saldo = 0;

            

            
            



            



            //Verifica se user está preenchido.
            if(String.IsNullOrEmpty(txt_nome.Text) || String.IsNullOrEmpty(txt_nif.Text)){
                MessageBox.Show("User não preenchido");
                return;
            }
            else
            {
                nome = txt_nome.Text;
                nif = int.Parse(txt_nif.Text);
                //TODO: Verificação do nif se é numeric ou não.

            }

            //Verifica se o Tipo está preenchido
            if (!rb_cliente.Checked && !rb_funcionario.Checked) 
            {
                MessageBox.Show("Tipo não preenchido");
                return;
            }

            if (rb_cliente.Checked)
            {
                if (rb_estudante.Checked)
                {
                    if (String.IsNullOrEmpty(txt_numEstudante.Text))
                    {
                        MessageBox.Show("O número do estudante tem de estar preenchido");
                        return;
                    }
                    //UserController.AddUser(_cantinaContext, txt_nome.Text, txt_nif.Text);
                    //CustomerController.AddCustomer(_cantinaContext);
                    //StudentController.AddStudent(_cantinaContext, txt_numEstudante.Text);

                    //TODO: Verifica se é numeric o numestudante
                    num_estudante = int.Parse(txt_numEstudante.Text);

                    StudentController.AddStudent(new Student { Nif = nif, Nome = nome, Saldo = saldo, NumEstudante = num_estudante });
                    MessageBox.Show("Adicionado com sucesso"); //Adicionar estudante
                    return;
                }
                else if (rb_professor.Checked)
                {
                    if (String.IsNullOrEmpty(txt_email.Text))
                    {
                        MessageBox.Show("O campo de email tem de estar preenchido");
                        return;
                    }
                    MessageBox.Show("Adicionado com sucesso"); //Adicionar Professor
                    email = txt_email.Text;
                    ProfessorController.AddProfessor(new Professor { Nif = nif, Nome = nome, Saldo = saldo, Email = email });
                    return;
                }
                else
                {
                    MessageBox.Show("É necessário escolher o tipo de cliente");
                    return;
                }
            }
            else if(rb_funcionario.Checked)
            {
                if(String.IsNullOrEmpty(txt_user.Text))
                {
                    MessageBox.Show("É necessário adicionar o username do funcionário");
                    return;
                }
                MessageBox.Show("Adicionado com sucesso"); // Adicionar funcionário
                username = txt_user.Text;
                EmployeeController.AddEmployee(new Employee { Nif = nif, Nome = nome, Username = username });
                    return;
            }
            

            
                 

        }
    }
}
