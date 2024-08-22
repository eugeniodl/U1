namespace ConversionMoneda
{
    public partial class Form1 : Form
    {
        // Tasas de conversión predefinidas
        private const double NIO_TO_USD = 1 / 36.6243;
        private const double USD_TO_EUR = 1 / 1.11642;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            // Leer la cantidad ingresada en NIO
            double cantidadNIO = Convert.ToDouble(txtCantidadNIO.Text);

            // Convertir de NIO a USD
            double cantidadUSD = cantidadNIO * NIO_TO_USD;

            // Convertir de USD a EUR
            double cantidadEUR = cantidadUSD * USD_TO_EUR;

            // Mostrar los resultados en las etiquetas
            lblResultadoUSD.Text = $"Equivalente en USD: {cantidadUSD:F2}";
            lblResultadoEUR.Text = $"Equivalente en EUR: {cantidadEUR:F2}";
        }
    }
}