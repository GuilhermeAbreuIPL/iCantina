namespace iCantina.Views
{
    partial class Form_Menu
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
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.cb_horario = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_criar = new System.Windows.Forms.Button();
            this.btn_addExtras = new System.Windows.Forms.Button();
            this.btn_addPrato = new System.Windows.Forms.Button();
            this.btn_retirar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_extras = new System.Windows.Forms.ListBox();
            this.lb_pratos = new System.Windows.Forms.ListBox();
            this.lb_menu = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_precoProf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_precoAluno = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_data
            // 
            this.dtp_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_data.Location = new System.Drawing.Point(20, 31);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(200, 22);
            this.dtp_data.TabIndex = 3;
            // 
            // cb_horario
            // 
            this.cb_horario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_horario.FormattingEnabled = true;
            this.cb_horario.Location = new System.Drawing.Point(244, 29);
            this.cb_horario.Name = "cb_horario";
            this.cb_horario.Size = new System.Drawing.Size(121, 24);
            this.cb_horario.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(152, 372);
            this.listBox1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Menus Existentes:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_precoAluno);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_precoProf);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.btn_editar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_quantidade);
            this.groupBox1.Controls.Add(this.btn_criar);
            this.groupBox1.Controls.Add(this.btn_addExtras);
            this.groupBox1.Controls.Add(this.btn_addPrato);
            this.groupBox1.Controls.Add(this.btn_retirar);
            this.groupBox1.Controls.Add(this.cb_horario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtp_data);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lb_extras);
            this.groupBox1.Controls.Add(this.lb_pratos);
            this.groupBox1.Controls.Add(this.lb_menu);
            this.groupBox1.Location = new System.Drawing.Point(170, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 538);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criar / Editar Menu";
            // 
            // btn_criar
            // 
            this.btn_criar.Location = new System.Drawing.Point(20, 452);
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.Size = new System.Drawing.Size(77, 37);
            this.btn_criar.TabIndex = 19;
            this.btn_criar.Text = "Criar";
            this.btn_criar.UseVisualStyleBackColor = true;
            this.btn_criar.Click += new System.EventHandler(this.btn_criar_Click_1);
            // 
            // btn_addExtras
            // 
            this.btn_addExtras.Location = new System.Drawing.Point(409, 452);
            this.btn_addExtras.Name = "btn_addExtras";
            this.btn_addExtras.Size = new System.Drawing.Size(160, 38);
            this.btn_addExtras.TabIndex = 18;
            this.btn_addExtras.Text = "Adicionar";
            this.btn_addExtras.UseVisualStyleBackColor = true;
            this.btn_addExtras.Click += new System.EventHandler(this.btn_addExtras_Click);
            // 
            // btn_addPrato
            // 
            this.btn_addPrato.Location = new System.Drawing.Point(221, 452);
            this.btn_addPrato.Name = "btn_addPrato";
            this.btn_addPrato.Size = new System.Drawing.Size(157, 38);
            this.btn_addPrato.TabIndex = 17;
            this.btn_addPrato.Text = "Adicionar";
            this.btn_addPrato.UseVisualStyleBackColor = true;
            this.btn_addPrato.Click += new System.EventHandler(this.btn_addPrato_Click);
            // 
            // btn_retirar
            // 
            this.btn_retirar.Location = new System.Drawing.Point(103, 452);
            this.btn_retirar.Name = "btn_retirar";
            this.btn_retirar.Size = new System.Drawing.Size(86, 37);
            this.btn_retirar.TabIndex = 16;
            this.btn_retirar.Text = "Retirar";
            this.btn_retirar.UseVisualStyleBackColor = true;
            this.btn_retirar.Click += new System.EventHandler(this.btn_retirar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Extras Disponiveis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Pratos Disponiveis:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Menu:";
            // 
            // lb_extras
            // 
            this.lb_extras.FormattingEnabled = true;
            this.lb_extras.ItemHeight = 16;
            this.lb_extras.Location = new System.Drawing.Point(409, 98);
            this.lb_extras.Name = "lb_extras";
            this.lb_extras.Size = new System.Drawing.Size(160, 340);
            this.lb_extras.TabIndex = 12;
            // 
            // lb_pratos
            // 
            this.lb_pratos.FormattingEnabled = true;
            this.lb_pratos.ItemHeight = 16;
            this.lb_pratos.Location = new System.Drawing.Point(218, 98);
            this.lb_pratos.Name = "lb_pratos";
            this.lb_pratos.Size = new System.Drawing.Size(160, 340);
            this.lb_pratos.TabIndex = 11;
            // 
            // lb_menu
            // 
            this.lb_menu.FormattingEnabled = true;
            this.lb_menu.ItemHeight = 16;
            this.lb_menu.Location = new System.Drawing.Point(20, 98);
            this.lb_menu.Name = "lb_menu";
            this.lb_menu.Size = new System.Drawing.Size(169, 340);
            this.lb_menu.TabIndex = 10;
            this.lb_menu.SelectedIndexChanged += new System.EventHandler(this.lb_menu_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 31);
            this.button2.TabIndex = 14;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(600, 332);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(120, 22);
            this.txt_quantidade.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Quantidade Menus:";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(600, 452);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(124, 37);
            this.btn_clear.TabIndex = 15;
            this.btn_clear.Text = "Clear ALL";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(20, 495);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(169, 36);
            this.btn_editar.TabIndex = 22;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(597, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Preço Professor:";
            // 
            // txt_precoProf
            // 
            this.txt_precoProf.Location = new System.Drawing.Point(600, 193);
            this.txt_precoProf.Name = "txt_precoProf";
            this.txt_precoProf.Size = new System.Drawing.Size(120, 22);
            this.txt_precoProf.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(597, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Preço Aluno:";
            // 
            // txt_precoAluno
            // 
            this.txt_precoAluno.Location = new System.Drawing.Point(600, 258);
            this.txt_precoAluno.Name = "txt_precoAluno";
            this.txt_precoAluno.Size = new System.Drawing.Size(120, 22);
            this.txt_precoAluno.TabIndex = 26;
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 562);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Menu";
            this.Text = "Form_Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.ComboBox cb_horario;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_addExtras;
        private System.Windows.Forms.Button btn_addPrato;
        private System.Windows.Forms.Button btn_retirar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_extras;
        private System.Windows.Forms.ListBox lb_pratos;
        private System.Windows.Forms.ListBox lb_menu;
        private System.Windows.Forms.Button btn_criar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.TextBox txt_precoAluno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_precoProf;
        private System.Windows.Forms.Label label6;
    }
}