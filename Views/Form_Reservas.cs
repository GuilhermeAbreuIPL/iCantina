using iCantina.Controllers;
using iCantina.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.EntitySql;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.Views
{
    public partial class Form_Reservas : Form
    {
        public enum tipoCustomer{
            Professor,
            Estudante
        }
        private tipoCustomer _tipoCustomer;
        private decimal _totalExtra = 0;
        private decimal _precoTotal = 0;
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
                    Models.Menu menu = (Models.Menu)lb_menus.SelectedItem;

                    if (_tipoCustomer == tipoCustomer.Estudante)
                    {
                        txt_precoPrato.Text = menu.PrecoEstudante.ToString();
                        
                        _precoTotal += menu.PrecoEstudante;
                        txt_precoTotal.Text = _precoTotal.ToString();
                        return;

                    }
                    else if (_tipoCustomer == tipoCustomer.Professor)
                    {
                        txt_precoPrato.Text = menu.PrecoProfessor.ToString();
                        _precoTotal += menu.PrecoProfessor;
                        txt_precoTotal.Text = _precoTotal.ToString();
                       
                        return;
                    }
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
                    _totalExtra += extra.Preco;
                    _precoTotal += extra.Preco;
                    lb_reservar.Items.Add(extra);
                    txt_precoExtra.Text = _totalExtra.ToString();
                    txt_precoTotal.Text = _precoTotal.ToString();
                    
                }
            }
        }

        private void ClearReservaAndItems()
        {
            lb_extras.Items.Clear();
            lb_pratos.Items.Clear();
            lb_reservar.Items.Clear();


        }

        private void btn_procurar_Click(object sender, EventArgs e)
        {
            int nif;
            if (txt_nif.Text.Length == 9  && int.TryParse(txt_nif.Text, out nif))
            {
                if (StudentController.GetStudentByNif(nif) != null)
                {
                    
                    Student student = StudentController.GetStudentByNif(nif);

                    txt_saldo.Text = student.Saldo.ToString();
                    txt_nome.Text = student.Nome;
                    _tipoCustomer = tipoCustomer.Estudante;

                    gb_all.Enabled = true;
                    return;
                }

                if(ProfessorController.GetProfessorByNif(nif) != null){
                    Professor professor = ProfessorController.GetProfessorByNif(nif);

                    txt_saldo.Text = professor.Saldo.ToString();
                    txt_nome.Text = professor.Nome;
                    _tipoCustomer = tipoCustomer.Professor;
                    
                    gb_all.Enabled = true;
                    return;
                }

                //Se o codigo chegou aqui o nif n existe.
            }
            else
            {
                MessageBox.Show("O nif tem de ser um número e tem de ter 9 numeros");
                return;
            }
            
        }

        

       
    }
    
}
