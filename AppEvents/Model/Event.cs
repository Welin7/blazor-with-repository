namespace AppEvents.Model
{
    public class Event
    {
        public Event(int id, string? title, string? description, DateTime dateInitial, DateTime dateFinal, bool isActive)
        {
            Id = id;
            Title = title;
            Description = description;
            DateInitial = dateInitial;
            DateFinal = dateFinal;
            this.isActive = isActive;
        }

        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime DateInitial { get; set; }
        public DateTime DateFinal { get; set; }
        public bool isActive { get; set; }
    }
}
