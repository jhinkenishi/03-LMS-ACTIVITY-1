using System;

delegate int health(int health);
namespace _03_LMS__ACTIVITY_1
{
    struct Coordinate
    {
        public int x;
        public int y;
    }

    enum Weekdays{
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class Program

    {
        static void Main(string[] args)
        {

            //Player(Class) implements IPlayer(Interface)
            Player playerWithInterface = new Player();
            playerWithInterface.run();
            playerWithInterface.walk();
            //Struct
            Coordinate point;
            point.x = 10;
            point.y = 50;
            Console.WriteLine("X: " + point.x + " Y: " + point.y);
            //Delegate
            health playerH = new health(Player.AddHealth);
            playerH(500);
            Console.WriteLine("Health: " + Player.health);

            //Enum
            Console.WriteLine(Weekdays.Monday);
            Console.WriteLine(Weekdays.Tuesday);
            Console.WriteLine(Weekdays.Wednesday);
            Console.WriteLine(Weekdays.Thursday);
            Console.WriteLine(Weekdays.Friday);
        }
    }
}
