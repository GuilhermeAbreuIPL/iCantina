namespace iCantina.Views
{
    partial class Teste
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.groupBoxTipo = new System.Windows.Forms.GroupBox();
            this.rb_cliente = new System.Windows.Forms.RadioButton();
            this.rb_funcionario = new System.Windows.Forms.RadioButton();
            this.gb_funcionario = new System.Windows.Forms.GroupBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_cliente = new System.Windows.Forms.GroupBox();
            this.rb_estudante = new System.Windows.Forms.RadioButton();
            this.rb_professor = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_estudante = new System.Windows.Forms.TextBox();
            this.txt_professor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIF:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.textBox2);
            this.groupBoxUser.Controls.Add(this.label1);
            this.groupBoxUser.Controls.Add(this.label2);
            this.groupBoxUser.Controls.Add(this.textBox1);
            this.groupBoxUser.Location = new System.Drawing.Point(195, 93);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(251, 109);
            this.groupBoxUser.TabIndex = 4;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "User";
            this.groupBoxUser.Enter += new System.EventHandler(this.groupBoxUser_Enter);
            // 
            // groupBoxTipo
            // 
            this.groupBoxTipo.Controls.Add(this.rb_cliente);
            this.groupBoxTipo.Controls.Add(this.rb_funcionario);
            this.groupBoxTipo.Location = new System.Drawing.Point(467, 97);
            this.groupBoxTipo.Name = "groupBoxTipo";
            this.groupBoxTipo.Size = new System.Drawing.Size(248, 105);
            this.groupBoxTipo.TabIndex = 5;
            this.groupBoxTipo.TabStop = false;
            this.groupBoxTipo.Text = "Tipo";
            // 
            // rb_cliente
            // 
            this.rb_cliente.AutoSize = true;
            this.rb_cliente.Location = new System.Drawing.Point(21, 50);
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
            this.gb_funcionario.Name = "gb_funcionario";
            this.gb_funcionario.Size = new System.Drawing.Size(251, 136);
            this.gb_funcionario.TabIndex = 6;
            this.gb_funcionario.TabStop = false;
            this.gb_funcionario.Text = "Funcionário";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(100, 19);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(134, 22);
            this.txt_user.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username: ";
            // 
            // gb_cliente
            // 
            this.gb_cliente.Controls.Add(this.txt_professor);
            this.gb_cliente.Controls.Add(this.txt_estudante);
            this.gb_cliente.Controls.Add(this.label5);
            this.gb_cliente.Controls.Add(this.label4);
            this.gb_cliente.Controls.Add(this.rb_professor);
            this.gb_cliente.Controls.Add(this.rb_estudante);
            this.gb_cliente.Enabled = false;
            this.gb_cliente.Location = new System.Drawing.Point(195, 229);
            this.gb_cliente.Name = "gb_cliente";
            this.gb_cliente.Size = new System.Drawing.Size(248, 206);
            this.gb_cliente.TabIndex = 7;
            this.gb_cliente.TabStop = false;
            this.gb_cliente.Text = "Cliente";
            this.gb_cliente.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rb_estudante
            // 
            this.rb_estudante.AutoSize = true;
            this.rb_estudante.Location = new System.Drawing.Point(21, 31);
            this.rb_estudante.Name = "rb_estudante";
            this.rb_estudante.Size = new System.Drawing.Size(88, 20);
            this.rb_estudante.TabIndex = 0;
            this.rb_estudante.TabStop = true;
            this.rb_estudante.Text = "Estudante";
            this.rb_estudante.UseVisualStyleBackColor = true;
            this.rb_estudante.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_professor
            // 
            this.rb_professor.AutoSize = true;
            this.rb_professor.Location = new System.Drawing.Point(21, 116);
            this.rb_professor.Name = "rb_professor";
            this.rb_professor.Size = new System.Drawing.Size(86, 20);
            this.rb_professor.TabIndex = 1;
            this.rb_professor.TabStop = true;
            this.rb_professor.Text = "Professor";
            this.rb_professor.UseVisualStyleBackColor = true;
            this.rb_professor.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nº Estudante";
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
            // txt_estudante
            // 
            this.txt_estudante.Enabled = false;
            this.txt_estudante.Location = new System.Drawing.Point(109, 63);
            this.txt_estudante.Name = "txt_estudante";
            this.txt_estudante.Size = new System.Drawing.Size(115, 22);
            this.txt_estudante.TabIndex = 4;
            // 
            // txt_professor
            // 
            this.txt_professor.Enabled = false;
            this.txt_professor.Location = new System.Drawing.Point(78, 155);
            this.txt_professor.Name = "txt_professor";
            this.txt_professor.Size = new System.Drawing.Size(146, 22);
            this.txt_professor.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(467, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "Introduzir User";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Teste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 563);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gb_cliente);
            this.Controls.Add(this.gb_funcionario);
            this.Controls.Add(this.groupBoxTipo);
            this.Controls.Add(this.groupBoxUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Teste";
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

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.GroupBox groupBoxTipo;
        private System.Windows.Forms.RadioButton rb_cliente;
        private System.Windows.Forms.RadioButton rb_funcionario;
        private System.Windows.Forms.GroupBox gb_funcionario;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gb_cliente;
        private System.Windows.Forms.TextBox txt_professor;
        private System.Windows.Forms.TextBox txt_estudante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_professor;
        private System.Windows.Forms.RadioButton rb_estudante;
        private System.Windows.Forms.Button button1;
    }
}