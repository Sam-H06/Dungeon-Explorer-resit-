public abstract class Creature
{
    public string Name { get; set; }
    public int Health { get; set; }

    protected Creature(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void Heal(int amount) => Health += amount;
}