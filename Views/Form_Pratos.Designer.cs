﻿namespace iCantina.Views
{
    partial class Form_Pratos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_pratos = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_criar = new System.Windows.Forms.Button();
            this.cb_criarAtivo = new System.Windows.Forms.CheckBox();
            this.cb_criarTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_criarDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.cb_editAtivo = new System.Windows.Forms.CheckBox();
            this.cb_editTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_editDescricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_pratos
            // 
            this.lb_pratos.FormattingEnabled = true;
            this.lb_pratos.Location = new System.Drawing.Point(168, 60);
            this.lb_pratos.Margin = new System.Windows.Forms.Padding(2);
            this.lb_pratos.Name = "lb_pratos";
            this.lb_pratos.Size = new System.Drawing.Size(167, 316);
            this.lb_pratos.TabIndex = 0;
            this.lb_pratos.SelectedIndexChanged += new System.EventHandler(this.lb_pratos_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_criar);
            this.groupBox1.Controls.Add(this.cb_criarAtivo);
            this.groupBox1.Controls.Add(this.cb_criarTipo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_criarDescricao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(364, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(213, 143);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criar";
            // 
            // cb_criarAtivo
            // 
            this.cb_criarAtivo.AutoSize = true;
            this.cb_criarAtivo.Location = new System.Drawing.Point(7, 112);
            this.cb_criarAtivo.Margin = new System.Windows.Forms.Padding(2);
            this.cb_criarAtivo.Name = "cb_criarAtivo";
            this.cb_criarAtivo.Size = new System.Drawing.Size(50, 17);
            this.cb_criarAtivo.TabIndex = 5;
            this.cb_criarAtivo.Text = "Ativo";
            this.cb_criarAtivo.UseVisualStyleBackColor = true;
            // 
            // cb_criarTipo
            // 
            this.cb_criarTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_criarTipo.FormattingEnabled = true;
            this.cb_criarTipo.Items.AddRange(new object[] {
            "Carne",
            "Peixe",
            "Vegetariano"});
            this.cb_criarTipo.Location = new System.Drawing.Point(63, 68);
            this.cb_criarTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cb_criarTipo.Name = "cb_criarTipo";
            this.cb_criarTipo.Size = new System.Drawing.Size(132, 21);
            this.cb_criarTipo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo:";
            // 
            // txt_criarDescricao
            // 
            this.txt_criarDescricao.Location = new System.Drawing.Point(63, 17);
            this.txt_criarDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.txt_criarDescricao.Multiline = true;
            this.txt_criarDescricao.Name = "txt_criarDescricao";
            this.txt_criarDescricao.Size = new System.Drawing.Size(132, 40);
            this.txt_criarDescricao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Pratos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_editar);
            this.groupBox2.Controls.Add(this.cb_editAtivo);
            this.groupBox2.Controls.Add(this.cb_editTipo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_editDescricao);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(364, 219);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(213, 156);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Criar";           // 
            // cb_editAtivo
            // 
            this.cb_editAtivo.AutoSize = true;
            this.cb_editAtivo.Location = new System.Drawing.Point(7, 112);
            this.cb_editAtivo.Margin = new System.Windows.Forms.Padding(2);
            this.cb_editAtivo.Name = "cb_editAtivo";
            this.cb_editAtivo.Size = new System.Drawing.Size(50, 17);
            this.cb_editAtivo.TabIndex = 5;
            this.cb_editAtivo.Text = "Ativo";
            this.cb_editAtivo.UseVisualStyleBackColor = true;
            // 
            // cb_editTipo
            // 
            this.cb_editTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_editTipo.FormattingEnabled = true;
            this.cb_editTipo.Items.AddRange(new object[] {
            "Carne",
            "Peixe",
            "Vegetariano"});
            this.cb_editTipo.Location = new System.Drawing.Point(63, 68);
            this.cb_editTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cb_editTipo.Name = "cb_editTipo";
            this.cb_editTipo.Size = new System.Drawing.Size(132, 21);
            this.cb_editTipo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo:";
            // 
            // txt_editDescricao
            // 
            this.txt_editDescricao.Location = new System.Drawing.Point(63, 17);
            this.txt_editDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.txt_editDescricao.Multiline = true;
            this.txt_editDescricao.Name = "txt_editDescricao";
            this.txt_editDescricao.Size = new System.Drawing.Size(132, 40);
            this.txt_editDescricao.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Descrição:";
            // 
            // Form_Pratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 457);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_pratos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Pratos";
            this.Text = "Form_Pratos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_pratos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_criarAtivo;
        private System.Windows.Forms.ComboBox cb_criarTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_criarDescricao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb_editAtivo;
        private System.Windows.Forms.ComboBox cb_editTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_editDescricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_criar;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_editar;
    }
}