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
<<<<<<< Updated upstream
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form_Menu";
        }

        #endregion
=======
            this.lb_pratos = new System.Windows.Forms.ListBox();
            this.mc_menu = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_menu = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_extras = new System.Windows.Forms.ListBox();
            this.btn_retirar = new System.Windows.Forms.Button();
            this.btn_addPratos = new System.Windows.Forms.Button();
            this.btn_addExtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_pratos
            // 
            this.lb_pratos.FormattingEnabled = true;
            this.lb_pratos.ItemHeight = 16;
            this.lb_pratos.Location = new System.Drawing.Point(542, 131);
            this.lb_pratos.Name = "lb_pratos";
            this.lb_pratos.Size = new System.Drawing.Size(120, 292);
            this.lb_pratos.TabIndex = 0;
            // 
            // mc_menu
            // 
            this.mc_menu.Location = new System.Drawing.Point(46, 101);
            this.mc_menu.Name = "mc_menu";
            this.mc_menu.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Menu";
            // 
            // lb_menu
            // 
            this.lb_menu.FormattingEnabled = true;
            this.lb_menu.ItemHeight = 16;
            this.lb_menu.Location = new System.Drawing.Point(338, 131);
            this.lb_menu.Name = "lb_menu";
            this.lb_menu.Size = new System.Drawing.Size(161, 292);
            this.lb_menu.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Menu atual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Pratos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(700, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Extras:";
            // 
            // lb_extras
            // 
            this.lb_extras.FormattingEnabled = true;
            this.lb_extras.ItemHeight = 16;
            this.lb_extras.Location = new System.Drawing.Point(703, 131);
            this.lb_extras.Name = "lb_extras";
            this.lb_extras.Size = new System.Drawing.Size(120, 292);
            this.lb_extras.TabIndex = 25;
            // 
            // btn_retirar
            // 
            this.btn_retirar.Location = new System.Drawing.Point(338, 430);
            this.btn_retirar.Name = "btn_retirar";
            this.btn_retirar.Size = new System.Drawing.Size(161, 23);
            this.btn_retirar.TabIndex = 26;
            this.btn_retirar.Text = "Retirar";
            this.btn_retirar.UseVisualStyleBackColor = true;
            // 
            // btn_addPratos
            // 
            this.btn_addPratos.Location = new System.Drawing.Point(542, 430);
            this.btn_addPratos.Name = "btn_addPratos";
            this.btn_addPratos.Size = new System.Drawing.Size(120, 23);
            this.btn_addPratos.TabIndex = 27;
            this.btn_addPratos.Text = "Adicionar";
            this.btn_addPratos.UseVisualStyleBackColor = true;
            // 
            // btn_addExtras
            // 
            this.btn_addExtras.Location = new System.Drawing.Point(703, 430);
            this.btn_addExtras.Name = "btn_addExtras";
            this.btn_addExtras.Size = new System.Drawing.Size(120, 23);
            this.btn_addExtras.TabIndex = 28;
            this.btn_addExtras.Text = "Adicionar";
            this.btn_addExtras.UseVisualStyleBackColor = true;
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 516);
            this.Controls.Add(this.btn_addExtras);
            this.Controls.Add(this.btn_addPratos);
            this.Controls.Add(this.btn_retirar);
            this.Controls.Add(this.lb_extras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_menu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mc_menu);
            this.Controls.Add(this.lb_pratos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Menu";
            this.Text = "Form_Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_pratos;
        private System.Windows.Forms.MonthCalendar mc_menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_menu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lb_extras;
        private System.Windows.Forms.Button btn_retirar;
        private System.Windows.Forms.Button btn_addPratos;
        private System.Windows.Forms.Button btn_addExtras;
>>>>>>> Stashed changes
    }
}