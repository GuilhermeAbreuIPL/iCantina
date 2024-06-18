namespace iCantina.Views
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
            this.lb_pratos.ItemHeight = 16;
            this.lb_pratos.Location = new System.Drawing.Point(224, 74);
            this.lb_pratos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_pratos.Name = "lb_pratos";
            this.lb_pratos.Size = new System.Drawing.Size(221, 388);
            this.lb_pratos.TabIndex = 0;
            this.lb_pratos.SelectedIndexChanged += new System.EventHandler(this.lb_pratos_SelectedIndexChanged);
            this.lb_pratos.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lb_pratos_Format);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_criar);
            this.groupBox1.Controls.Add(this.cb_criarAtivo);
            this.groupBox1.Controls.Add(this.cb_criarTipo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_criarDescricao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(485, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(284, 176);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criar";
            // 
            // btn_criar
            // 
            this.btn_criar.Location = new System.Drawing.Point(177, 142);
            this.btn_criar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.Size = new System.Drawing.Size(100, 28);
            this.btn_criar.TabIndex = 0;
            this.btn_criar.Text = "Criar";
            this.btn_criar.Click += new System.EventHandler(this.btn_criar_Click);
            // 
            // cb_criarAtivo
            // 
            this.cb_criarAtivo.AutoSize = true;
            this.cb_criarAtivo.Location = new System.Drawing.Point(9, 138);
            this.cb_criarAtivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_criarAtivo.Name = "cb_criarAtivo";
            this.cb_criarAtivo.Size = new System.Drawing.Size(59, 20);
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
            this.cb_criarTipo.Location = new System.Drawing.Point(84, 84);
            this.cb_criarTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_criarTipo.Name = "cb_criarTipo";
            this.cb_criarTipo.Size = new System.Drawing.Size(175, 24);
            this.cb_criarTipo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo:";
            // 
            // txt_criarDescricao
            // 
            this.txt_criarDescricao.Location = new System.Drawing.Point(84, 21);
            this.txt_criarDescricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_criarDescricao.Multiline = true;
            this.txt_criarDescricao.Name = "txt_criarDescricao";
            this.txt_criarDescricao.Size = new System.Drawing.Size(175, 48);
            this.txt_criarDescricao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
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
            this.groupBox2.Location = new System.Drawing.Point(485, 270);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(284, 192);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editar";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(177, 158);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 28);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "Delete";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click_1);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(69, 158);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(100, 28);
            this.btn_editar.TabIndex = 1;
            this.btn_editar.Text = "Editar";
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // cb_editAtivo
            // 
            this.cb_editAtivo.AutoSize = true;
            this.cb_editAtivo.Location = new System.Drawing.Point(9, 138);
            this.cb_editAtivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_editAtivo.Name = "cb_editAtivo";
            this.cb_editAtivo.Size = new System.Drawing.Size(59, 20);
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
            this.cb_editTipo.Location = new System.Drawing.Point(84, 84);
            this.cb_editTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_editTipo.Name = "cb_editTipo";
            this.cb_editTipo.Size = new System.Drawing.Size(175, 24);
            this.cb_editTipo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo:";
            // 
            // txt_editDescricao
            // 
            this.txt_editDescricao.Location = new System.Drawing.Point(84, 21);
            this.txt_editDescricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_editDescricao.Multiline = true;
            this.txt_editDescricao.Name = "txt_editDescricao";
            this.txt_editDescricao.Size = new System.Drawing.Size(175, 48);
            this.txt_editDescricao.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Descrição:";
            // 
            // Form_Pratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_pratos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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