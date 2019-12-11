using NewsNotifierService.Widgets;

namespace NewsNotifierService.Aggregator
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observerToRegister);
        bool ReleaseObserver(IObserver observerToRelease);
        void NotifyObservers();
    }
}
