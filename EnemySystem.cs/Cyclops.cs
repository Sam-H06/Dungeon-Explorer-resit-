public class Cyclops : Monster
{
    public Cyclops() : base("Cyclops", 30) { }

    public override void Attack(Player player)
    {
        Console.WriteLine("Cyclops swipes!");
        player.TakeDamage(5);
    }
}