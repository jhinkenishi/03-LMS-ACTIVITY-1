using System;
using System.Collections.Generic;
using System.Text;

namespace _03_LMS__ACTIVITY_1
{
    interface IPlayer
    {
        void walk();
        void run();

        delegate int health(int health);
    }
}
