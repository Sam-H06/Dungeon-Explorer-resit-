public class Potion : Item
{
    public int HealAmount { get; set; }

    public override void Use(Player player)
    {
        player.Heal(HealAmount);
        Console.WriteLine($"{player.Name} uses {Name} and heals {HealAmount} HP.");
    }
}