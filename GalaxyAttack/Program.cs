namespace GalaxyAttack;

public class Program
{
    public static int level = 1;
    public static void Main(string[] args)
    {
        Player player1 = new Player();
        
        player1.SpaceshipMove();
        Console.WriteLine($"Spaceship health: {player1.playerHealth}");
        player1.SpaceshipDamage();
        
        player1.TakeDamage(20);

        level = 2;
        
        Console.WriteLine($"Spaceship health: {player1.playerHealth}");
        player1.SpaceshipDamage();

        if (player1.playerHealth == 0)
        {
            Console.Write($"You died.");
        }

        Enemy enemy1 = new Enemy();
        enemy1.Drop();
    }
}