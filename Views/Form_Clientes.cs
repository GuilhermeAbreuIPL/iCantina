using iCantina.Controllers;
using iCantina.Models;
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
    public partial class Form_Cliente : Form
    {
        public Form_Cliente()
        {
            InitializeComponent();
            lb_cliente.DataSource = CustomerController.ShowAll();
        }

        private void btn_mostrarTodos_Click(object sender, EventArgs e)
        {
            lb_cliente.DataSource = CustomerController.ShowAll();
        }

        private void btn_mostrarProfessor_Click(object sender, EventArgs e)
        {
            lb_cliente.DataSource = ProfessorController.ShowAll();
        }

        private void btn_mostrarEstudantes_Click(object sender, EventArgs e)
        {
            lb_cliente.DataSource = StudentController.ShowAll();
        }

        private void lb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Listbox Selecionar um item.

            var userSelecionado = lb_cliente.SelectedItem;
            Professor professor;
            Student student;
            txt_procurarNif.Clear();

            if(userSelecionado != null)
            {
                if (userSelecionado.GetType() == typeof(Professor))
                {
                    txt_numEstudante.Clear();
                    rb_professor.Checked = true;


                    professor = (Professor)userSelecionado;

                    FillProfessor(professor);

                }
                else if (userSelecionado.GetType() == typeof(Student))
                {
                    txt_email.Clear();
                    rb_estudante.Checked = true;


                    student = (Student)userSelecionado;
                    FillStudent(student);


                }
            }
           

            
        }

        private void btn_procurar_Click(object sender, EventArgs e)
        {
            int nif;
            if (txt_procurarNif.TextLength == 9)
            {
                
                try
                {
                    nif = int.Parse(txt_procurarNif.Text);
                }
                catch (Exception)
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

            Customer customer = CustomerController.GetCustomerByNif(nif);
            
            if (customer == null)
            {
                MessageBox.Show("O nif inserido não está associado a um cliente.");
                return;
            }

            if(StudentController.GetCustomerByNif(nif) != null)
            {
                if(StudentController.GetStudentByNif(nif) != null)
                {
                    FillStudent(StudentController.GetStudentByNif(nif));
                    MessageBox.Show("Encontrado com sucesso!");
                    lb_cliente.DataSource = null;
                    lb_cliente.Items.Add(StudentController.GetStudentByNif(nif)) ; //Adicionado novo
                    return;
                }
                
            }

            if (ProfessorController.GetCustomerByNif(nif) != null)
            {
                FillProfessor(ProfessorController.GetProfessorByNif(nif));
                MessageBox.Show("Encontrado com sucesso!");
                lb_cliente.DataSource = null;
                lb_cliente.Items.Add(ProfessorController.GetProfessorByNif(nif));
                return;
            }
            
            

        }

        private void btn_addSaldo_Click(object sender, EventArgs e)
        {
            decimal saldoAdicionar;
            try
            {
                saldoAdicionar = decimal.Parse(txt_saldo.Text);

            }catch(Exception)
            {
                MessageBox.Show("Tem de ser um valor númerico");
                return;
            }

            if(saldoAdicionar <= 0)
            {
                MessageBox.Show("O valor a inserir não pode ser negativo.");
                return;
            }


            if(lb_cliente.SelectedItem != null)
            {
                var userSelecionado = lb_cliente.SelectedItem;
                
                Customer customer = (Customer)lb_cliente.SelectedItem;
                if(CustomerController.AddSaldo(customer.Nif, saldoAdicionar))
                {
                    MessageBox.Show("O saldo foi adicionado com sucesso!");
                    txt_saldo.Clear();
                    txt_saldoAtual.Text = CustomerController.GetSaldo(customer.Nif).ToString();
                    return;
                }
                else
                {
                    MessageBox.Show("Erro ao adicionar o saldo!");
                    txt_saldo.Clear();
                    
                    return;
                }

            }
            else
            {
                MessageBox.Show("Tem de haver um utilizador selecionado.");
                return;
            }
            
                
                
        }

        private void FillProfessor(Professor professor)
        {
            txt_numEstudante.Clear();
            rb_professor.Checked = true;


            
            FillUserText(professor.Nome, professor.Nif);
            FillProfessorText(professor.Email);
            FillCustomerText(professor.Saldo);


        }

        private void FillStudent(Student student)
        {
            txt_email.Clear();
            rb_estudante.Checked = true;


            FillUserText(student.Nome, student.Nif);
            FillCustomerText(student.Saldo);
            FillStudentText(student.NumEstudante);

        }
        

        private void FillUserText(string nome, int nif)
        {
            txt_nome.Text = nome;
            txt_nif.Text = nif.ToString();
        }

        private void FillCustomerText(decimal saldo)
        {
            txt_saldoAtual.Text = saldo.ToString();
        }

        private void FillProfessorText(string email)
        {
            txt_email.Text = email;
        }

        private void FillStudentText(int numero) 
        {
            txt_numEstudante.Text = numero.ToString();    
        }

        
    }

   
}
