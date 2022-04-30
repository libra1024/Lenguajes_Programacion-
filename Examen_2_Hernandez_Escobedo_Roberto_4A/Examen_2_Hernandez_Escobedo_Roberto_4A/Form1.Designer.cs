namespace Examen_2_Hernandez_Escobedo_Roberto_4A
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblConversiones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MXN-Peso Mexicano",
            "CAD-Dólar Canadiense",
            "USD-Dólar Estadounidense",
            "EUR-Euro",
            "JPY-Yen"});
            this.comboBox1.Location = new System.Drawing.Point(12, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Location = new System.Drawing.Point(89, 21);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(51, 15);
            this.lblMoneda.TabIndex = 1;
            this.lblMoneda.Text = "Moneda";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(316, 21);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(43, 15);
            this.lblMonto.TabIndex = 2;
            this.lblMonto.Text = "Monto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(271, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 23);
            this.textBox1.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(293, 113);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(btnCalcular_Click);
            // 
            // lblConversiones
            // 
            this.lblConversiones.AutoSize = true;
            this.lblConversiones.Location = new System.Drawing.Point(203, 186);
            this.lblConversiones.Name = "lblConversiones";
            this.lblConversiones.Size = new System.Drawing.Size(78, 15);
            this.lblConversiones.TabIndex = 5;
            this.lblConversiones.Text = "Conversiones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 486);
            this.Controls.Add(this.lblConversiones);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblMoneda);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private Label lblMoneda;
        private Label lblMonto;
        private TextBox textBox1;
        private Button btnCalcular;
        private Label lblConversiones;
    }
}