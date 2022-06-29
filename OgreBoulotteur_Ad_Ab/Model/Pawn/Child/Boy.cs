using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OgreBoulotteur_Ad_Ab.Model.Square;

namespace OgreBoulotteur_Ad_Ab.Model.Pawn.Child
{
    internal class Boy : DecoratorChild
    {
        private static readonly ISprite sprite = new Sprite('Ω');
        public Boy(MandatoryChild child) : base(child)
        {

        }

        public override ISprite GetSpriteExtendedDecorated(int num)
        {
            if (num == 1)
            {
                return Boy.sprite;
            }
            return null;
        }
    }
}
