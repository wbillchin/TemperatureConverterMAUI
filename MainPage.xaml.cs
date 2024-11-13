namespace TemperatureConverter
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnConvertButtonClicked(object sender, EventArgs e)
        {
            if (double.TryParse(CelsiusEntry.Text, out double celsius))
            {
                // Convert Celsius to Fahrenheit
                double fahrenheit = ConvertTemperature.convertCelsiusToFahrenheit(celsius);
                ResultLabel.Text = $"Fahrenheit: {fahrenheit:F1} °F";
            }
            else
            {
                ResultLabel.Text = "Invalid input. Please enter a number.";
            }
        }
    }

}
