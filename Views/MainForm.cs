using iCantina.Views;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace iCantina
{
    public partial class MainForm : Form
    {
        public static bool Funcionarioselected;
        public MainForm()
        {
            InitializeComponent();
            LoadEmployees();
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            openNewForm(new Form_Menu());
        }

        private void btn_multas_Click(object sender, EventArgs e)
        {
            openNewForm(new Form_Multas());
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

        private void LoadEmployees()
        {
            List<Employee> employees = EmployeeController.ShowAll();
            List<object> items = new List<object>();

            items.Add(new { Text = "", Value = (Employee)null });

            foreach (Employee employee in employees)
            {
                items.Add(new { Text = employee.Username, Value = employee });
            }

            cb_funcionario.DataSource = items;
            cb_funcionario.DisplayMember = "Text";

            cb_funcionario.SelectedIndex = 0;
        }

        private void cb_funcionario_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cb_funcionario.SelectedIndex == 0)
            {
                btn_cliente.Enabled = false;
                btn_reservas.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                btn_multas.Enabled = false;

                if (this.ActiveMdiChild != null)
                {
                    this.ActiveMdiChild.Close();
                }
                CheckFuncionario();
                return;
            }
            else
            {
                btn_cliente.Enabled = true;
                btn_reservas.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                btn_multas.Enabled = true;
                if (this.ActiveMdiChild != null)
                {
                    this.ActiveMdiChild.Close();
                }
                CheckFuncionario();
                return;
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        public void CheckFuncionario()
        {
            if (cb_funcionario.SelectedIndex == 0)
            {
                Funcionarioselected = false;
            }
            else
            {
                Funcionarioselected = true;
            }
        }

       
    }
}
