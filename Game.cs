public class Game
{
    private Player player;
    private GameMap map;

    public void Start()
    {
        Console.WriteLine("Welcome to Dungeon Explorer!");
        map = new GameMap();
        player = new Player("Hero", 100);
        map.InitializeMap(player);
        GameLoop();
    }

    private void GameLoop()
    {
        while (true)
        {
            Console.WriteLine(player.CurrentRoom.Description);
            Console.Write("Command: ");
            string input = Console.ReadLine().ToLower();

            try
            {
                if (input.StartsWith("go "))
                    player.Move(input.Substring(3));
                else if (input.StartsWith("use "))
                    player.UseItem(input.Substring(4));
                else if (input == "inventory")
                    player.ShowInventory();
                else if (input == "exit")
                    break;
                else
                    Console.WriteLine("Unknown command.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}