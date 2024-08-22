namespace ConversionMoneda
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
            label1 = new Label();
            txtCantidadNIO = new TextBox();
            btnConvertir = new Button();
            lblResultadoUSD = new Label();
            lblResultadoEUR = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 0;
            label1.Text = "Cantidad en NIO:";
            // 
            // txtCantidadNIO
            // 
            txtCantidadNIO.Location = new Point(188, 44);
            txtCantidadNIO.Name = "txtCantidadNIO";
            txtCantidadNIO.Size = new Size(198, 23);
            txtCantidadNIO.TabIndex = 1;
            // 
            // btnConvertir
            // 
            btnConvertir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConvertir.Location = new Point(422, 40);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(94, 30);
            btnConvertir.TabIndex = 2;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // lblResultadoUSD
            // 
            lblResultadoUSD.AutoSize = true;
            lblResultadoUSD.Location = new Point(23, 93);
            lblResultadoUSD.Name = "lblResultadoUSD";
            lblResultadoUSD.Size = new Size(38, 15);
            lblResultadoUSD.TabIndex = 3;
            lblResultadoUSD.Text = "label2";
            // 
            // lblResultadoEUR
            // 
            lblResultadoEUR.AutoSize = true;
            lblResultadoEUR.Location = new Point(339, 93);
            lblResultadoEUR.Name = "lblResultadoEUR";
            lblResultadoEUR.Size = new Size(38, 15);
            lblResultadoEUR.TabIndex = 4;
            lblResultadoEUR.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 162);
            Controls.Add(lblResultadoEUR);
            Controls.Add(lblResultadoUSD);
            Controls.Add(btnConvertir);
            Controls.Add(txtCantidadNIO);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Conversión de moneda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCantidadNIO;
        private Button btnConvertir;
        private Label lblResultadoUSD;
        private Label lblResultadoEUR;
    }
}