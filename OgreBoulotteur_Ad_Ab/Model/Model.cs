using System.Collections.Generic;

namespace OgreBoulotteur_Ad_Ab.Model {
    using OgreBoulotteur_Ad_Ab.Model.Pawn;
    using OgreBoulotteur_Ad_Ab.Model.Square;
    public class Model : IModel {
        private IWorld Forest { get; set; }

        public int Height { get { return Forest.Height; } }
        public int Width { get { return Forest.Width; } }

        public ThroughableFactory ThroughableFactory { get; private set; }
        public NotThroughableFactory NotThroughableFactory { get; private set; }
        Model IWorld.Model { get; set; }

        public Model() {
            NotThroughableFactory = new NotThroughableFactory();
            ThroughableFactory = new ThroughableFactory();
            Forest = new World(15, 59, 10, this);
        }

        public ISquare GetSquare(int x, int y) {
            return Forest.GetSquare(x, y);
        }

        public List<IPawn> GetPawn(int x, int y) {
            return Forest.GetPawn(x, y);
        }

        public void Live() {
            LivePawns();
        }

        public void LivePawns() {
            Forest.LivePawns();
        }

        public void AddPawn(IPawn pawn) {
            Forest.AddPawn(pawn);
        }
    }
}
