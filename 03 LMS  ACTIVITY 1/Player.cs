using System;
using System.Collections.Generic;
using System.Text;

namespace _03_LMS__ACTIVITY_1
{
    class Player : IPlayer
    {
        public static int health = 10;
        public void run()
        {
            Console.WriteLine("Player is running");
        }

        public void walk()
        {
            Console.WriteLine("Player is walking");
        }

        public static int AddHealth(int h)
        {
            return health += h;
        }
    }
}
