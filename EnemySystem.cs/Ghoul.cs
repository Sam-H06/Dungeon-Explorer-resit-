public class Ghoul : Monster
{
    public Ghoul() : base("Dragon", 100) { }

    public override void Attack(Player player)
    {
        Console.WriteLine("Ghoul Haunts!");
        player.TakeDamage(25);
    }
}