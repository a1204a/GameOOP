namespace GalaxyAttack;

public class Enemy : ISpaceship
{
    private double enemyHealth { get; set; }
    private int enemyDamageAmount { get; set; }

    public Enemy()
    {
        enemyHealth = 120;
        enemyDamageAmount = 15;
    }

    public void SpaceshipMove()
    {
        Console.WriteLine("Player is moving forward.");
    }

    public double SpaceshipHealth()
    {
        return enemyHealth;
    }

    public void SpaceshipDamage()
    {
        Console.WriteLine($"The spaceship deals {enemyDamageAmount} damage to the enemy.");
    }
    
    public void TakeDamage(int damage)
    {
        enemyHealth -= damage;
        if (enemyHealth < 0) enemyHealth = 0;
        Console.WriteLine($"The spaceship took {damage} damage. Current health: {enemyHealth}");
    }

    public void Drop()
    {
        Random rnd = new Random();
        int dropChance = rnd.Next(0, 11);

        if (dropChance == 6)
        {
            Console.WriteLine("The enemy dropped a token. Press '1' to pick it up otherwise press '2'.");
            string accept = Console.ReadLine();

            if (accept == "1")
            {
                Upgrades.GetDrop();
            }
            else if (accept == "2")
            {
                Console.WriteLine("The token has not been picked up and is now lost..");
            }
            else
            {
                Console.WriteLine("There was no valid response given.");
            }
        }
    }
}
