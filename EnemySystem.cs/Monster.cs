public class Monster : Creature, IDamageable
{
    public virtual void Attack(Player player)
    {
        Console.WriteLine($"{Name} attacks!");
        player.TakeDamage(10);
    }

    public void TakeDamage(int amount)
    {
        Health -= amount;
        Console.WriteLine($"{Name} takes {amount} damage.");
        if (Health <= 0)
            Console.WriteLine($"{Name} has been defeated.");
    }
}