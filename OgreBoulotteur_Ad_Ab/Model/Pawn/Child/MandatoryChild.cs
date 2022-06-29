using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OgreBoulotteur_Ad_Ab.Model.Square;

namespace OgreBoulotteur_Ad_Ab.Model.Pawn.Child
{
    public class MandatoryChild : IPawn
    {
        public Child child { get; }

        public MandatoryChild(Child child)
        {
            this.child = child;
        }

        public int X => child.X;

        public int Y => child.Y;

        public IForest Forest { get => child.Forest; set => child.Forest = value; }

        public ISprite Sprite => child.Sprite;

        public bool Throughable => child.Throughable;

        public void Die()
        {
            child.Die();
        }

        public virtual ISprite GetSprite(int num)
        {
            return child.GetSprite(num);
        }

        public void SetSprite(int num, ISprite sprite)
        {
            child.SetSprite(num, sprite);
        }

        public void Live()
        {
            child.Live();
        }

        public virtual ISprite GetSpriteExtended(int num)
        {
            return child.GetSpriteExtended(num);
        }
    }
}

