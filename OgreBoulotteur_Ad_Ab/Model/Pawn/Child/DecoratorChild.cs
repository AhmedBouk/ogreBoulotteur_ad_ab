using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgreBoulotteur_Ad_Ab.Model.Pawn.Child
{
    abstract class DecoratorChild : MandatoryChild
    {
        protected MandatoryChild MandatoryChild { get; set; }
        protected DecoratorChild(MandatoryChild child) : base(child.child)
        {
            MandatoryChild = child;
        }

        public override ISprite GetSprite(int num)
        {
            ISprite result = GetSpriteExtended(num);
            if (result != null)
            {
                return result;
            }
            return this.MandatoryChild.GetSprite(num);
        }

        public override ISprite GetSpriteExtended(int num)
        {
            ISprite result;
            result = this.GetSpriteExtendedDecorated(num);
            if (result != null)
            {
                return result;
            }
            return this.MandatoryChild.GetSpriteExtended(num);
        }

        public abstract ISprite GetSpriteExtendedDecorated(int num);
    }
}
}
