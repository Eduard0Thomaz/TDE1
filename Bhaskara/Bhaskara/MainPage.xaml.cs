namespace Bhaskara
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btCalcular_Clicked(object sender, EventArgs e)
        {
            // Pegando os valores conforme a lógica do seu professor
            double a = Convert.ToDouble(valA.Text);
            double b = Convert.ToDouble(valB.Text);
            double c = Convert.ToDouble(valC.Text);

            // Calculando o Delta
            double delta = (b * b) - (4 * a * c);
            lbDelta.Text = $"Delta: {delta:F2}";

            // Calculando as raízes
            if (delta < 0)
            {
                lbResultado.Text = "Sem raízes";
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                lbResultado.Text = $"X1: {x1:F2} | X2: {x2:F2}";
            }
        }
    }
}