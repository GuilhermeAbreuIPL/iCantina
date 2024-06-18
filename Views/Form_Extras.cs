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
    public partial class Form_Extras : Form
    {
        public Form_Extras()
        {
            InitializeComponent();
            lb_extra.DataSource = ExtraController.ShowAll();
        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_criarDescricao.Text))
            {
                MessageBox.Show("Insira uma descrição");
                return;
            }

            Extra extra = new Extra();
            extra.Descricao = txt_criarDescricao.Text;
            try
            {
                extra.Preco = Convert.ToDecimal(txt_criarPreco.Text);
                if( extra.Preco <= 0 ) {
                    MessageBox.Show("O preço não pode ser menor nem igual a 0");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Insira um preço válido");
                return;
            }
            extra.Ativo = cb_criarAtivo.Checked;

            if (ExtraController.AddExtra(extra))
            {
                MessageBox.Show("Extra adicionado com sucesso!");
                lb_extra.DataSource = null;
                lb_extra.DataSource = ExtraController.ShowAll();
                txt_criarDescricao.Clear();
                txt_criarPreco.Clear();
                cb_criarAtivo.Checked = false;
                return;
            }
            else
            {
                MessageBox.Show("Erro ao adicionar extra");
                return;
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Extra selected = (Extra)lb_extra.SelectedItem;

            if (selected != null)
            {
                if (String.IsNullOrEmpty(txt_editDescricao.Text))
                {
                    MessageBox.Show("Insira uma descrição");
                    return;
                }

                selected.Descricao = txt_editDescricao.Text;

                try
                {
                    selected.Preco = Convert.ToDecimal(txt_editPreco.Text);
                    if (selected.Preco <= 0)
                    {
                        MessageBox.Show("O preço não pode ser menor nem igual a 0");
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Insira um preço válido");
                    return;
                }

                selected.Ativo = cb_editAtivo.Checked;

                if (ExtraController.UpdateExtra(selected.Id, selected.Descricao, selected.Preco, selected.Ativo))
                {
                    MessageBox.Show("Extra atualizado com sucesso!");
                    lb_extra.DataSource = null;
                    lb_extra.DataSource = ExtraController.ShowAll();
                    return;
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar extra");
                    return;
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Extra selected = (Extra)lb_extra.SelectedItem;

            if (selected != null)
            {
                if (ExtraController.DeleteExtra(selected.Id))
                {
                    MessageBox.Show("Extra deletado com sucesso!");
                    lb_extra.DataSource = null;
                    lb_extra.DataSource = ExtraController.ShowAll();
                    txt_editDescricao.Clear();
                    txt_editPreco.Clear();
                    cb_editAtivo.Checked = false;
                    return;
                }
                else
                {
                    MessageBox.Show("Erro ao deletar extra");
                    return;
                }
            }
        }

        private void lb_extra_SelectedIndexChanged(object sender, EventArgs e)
        {
            Extra selected = (Extra)lb_extra.SelectedItem;

            if (selected != null)
            {
                txt_editDescricao.Text = selected.Descricao;
                txt_editPreco.Text = selected.Preco.ToString();
                cb_editAtivo.Checked = selected.Ativo;
            }
        }

        private void lb_extra_Format(object sender, ListControlConvertEventArgs e)
        {

                if (e.ListItem is Extra extra)
                {
                    e.Value = extra.ToString() + (extra.Ativo ? " - Ativo" : " - Inativo");
                } 
        }
    }
}
