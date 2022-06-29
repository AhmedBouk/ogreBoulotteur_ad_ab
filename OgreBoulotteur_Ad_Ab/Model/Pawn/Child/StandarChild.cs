using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OgreBoulotteur_Ad_Ab.Model.Square;

namespace OgreBoulotteur_Ad_Ab.Model.Pawn.Child
{
    class StandarChild : Child
    {
        private static readonly Sprite sprite = new('☺');
        public StandarChild(int x, int y) : base(x, y)
        {
            this.SetSprite(0, sprite);
            this.SetSprite(1, sprite);
            this.SetSprite(2, sprite);
            this.SetSprite(3, sprite);
        }

        public override ISprite GetSpriteExtended(int num)
        {
            return null;
        }
    }
}
