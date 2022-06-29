using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OgreBoulotteur_Ad_Ab.Model.Square;

namespace OgreBoulotteur_Ad_Ab.Model.Pawn.Child
{
    public abstract class Child : Pawn
    {
        public Child(int x, int y) : base(x, y)
        {
            
        }

        public override void Die()
        {
            Sprite sprite = new Sprite('⁜');
            SetSprite(0,sprite );
            X = -1;
            Y = -1;
        }

        public override void Live()
        {
            int newX = X;
            int newY = Y;
            switch (GetRandomDirection())
            {
                case 0:
                    newY = Y == 0 ? 0 : Y - 1;
                    break;
                case 1:
                    newX = X == World.Width ? World.Width : X + 1;
                    break;
                case 2:
                    newY = Y == World.Height ? World.Height : Y + 1;
                    break;
                case 3:
                    newX = X == 0 ? 0 : X - 1;
                    break;
            }
            if (World.GetSquare(newX, newY).Throughable)
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
