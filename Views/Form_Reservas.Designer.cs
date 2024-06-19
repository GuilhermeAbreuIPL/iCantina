namespace iCantina.Views
{
    partial class Form_Reservas
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gb_all = new System.Windows.Forms.GroupBox();
            this.gb_total = new System.Windows.Forms.GroupBox();
            this.txt_precoTotal = new System.Windows.Forms.TextBox();
            this.txt_precoExtra = new System.Windows.Forms.TextBox();
            this.txt_precoPrato = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_menus = new System.Windows.Forms.ListBox();
            this.btn_AddMenus = new System.Windows.Forms.Button();
            this.btn_Reservar = new System.Windows.Forms.Button();
            this.lb_reservar = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_extras = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_pratos = new System.Windows.Forms.ListBox();
            this.btn_retirar = new System.Windows.Forms.Button();
            this.btn_addExtras = new System.Windows.Forms.Button();
            this.btn_addPratos = new System.Windows.Forms.Button();
            this.dtp_criarReserva = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_saldo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_procurar = new System.Windows.Forms.Button();
            this.txt_nif = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gb_all.SuspendLayout();
            this.gb_total.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(704, 457);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gb_all);
            this.tabPage1.Controls.Add(this.dtp_criarReserva);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(696, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Criar Reserva";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gb_all
            // 
            this.gb_all.Controls.Add(this.gb_total);
            this.gb_all.Controls.Add(this.label2);
            this.gb_all.Controls.Add(this.lb_menus);
            this.gb_all.Controls.Add(this.btn_AddMenus);
            this.gb_all.Controls.Add(this.btn_Reservar);
            this.gb_all.Controls.Add(this.lb_reservar);
            this.gb_all.Controls.Add(this.label6);
            this.gb_all.Controls.Add(this.lb_extras);
            this.gb_all.Controls.Add(this.label5);
            this.gb_all.Controls.Add(this.lb_pratos);
            this.gb_all.Controls.Add(this.btn_retirar);
            this.gb_all.Controls.Add(this.btn_addExtras);
            this.gb_all.Controls.Add(this.btn_addPratos);
            this.gb_all.Enabled = false;
            this.gb_all.Location = new System.Drawing.Point(158, -22);
            this.gb_all.Name = "gb_all";
            this.gb_all.Size = new System.Drawing.Size(542, 457);
            this.gb_all.TabIndex = 39;
            this.gb_all.TabStop = false;
            this.gb_all.Text = "groupBox3";
            // 
            // gb_total
            // 
            this.gb_total.Controls.Add(this.txt_precoTotal);
            this.gb_total.Controls.Add(this.txt_precoExtra);
            this.gb_total.Controls.Add(this.txt_precoPrato);
            this.gb_total.Controls.Add(this.label13);
            this.gb_total.Controls.Add(this.label10);
            this.gb_total.Controls.Add(this.label9);
            this.gb_total.Location = new System.Drawing.Point(414, 259);
            this.gb_total.Margin = new System.Windows.Forms.Padding(2);
            this.gb_total.Name = "gb_total";
            this.gb_total.Padding = new System.Windows.Forms.Padding(2);
            this.gb_total.Size = new System.Drawing.Size(110, 172);
            this.gb_total.TabIndex = 50;
            this.gb_total.TabStop = false;
            this.gb_total.Text = "Total";
            // 
            // txt_precoTotal
            // 
            this.txt_precoTotal.Location = new System.Drawing.Point(28, 139);
            this.txt_precoTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txt_precoTotal.Name = "txt_precoTotal";
            this.txt_precoTotal.ReadOnly = true;
            this.txt_precoTotal.Size = new System.Drawing.Size(58, 20);
            this.txt_precoTotal.TabIndex = 5;
            // 
            // txt_precoExtra
            // 
            this.txt_precoExtra.Location = new System.Drawing.Point(28, 93);
            this.txt_precoExtra.Margin = new System.Windows.Forms.Padding(2);
            this.txt_precoExtra.Name = "txt_precoExtra";
            this.txt_precoExtra.ReadOnly = true;
            this.txt_precoExtra.Size = new System.Drawing.Size(58, 20);
            this.txt_precoExtra.TabIndex = 4;
            // 
            // txt_precoPrato
            // 
            this.txt_precoPrato.Location = new System.Drawing.Point(28, 45);
            this.txt_precoPrato.Margin = new System.Windows.Forms.Padding(2);
            this.txt_precoPrato.Name = "txt_precoPrato";
            this.txt_precoPrato.ReadOnly = true;
            this.txt_precoPrato.Size = new System.Drawing.Size(58, 20);
            this.txt_precoPrato.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 77);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Preço Extra:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 29);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Preço Menu:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 125);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Preço Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "Menus";
            // 
            // lb_menus
            // 
            this.lb_menus.FormattingEnabled = true;
            this.lb_menus.Location = new System.Drawing.Point(5, 57);
            this.lb_menus.Margin = new System.Windows.Forms.Padding(2);
            this.lb_menus.Name = "lb_menus";
            this.lb_menus.Size = new System.Drawing.Size(160, 147);
            this.lb_menus.TabIndex = 48;
            this.lb_menus.SelectedIndexChanged += new System.EventHandler(this.lb_menus_SelectedIndexChanged);
            // 
            // btn_AddMenus
            // 
            this.btn_AddMenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddMenus.Location = new System.Drawing.Point(5, 208);
            this.btn_AddMenus.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddMenus.Name = "btn_AddMenus";
            this.btn_AddMenus.Size = new System.Drawing.Size(159, 34);
            this.btn_AddMenus.TabIndex = 47;
            this.btn_AddMenus.Text = "Adicionar Menus";
            this.btn_AddMenus.UseVisualStyleBackColor = true;
            // 
            // btn_Reservar
            // 
            this.btn_Reservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reservar.Location = new System.Drawing.Point(257, 401);
            this.btn_Reservar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Reservar.Name = "btn_Reservar";
            this.btn_Reservar.Size = new System.Drawing.Size(141, 30);
            this.btn_Reservar.TabIndex = 46;
            this.btn_Reservar.Text = "Reservar";
            this.btn_Reservar.UseVisualStyleBackColor = true;
            // 
            // lb_reservar
            // 
            this.lb_reservar.FormattingEnabled = true;
            this.lb_reservar.Location = new System.Drawing.Point(94, 263);
            this.lb_reservar.Margin = new System.Windows.Forms.Padding(2);
            this.lb_reservar.Name = "lb_reservar";
            this.lb_reservar.Size = new System.Drawing.Size(305, 134);
            this.lb_reservar.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(363, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Extras";
            // 
            // lb_extras
            // 
            this.lb_extras.FormattingEnabled = true;
            this.lb_extras.Location = new System.Drawing.Point(365, 57);
            this.lb_extras.Margin = new System.Windows.Forms.Padding(2);
            this.lb_extras.Name = "lb_extras";
            this.lb_extras.Size = new System.Drawing.Size(160, 147);
            this.lb_extras.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(182, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Pratos";
            // 
            // lb_pratos
            // 
            this.lb_pratos.FormattingEnabled = true;
            this.lb_pratos.Location = new System.Drawing.Point(184, 57);
            this.lb_pratos.Margin = new System.Windows.Forms.Padding(2);
            this.lb_pratos.Name = "lb_pratos";
            this.lb_pratos.Size = new System.Drawing.Size(160, 147);
            this.lb_pratos.TabIndex = 41;
            // 
            // btn_retirar
            // 
            this.btn_retirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retirar.Location = new System.Drawing.Point(94, 401);
            this.btn_retirar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_retirar.Name = "btn_retirar";
            this.btn_retirar.Size = new System.Drawing.Size(151, 30);
            this.btn_retirar.TabIndex = 40;
            this.btn_retirar.Text = "Retirar";
            this.btn_retirar.UseVisualStyleBackColor = true;
            // 
            // btn_addExtras
            // 
            this.btn_addExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addExtras.Location = new System.Drawing.Point(365, 208);
            this.btn_addExtras.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addExtras.Name = "btn_addExtras";
            this.btn_addExtras.Size = new System.Drawing.Size(159, 34);
            this.btn_addExtras.TabIndex = 39;
            this.btn_addExtras.Text = "Adicionar Extra";
            this.btn_addExtras.UseVisualStyleBackColor = true;
            this.btn_addExtras.Click += new System.EventHandler(this.btn_addExtras_Click);
            // 
            // btn_addPratos
            // 
            this.btn_addPratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addPratos.Location = new System.Drawing.Point(185, 208);
            this.btn_addPratos.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addPratos.Name = "btn_addPratos";
            this.btn_addPratos.Size = new System.Drawing.Size(158, 34);
            this.btn_addPratos.TabIndex = 38;
            this.btn_addPratos.Text = "Adicionar Prato";
            this.btn_addPratos.UseVisualStyleBackColor = true;
            this.btn_addPratos.Click += new System.EventHandler(this.btn_addPratos_Click);
            // 
            // dtp_criarReserva
            // 
            this.dtp_criarReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_criarReserva.Location = new System.Drawing.Point(12, 254);
            this.dtp_criarReserva.Name = "dtp_criarReserva";
            this.dtp_criarReserva.Size = new System.Drawing.Size(138, 20);
            this.dtp_criarReserva.TabIndex = 38;
            this.dtp_criarReserva.ValueChanged += new System.EventHandler(this.dtp_criarReserva_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_saldo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_nome);
            this.groupBox2.Location = new System.Drawing.Point(10, 125);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(140, 119);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente ATIVO";
            // 
            // txt_saldo
            // 
            this.txt_saldo.Location = new System.Drawing.Point(16, 90);
            this.txt_saldo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_saldo.Name = "txt_saldo";
            this.txt_saldo.ReadOnly = true;
            this.txt_saldo.Size = new System.Drawing.Size(115, 20);
            this.txt_saldo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Saldo Disponivel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(16, 37);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.ReadOnly = true;
            this.txt_nome.Size = new System.Drawing.Size(115, 20);
            this.txt_nome.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_procurar);
            this.groupBox1.Controls.Add(this.txt_nif);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(140, 96);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Procurar Cliente:";
            // 
            // btn_procurar
            // 
            this.btn_procurar.Location = new System.Drawing.Point(74, 68);
            this.btn_procurar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_procurar.Name = "btn_procurar";
            this.btn_procurar.Size = new System.Drawing.Size(56, 19);
            this.btn_procurar.TabIndex = 2;
            this.btn_procurar.Text = "Procurar";
            this.btn_procurar.UseVisualStyleBackColor = true;
            this.btn_procurar.Click += new System.EventHandler(this.btn_procurar_Click);
            // 
            // txt_nif
            // 
            this.txt_nif.Location = new System.Drawing.Point(41, 33);
            this.txt_nif.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nif.MaxLength = 9;
            this.txt_nif.Name = "txt_nif";
            this.txt_nif.Size = new System.Drawing.Size(90, 20);
            this.txt_nif.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIF:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.listBox4);
            this.tabPage2.Controls.Add(this.monthCalendar2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(696, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ver Reservas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(476, 19);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 17);
            this.label11.TabIndex = 39;
            this.label11.Text = "Detalhes da Reserva";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(256, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Reservas Feitas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Dias da Reserva";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(478, 42);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(199, 199);
            this.listBox1.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(478, 259);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(198, 36);
            this.button5.TabIndex = 7;
            this.button5.Text = "Usar Reserva";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(259, 42);
            this.listBox4.Margin = new System.Windows.Forms.Padding(2);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(199, 199);
            this.listBox4.TabIndex = 1;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(10, 42);
            this.monthCalendar2.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 0;
            // 
            // Form_Reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 457);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Reservas";
            this.Text = "Form_Reservas";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gb_all.ResumeLayout(false);
            this.gb_all.PerformLayout();
            this.gb_total.ResumeLayout(false);
            this.gb_total.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gb_all;
        private System.Windows.Forms.DateTimePicker dtp_criarReserva;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_saldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_procurar;
        private System.Windows.Forms.TextBox txt_nif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_total;
        private System.Windows.Forms.TextBox txt_precoTotal;
        private System.Windows.Forms.TextBox txt_precoExtra;
        private System.Windows.Forms.TextBox txt_precoPrato;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_menus;
        private System.Windows.Forms.Button btn_AddMenus;
        private System.Windows.Forms.Button btn_Reservar;
        private System.Windows.Forms.ListBox lb_reservar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lb_extras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lb_pratos;
        private System.Windows.Forms.Button btn_retirar;
        private System.Windows.Forms.Button btn_addExtras;
        private System.Windows.Forms.Button btn_addPratos;
    }
}