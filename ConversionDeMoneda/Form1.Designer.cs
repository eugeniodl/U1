namespace ConversionDeMoneda
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
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(48, 33);
            label1.Name = "label1";
            label1.Size = new Size(128, 21);
            label1.TabIndex = 0;
            label1.Text = "Cantidad en NIO:";
            // 
            // txtCantidadNIO
            // 
            txtCantidadNIO.Location = new Point(182, 33);
            txtCantidadNIO.Name = "txtCantidadNIO";
            txtCantidadNIO.Size = new Size(262, 23);
            txtCantidadNIO.TabIndex = 1;
            // 
            // btnConvertir
            // 
            btnConvertir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConvertir.Location = new Point(48, 79);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(115, 29);
            btnConvertir.TabIndex = 2;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // lblResultadoUSD
            // 
            lblResultadoUSD.AutoSize = true;
            lblResultadoUSD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultadoUSD.Location = new Point(52, 130);
            lblResultadoUSD.Name = "lblResultadoUSD";
            lblResultadoUSD.Size = new Size(149, 21);
            lblResultadoUSD.TabIndex = 3;
            lblResultadoUSD.Text = "Equivalente en USD:";
            // 
            // lblResultadoEUR
            // 
            lblResultadoEUR.AutoSize = true;
            lblResultadoEUR.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultadoEUR.Location = new Point(52, 169);
            lblResultadoEUR.Name = "lblResultadoEUR";
            lblResultadoEUR.Size = new Size(147, 21);
            lblResultadoEUR.TabIndex = 4;
            lblResultadoEUR.Text = "Equivalente en EUR:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 222);
            Controls.Add(lblResultadoEUR);
            Controls.Add(lblResultadoUSD);
            Controls.Add(btnConvertir);
            Controls.Add(txtCantidadNIO);
            Controls.Add(label1);
            Name = "Form1";
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