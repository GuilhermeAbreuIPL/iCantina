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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace iCantina.Views
{
    public partial class Form_Cliente : Form
    {
        public Form_Cliente()
        {
            InitializeComponent();
            lb_cliente.DataSource = CustomerController.ShowAll();
            lb_funcionarios.DataSource = EmployeeController.ShowAll();
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
            gb_cliente.Enabled = true;
            groupBoxUser.Enabled = true;

            if(userSelecionado != null)
            {
                if (userSelecionado.GetType() == typeof(Professor))
                {
                    txt_numEstudante.Clear();
                    rb_professor.Checked = true;


                    professor = (Professor)userSelecionado;

                    FillProfessor(professor);

                    txt_numEstudante.Enabled = false;
                }
                else if (userSelecionado.GetType() == typeof(Student))
                {
                    txt_email.Clear();
                    rb_estudante.Checked = true;


                    student = (Student)userSelecionado;
                    FillStudent(student);

                    txt_numEstudante.Enabled = true;
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

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Customer customer = (Customer)lb_cliente.SelectedItem;
            int num_estudante;
            int nif;
            string nome;

            if (String.IsNullOrEmpty(txt_nome.Text))
            {
                MessageBox.Show("O nome, tem de estar preenchido.");
                return;
            }

            nome = txt_nome.Text;

            if (txt_nif.TextLength == 9)
            {
                try
                {
                    nif = int.Parse(txt_nif.Text);
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

            if (StudentController.GetStudentByNif(customer.Nif) != null)
            {
                //Update estudante
                if (txt_numEstudante.Text.Length == 7)
                {
                    try
                    {
                        num_estudante = int.Parse(txt_numEstudante.Text);
                    }
                    catch (Exception)
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

                StudentController.UpdateStudent(customer.Id, nome, nif, num_estudante);
                lb_cliente.DataSource = null;
                lb_cliente.DataSource = CustomerController.ShowAll();            }

            if ( ProfessorController.GetProfessorByNif(customer.Nif) != null)
            {
                ProfessorController.UpdateProfessor(customer.Id, nome, nif);
                lb_cliente.DataSource = null;
                lb_cliente.DataSource = CustomerController.ShowAll();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Customer customer = (Customer)lb_cliente.SelectedItem;
            if (customer == null)
            {
                MessageBox.Show("Tem de haver um utilizador selecionado.");
                return;
            }

            if (StudentController.GetStudentByNif(customer.Nif) != null)
            {
                StudentController.DeleteStudent(customer.Id);
                lb_cliente.DataSource = null;
                lb_cliente.DataSource = CustomerController.ShowAll();
            }

            if (ProfessorController.GetProfessorByNif(customer.Nif) != null)
            {
                ProfessorController.DeleteProfessor(customer.Id);
                lb_cliente.DataSource = null;
                lb_cliente.DataSource = CustomerController.ShowAll();
            }
        }

        private void lb_funcionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            var userSelecionado = lb_funcionarios.SelectedItem;
            Employee employee;

            if (userSelecionado != null)
            {
                employee = (Employee)userSelecionado;
                FillUserFuncionarioText(employee.Nome, employee.Nif, employee.Username);
            }
        }

        private void btn_editarFuncionario_Click(object sender, EventArgs e)
        {
            Employee employee = (Employee)lb_funcionarios.SelectedItem;
            int nif;
            string nome;
            string username;

            if (String.IsNullOrEmpty(txt_nomeFuncionario.Text))
            {
                MessageBox.Show("O nome, tem de estar preenchido.");
                return;
            }

            nome = txt_nomeFuncionario.Text;

            if (txt_nifFuncionario.TextLength == 9)
            {
                try
                {
                    nif = int.Parse(txt_nifFuncionario.Text);
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

            if (String.IsNullOrEmpty(txt_username.Text))
            {
                MessageBox.Show("O username, tem de estar preenchido.");
                return;
            }

            username = txt_username.Text;

            EmployeeController.UpdateEmployee(employee.Id, nome, nif, username);
            lb_funcionarios.DataSource = null;
            lb_funcionarios.DataSource = EmployeeController.ShowAll();

        }

        private void btn_deleteFuncionario_Click(object sender, EventArgs e)
        {
            Employee employee = (Employee)lb_funcionarios.SelectedItem;
            if (employee == null)
            {
                MessageBox.Show("Tem de haver um utilizador selecionado.");
                return;
            }

            EmployeeController.DeleteEmployee(employee.Id);
            lb_funcionarios.DataSource = null;
            lb_funcionarios.DataSource = EmployeeController.ShowAll();
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
            FillStudentText(Convert.ToInt32(student.NumEstudante));

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

        private void FillUserFuncionarioText(string nome, int nif, string username)
        {
            txt_nomeFuncionario.Text = nome;
            txt_nifFuncionario.Text = nif.ToString();
            txt_username.Text = username;
        }
    }
}
