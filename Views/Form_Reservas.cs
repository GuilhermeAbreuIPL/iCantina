using iCantina.Controllers;
using iCantina.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.EntitySql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.Views
{
    public partial class Form_Reservas : Form
    {
        public Form_Reservas()
        {
            InitializeComponent();
            //Limitar calendario
            dtp_criarReserva.MinDate = DateTime.Now;

            //Carregar menus do dia atual e verificar e se passar da hora do almoço mostra só o jantar
            lb_menus.DataSource = MenuController.GetAvailableMenus(DateTime.Now);


        }

        private void dtp_criarReserva_ValueChanged(object sender, EventArgs e)
        {
            ClearReservaAndItems();
            lb_menus.DataSource = MenuController.GetAvailableMenus(dtp_criarReserva.Value);
        }

        private void lb_menus_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Função relativa ao listbox que contem os menus disponiveis para um dia.
            //Preenche as lbs dos pratos e dos extras.

            //Quando o index muda limpa a lb dos pratos a lb dos extras e o lb da reserva.
            
            if(lb_menus.SelectedItem != null)
            {
                ClearReservaAndItems();
                Models.Menu menuSelecionado = (Models.Menu)lb_menus.SelectedItem;

                foreach (Meal meal in menuSelecionado.Pratos)
                {
                    lb_pratos.Items.Add(meal);
                }

                foreach (Extra extra in menuSelecionado.Extras)
                {
                    lb_extras.Items.Add(extra);
                }
            }

        }

        private void btn_addPratos_Click(object sender, EventArgs e)
        {
            Meal meal = (Meal)lb_pratos.SelectedItem;
            int selectedIndex = lb_pratos.SelectedIndex;
            if (meal != null)
            {
                if (lb_reservar.Items.OfType<Meal>().Any())
                {
                    MessageBox.Show("Prato já adicionado, só é possivel ter um prato por reserva.");
                    
                    return;
                    
                }
                else
                {
                    lb_reservar.Items.Add(meal);
                }
            }
        }

        private void btn_addExtras_Click(object sender, EventArgs e)
        {
            Extra extra = (Extra)lb_extras.SelectedItem;
            int selectedIndex = lb_extras.SelectedIndex;
            if (extra != null)
            {
                if (lb_reservar.Items.OfType<Extra>().Count() >= 3)
                {
                    MessageBox.Show("Só é possivel adicionar 3 extras");

                    return;

                }
                else
                {
                    lb_reservar.Items.Add(extra);
                }
            }
        }

        private void ClearReservaAndItems()
        {
            lb_extras.Items.Clear();
            lb_pratos.Items.Clear();
            lb_reservar.Items.Clear();


        }

        
    }
    
}
