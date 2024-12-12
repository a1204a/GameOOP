namespace GalaxyAttack;

public class Upgrades
{
    public static void GetDrop()
    {
        Random r = new Random();
        int choseDrop = r.Next(1, 3);

        if (choseDrop == 1)
        {
            LevelUp();
        }
        else if (choseDrop == 2)
        {
            AddHealth(Player player1);
        }
    }

    public static void LevelUp()
    {
        Program.level++;
    }

    public void AddHealth(Player player1)
    {
        double multiplicator = player1.playerHealth / 100.0 * 10;
        player1.playerHealth += multiplicator;
    }
}