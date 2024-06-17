namespace iCantina.Views
{
    partial class Form_Extras
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_editPreco = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.cb_editAtivo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_editDescricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_criarPreco = new System.Windows.Forms.TextBox();
            this.btn_criar = new System.Windows.Forms.Button();
            this.cb_criarAtivo = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_criarDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_extra = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_editPreco);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_editar);
            this.groupBox2.Controls.Add(this.cb_editAtivo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_editDescricao);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(463, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 192);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editar";
            // 
            // txt_editPreco
            // 
            this.txt_editPreco.Location = new System.Drawing.Point(84, 84);
            this.txt_editPreco.Name = "txt_editPreco";
            this.txt_editPreco.Size = new System.Drawing.Size(174, 22);
            this.txt_editPreco.TabIndex = 8;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(194, 147);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(113, 147);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 6;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // cb_editAtivo
            // 
            this.cb_editAtivo.AutoSize = true;
            this.cb_editAtivo.Location = new System.Drawing.Point(9, 138);
            this.cb_editAtivo.Name = "cb_editAtivo";
            this.cb_editAtivo.Size = new System.Drawing.Size(59, 20);
            this.cb_editAtivo.TabIndex = 5;
            this.cb_editAtivo.Text = "Ativo";
            this.cb_editAtivo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preço:";
            // 
            // txt_editDescricao
            // 
            this.txt_editDescricao.Location = new System.Drawing.Point(84, 21);
            this.txt_editDescricao.Multiline = true;
            this.txt_editDescricao.Name = "txt_editDescricao";
            this.txt_editDescricao.Size = new System.Drawing.Size(174, 48);
            this.txt_editDescricao.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "Extras";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_criarPreco);
            this.groupBox1.Controls.Add(this.btn_criar);
            this.groupBox1.Controls.Add(this.cb_criarAtivo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_criarDescricao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(463, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 176);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criar";
            // 
            // txt_criarPreco
            // 
            this.txt_criarPreco.Location = new System.Drawing.Point(84, 87);
            this.txt_criarPreco.Name = "txt_criarPreco";
            this.txt_criarPreco.Size = new System.Drawing.Size(174, 22);
            this.txt_criarPreco.TabIndex = 7;
            // 
            // btn_criar
            // 
            this.btn_criar.Location = new System.Drawing.Point(183, 138);
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.Size = new System.Drawing.Size(75, 23);
            this.btn_criar.TabIndex = 6;
            this.btn_criar.Text = "Criar";
            this.btn_criar.UseVisualStyleBackColor = true;
            // 
            // cb_criarAtivo
            // 
            this.cb_criarAtivo.AutoSize = true;
            this.cb_criarAtivo.Location = new System.Drawing.Point(9, 138);
            this.cb_criarAtivo.Name = "cb_criarAtivo";
            this.cb_criarAtivo.Size = new System.Drawing.Size(59, 20);
            this.cb_criarAtivo.TabIndex = 5;
            this.cb_criarAtivo.Text = "Ativo";
            this.cb_criarAtivo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preço:";
            // 
            // txt_criarDescricao
            // 
            this.txt_criarDescricao.Location = new System.Drawing.Point(84, 21);
            this.txt_criarDescricao.Multiline = true;
            this.txt_criarDescricao.Name = "txt_criarDescricao";
            this.txt_criarDescricao.Size = new System.Drawing.Size(174, 48);
            this.txt_criarDescricao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // lb_extra
            // 
            this.lb_extra.FormattingEnabled = true;
            this.lb_extra.ItemHeight = 16;
            this.lb_extra.Location = new System.Drawing.Point(201, 87);
            this.lb_extra.Name = "lb_extra";
            this.lb_extra.Size = new System.Drawing.Size(221, 388);
            this.lb_extra.TabIndex = 21;
            // 
            // Form_Extras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 563);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_extra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Extras";
            this.Text = "Form_Extras";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_editPreco;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.CheckBox cb_editAtivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_editDescricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_criarPreco;
        private System.Windows.Forms.Button btn_criar;
        private System.Windows.Forms.CheckBox cb_criarAtivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_criarDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_extra;
    }
}