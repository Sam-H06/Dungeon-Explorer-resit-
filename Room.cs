public class Room
{
    public string Description { get; set; }
    public Dictionary<string, Room> Exits { get; } = new Dictionary<string, Room>();
    public List<Item> Items { get; } = new List<Item>();
    public List<Monster> Monsters { get; } = new List<Monster>();

    public Room(string description)
    {
        Description = description;
    }

    public void AddExit(string direction, Room room) => Exits[direction] = room;
}