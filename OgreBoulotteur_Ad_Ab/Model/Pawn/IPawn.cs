namespace OgreBoulotteur_Ad_Ab.Model.Pawn {
    using OgreBoulotteur_Ad_Ab.Model.Square;
    using OgreBoulotteur_Ad_Ab.Model;

    public interface IPawn:ISquare {
        int X { get; }
        int Y { get; }
        public IForest Forest { get; set; }
        void Live();
        void Die();
        ISprite GetSpriteExtended(int num);
    }
}
