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
                
                txt_numEstudante.Clear();

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
                if(txt_nif.TextLength == 9)
                {
                    try
                    {
                        nif = int.Parse(txt_nif.Text);
                    }catch(Exception) 
                    {
                        MessageBox.Show("O nif tem de ser um número");
                        return;
                    }
                   
                    
                }
                else
                {
                    MessageBox.Show("O nif tem de ter 9 caracteres");
                    return;
                }
                
                
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
                    
                    if(txt_numEstudante.Text.Length == 7)
                    {
                        try
                        {
                            num_estudante = int.Parse(txt_numEstudante.Text);
                        }catch (Exception)
                        {
                            MessageBox.Show("O número de estudante tem de ser um número");
                                return;
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("O número de estudante tem de ter 7 caracteres");
                        return;
                    }

                    //Adicionar estudante
                    StudentController.AddStudent(new Student { Nif = nif, Nome = nome, Saldo = saldo, NumEstudante = num_estudante });
                     
                    return;
                }
                else if (rb_professor.Checked)
                {
                  
                    //Adicionar Professor
                    ProfessorController.AddProfessor(new Professor { Nif = nif, Nome = nome, Saldo = saldo });
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
                // Adicionar funcionário

                username = txt_user.Text;
                EmployeeController.AddEmployee(new Employee { Nif = nif, Nome = nome, Username = username });
                    return;
            }
            

            
                 

        }

        private void Form_RegistarUser_Load(object sender, EventArgs e)
        {

        }
    }
}
