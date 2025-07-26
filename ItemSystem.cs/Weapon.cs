public class Weapon : Item
{
    public int Damage { get; set; }

    public override void Use(Player player)
    {
        var monster = player.CurrentRoom.Monsters.FirstOrDefault();
        if (monster != null)
        {
            Console.WriteLine($"{player.Name} attacks with {Name}.");
            monster.TakeDamage(Damage);
        }
    }
}