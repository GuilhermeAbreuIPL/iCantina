using iCantina.Controllers;
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
    }
}
