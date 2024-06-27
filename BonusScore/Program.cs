class BonusScore
{
    public static void Main(String[] args)
    {


        int points = int.Parse(Console.ReadLine());

        double bonus = 0;
        
        if (points >= 0 && points <= 3)
        {
            bonus =5+points;
        }
        else if (points >= 4 && points < 7)
        {
            bonus=15+points;
           
        }
        else if (points>6 && points<10)
        {
            bonus=20+points;
        }
        Console.WriteLine(bonus);
    }
}
