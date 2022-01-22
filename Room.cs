using System.Collections.Generic;

namespace DRRG
{
    class Room
    {
        public int[] sides = new int[4];

        public Room(int sideOne, int sideTwo, int sideThree, int sideFour)
        {
            sides[0] = sideOne;
            sides[1] = sideTwo;
            sides[2] = sideThree;
            sides[3] = sideFour;
        }
    }
}