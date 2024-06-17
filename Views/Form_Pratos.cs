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
    public partial class Form_Pratos : Form
    {
        public Form_Pratos()
        {
            InitializeComponent();
            lb_pratos.DataSource = Controllers.MealController.ShowAll();
            cb_criarTipo.SelectedIndex = 0;
        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_criarDescricao.Text))
            {
                MessageBox.Show("Insira uma descrição");
                return;
            }


            Models.Meal meal = new Models.Meal();
            meal.Descricao = txt_criarDescricao.Text;
            meal.Tipo = (Models.Tipo)cb_criarTipo.SelectedIndex;
            meal.Ativo = cb_criarAtivo.Checked;

            if (Controllers.MealController.AddMeal(meal))
            {
                MessageBox.Show("Prato adicionado com sucesso!");
                lb_pratos.DataSource = null;
                lb_pratos.DataSource = Controllers.MealController.ShowAll();
                return;
            }else
            {
                MessageBox.Show("Erro ao adicionar prato");
                return;
            }
            
        }

        private void lb_pratos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get selected item
            Models.Meal selected = (Models.Meal)lb_pratos.SelectedItem;

            //Set textboxes
            txt_editDescricao.Text = selected.Descricao;
            cb_editTipo.SelectedIndex = (int)selected.Tipo;
            cb_editAtivo.Checked = selected.Ativo;
            
        }
    }
}
