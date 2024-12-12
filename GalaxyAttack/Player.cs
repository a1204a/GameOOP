namespace GalaxyAttack;

public class Player : ISpaceship
{
    public double playerHealth { get; set; }
    private int playerDamageAmount { get; set; }
    public int inventorySpace { get; set; }

    
    public Player()
    {
        playerHealth = 100;
        playerDamageAmount = 20;

        if (Program.level == 2)
        {
            playerHealth = 150;
            playerDamageAmount = 30;
        }
        if (Program.level == 3)
        {
            playerHealth = 200;
            playerDamageAmount = 40;
        }
    }

    public void SpaceshipMove()
    {
        Console.WriteLine("Player is moving right.");
    }

    public double SpaceshipHealth()
    {
        if (Program.level == 2)
        {
            playerHealth = 150;
            playerDamageAmount = 30;
        }
        if (Program.level == 3)
        {
            playerHealth = 200;
            playerDamageAmount = 40;
        }
        return playerHealth;
    }

    public void SpaceshipDamage()
    {
        if (Program.level == 2)
        {
            playerHealth = 150;
            playerDamageAmount = 30;
        }
        if (Program.level == 3)
        {
            playerHealth = 200;
            playerDamageAmount = 40;
        }
        Console.WriteLine($"The spaceship deals {playerDamageAmount} damage to the enemy.");
    }
    
    public void TakeDamage(int damage)
    {
        if (Program.level == 2)
        {
            playerHealth = 150;
            playerDamageAmount = 30;
        }
        if (Program.level == 3)
        {
            playerHealth = 200;
            playerDamageAmount = 40;
        }
        playerHealth -= damage;
        if (playerHealth < 0) playerHealth = 0;
        Console.WriteLine($"The spaceship took {damage} damage. Current health: {playerHealth}");
    }
}