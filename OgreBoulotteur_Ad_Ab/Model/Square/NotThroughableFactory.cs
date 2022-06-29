using System;
namespace OgreBoulotteur_Ad_Ab.Model.Square
{
    public class NotThroughableFactory : SquareFactory
    {
        private static ISquare tree = new Tree();
        private static ISquare water = new Water();
        private static ISquare rock = new Rock();

        public override ISquare makeSquare()
        {
            int rand = new Random().Next(0, 2);

            if (rand == 0)
            {
                return makeTree();
            } else if(rand == 1)
            {
                return makeWater();
            } else
            {
                return makeRock();
            }
        }

        private ISquare makeTree()
        {
            return NotThroughableFactory.tree;
        }

        private ISquare makeWater()
        {
            return NotThroughableFactory.water;
        }

        private ISquare makeRock()
        {
            return NotThroughableFactory.rock;
        }
    }
}
