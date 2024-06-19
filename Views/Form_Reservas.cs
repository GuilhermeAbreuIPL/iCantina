using iCantina.Controllers;
using iCantina.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.EntitySql;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

                //ver a quantidade na txt_quantidade
                txt_quantidade.Text = menuSelecionado.Quantidade.ToString();
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

            //se a quantidade for menos do que 0 nao deixa fazer a reserva e mostra mensagem de erro
            if (reservation.Menu.Quantidade <= 0)
            {
                MessageBox.Show("Erro ao fazer a reserva, quantidade insuficiente");
                return;
            }

            reservation.Menu.Quantidade -= 1;
            MenuController.UpdateMenuQuantidade(reservation.Menu.Id, reservation.Menu.Quantidade);

            if (ReservationController.AddReservation(reservation))
            {
                MessageBox.Show("Reserva feita com sucesso");

                //TODO: Atualizar saldo
                CustomerController.MakePayment(_nifSelecionado, _precoTotal);
                txt_saldo.Text = (decimal.Parse(txt_saldo.Text) - _precoTotal).ToString();

                //funcao imprimir fatura em txt
                ImprimirFaturaTxt(reservation);
                //funcao imprimir fatura em pdf
                ImprimirFaturaPdf(reservation);

                //diminuir 1 na quantidade do menu
                Models.Menu menu = (Models.Menu)lb_menus.SelectedItem;

                //limpar tudo
                txt_precoExtra.Text = "0,00";
                txt_precoPrato.Text = "0,00";
                txt_precoTotal.Text = "0,00";
                txt_quantidade.Text = "";
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
            txt_quantidade.Text = "";
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
            //quando a data é colocada ele mostra na lb_reservasfeitas as reservas feitas nesse dia
            lb_reservasfeitas.DataSource = ReservationController.GetReservationsByDate(dtp_verReserva.Value);

        }

        private void lb_reservasfeitas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_reservasfeitas.SelectedItem != null && lb_reservasfeitas.SelectedItem.GetType() == typeof(Reservation))
            {
                
                
                    Reservation reservation = (Reservation)lb_reservasfeitas.SelectedItem;


                

                if (reservation != null)
                    {
                    // Mostrar os detalhes da reserva
                    txt_prato.Text = reservation.Meal.Descricao;
                    int n = 1;

                    foreach (Extra extra in reservation.Extra)
                    {
                        switch(n)
                        {
                            case 1:
                                txt_extra1.Text = extra.Descricao;
                                break;
                            case 2:
                                txt_extra2.Text = extra.Descricao;
                                break;
                            case 3:
                                txt_extra3.Text = extra.Descricao;
                                break;
                        }
                        n++;
                    }
                }

            }
        }

        //funcao para imprimir fatura em txt
        private void ImprimirFaturaTxt(Reservation reserva)
        {
            try
            {
                string path = "Recibo";
                string fileName = "Fatura_" + reserva.Id + ".txt";
                string fullPath = Path.Combine(path, fileName);

                // Verificar se a pasta existe, e criar se não existir
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using (StreamWriter sw = new StreamWriter(fullPath))
                {
                    sw.WriteLine("Fatura nº: " + reserva.Id);
                    sw.WriteLine("Data: " + reserva.Menu.DataHora);
                    sw.WriteLine("Nome: " + reserva.Customer.Nome);
                    sw.WriteLine("NIF: " + reserva.Customer.Nif);
                    sw.WriteLine("Prato: " + reserva.Meal.Descricao);
                    sw.WriteLine("Extras: ");
                    foreach (Extra extra in reserva.Extra)
                    {
                        sw.WriteLine(extra.Descricao);
                    }

                    decimal fee = CheckMulta();
                    if (fee != 0)
                    {
                        sw.WriteLine("Multa: " + fee);
                    }
                    sw.WriteLine("Preço total: " + _precoTotal);
                }

                MessageBox.Show("Fatura TXT gerada com sucesso.");
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Acesso negado ao caminho: " + ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show("Diretório não encontrado: " + ex.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Erro de I/O: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void ImprimirFaturaPdf(Reservation reserva)
        {
            try
            {
                string path = "Fatura";
                string fileName = "Fatura_" + reserva.Id + ".pdf";
                string fullPath = Path.Combine(path, fileName);

                // Verificar se a pasta existe, e criar se não existir
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                // Cria o documento PDF
                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream(fullPath, FileMode.Create));
                document.Open();

                // Adiciona conteúdo ao documento
                document.Add(new Paragraph("Fatura nº: " + reserva.Id));
                document.Add(new Paragraph("Data: " + reserva.Menu.DataHora));
                document.Add(new Paragraph("Nome: " + reserva.Customer.Nome));
                document.Add(new Paragraph("NIF: " + reserva.Customer.Nif));
                document.Add(new Paragraph("Prato: " + reserva.Meal.Descricao));
                document.Add(new Paragraph("Extras:"));

                foreach (Extra extra in reserva.Extra)
                {
                    document.Add(new Paragraph(extra.Descricao));
                }

                decimal fee = CheckMulta();
                if (fee != 0)
                {
                    document.Add(new Paragraph("Multa: " + fee));
                }
                document.Add(new Paragraph("Preço total: " + _precoTotal));

                // Fecha o documento
                document.Close();

                MessageBox.Show("Fatura PDF gerada com sucesso.");
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Acesso negado ao caminho: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void btn_reserva_Click(object sender, EventArgs e)
        {

            //quando este buttao é carregado ele ve se a reserva selecionada no lb_reservasfeitas é se já foi consumida ou não
            //se já foi consumida ele mostra mensagem de erro
            //se não foi consumida ele consome a reserva e mostra mensagem de sucesso
            if (lb_reservasfeitas.SelectedItem != null && lb_reservasfeitas.SelectedItem.GetType() == typeof(Reservation))
            {
                Reservation reserva = (Reservation)lb_reservasfeitas.SelectedItem;
                if (reserva.Consumido == true)
                {
                    MessageBox.Show("Reserva já consumida");
                    clear();
                    return;
                }
                else
                {
                    if (ReservationController.ConsumirReserva(reserva.Id))
                    {
                        MessageBox.Show("Reserva consumida com sucesso");
                        lb_reservasfeitas.DataSource = ReservationController.GetReservationsByDate(dtp_verReserva.Value);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao consumir reserva");
                        clear();
                        return;
                    }
                }
            }

        }
        private void clear()
        {
            txt_extra1.Text = "";
            txt_extra2.Text = "";
            txt_extra3.Text = "";
            txt_prato.Text = "";
        }

    }

}
