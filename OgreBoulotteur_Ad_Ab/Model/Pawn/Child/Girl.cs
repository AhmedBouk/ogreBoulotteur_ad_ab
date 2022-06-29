using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OgreBoulotteur_Ad_Ab.Model.Square;

namespace OgreBoulotteur_Ad_Ab.Model.Pawn.Child
{
     class Girl : DecoratorChild
    {
        private static readonly ISprite sprite = new Sprite('♀');
        public Girl(MandatoryChild child) : base(child)
        {

        }

        public override ISprite GetSpriteExtendedDecorated(int num)
        {
            if (num == 1)
            {
                return Girl.sprite;
            }
            return null;
        }
    }
}

