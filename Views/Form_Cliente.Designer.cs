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
            this.gb_eliminar = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_eliminar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_editar = new System.Windows.Forms.GroupBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_nif = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_eliminar.SuspendLayout();
            this.gb_editar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_eliminar
            // 
            this.gb_eliminar.Controls.Add(this.button3);
            this.gb_eliminar.Controls.Add(this.txt_eliminar);
            this.gb_eliminar.Controls.Add(this.label5);
            this.gb_eliminar.Location = new System.Drawing.Point(484, 339);
            this.gb_eliminar.Name = "gb_eliminar";
            this.gb_eliminar.Size = new System.Drawing.Size(227, 126);
            this.gb_eliminar.TabIndex = 11;
            this.gb_eliminar.TabStop = false;
            this.gb_eliminar.Text = "Eliminar";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(125, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // txt_eliminar
            // 
            this.txt_eliminar.Location = new System.Drawing.Point(9, 46);
            this.txt_eliminar.Name = "txt_eliminar";
            this.txt_eliminar.ReadOnly = true;
            this.txt_eliminar.Size = new System.Drawing.Size(178, 22);
            this.txt_eliminar.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Eliminar User:";
            // 
            // gb_editar
            // 
            this.gb_editar.Controls.Add(this.btn_editar);
            this.gb_editar.Controls.Add(this.txt_username);
            this.gb_editar.Controls.Add(this.txt_nif);
            this.gb_editar.Controls.Add(this.txt_nome);
            this.gb_editar.Controls.Add(this.label4);
            this.gb_editar.Controls.Add(this.label3);
            this.gb_editar.Controls.Add(this.label2);
            this.gb_editar.Location = new System.Drawing.Point(484, 96);
            this.gb_editar.Name = "gb_editar";
            this.gb_editar.Size = new System.Drawing.Size(227, 210);
            this.gb_editar.TabIndex = 10;
            this.gb_editar.TabStop = false;
            this.gb_editar.Text = "Editar Cliente";
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(9, 143);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(197, 31);
            this.btn_editar.TabIndex = 5;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(85, 94);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(121, 22);
            this.txt_username.TabIndex = 5;
            // 
            // txt_nif
            // 
            this.txt_nif.Location = new System.Drawing.Point(85, 60);
            this.txt_nif.Name = "txt_nif";
            this.txt_nif.Size = new System.Drawing.Size(121, 22);
            this.txt_nif.TabIndex = 4;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(85, 30);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(121, 22);
            this.txt_nome.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "NIF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Update ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(230, 99);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(164, 308);
            this.listBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Clientes";
            // 
            // Form_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 563);
            this.Controls.Add(this.gb_eliminar);
            this.Controls.Add(this.gb_editar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Cliente";
            this.Text = "Form_Cliente";
            this.gb_eliminar.ResumeLayout(false);
            this.gb_eliminar.PerformLayout();
            this.gb_editar.ResumeLayout(false);
            this.gb_editar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_eliminar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_eliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gb_editar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_nif;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}