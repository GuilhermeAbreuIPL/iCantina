using iCantina.Controllers;
using iCantina.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Mapping;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace iCantina.Views
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();

            List<object> items = new List<object>();
            items.Add(new { Text = "Almoço", Value = "12:00:00" });
            items.Add(new { Text = "Jantar", Value = "19:00:00" });

            cb_horario.DataSource = items;
            cb_horario.DisplayMember = "Text";
            cb_horario.ValueMember = "Value";

            lb_pratos.DataSource = MealController.GetMealByState(true);
            lb_extras.DataSource = ExtraController.GetExtrasByState(true);
            lb_menuExistente.DataSource = MenuController.GetMenus();
            
        }

        private void lb_pratos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_addExtras_Click(object sender, EventArgs e)
        {
            //Adicionar extras.
            Extra extra = (Extra)lb_extras.SelectedItem;
            int selectedIndex = lb_extras.SelectedIndex;
            if(extra != null)
            {


                if (lb_menu.Items.Contains(extra)){
                    MessageBox.Show("Extra já adicionado");
                    return;
                }
                else 
                {
                    lb_menu.Items.Add(extra);
                    
                }

            }
        }

        private void btn_addPrato_Click(object sender, EventArgs e)
        {
            //Adicionar prato.
            Meal meal = (Meal)lb_pratos.SelectedItem;
            int selectedIndex = lb_pratos.SelectedIndex;
            if (meal != null)
            {
                if (lb_menu.Items.Contains(meal))
                {
                    MessageBox.Show("Prato já adicionado");
                    return;
                }
                else
                {
                    lb_menu.Items.Add(meal);
                }
            }

        }

        private void btn_criar_Click_1(object sender, EventArgs e)
        {
            // Criar menu.
            
            string horas = cb_horario.SelectedValue.ToString();
            string data = dtp_data.Value.ToShortDateString();
            DateTime diaHora = DateTime.Parse($"{data} {horas}");
            if (lb_menu.Items.Count == 0)
            {
                MessageBox.Show("Adicione pratos ou extras ao menu");
                return;
            }

            int quantidade;
            decimal precoAluno;
            decimal precoProf;
      
            if (!int.TryParse(txt_quantidade.Text, out quantidade))
            {
                MessageBox.Show("Quantidade introduzida não pode ser 0, ou numero negativo!");
                return;
            }

            if (!decimal.TryParse(txt_precoAluno.Text, out precoAluno))
            {
                MessageBox.Show("Preço referente ao aluno tem de ser um número!");
                return;
            }

            if (!decimal.TryParse(txt_precoProf.Text, out precoProf))
            {
                MessageBox.Show("Preço referente ao professor tem de ser um número!");
                return;
            }

            if (diaHora < DateTime.Now)
            {
                MessageBox.Show("Data introduzida não pode ser no passado!");
                return;
            }

            if (!CheckExtras())
            {
                MessageBox.Show("Adicione pelo menos 3 extras ao menu");
                return;
            }

            if (!CheckMeals())
            {
                MessageBox.Show("Adicione pelo menos 1 prato de cada tipo (Carne, Peixe, Vegetariano)");
                return;
            }

            Models.Menu menu = new Models.Menu();
            menu.DataHora = diaHora;
            menu.Quantidade = quantidade;
            menu.PrecoEstudante = precoAluno;
            menu.PrecoProfessor = precoProf;
            
            //Adicionar pratos e extras ao menu.
            foreach (object item in lb_menu.Items)
            {
                if (item is Meal meal)
                {
                    menu.Pratos.Add(meal);
                }
                else if (item is Extra extra)
                {
                    menu.Extras.Add(extra);
                }
            }

            if (MenuController.AddMenu(menu)) 
            { 
                MessageBox.Show("Menu criado com sucesso!");
                ClearMenu();
                return;
            }
            else
            {
                MessageBox.Show("Erro ao criar menu");
                return;
            }

        }

        //Create a function that checks if lb_menu contains at least 3 extras.
        private bool CheckExtras()
        {
            int count = 0;
            foreach (object item in lb_menu.Items)
            {
                if (item is Extra)
                {
                    count++;
                }
            }
            return count >= 3;
        }

        //Create a function that checks if lb_menu contains at least 1 meal of each type being meal.tipo = "Carne", meal.tipo = "Peixe" and meal.tipo = "Vegetariano".
        private bool CheckMeals()
        {
            bool carne = false;
            bool peixe = false;
            bool vegetariano = false;
            foreach (object item in lb_menu.Items)
            {
                if (item is Meal meal)
                {
                    if (meal.Tipo == Tipo.Carne)
                    {
                        carne = true;
                    }
                    else if (meal.Tipo == Tipo.Peixe)
                    {
                        peixe = true;
                    }
                    else if (meal.Tipo == Tipo.Vegetariano)
                    {
                        vegetariano = true;
                    }
                }
            }
            return carne && peixe && vegetariano;
        }

        private void btn_retirar_Click(object sender, EventArgs e)
        {
            //Retirar prato ou extra.
            if (lb_menu.SelectedItem != null)
            {
                lb_menu.Items.Remove(lb_menu.SelectedItem);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearMenu();
            btn_criar.Enabled = true;
        }

        private void btn_selecionar_Click(object sender, EventArgs e)
        {
            Models.Menu menu = (Models.Menu)lb_menuExistente.SelectedItem;
            if (menu != null)
            {
                ClearMenu();
                btn_criar.Enabled = false;
                dtp_data.Value = menu.DataHora;
                cb_horario.SelectedValue = menu.DataHora.ToString("HH:mm:ss");
                txt_quantidade.Text = menu.Quantidade.ToString();
                txt_precoAluno.Text = menu.PrecoEstudante.ToString();
                txt_precoProf.Text = menu.PrecoProfessor.ToString();


                foreach (Meal meal in menu.Pratos)
                {
                    lb_menu.Items.Add(meal);
                }

                foreach (Extra extra in menu.Extras)
                {
                    lb_menu.Items.Add(extra);
                }

            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            // Editar menu.

            string horas = cb_horario.SelectedValue.ToString();
            string data = dtp_data.Value.ToShortDateString();
            DateTime diaHora = DateTime.Parse($"{data} {horas}");
            if (lb_menu.Items.Count == 0)
            {
                MessageBox.Show("Adicione pratos ou extras ao menu");
                return;
            }

            int quantidade;
            decimal precoAluno;
            decimal precoProf;

            if (!int.TryParse(txt_quantidade.Text, out quantidade))
            {
                MessageBox.Show("Quantidade introduzida não pode ser 0, ou numero negativo!");
                return;
            }

            if (!decimal.TryParse(txt_precoAluno.Text, out precoAluno))
            {
                MessageBox.Show("Preço referente ao aluno tem de ser um número!");
                return;
            }

            if (!decimal.TryParse(txt_precoProf.Text, out precoProf))
            {
                MessageBox.Show("Preço referente ao professor tem de ser um número!");
                return;
            }

            if (diaHora < DateTime.Now)
            {
                MessageBox.Show("Data introduzida não pode ser no passado!");
                return;
            }

            if (!CheckExtras())
            {
                MessageBox.Show("Adicione pelo menos 3 extras ao menu");
                return;
            }

            if (!CheckMeals())
            {
                MessageBox.Show("Adicione pelo menos 1 prato de cada tipo (Carne, Peixe, Vegetariano)");
                return;
            }
            List<Meal> listMeal = new List<Meal>();
            List<Extra> listExtra = new List<Extra>();
            foreach (object item in lb_menu.Items)
            {
                if (item is Meal meal)
                {
                    listMeal.Add(meal);
                }
                else if (item is Extra extra)
                {
                    listExtra.Add(extra);
                }
            }

            if (MenuController.UpdateMenu(((Models.Menu)lb_menuExistente.SelectedItem).Id, quantidade, precoProf, precoAluno, diaHora, listMeal ,listExtra ))
            {
                MessageBox.Show("Menu atualizado com sucesso!");
                ClearMenu();
                btn_criar.Enabled = true;
                return;
            }
            else
            {
                MessageBox.Show("Erro ao atualizar menu");
                return;
            }

            
        }

        private void lb_menuExistente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClearMenu()
        {
            lb_menu.Items.Clear();
            txt_quantidade.Clear();
            cb_horario.SelectedIndex = 0;
            dtp_data.Value = DateTime.Now;
            txt_precoAluno.Clear();
            txt_precoProf.Clear();
        }

       
    }
}
