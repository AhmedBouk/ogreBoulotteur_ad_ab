using System.Collections.Generic;

namespace OgreBoulotteur_Ad_Ab.Model {
    using OgreBoulotteur_Ad_Ab.Model.Pawn;
    using OgreBoulotteur_Ad_Ab.Model.Square;
    public interface IWorld {
        int Height { get; }
        int Width { get; }
        ISquare GetSquare(int x, int y);
        List<IPawn> GetPawn(int x, int y);
        void LivePawns();
        void AddPawn(IPawn pawn);
        Model Model { get; set; }
    }
}
