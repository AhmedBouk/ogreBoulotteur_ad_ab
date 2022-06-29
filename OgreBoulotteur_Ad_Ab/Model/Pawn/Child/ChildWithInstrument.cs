using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgreBoulotteur_Ad_Ab.Model.Pawn.Child
{
    class ChildWithInstrument : DecoratorChild
    {
        private static readonly ISprite sprite = new Sprite('∑');
        public ChildWithInstrument(MandatoryChild child) : base(child)
        {

        }

        public override ISprite GetSpriteExtendedDecorated(int num)
        {
            if (num == 2)
            {
                return ChildWithInstrument.sprite;
            }
            return null;
        }
    }
}
}
