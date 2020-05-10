using observer_example.Observers;
using System.Collections.Generic;

namespace observer_example.Subjects
{
    public class WeatherData : ISubject
    {
        private readonly List<IObserver> _observers;

        public float Temperature { get; private set; }
        public float Humidity { get; private set; }
        public float Pressure { get; private set; }

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void DeleteObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void DataChanged()
        {
            NotifyObservers();
        }

        public void UpdateConditions(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
        }
    }
}
