namespace Simulacion
{
    partial class Fibonacci
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fibonacci));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ingreseA = new System.Windows.Forms.TextBox();
            this.textBox_ingreseV1 = new System.Windows.Forms.TextBox();
            this.textBox_ingreseV2 = new System.Windows.Forms.TextBox();
            this.button_generar = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox_resultado = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.radioButton_intervalo = new System.Windows.Forms.RadioButton();
            this.numericUpDown_inferior = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_superior = new System.Windows.Forms.NumericUpDown();
            this.panel_intervalo = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inferior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_superior)).BeginInit();
            this.panel_intervalo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese A: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese V1: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese V2: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingrese N: ";
            // 
            // textBox_ingreseA
            // 
            this.textBox_ingreseA.Location = new System.Drawing.Point(103, 25);
            this.textBox_ingreseA.MaxLength = 9;
            this.textBox_ingreseA.Name = "textBox_ingreseA";
            this.textBox_ingreseA.Size = new System.Drawing.Size(100, 20);
            this.textBox_ingreseA.TabIndex = 4;
            this.textBox_ingreseA.TextChanged += new System.EventHandler(this.textBox_ingreseA_TextChanged);
            this.textBox_ingreseA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ingreseA_KeyPress);
            this.textBox_ingreseA.Validated += new System.EventHandler(this.textBox_ingreseA_Validated);
            // 
            // textBox_ingreseV1
            // 
            this.textBox_ingreseV1.Location = new System.Drawing.Point(103, 61);
            this.textBox_ingreseV1.MaxLength = 9;
            this.textBox_ingreseV1.Name = "textBox_ingreseV1";
            this.textBox_ingreseV1.Size = new System.Drawing.Size(100, 20);
            this.textBox_ingreseV1.TabIndex = 5;
            this.textBox_ingreseV1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ingreseV1_KeyPress);
            this.textBox_ingreseV1.Validated += new System.EventHandler(this.textBox_ingreseV1_Validated);
            // 
            // textBox_ingreseV2
            // 
            this.textBox_ingreseV2.Location = new System.Drawing.Point(103, 101);
            this.textBox_ingreseV2.MaxLength = 9;
            this.textBox_ingreseV2.Name = "textBox_ingreseV2";
            this.textBox_ingreseV2.Size = new System.Drawing.Size(100, 20);
            this.textBox_ingreseV2.TabIndex = 6;
            this.textBox_ingreseV2.Validated += new System.EventHandler(this.textBox_ingreseV2_Validated);
            // 
            // button_generar
            // 
            this.button_generar.Location = new System.Drawing.Point(25, 291);
            this.button_generar.Name = "button_generar";
            this.button_generar.Size = new System.Drawing.Size(100, 35);
            this.button_generar.TabIndex = 9;
            this.button_generar.Text = "Generar";
            this.button_generar.UseVisualStyleBackColor = true;
            this.button_generar.Click += new System.EventHandler(this.button_generar_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(103, 144);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown1.TabIndexChanged += new System.EventHandler(this.numericUpDown1_TabIndexChanged);
            this.numericUpDown1.VisibleChanged += new System.EventHandler(this.numericUpDown1_VisibleChanged);
            this.numericUpDown1.Validated += new System.EventHandler(this.numericUpDown1_Validated);
            // 
            // textBox_resultado
            // 
            this.textBox_resultado.Location = new System.Drawing.Point(239, 25);
            this.textBox_resultado.Multiline = true;
            this.textBox_resultado.Name = "textBox_resultado";
            this.textBox_resultado.ReadOnly = true;
            this.textBox_resultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_resultado.Size = new System.Drawing.Size(278, 186);
            this.textBox_resultado.TabIndex = 11;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // radioButton_intervalo
            // 
            this.radioButton_intervalo.AutoSize = true;
            this.radioButton_intervalo.Location = new System.Drawing.Point(25, 194);
            this.radioButton_intervalo.Name = "radioButton_intervalo";
            this.radioButton_intervalo.Size = new System.Drawing.Size(99, 17);
            this.radioButton_intervalo.TabIndex = 13;
            this.radioButton_intervalo.TabStop = true;
            this.radioButton_intervalo.Text = "Utilizar intervalo";
            this.radioButton_intervalo.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_inferior
            // 
            this.numericUpDown_inferior.Location = new System.Drawing.Point(24, 12);
            this.numericUpDown_inferior.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown_inferior.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_inferior.Name = "numericUpDown_inferior";
            this.numericUpDown_inferior.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown_inferior.TabIndex = 14;
            this.numericUpDown_inferior.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_superior
            // 
            this.numericUpDown_superior.Location = new System.Drawing.Point(24, 38);
            this.numericUpDown_superior.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown_superior.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_superior.Name = "numericUpDown_superior";
            this.numericUpDown_superior.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown_superior.TabIndex = 15;
            this.numericUpDown_superior.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel_intervalo
            // 
            this.panel_intervalo.Controls.Add(this.label6);
            this.panel_intervalo.Controls.Add(this.label5);
            this.panel_intervalo.Controls.Add(this.numericUpDown_inferior);
            this.panel_intervalo.Controls.Add(this.numericUpDown_superior);
            this.panel_intervalo.Location = new System.Drawing.Point(130, 182);
            this.panel_intervalo.Name = "panel_intervalo";
            this.panel_intervalo.Size = new System.Drawing.Size(73, 65);
            this.panel_intervalo.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "A:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "B:";
            // 
            // Fibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 351);
            this.Controls.Add(this.panel_intervalo);
            this.Controls.Add(this.radioButton_intervalo);
            this.Controls.Add(this.textBox_resultado);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button_generar);
            this.Controls.Add(this.textBox_ingreseV2);
            this.Controls.Add(this.textBox_ingreseV1);
            this.Controls.Add(this.textBox_ingreseA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Fibonacci";
            this.Text = "Fibonacci";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inferior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_superior)).EndInit();
            this.panel_intervalo.ResumeLayout(false);
            this.panel_intervalo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_ingreseA;
        private System.Windows.Forms.TextBox textBox_ingreseV1;
        private System.Windows.Forms.TextBox textBox_ingreseV2;
        private System.Windows.Forms.Button button_generar;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox_resultado;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel_intervalo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_inferior;
        private System.Windows.Forms.NumericUpDown numericUpDown_superior;
        private System.Windows.Forms.RadioButton radioButton_intervalo;
    }
}