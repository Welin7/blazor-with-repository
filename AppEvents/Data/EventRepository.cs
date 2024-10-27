using AppEvents.Model;

namespace AppEvents.Data
{
    public class EventRepository : IEventRepository
    {
        private readonly List<Event> _events;

        public EventRepository(List<Event> events)
        {
            _events = [
                new Event(1, "Event 1", "Description event 1", DateTime.Now.AddDays(32), DateTime.Now.AddDays(34), false),
                new Event(2, "Event 2", "Description event 2", DateTime.Now.AddDays(40), DateTime.Now.AddDays(48), false),
                new Event(3, "Event 3", "Description event 3", DateTime.Now.AddDays(59), DateTime.Now.AddDays(67), false),
                new Event(4, "Event 4", "Description event 4", DateTime.Now.AddDays(69), DateTime.Now.AddDays(73), false),
                new Event(5, "Event 5", "Description event 5", DateTime.Now.AddDays(78), DateTime.Now.AddDays(83), false),
                new Event(6, "Event 6", "Description event 6", DateTime.Now.AddDays(89), DateTime.Now.AddDays(97), false),
                new Event(7, "Event 7", "Description event 7", DateTime.Now.AddDays(100), DateTime.Now.AddDays(130), false),
                new Event(8, "Event 8", "Description event 8", DateTime.Now.AddDays(150), DateTime.Now.AddDays(180), false),
                new Event(9, "Event 9", "Description event 9", DateTime.Now.AddDays(190), DateTime.Now.AddDays(210), false),
                new Event(10, "Event 10", "Description event 10", DateTime.Now.AddDays(220), DateTime.Now.AddDays(290), false)
                ];
        }
        public List<Event> GetAll()
        {
            return _events;
        }
    }
}
