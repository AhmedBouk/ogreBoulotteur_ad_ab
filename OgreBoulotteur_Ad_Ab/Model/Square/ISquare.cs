namespace OgreBoulotteur_Ad_Ab.Model.Square {
    public interface ISquare {
        ISprite Sprite { get; }
        bool Throughable { get; }
        public ISprite GetSprite(int num);
        public void SetSprite(int num, ISprite sprite);
    }
}
