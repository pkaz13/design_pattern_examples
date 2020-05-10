using observer_example.Observers;
using observer_example.Subjects;
using observer_example.Views;

namespace observer_example
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            IObserver observer = new CurrentConditionsView(weatherData);

            weatherData.UpdateConditions(21.5f, 15, 25);
            weatherData.DataChanged();

            weatherData.UpdateConditions(35f, 10, 10);
            weatherData.DataChanged();
        }
    }
}
