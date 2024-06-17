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
    public partial class Form_Pratos : Form
    {
        public Form_Pratos()
        {
            InitializeComponent();
            lb_pratos.DataSource = MealController.ShowAll();
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
                lb_pratos.DataSource = MealController.ShowAll();
                txt_criarDescricao.Clear();
                cb_criarTipo.SelectedIndex = 0;
                cb_criarAtivo.Checked = false;
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
           if(selected != null)
            {
                txt_editDescricao.Text = selected.Descricao;
                cb_editTipo.SelectedIndex = (int)selected.Tipo;
                cb_editAtivo.Checked = selected.Ativo;

            }

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if(lb_pratos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um prato para editar.");
                return;
            }

            if(String.IsNullOrEmpty(txt_editDescricao.Text))
            {
                MessageBox.Show("A descrição não pode estar vazia.");
                return;
            }


            //Get selected item
            Meal selected = (Meal)lb_pratos.SelectedItem;

            //Update selected item
            if (MealController.UpdateMeal(selected.Id, txt_editDescricao.Text, (Models.Tipo)cb_editTipo.SelectedIndex, cb_editAtivo.Checked))
            {
                MessageBox.Show("Prato atualizado com sucesso!");
                lb_pratos.DataSource = null;
                lb_pratos.DataSource = MealController.ShowAll();
                return;

            }
            else
            {
                MessageBox.Show("Erro ao atualizar prato");
                return;
            }
            
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {

            if(lb_pratos.SelectedItem != null)
            {
                Meal meal = (Meal)lb_pratos.SelectedItem;
                if (MealController.DeleteMeal(meal.Id))
                {
                    MessageBox.Show("Prato removido com sucesso!");
                    lb_pratos.DataSource = null;
                    lb_pratos.DataSource = MealController.ShowAll();
                    txt_editDescricao.Clear();
                    cb_editTipo.SelectedIndex = 0;
                    cb_editAtivo.Checked = false;

                    return;
                }
                else
                {
                    MessageBox.Show("Erro ao remover prato");
                    return;
                }
            }
            else {                
                MessageBox.Show("Selecione um prato para remover");
                return;
            }

        }

    }
}
