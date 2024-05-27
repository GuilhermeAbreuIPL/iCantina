namespace iCantina.Views
{
    partial class Form_RegistarUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_nif = new System.Windows.Forms.TextBox();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.groupBoxTipo = new System.Windows.Forms.GroupBox();
            this.rb_cliente = new System.Windows.Forms.RadioButton();
            this.rb_funcionario = new System.Windows.Forms.RadioButton();
            this.gb_funcionario = new System.Windows.Forms.GroupBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_cliente = new System.Windows.Forms.GroupBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_numEstudante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_professor = new System.Windows.Forms.RadioButton();
            this.rb_estudante = new System.Windows.Forms.RadioButton();
            this.btn_introduzir = new System.Windows.Forms.Button();
            this.lbl_avisos = new System.Windows.Forms.Label();
            this.groupBoxUser.SuspendLayout();
            this.groupBoxTipo.SuspendLayout();
            this.gb_funcionario.SuspendLayout();
            this.gb_cliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIF:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(93, 27);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 22);
            this.txt_nome.TabIndex = 2;
            // 
            // txt_nif
            // 
            this.txt_nif.Location = new System.Drawing.Point(93, 60);
            this.txt_nif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nif.Name = "txt_nif";
            this.txt_nif.Size = new System.Drawing.Size(100, 22);
            this.txt_nif.TabIndex = 3;
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.txt_nif);
            this.groupBoxUser.Controls.Add(this.label1);
            this.groupBoxUser.Controls.Add(this.label2);
            this.groupBoxUser.Controls.Add(this.txt_nome);
            this.groupBoxUser.Location = new System.Drawing.Point(195, 94);
            this.groupBoxUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxUser.Size = new System.Drawing.Size(251, 110);
            this.groupBoxUser.TabIndex = 4;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "User";
            // 
            // groupBoxTipo
            // 
            this.groupBoxTipo.Controls.Add(this.rb_cliente);
            this.groupBoxTipo.Controls.Add(this.rb_funcionario);
            this.groupBoxTipo.Location = new System.Drawing.Point(467, 97);
            this.groupBoxTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTipo.Name = "groupBoxTipo";
            this.groupBoxTipo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTipo.Size = new System.Drawing.Size(248, 105);
            this.groupBoxTipo.TabIndex = 5;
            this.groupBoxTipo.TabStop = false;
            this.groupBoxTipo.Text = "Tipo";
            // 
            // rb_cliente
            // 
            this.rb_cliente.AutoSize = true;
            this.rb_cliente.Location = new System.Drawing.Point(21, 50);
            this.rb_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_cliente.Name = "rb_cliente";
            this.rb_cliente.Size = new System.Drawing.Size(69, 20);
            this.rb_cliente.TabIndex = 1;
            this.rb_cliente.TabStop = true;
            this.rb_cliente.Text = "Cliente";
            this.rb_cliente.UseVisualStyleBackColor = true;
            this.rb_cliente.CheckedChanged += new System.EventHandler(this.rb_cliente_CheckedChanged);
            // 
            // rb_funcionario
            // 
            this.rb_funcionario.AutoSize = true;
            this.rb_funcionario.Location = new System.Drawing.Point(21, 25);
            this.rb_funcionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_funcionario.Name = "rb_funcionario";
            this.rb_funcionario.Size = new System.Drawing.Size(98, 20);
            this.rb_funcionario.TabIndex = 0;
            this.rb_funcionario.TabStop = true;
            this.rb_funcionario.Text = "Funcionário";
            this.rb_funcionario.UseVisualStyleBackColor = true;
            this.rb_funcionario.CheckedChanged += new System.EventHandler(this.rb_funcionario_CheckedChanged);
            // 
            // gb_funcionario
            // 
            this.gb_funcionario.Controls.Add(this.txt_user);
            this.gb_funcionario.Controls.Add(this.label3);
            this.gb_funcionario.Enabled = false;
            this.gb_funcionario.Location = new System.Drawing.Point(467, 229);
            this.gb_funcionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_funcionario.Name = "gb_funcionario";
            this.gb_funcionario.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_funcionario.Size = new System.Drawing.Size(251, 135);
            this.gb_funcionario.TabIndex = 6;
            this.gb_funcionario.TabStop = false;
            this.gb_funcionario.Text = "Funcionário";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(100, 18);
            this.txt_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(135, 22);
            this.txt_user.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username: ";
            // 
            // gb_cliente
            // 
            this.gb_cliente.Controls.Add(this.txt_email);
            this.gb_cliente.Controls.Add(this.txt_numEstudante);
            this.gb_cliente.Controls.Add(this.label5);
            this.gb_cliente.Controls.Add(this.label4);
            this.gb_cliente.Controls.Add(this.rb_professor);
            this.gb_cliente.Controls.Add(this.rb_estudante);
            this.gb_cliente.Enabled = false;
            this.gb_cliente.Location = new System.Drawing.Point(195, 229);
            this.gb_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_cliente.Name = "gb_cliente";
            this.gb_cliente.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_cliente.Size = new System.Drawing.Size(248, 206);
            this.gb_cliente.TabIndex = 7;
            this.gb_cliente.TabStop = false;
            this.gb_cliente.Text = "Cliente";
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            this.txt_email.Location = new System.Drawing.Point(77, 155);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(145, 22);
            this.txt_email.TabIndex = 5;
            // 
            // txt_numEstudante
            // 
            this.txt_numEstudante.Enabled = false;
            this.txt_numEstudante.Location = new System.Drawing.Point(109, 63);
            this.txt_numEstudante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_numEstudante.Name = "txt_numEstudante";
            this.txt_numEstudante.Size = new System.Drawing.Size(115, 22);
            this.txt_numEstudante.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nº Estudante";
            // 
            // rb_professor
            // 
            this.rb_professor.AutoSize = true;
            this.rb_professor.Location = new System.Drawing.Point(21, 116);
            this.rb_professor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_professor.Name = "rb_professor";
            this.rb_professor.Size = new System.Drawing.Size(86, 20);
            this.rb_professor.TabIndex = 1;
            this.rb_professor.TabStop = true;
            this.rb_professor.Text = "Professor";
            this.rb_professor.UseVisualStyleBackColor = true;
            this.rb_professor.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rb_estudante
            // 
            this.rb_estudante.AutoSize = true;
            this.rb_estudante.Location = new System.Drawing.Point(21, 31);
            this.rb_estudante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_estudante.Name = "rb_estudante";
            this.rb_estudante.Size = new System.Drawing.Size(88, 20);
            this.rb_estudante.TabIndex = 0;
            this.rb_estudante.TabStop = true;
            this.rb_estudante.Text = "Estudante";
            this.rb_estudante.UseVisualStyleBackColor = true;
            this.rb_estudante.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btn_introduzir
            // 
            this.btn_introduzir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_introduzir.Location = new System.Drawing.Point(467, 384);
            this.btn_introduzir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_introduzir.Name = "btn_introduzir";
            this.btn_introduzir.Size = new System.Drawing.Size(248, 50);
            this.btn_introduzir.TabIndex = 8;
            this.btn_introduzir.Text = "Introduzir User";
            this.btn_introduzir.UseVisualStyleBackColor = true;
            this.btn_introduzir.Click += new System.EventHandler(this.btn_introduzir_Click);
            // 
            // lbl_avisos
            // 
            this.lbl_avisos.AutoSize = true;
            this.lbl_avisos.Location = new System.Drawing.Point(464, 450);
            this.lbl_avisos.Name = "lbl_avisos";
            this.lbl_avisos.Size = new System.Drawing.Size(0, 16);
            this.lbl_avisos.TabIndex = 9;
            // 
            // Form_RegistarUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 562);
            this.Controls.Add(this.lbl_avisos);
            this.Controls.Add(this.btn_introduzir);
            this.Controls.Add(this.gb_cliente);
            this.Controls.Add(this.gb_funcionario);
            this.Controls.Add(this.groupBoxTipo);
            this.Controls.Add(this.groupBoxUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_RegistarUser";
            this.Text = " ";
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            this.groupBoxTipo.ResumeLayout(false);
            this.groupBoxTipo.PerformLayout();
            this.gb_funcionario.ResumeLayout(false);
            this.gb_funcionario.PerformLayout();
            this.gb_cliente.ResumeLayout(false);
            this.gb_cliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_nif;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.GroupBox groupBoxTipo;
        private System.Windows.Forms.RadioButton rb_cliente;
        private System.Windows.Forms.RadioButton rb_funcionario;
        private System.Windows.Forms.GroupBox gb_funcionario;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gb_cliente;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_numEstudante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_professor;
        private System.Windows.Forms.RadioButton rb_estudante;
        private System.Windows.Forms.Button btn_introduzir;
        private System.Windows.Forms.Label lbl_avisos;
    }
}