namespace OgreBoulotteur_Ad_Ab.Model.Square {
    class Tree : Square {
        private static readonly Sprite sprite = new('T');
        public Tree() : base(false) {
            for (int num = 0; num <4; num++) {
                SetSprite(num, Tree.sprite);
            }
        }

        public override ISprite GetSpriteExtended(int num)
        {
            return null;
        }
    }
}
