namespace OgreBoulotteur_Ad_Ab.Model.Square
{
    class Rock : Square
    {
        private static readonly Sprite sprite = new('#');
        public Rock() : base(false)
        {
            for (int num = 0; num < 4; num++)
            {
                SetSprite(num, Rock.sprite);
            }
        }

        public override ISprite GetSpriteExtended(int num)
        {
            return null;
        }
    }
}
