namespace Simulacion
{
    partial class Vonneuman
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label_semilla = new System.Windows.Forms.Label();
            this.label_n = new System.Windows.Forms.Label();
            this.textBox_semilla = new System.Windows.Forms.TextBox();
            this.numericUpDown_n = new System.Windows.Forms.NumericUpDown();
            this.textBox_resultado = new System.Windows.Forms.TextBox();
            this.checkBox_intervalo = new System.Windows.Forms.CheckBox();
            this.panel_intervalo = new System.Windows.Forms.Panel();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_generar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_n)).BeginInit();
            this.panel_intervalo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label_semilla
            // 
            this.label_semilla.AutoSize = true;
            this.label_semilla.Location = new System.Drawing.Point(42, 42);
            this.label_semilla.Name = "label_semilla";
            this.label_semilla.Size = new System.Drawing.Size(81, 13);
            this.label_semilla.TabIndex = 0;
            this.label_semilla.Text = "Ingrese Semilla:";
            // 
            // label_n
            // 
            this.label_n.AutoSize = true;
            this.label_n.Location = new System.Drawing.Point(42, 88);
            this.label_n.Name = "label_n";
            this.label_n.Size = new System.Drawing.Size(63, 13);
            this.label_n.TabIndex = 1;
            this.label_n.Text = "Cantidad N:";
            // 
            // textBox_semilla
            // 
            this.textBox_semilla.Location = new System.Drawing.Point(129, 42);
            this.textBox_semilla.MaxLength = 4;
            this.textBox_semilla.Name = "textBox_semilla";
            this.textBox_semilla.Size = new System.Drawing.Size(100, 20);
            this.textBox_semilla.TabIndex = 3;
            this.textBox_semilla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_semilla_KeyPress);
            this.textBox_semilla.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_semilla_Validating);
            this.textBox_semilla.Validated += new System.EventHandler(this.textBox_semilla_Validated);
            // 
            // numericUpDown_n
            // 
            this.numericUpDown_n.Location = new System.Drawing.Point(129, 88);
            this.numericUpDown_n.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown_n.Name = "numericUpDown_n";
            this.numericUpDown_n.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_n.TabIndex = 4;
            this.numericUpDown_n.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // textBox_resultado
            // 
            this.textBox_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_resultado.Location = new System.Drawing.Point(268, 42);
            this.textBox_resultado.Multiline = true;
            this.textBox_resultado.Name = "textBox_resultado";
            this.textBox_resultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_resultado.Size = new System.Drawing.Size(243, 135);
            this.textBox_resultado.TabIndex = 5;
            // 
            // checkBox_intervalo
            // 
            this.checkBox_intervalo.AutoSize = true;
            this.checkBox_intervalo.Location = new System.Drawing.Point(45, 137);
            this.checkBox_intervalo.Name = "checkBox_intervalo";
            this.checkBox_intervalo.Size = new System.Drawing.Size(70, 17);
            this.checkBox_intervalo.TabIndex = 6;
            this.checkBox_intervalo.Text = "Intervalo:";
            this.checkBox_intervalo.UseVisualStyleBackColor = true;
            this.checkBox_intervalo.CheckedChanged += new System.EventHandler(this.checkBox_intervalo_CheckedChanged);
            // 
            // panel_intervalo
            // 
            this.panel_intervalo.Controls.Add(this.numericUpDown3);
            this.panel_intervalo.Controls.Add(this.numericUpDown2);
            this.panel_intervalo.Controls.Add(this.label2);
            this.panel_intervalo.Controls.Add(this.label1);
            this.panel_intervalo.Location = new System.Drawing.Point(129, 128);
            this.panel_intervalo.Name = "panel_intervalo";
            this.panel_intervalo.Size = new System.Drawing.Size(100, 59);
            this.panel_intervalo.TabIndex = 7;
            this.panel_intervalo.Visible = false;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(27, 29);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown3.TabIndex = 3;
            this.numericUpDown3.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(27, 4);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A:";
            // 
            // button_generar
            // 
            this.button_generar.Location = new System.Drawing.Point(45, 233);
            this.button_generar.Name = "button_generar";
            this.button_generar.Size = new System.Drawing.Size(466, 44);
            this.button_generar.TabIndex = 8;
            this.button_generar.Text = "Generar";
            this.button_generar.UseVisualStyleBackColor = true;
            this.button_generar.Click += new System.EventHandler(this.button_generar_Click);
            // 
            // Vonneuman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 336);
            this.Controls.Add(this.button_generar);
            this.Controls.Add(this.panel_intervalo);
            this.Controls.Add(this.checkBox_intervalo);
            this.Controls.Add(this.textBox_resultado);
            this.Controls.Add(this.numericUpDown_n);
            this.Controls.Add(this.textBox_semilla);
            this.Controls.Add(this.label_n);
            this.Controls.Add(this.label_semilla);
            this.Name = "Vonneuman";
            this.Text = "Von Neuman";
            this.Load += new System.EventHandler(this.Vonneuman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_n)).EndInit();
            this.panel_intervalo.ResumeLayout(false);
            this.panel_intervalo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.Label label_semilla;
        private System.Windows.Forms.TextBox textBox_resultado;
        private System.Windows.Forms.NumericUpDown numericUpDown_n;
        private System.Windows.Forms.TextBox textBox_semilla;
        private System.Windows.Forms.Panel panel_intervalo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_intervalo;
        private System.Windows.Forms.Button button_generar;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}