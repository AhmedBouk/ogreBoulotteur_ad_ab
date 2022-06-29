using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgreBoulotteur_Ad_Ab.Model.Pawn.Child
{
    public abstract class Child : Pawn
    {
        public Child(int x, int y) : base(x, y)
        {

        }

        public override void Die()
        {
            // Nothing
        }

        public override void Live()
        {
            int newX = X;
            int newY = Y;
            switch (this.GetRandomDirection())
            {
                case 0:
                    newY = Y == 0 ? 0 : Y - 1;
                    break;
                case 1:
                    newX = X == Forest.Width ? Forest.Width : X + 1;
                    break;
                case 2:
                    newY = Y == Forest.Height ? Forest.Height : Y + 1;
                    break;
                case 3:
                    newX = X == 0 ? 0 : X - 1;
                    break;
            }
            if (Forest.GetSquare(newX, newY).Throughable)
            {
                X = newX;
                Y = newY;
            }
        }

        private int GetRandomDirection()
        {
            Random random = new();
            return random.Next(0, 4);
        }
    }
}
