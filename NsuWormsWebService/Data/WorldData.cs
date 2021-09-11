namespace NsuWormsWebService.Data
{
    public class WorldData
    {
        public Worm[] Worms;
        public Food[] Food;
    }

    public class Worm
    {
        public string name;
        public int lifeStrength;
        public Position Position;
    }

    public class Food
    {
        public int expiresIn;
        public Position Position;
    }

    public class Position
    {
        public int X;
        public int Y;
    }
}
