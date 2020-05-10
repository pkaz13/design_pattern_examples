using observer_example.Subjects;

namespace observer_example.Observers
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}
