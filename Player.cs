public class Player : Creature, IDamageable
{
    public Room CurrentRoom { get; set; }
    private Inventory inventory;

    public Player(string name, int health) : base(name, health)
    {
        inventory = new Inventory();
    }

    public void Move(string direction)
    {
        if (CurrentRoom.Exits.TryGetValue(direction, out Room nextRoom))
            CurrentRoom = nextRoom;
        else
            throw new InvalidOperationException("Can't move that way.");
    }

    public void ShowInventory() => inventory.ListItems();

    public void UseItem(string itemName)
    {
        var item = inventory.GetItem(itemName);
        item?.Use(this);
    }

    public void TakeDamage(int amount)
    {
        Health -= amount;
        Console.WriteLine($"{Name} takes {amount} damage. Health: {Health}");
        if (Health <= 0)
            Console.WriteLine($"{Name} has died.");
    }

    public void AddItem(Item item) => inventory.AddItem(item);
}