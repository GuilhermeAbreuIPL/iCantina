namespace iCantina.Views
{
    partial class Form_Multas
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
            this.nud_numHorasEdit = new System.Windows.Forms.NumericUpDown();
            this.txt_valorEdit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nud_numHorasCriar = new System.Windows.Forms.NumericUpDown();
            this.txt_valorCriar = new System.Windows.Forms.TextBox();
            this.btn_criar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_multas = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_numHorasEdit)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_numHorasCriar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nud_numHorasEdit);
            this.groupBox2.Controls.Add(this.txt_valorEdit);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_editar);
            this.groupBox2.Location = new System.Drawing.Point(458, 309);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(284, 192);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit";
            // 
            // nud_numHorasEdit
            // 
            this.nud_numHorasEdit.Location = new System.Drawing.Point(149, 87);
            this.nud_numHorasEdit.Name = "nud_numHorasEdit";
            this.nud_numHorasEdit.Size = new System.Drawing.Size(110, 22);
            this.nud_numHorasEdit.TabIndex = 26;
            // 
            // txt_valorEdit
            // 
            this.txt_valorEdit.Location = new System.Drawing.Point(84, 39);
            this.txt_valorEdit.Name = "txt_valorEdit";
            this.txt_valorEdit.Size = new System.Drawing.Size(175, 22);
            this.txt_valorEdit.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Numero de Horas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor:";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(159, 140);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 28);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "Delete";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(51, 140);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(100, 28);
            this.btn_editar.TabIndex = 1;
            this.btn_editar.Text = "Editar";
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "Multas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nud_numHorasCriar);
            this.groupBox1.Controls.Add(this.txt_valorCriar);
            this.groupBox1.Controls.Add(this.btn_criar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(458, 113);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(284, 176);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criar";
            // 
            // nud_numHorasCriar
            // 
            this.nud_numHorasCriar.Location = new System.Drawing.Point(149, 76);
            this.nud_numHorasCriar.Name = "nud_numHorasCriar";
            this.nud_numHorasCriar.Size = new System.Drawing.Size(110, 22);
            this.nud_numHorasCriar.TabIndex = 25;
            // 
            // txt_valorCriar
            // 
            this.txt_valorCriar.Location = new System.Drawing.Point(84, 28);
            this.txt_valorCriar.Name = "txt_valorCriar";
            this.txt_valorCriar.Size = new System.Drawing.Size(175, 22);
            this.txt_valorCriar.TabIndex = 6;
            // 
            // btn_criar
            // 
            this.btn_criar.Location = new System.Drawing.Point(159, 125);
            this.btn_criar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.Size = new System.Drawing.Size(100, 28);
            this.btn_criar.TabIndex = 0;
            this.btn_criar.Text = "Criar";
            this.btn_criar.Click += new System.EventHandler(this.btn_criar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numero de Horas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor:";
            // 
            // lb_multas
            // 
            this.lb_multas.FormattingEnabled = true;
            this.lb_multas.ItemHeight = 16;
            this.lb_multas.Location = new System.Drawing.Point(113, 113);
            this.lb_multas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_multas.Name = "lb_multas";
            this.lb_multas.Size = new System.Drawing.Size(305, 388);
            this.lb_multas.TabIndex = 21;
            this.lb_multas.SelectedIndexChanged += new System.EventHandler(this.lb_multas_SelectedIndexChanged);
            // 
            // Form_Multas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_multas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Multas";
            this.Text = "Form_Multas";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_numHorasEdit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_numHorasCriar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_criar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_multas;
        private System.Windows.Forms.TextBox txt_valorCriar;
        private System.Windows.Forms.TextBox txt_valorEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_numHorasEdit;
        private System.Windows.Forms.NumericUpDown nud_numHorasCriar;
    }
}