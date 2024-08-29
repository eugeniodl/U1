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
            label1.Location = new Point(14, 56);
            label1.Name = "label1";
            label1.Size = new Size(197, 32);
            label1.TabIndex = 0;
            label1.Text = "Cantidad en NIO:";
            // 
            // txtCantidadNIO
            // 
            txtCantidadNIO.Location = new Point(215, 59);
            txtCantidadNIO.Margin = new Padding(3, 4, 3, 4);
            txtCantidadNIO.Name = "txtCantidadNIO";
            txtCantidadNIO.Size = new Size(226, 27);
            txtCantidadNIO.TabIndex = 1;
            // 
            // btnConvertir
            // 
            btnConvertir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConvertir.Location = new Point(482, 53);
            btnConvertir.Margin = new Padding(3, 4, 3, 4);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(107, 40);
            btnConvertir.TabIndex = 2;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // lblResultadoUSD
            // 
            lblResultadoUSD.AutoSize = true;
            lblResultadoUSD.Location = new Point(26, 124);
            lblResultadoUSD.Name = "lblResultadoUSD";
            lblResultadoUSD.Size = new Size(142, 20);
            lblResultadoUSD.TabIndex = 3;
            lblResultadoUSD.Text = "Equivalente en USD:";
            // 
            // lblResultadoEUR
            // 
            lblResultadoEUR.AutoSize = true;
            lblResultadoEUR.Location = new Point(387, 124);
            lblResultadoEUR.Name = "lblResultadoEUR";
            lblResultadoEUR.Size = new Size(140, 20);
            lblResultadoEUR.TabIndex = 4;
            lblResultadoEUR.Text = "Equivalente en EUR:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 216);
            Controls.Add(lblResultadoEUR);
            Controls.Add(lblResultadoUSD);
            Controls.Add(btnConvertir);
            Controls.Add(txtCantidadNIO);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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