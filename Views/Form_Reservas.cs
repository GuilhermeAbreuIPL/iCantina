﻿using iCantina.Controllers;
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
        public enum tipoCustomer
        {
            Professor,
            Estudante
        }
        private tipoCustomer _tipoCustomer;
        private decimal _totalExtra = 0;
        private decimal _precoTotal = 0;
        private int _nifSelecionado;
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

            if (lb_menus.SelectedItem != null)
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

                    //chama a função que verifica se existe multa para aplicar ou não em bool
                    decimal fee = CheckMulta();

                    if (_tipoCustomer == tipoCustomer.Estudante)
                    {
                        txt_precoPrato.Text = menu.PrecoEstudante.ToString();

                        _precoTotal += menu.PrecoEstudante;
                        _precoTotal += fee;

                        if (fee != 0)
                        {
                            MessageBox.Show("Foi aplicada uma multa de " + fee + "€");
                        }
                        
                        txt_precoTotal.Text = _precoTotal.ToString();
                        return;

                    }
                    else if (_tipoCustomer == tipoCustomer.Professor)
                    {
                        txt_precoPrato.Text = menu.PrecoProfessor.ToString();

                        _precoTotal += menu.PrecoProfessor;
                        _precoTotal += fee;

                        if (fee != 0)
                        {
                            MessageBox.Show("Foi aplicada uma multa de " + fee + "€");
                        }

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

        private void btn_procurar_Click(object sender, EventArgs e)
        {
            ClearReservaAndItems();
            int nif;
            if (txt_nif.Text.Length == 9 && int.TryParse(txt_nif.Text, out nif))
            {
                if (StudentController.GetStudentByNif(nif) != null)
                {
                    _nifSelecionado = nif;

                    Student student = StudentController.GetStudentByNif(nif);

                    txt_saldo.Text = student.Saldo.ToString();
                    txt_nome.Text = student.Nome + " - Student";
                    
                    
                    
                    

                    _tipoCustomer = tipoCustomer.Estudante;

                    gb_all.Enabled = true;
                    ResetBoxes();
                    return;
                }

                if (ProfessorController.GetProfessorByNif(nif) != null)
                {
                    _nifSelecionado = nif;
                    Professor professor = ProfessorController.GetProfessorByNif(nif);

                    txt_saldo.Text = professor.Saldo.ToString();
                    txt_nome.Text = professor.Nome + " - Professor";
                    _tipoCustomer = tipoCustomer.Professor;

                    gb_all.Enabled = true;
                    ResetBoxes();
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

        private void btn_Reservar_Click(object sender, EventArgs e)
        {
            if (lb_reservar.Items.Count == 0)
            {
                MessageBox.Show("Não é possivel fazer uma reserva sem pratos ou extras");
                return;
            }

            if (!lb_reservar.Items.OfType<Meal>().Any())
            {
                MessageBox.Show("Tem de ter pelo menos 1 prato");
                return;
            }

            if (lb_reservar.Items.OfType<Extra>().Count() <= 0)
            {
                MessageBox.Show("Tem de ter pelo menos 1 extra");
            }

            if (_tipoCustomer == tipoCustomer.Estudante)
            {
                if (_precoTotal > StudentController.GetStudentByNif(_nifSelecionado).Saldo)
                {
                    MessageBox.Show("Saldo insuficiente");
                    return;
                }
            }
            else if (_tipoCustomer == tipoCustomer.Professor)
            {
                if (_precoTotal > ProfessorController.GetProfessorByNif(_nifSelecionado).Saldo)
                {
                    MessageBox.Show("Saldo insuficiente");
                    return;
                }
            }

            Reservation reservation = new Reservation();
            reservation.Customer = CustomerController.GetCustomerByNif(_nifSelecionado);
            reservation.Consumido = false;
            reservation.Extra = lb_reservar.Items.OfType<Extra>().ToList();
            reservation.Meal = lb_reservar.Items.OfType<Meal>().First();
            reservation.Menu = (Models.Menu)lb_menus.SelectedItem;

            if (ReservationController.AddReservation(reservation))
            {
                MessageBox.Show("Reserva feita com sucesso");
                //TODO: Atualizar saldo
                CustomerController.MakePayment(_nifSelecionado, _precoTotal);
                txt_saldo.Text = (decimal.Parse(txt_saldo.Text) - _precoTotal).ToString();

                txt_precoExtra.Text = "0,00";
                txt_precoPrato.Text = "0,00";
                txt_precoTotal.Text = "0,00";
                _precoTotal = 0;
                _totalExtra = 0;
                lb_reservar.Items.Clear();
            }
            else
            {
                MessageBox.Show("Erro ao fazer a reserva");
            }

           

        }

        private void btn_retirar_Click(object sender, EventArgs e)
        {
            if (lb_reservar.SelectedItem != null)
            {
                if (lb_reservar.SelectedItem is Meal)
                {
                    Meal meal = (Meal)lb_reservar.SelectedItem;
                    Models.Menu menu = (Models.Menu)lb_menus.SelectedItem;
                    if (_tipoCustomer == tipoCustomer.Estudante)
                    {
                        _precoTotal -= menu.PrecoEstudante;
                        txt_precoTotal.Text = _precoTotal.ToString();
                        txt_precoPrato.Text = "0";
                        lb_reservar.Items.Remove(meal);
                        return;
                    }
                    else if (_tipoCustomer == tipoCustomer.Professor)
                    {
                        _precoTotal -= menu.PrecoProfessor;
                        txt_precoTotal.Text = _precoTotal.ToString();
                        txt_precoPrato.Text = "0";
                        lb_reservar.Items.Remove(meal);
                        return;
                    }
                }
                else if (lb_reservar.SelectedItem is Extra)
                {
                    Extra extra = (Extra)lb_reservar.SelectedItem;
                    _totalExtra -= extra.Preco;
                    _precoTotal -= extra.Preco;
                    txt_precoExtra.Text = _totalExtra.ToString();
                    txt_precoTotal.Text = _precoTotal.ToString();
                    lb_reservar.Items.Remove(extra);
                }
            }
        }

        private void ClearReservaAndItems()
        {
            lb_extras.Items.Clear();
            lb_pratos.Items.Clear();
            lb_reservar.Items.Clear();
            txt_precoExtra.Text = "0,00";
            txt_precoPrato.Text = "0,00";
            txt_precoTotal.Text = "0,00";
            _precoTotal = 0;
            _totalExtra = 0;
        }

        private void ResetBoxes()
        {
            lb_reservar.Items.Clear();
            txt_precoExtra.Text = "0,00";
            txt_precoPrato.Text = "0,00";
            txt_precoTotal.Text = "0,00";
        }

        private decimal CheckMulta()
        {
            //vai buscar a hora do menu selecionado e guarda na variavel horaReserva
            Fee fee;
            DateTime horaReserva = ((Models.Menu)lb_menus.SelectedItem).DataHora;
            TimeSpan tempoRestante = FeeController.CalcularTempoRestante(horaReserva.Hour);
            fee = FeeController.ProcurarMulta(tempoRestante);
            if(fee == null)
            {
                return 0;
            }
            
            
            return fee.valor;
        }



        /* Parte ver Reservas */
        private void dtp_verReserva_ValueChanged(object sender, EventArgs e)
        {

        }
    }

}
