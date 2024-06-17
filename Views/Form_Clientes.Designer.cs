namespace iCantina.Views
{
    partial class Form_Cliente
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_cliente = new System.Windows.Forms.TabPage();
            this.btn_mostrarProfessor = new System.Windows.Forms.Button();
            this.btn_mostrarEstudantes = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_procurar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_procurarNif = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_addSaldo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_saldoAtual = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_saldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_cliente = new System.Windows.Forms.GroupBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_numEstudante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_professor = new System.Windows.Forms.RadioButton();
            this.rb_estudante = new System.Windows.Forms.RadioButton();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.txt_nif = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.btn_mostrarTodos = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.lb_cliente = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tp_funcionarios = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_nifFuncionario = new System.Windows.Forms.TextBox();
            this.txt_nomeFuncionario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_funcionarios = new System.Windows.Forms.ListBox();
            this.btn_deleteFuncionario = new System.Windows.Forms.Button();
            this.btn_editarFuncionario = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tp_cliente.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gb_cliente.SuspendLayout();
            this.groupBoxUser.SuspendLayout();
            this.tp_funcionarios.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_cliente);
            this.tabControl1.Controls.Add(this.tp_funcionarios);
            this.tabControl1.Location = new System.Drawing.Point(4, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(935, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // tp_cliente
            // 
            this.tp_cliente.Controls.Add(this.btn_mostrarProfessor);
            this.tp_cliente.Controls.Add(this.btn_mostrarEstudantes);
            this.tp_cliente.Controls.Add(this.btn_Delete);
            this.tp_cliente.Controls.Add(this.btn_procurar);
            this.tp_cliente.Controls.Add(this.groupBox4);
            this.tp_cliente.Controls.Add(this.btn_edit);
            this.tp_cliente.Controls.Add(this.btn_addSaldo);
            this.tp_cliente.Controls.Add(this.groupBox3);
            this.tp_cliente.Controls.Add(this.gb_cliente);
            this.tp_cliente.Controls.Add(this.groupBoxUser);
            this.tp_cliente.Controls.Add(this.btn_mostrarTodos);
            this.tp_cliente.Controls.Add(this.btn_select);
            this.tp_cliente.Controls.Add(this.lb_cliente);
            this.tp_cliente.Controls.Add(this.label1);
            this.tp_cliente.Location = new System.Drawing.Point(4, 25);
            this.tp_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_cliente.Name = "tp_cliente";
            this.tp_cliente.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_cliente.Size = new System.Drawing.Size(927, 532);
            this.tp_cliente.TabIndex = 0;
            this.tp_cliente.Text = "Clientes";
            this.tp_cliente.UseVisualStyleBackColor = true;
            // 
            // btn_mostrarProfessor
            // 
            this.btn_mostrarProfessor.Location = new System.Drawing.Point(21, 450);
            this.btn_mostrarProfessor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_mostrarProfessor.Name = "btn_mostrarProfessor";
            this.btn_mostrarProfessor.Size = new System.Drawing.Size(221, 30);
            this.btn_mostrarProfessor.TabIndex = 34;
            this.btn_mostrarProfessor.Text = "Mostrar Professores";
            this.btn_mostrarProfessor.UseVisualStyleBackColor = true;
            this.btn_mostrarProfessor.Click += new System.EventHandler(this.btn_mostrarProfessor_Click);
            // 
            // btn_mostrarEstudantes
            // 
            this.btn_mostrarEstudantes.Location = new System.Drawing.Point(21, 417);
            this.btn_mostrarEstudantes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_mostrarEstudantes.Name = "btn_mostrarEstudantes";
            this.btn_mostrarEstudantes.Size = new System.Drawing.Size(221, 30);
            this.btn_mostrarEstudantes.TabIndex = 33;
            this.btn_mostrarEstudantes.Text = "Mostrar Estudantes";
            this.btn_mostrarEstudantes.UseVisualStyleBackColor = true;
            this.btn_mostrarEstudantes.Click += new System.EventHandler(this.btn_mostrarEstudantes_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(605, 473);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(248, 34);
            this.btn_Delete.TabIndex = 32;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_procurar
            // 
            this.btn_procurar.Location = new System.Drawing.Point(291, 185);
            this.btn_procurar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_procurar.Name = "btn_procurar";
            this.btn_procurar.Size = new System.Drawing.Size(285, 34);
            this.btn_procurar.TabIndex = 31;
            this.btn_procurar.Text = "Procurar";
            this.btn_procurar.UseVisualStyleBackColor = true;
            this.btn_procurar.Click += new System.EventHandler(this.btn_procurar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_procurarNif);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(291, 53);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(285, 110);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Procurar";
            // 
            // txt_procurarNif
            // 
            this.txt_procurarNif.Location = new System.Drawing.Point(92, 39);
            this.txt_procurarNif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_procurarNif.MaxLength = 9;
            this.txt_procurarNif.Name = "txt_procurarNif";
            this.txt_procurarNif.Size = new System.Drawing.Size(169, 22);
            this.txt_procurarNif.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "NIF:";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(605, 414);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(248, 34);
            this.btn_edit.TabIndex = 29;
            this.btn_edit.Text = "Editar Cliente";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_addSaldo
            // 
            this.btn_addSaldo.Location = new System.Drawing.Point(291, 386);
            this.btn_addSaldo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addSaldo.Name = "btn_addSaldo";
            this.btn_addSaldo.Size = new System.Drawing.Size(285, 34);
            this.btn_addSaldo.TabIndex = 28;
            this.btn_addSaldo.Text = "Adicionar Saldo";
            this.btn_addSaldo.UseVisualStyleBackColor = true;
            this.btn_addSaldo.Click += new System.EventHandler(this.btn_addSaldo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_saldoAtual);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txt_saldo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(291, 267);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(285, 110);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Saldo";
            // 
            // txt_saldoAtual
            // 
            this.txt_saldoAtual.Enabled = false;
            this.txt_saldoAtual.Location = new System.Drawing.Point(111, 32);
            this.txt_saldoAtual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_saldoAtual.Name = "txt_saldoAtual";
            this.txt_saldoAtual.Size = new System.Drawing.Size(100, 22);
            this.txt_saldoAtual.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "Saldo atual: ";
            // 
            // txt_saldo
            // 
            this.txt_saldo.Location = new System.Drawing.Point(92, 70);
            this.txt_saldo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_saldo.Name = "txt_saldo";
            this.txt_saldo.Size = new System.Drawing.Size(100, 22);
            this.txt_saldo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Saldo: ";
            // 
            // gb_cliente
            // 
            this.gb_cliente.Controls.Add(this.txt_email);
            this.gb_cliente.Controls.Add(this.txt_numEstudante);
            this.gb_cliente.Controls.Add(this.label4);
            this.gb_cliente.Controls.Add(this.rb_professor);
            this.gb_cliente.Controls.Add(this.rb_estudante);
            this.gb_cliente.Enabled = false;
            this.gb_cliente.Location = new System.Drawing.Point(605, 185);
            this.gb_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_cliente.Name = "gb_cliente";
            this.gb_cliente.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_cliente.Size = new System.Drawing.Size(248, 219);
            this.gb_cliente.TabIndex = 25;
            this.gb_cliente.TabStop = false;
            this.gb_cliente.Text = "Cliente";
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            this.txt_email.Location = new System.Drawing.Point(19, 167);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(212, 22);
            this.txt_email.TabIndex = 34;
            // 
            // txt_numEstudante
            // 
            this.txt_numEstudante.Enabled = false;
            this.txt_numEstudante.Location = new System.Drawing.Point(105, 71);
            this.txt_numEstudante.Margin = new System.Windows.Forms.Padding(4);
            this.txt_numEstudante.MaxLength = 7;
            this.txt_numEstudante.Name = "txt_numEstudante";
            this.txt_numEstudante.Size = new System.Drawing.Size(125, 22);
            this.txt_numEstudante.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nº Estudante";
            // 
            // rb_professor
            // 
            this.rb_professor.AutoSize = true;
            this.rb_professor.Enabled = false;
            this.rb_professor.Location = new System.Drawing.Point(19, 130);
            this.rb_professor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_professor.Name = "rb_professor";
            this.rb_professor.Size = new System.Drawing.Size(86, 20);
            this.rb_professor.TabIndex = 1;
            this.rb_professor.TabStop = true;
            this.rb_professor.Text = "Professor";
            this.rb_professor.UseVisualStyleBackColor = true;
            // 
            // rb_estudante
            // 
            this.rb_estudante.AutoSize = true;
            this.rb_estudante.Enabled = false;
            this.rb_estudante.Location = new System.Drawing.Point(19, 39);
            this.rb_estudante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_estudante.Name = "rb_estudante";
            this.rb_estudante.Size = new System.Drawing.Size(88, 20);
            this.rb_estudante.TabIndex = 0;
            this.rb_estudante.TabStop = true;
            this.rb_estudante.Text = "Estudante";
            this.rb_estudante.UseVisualStyleBackColor = true;
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.txt_nif);
            this.groupBoxUser.Controls.Add(this.label2);
            this.groupBoxUser.Controls.Add(this.label11);
            this.groupBoxUser.Controls.Add(this.txt_nome);
            this.groupBoxUser.Enabled = false;
            this.groupBoxUser.Location = new System.Drawing.Point(605, 53);
            this.groupBoxUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxUser.Size = new System.Drawing.Size(248, 110);
            this.groupBoxUser.TabIndex = 22;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "User";
            // 
            // txt_nif
            // 
            this.txt_nif.Location = new System.Drawing.Point(93, 60);
            this.txt_nif.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nif.MaxLength = 9;
            this.txt_nif.Name = "txt_nif";
            this.txt_nif.Size = new System.Drawing.Size(137, 22);
            this.txt_nif.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "NIF:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(93, 27);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(137, 22);
            this.txt_nome.TabIndex = 2;
            // 
            // btn_mostrarTodos
            // 
            this.btn_mostrarTodos.Location = new System.Drawing.Point(21, 482);
            this.btn_mostrarTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_mostrarTodos.Name = "btn_mostrarTodos";
            this.btn_mostrarTodos.Size = new System.Drawing.Size(221, 30);
            this.btn_mostrarTodos.TabIndex = 21;
            this.btn_mostrarTodos.Text = "Mostrar todos";
            this.btn_mostrarTodos.UseVisualStyleBackColor = true;
            this.btn_mostrarTodos.Click += new System.EventHandler(this.btn_mostrarTodos_Click);
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(389, 447);
            this.btn_select.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(111, 23);
            this.btn_select.TabIndex = 20;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = true;
            // 
            // lb_cliente
            // 
            this.lb_cliente.FormattingEnabled = true;
            this.lb_cliente.ItemHeight = 16;
            this.lb_cliente.Location = new System.Drawing.Point(21, 21);
            this.lb_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_cliente.Name = "lb_cliente";
            this.lb_cliente.Size = new System.Drawing.Size(221, 388);
            this.lb_cliente.TabIndex = 19;
            this.lb_cliente.SelectedIndexChanged += new System.EventHandler(this.lb_cliente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Clientes";
            // 
            // tp_funcionarios
            // 
            this.tp_funcionarios.Controls.Add(this.btn_editarFuncionario);
            this.tp_funcionarios.Controls.Add(this.btn_deleteFuncionario);
            this.tp_funcionarios.Controls.Add(this.lb_funcionarios);
            this.tp_funcionarios.Controls.Add(this.groupBox2);
            this.tp_funcionarios.Controls.Add(this.label10);
            this.tp_funcionarios.Location = new System.Drawing.Point(4, 25);
            this.tp_funcionarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_funcionarios.Name = "tp_funcionarios";
            this.tp_funcionarios.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_funcionarios.Size = new System.Drawing.Size(927, 532);
            this.tp_funcionarios.TabIndex = 1;
            this.tp_funcionarios.Text = "Funcionarios";
            this.tp_funcionarios.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_username);
            this.groupBox2.Controls.Add(this.txt_nifFuncionario);
            this.groupBox2.Controls.Add(this.txt_nomeFuncionario);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(420, 85);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(257, 161);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editar Funcionário";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(103, 117);
            this.txt_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(121, 22);
            this.txt_username.TabIndex = 5;
            // 
            // txt_nifFuncionario
            // 
            this.txt_nifFuncionario.Location = new System.Drawing.Point(103, 75);
            this.txt_nifFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nifFuncionario.Name = "txt_nifFuncionario";
            this.txt_nifFuncionario.Size = new System.Drawing.Size(121, 22);
            this.txt_nifFuncionario.TabIndex = 4;
            // 
            // txt_nomeFuncionario
            // 
            this.txt_nomeFuncionario.Location = new System.Drawing.Point(103, 37);
            this.txt_nomeFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nomeFuncionario.Name = "txt_nomeFuncionario";
            this.txt_nomeFuncionario.Size = new System.Drawing.Size(121, 22);
            this.txt_nomeFuncionario.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "NIF:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nome:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Username:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(368, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 32);
            this.label10.TabIndex = 24;
            this.label10.Text = "Funcionário";
            // 
            // lb_funcionarios
            // 
            this.lb_funcionarios.FormattingEnabled = true;
            this.lb_funcionarios.ItemHeight = 16;
            this.lb_funcionarios.Location = new System.Drawing.Point(162, 75);
            this.lb_funcionarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_funcionarios.Name = "lb_funcionarios";
            this.lb_funcionarios.Size = new System.Drawing.Size(221, 388);
            this.lb_funcionarios.TabIndex = 35;
            this.lb_funcionarios.SelectedIndexChanged += new System.EventHandler(this.lb_funcionarios_SelectedIndexChanged);
            // 
            // btn_deleteFuncionario
            // 
            this.btn_deleteFuncionario.Location = new System.Drawing.Point(420, 312);
            this.btn_deleteFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_deleteFuncionario.Name = "btn_deleteFuncionario";
            this.btn_deleteFuncionario.Size = new System.Drawing.Size(257, 34);
            this.btn_deleteFuncionario.TabIndex = 36;
            this.btn_deleteFuncionario.Text = "Delete";
            this.btn_deleteFuncionario.UseVisualStyleBackColor = true;
            this.btn_deleteFuncionario.Click += new System.EventHandler(this.btn_deleteFuncionario_Click);
            // 
            // btn_editarFuncionario
            // 
            this.btn_editarFuncionario.Location = new System.Drawing.Point(420, 262);
            this.btn_editarFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_editarFuncionario.Name = "btn_editarFuncionario";
            this.btn_editarFuncionario.Size = new System.Drawing.Size(257, 34);
            this.btn_editarFuncionario.TabIndex = 37;
            this.btn_editarFuncionario.Text = "Editar";
            this.btn_editarFuncionario.UseVisualStyleBackColor = true;
            this.btn_editarFuncionario.Click += new System.EventHandler(this.btn_editarFuncionario_Click);
            // 
            // Form_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 562);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Cliente";
            this.Text = "Form_Cliente";
            this.tabControl1.ResumeLayout(false);
            this.tp_cliente.ResumeLayout(false);
            this.tp_cliente.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gb_cliente.ResumeLayout(false);
            this.gb_cliente.PerformLayout();
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            this.tp_funcionarios.ResumeLayout(false);
            this.tp_funcionarios.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_cliente;
        private System.Windows.Forms.TabPage tp_funcionarios;
        private System.Windows.Forms.Button btn_mostrarTodos;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.ListBox lb_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_nifFuncionario;
        private System.Windows.Forms.TextBox txt_nomeFuncionario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gb_cliente;
        private System.Windows.Forms.TextBox txt_numEstudante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_professor;
        private System.Windows.Forms.RadioButton rb_estudante;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.TextBox txt_nif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_saldo;
        private System.Windows.Forms.Button btn_addSaldo;
        private System.Windows.Forms.Button btn_procurar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_procurarNif;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox txt_saldoAtual;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_mostrarProfessor;
        private System.Windows.Forms.Button btn_mostrarEstudantes;
        private System.Windows.Forms.ListBox lb_funcionarios;
        private System.Windows.Forms.Button btn_editarFuncionario;
        private System.Windows.Forms.Button btn_deleteFuncionario;
    }
}