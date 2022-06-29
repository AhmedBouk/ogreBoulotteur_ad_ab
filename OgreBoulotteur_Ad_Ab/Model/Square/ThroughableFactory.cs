using System;
namespace OgreBoulotteur_Ad_Ab.Model.Square
{
    public class ThroughableFactory : SquareFactory
    {
        private static ISquare ground = new Ground();
        private static ISquare bridge = new Bridge();

        public override ISquare makeSquare()
        {
            int rand = new Random().Next(0, 3);

            if (rand == 1)
            {
           
                return makeGround();
            }
            else
            {
                return makeBridge();
            }
        }

        private ISquare makeGround()
        {
            return ThroughableFactory.ground;
        }


        private ISquare makeBridge()
        {
            return ThroughableFactory.bridge;
        }
    }
}
