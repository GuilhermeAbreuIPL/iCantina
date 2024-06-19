using iCantina.Controllers;
using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.Views
{
    public partial class Form_Multas : Form
    {
        public Form_Multas()
        {
            InitializeComponent();
            lb_multas.DataSource = Controllers.FeeController.ShowAll();
        }

        private void lb_multas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fill the textboxes with the selected item

            Fee selected = (Fee)lb_multas.SelectedItem;

            if (selected != null)
            {
                txt_valorEdit.Text = selected.valor.ToString();
                nud_numHorasEdit.Text = selected.numHoras.ToString();
            }

        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_valorCriar.Text))
            {
                MessageBox.Show("Insira um valor");
                return;
            }

            Fee fee = new Fee();
            fee.valor = Convert.ToDecimal(txt_valorCriar.Text);
            fee.numHoras = nud_numHorasCriar.Value;

            decimal numHoras = nud_numHorasCriar.Value;

            decimal valor = 0;

            if (FeeController.VerificarMultaExistente(numHoras))
            {
                MessageBox.Show("Multa já existe!");
                return;
            }

            if (!decimal.TryParse(txt_valorCriar.Text, out valor) || valor <= 0)
            {
                MessageBox.Show("Quantidade introduzida não pode ser 0, ou numero negativo!");
                return;
            }

            if (Controllers.FeeController.AddFee(fee))
            {
                MessageBox.Show("Multa adicionada com sucesso!");
                lb_multas.DataSource = null;
                lb_multas.DataSource = Controllers.FeeController.ShowAll();
                txt_valorCriar.Clear();
                nud_numHorasCriar.Value = 0;
                return;
            }
            else
            {
                MessageBox.Show("Erro ao adicionar multa");
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Fee selected = (Fee)lb_multas.SelectedItem;

            if (selected != null)
            {
                if (String.IsNullOrEmpty(txt_valorEdit.Text))
                {
                    MessageBox.Show("Insira um valor");
                    return;
                }

                selected.valor = Convert.ToDecimal(txt_valorEdit.Text);
                selected.numHoras = nud_numHorasEdit.Value;

                
                decimal valor;
                decimal.TryParse(txt_valorEdit.Text, out valor);

                if (valor <= 0)
                {
                    MessageBox.Show("Quantidade introduzida não pode ser 0, ou numero negativo!");
                    return;
                }

                if (Controllers.FeeController.UpdateFee(selected.Id, selected.valor, selected.numHoras))
                {
                    MessageBox.Show("Multa atualizada com sucesso!");
                    lb_multas.DataSource = null;
                    lb_multas.DataSource = Controllers.FeeController.ShowAll();
                    txt_valorEdit.Clear();
                    nud_numHorasEdit.Value = 0;
                    return;
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar multa");
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Fee selected = (Fee)lb_multas.SelectedItem;

            if (selected != null)
            {
                if (Controllers.FeeController.DeleteFee(selected.Id))
                {
                    MessageBox.Show("Multa deletada com sucesso!");
                    lb_multas.DataSource = null;
                    lb_multas.DataSource = Controllers.FeeController.ShowAll();
                    return;
                }
                else
                {
                    MessageBox.Show("Erro ao deletar multa");
                }
            }
        }
    }
}
