using observer_example.Observers;
using observer_example.Subjects;
using System;

namespace observer_example.Views
{
    public class CurrentConditionsView : IObserver, IView
    {
        private ISubject _subject;
        private float _temperature;
        private float _pressure;

        public CurrentConditionsView(ISubject subject)
        {
            _subject = subject;
            _subject.AddObserver(this);
        }

        public void Print()
        {
            Console.WriteLine($"Current conditions: {_temperature} C, {_pressure} hPa");
        }

        public void Update(ISubject subject)
        {
            if (subject is WeatherData)
            {
                WeatherData weatherData = (WeatherData)subject;
                _temperature = weatherData.Temperature;
                _pressure = weatherData.Pressure;
            }
            Print();
        }
    }
}
