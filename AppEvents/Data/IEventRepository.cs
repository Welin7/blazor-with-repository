using AppEvents.Model;

namespace AppEvents.Data
{
    public interface IEventRepository
    {
        List<Event> GetAll();
    }
}
