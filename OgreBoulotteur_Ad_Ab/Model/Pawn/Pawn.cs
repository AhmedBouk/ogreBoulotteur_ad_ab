namespace OgreBoulotteur_Ad_Ab.Model.Pawn {
    using OgreBoulotteur_Ad_Ab.Model.Square;
    public abstract class Pawn : Square, IPawn {
        public int X { get; protected set; }
        public int Y { get; protected set; }
        
        public bool IsOgre { get; set; }
        public IWorld World { get; set; }

        protected Pawn(int x, int y) : base(true){
            X = x;
            Y = y;
            World = null;
        }

        public abstract void Live();
        public abstract void Die();
    }
}
