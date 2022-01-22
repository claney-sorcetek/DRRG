using System.Collections.Generic;

namespace DRRG
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random r = new Random();

            int range = 2;
            int height = 10;
            int width = 10; 

            Dictionary<Tuple<int, int>, Room> map = new Dictionary<Tuple<int, int>, Room>();

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Room room = new Room(r.Next(range), r.Next(range), r.Next(range), r.Next(range));
                    
                    // Check up
                    if (map.ContainsKey(new Tuple<int, int>(x, y+1)))
                    {
                        if (room.sides[0] != map[new Tuple<int, int>(x, y+1)].sides[3])
                        {
                            continue;
                        }
                    }
                    // Check down
                    if (map.ContainsKey(new Tuple<int, int>(x, y-1)))
                    {
                        if (room.sides[3] != map[new Tuple<int, int>(x, y-1)].sides[0])
                        {
                            continue;
                        }
                    }
                    // Check right
                    if (map.ContainsKey(new Tuple<int, int>(x+1, y)))
                    {
                        if (room.sides[2] != map[new Tuple<int, int>(x+1, y)].sides[1])
                        {
                            continue;
                        }
                    }
                    // Check left
                    if (map.ContainsKey(new Tuple<int, int>(x-1, y)))
                    {
                        if (room.sides[1] != map[new Tuple<int, int>(x-1, y)].sides[2])
                        {
                            continue;
                        }
                    }

                    map.Add(new Tuple<int,int>(x,y), room);
                    continue;
                }
            }

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (map.ContainsKey(new Tuple<int, int>(x,y)))
                    {
                        Room room = map[new Tuple<int, int>(x,y)];

                        Console.Write($"|-{room.sides[0]}-{room.sides[1]}-{room.sides[2]}-{room.sides[3]}-|");
                    }
                    else
                    {
                        Console.Write("|---------|");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}