namespace Simulacion
{
    partial class Multiplicativo
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
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown_b = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_a = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_intervalo = new System.Windows.Forms.CheckBox();
            this.textBox_semilla = new System.Windows.Forms.TextBox();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.textBox_m = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_resultado = new System.Windows.Forms.TextBox();
            this.button_limpiar = new System.Windows.Forms.Button();
            this.button_generar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_a)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese semilla: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese multiplicativo: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingrese n: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown_b);
            this.panel1.Controls.Add(this.numericUpDown_a);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(127, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 82);
            this.panel1.TabIndex = 5;
            // 
            // numericUpDown_b
            // 
            this.numericUpDown_b.Location = new System.Drawing.Point(35, 42);
            this.numericUpDown_b.Name = "numericUpDown_b";
            this.numericUpDown_b.Size = new System.Drawing.Size(73, 20);
            this.numericUpDown_b.TabIndex = 9;
            // 
            // numericUpDown_a
            // 
            this.numericUpDown_a.Location = new System.Drawing.Point(35, 4);
            this.numericUpDown_a.Name = "numericUpDown_a";
            this.numericUpDown_a.Size = new System.Drawing.Size(73, 20);
            this.numericUpDown_a.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "B: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "A: ";
            // 
            // checkBox_intervalo
            // 
            this.checkBox_intervalo.AutoSize = true;
            this.checkBox_intervalo.Location = new System.Drawing.Point(15, 255);
            this.checkBox_intervalo.Name = "checkBox_intervalo";
            this.checkBox_intervalo.Size = new System.Drawing.Size(73, 17);
            this.checkBox_intervalo.TabIndex = 6;
            this.checkBox_intervalo.Text = "Intervalo: ";
            this.checkBox_intervalo.UseVisualStyleBackColor = true;
            // 
            // textBox_semilla
            // 
            this.textBox_semilla.Location = new System.Drawing.Point(128, 28);
            this.textBox_semilla.Name = "textBox_semilla";
            this.textBox_semilla.Size = new System.Drawing.Size(101, 20);
            this.textBox_semilla.TabIndex = 7;
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(127, 83);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(101, 20);
            this.textBox_a.TabIndex = 8;
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(128, 194);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(100, 20);
            this.textBox_n.TabIndex = 10;
            // 
            // textBox_m
            // 
            this.textBox_m.Location = new System.Drawing.Point(128, 136);
            this.textBox_m.Name = "textBox_m";
            this.textBox_m.Size = new System.Drawing.Size(100, 20);
            this.textBox_m.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ingrese el modulo: ";
            // 
            // textBox_resultado
            // 
            this.textBox_resultado.Location = new System.Drawing.Point(284, 25);
            this.textBox_resultado.Multiline = true;
            this.textBox_resultado.Name = "textBox_resultado";
            this.textBox_resultado.Size = new System.Drawing.Size(235, 189);
            this.textBox_resultado.TabIndex = 13;
            // 
            // button_limpiar
            // 
            this.button_limpiar.Location = new System.Drawing.Point(432, 297);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(87, 40);
            this.button_limpiar.TabIndex = 25;
            this.button_limpiar.Text = "Limpiar";
            this.button_limpiar.UseVisualStyleBackColor = true;
            // 
            // button_generar
            // 
            this.button_generar.Location = new System.Drawing.Point(284, 297);
            this.button_generar.Name = "button_generar";
            this.button_generar.Size = new System.Drawing.Size(87, 40);
            this.button_generar.TabIndex = 24;
            this.button_generar.Text = "Generar";
            this.button_generar.UseVisualStyleBackColor = true;
            this.button_generar.Click += new System.EventHandler(this.button_generar_Click);
            // 
            // Multiplicativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 376);
            this.Controls.Add(this.button_limpiar);
            this.Controls.Add(this.button_generar);
            this.Controls.Add(this.textBox_resultado);
            this.Controls.Add(this.textBox_m);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_n);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.textBox_semilla);
            this.Controls.Add(this.checkBox_intervalo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Multiplicativo";
            this.Text = "Multiplicativo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_a)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDown_b;
        private System.Windows.Forms.NumericUpDown numericUpDown_a;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_intervalo;
        private System.Windows.Forms.TextBox textBox_semilla;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.TextBox textBox_m;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_resultado;
        private System.Windows.Forms.Button button_limpiar;
        private System.Windows.Forms.Button button_generar;
    }
}