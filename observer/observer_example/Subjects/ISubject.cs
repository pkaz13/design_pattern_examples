using observer_example.Observers;

namespace observer_example.Subjects
{
    public interface ISubject
    {
        void AddObserver(IObserver observer);
        void DeleteObserver(IObserver observer);
        void NotifyObservers();
    }
}
