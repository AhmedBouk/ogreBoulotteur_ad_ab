using OgreBoulotteur_Ad_Ab.Model.Pawn;
using OgreBoulotteur_Ad_Ab.Model.Pawn.Ogre;

namespace OgreBoulotteur_Ad_Ab.Controller
{
    using OgreBoulotteur_Ad_Ab.Model;
    using OgreBoulotteur_Ad_Ab.View;
    using OgreBoulotteur_Ad_Ab.Model.Pawn.Child;

    public class Controller : IController
    {
        private IModel Model { get; set; }
        private IView View { get; set; }

        public Controller()
        {
            Model = new Model();
            View = new View(Model);
         

            MandatoryChild firstBoy =
                new ChildWithInstrument(new ChildWithHat(new Boy(new MandatoryChild(new StandardChild(10, 10)))));
            MandatoryChild firstGirl =
                new ChildWithHat(
                    new ChildWithInstrument(new ChildWithHat(new Girl(new MandatoryChild(new StandardChild(1, 1))))));
            MandatoryOgre ogre = new MandatoryOgre(new StandardOgre(5, 5));
            
            Model.AddPawn(ogre);

            Model.AddPawn(firstBoy);
            Model.AddPawn(firstGirl);

        }

        public void GameLoop()
        {
            for (;;)
            {
                List<IPawn> savedPawns = new List<IPawn>();
                for (int y = 0; y < Model.Height; y++) {
                    for (int x = 0; x < Model.Width; x++) {
                        List<IPawn> pawns = Model.GetPawn(x, y);
                        if (pawns.Count != 0) {
                          savedPawns.Add(pawns[0]);
                        }
                    }
                }
                

                foreach (IPawn pawn in savedPawns)
                {
                    int[] positionOgre = new int[0];
                    List<int[]> positionschild = new List<int[]>();
                    
                    if (pawn.IsOgre)
                    {
                       positionOgre = positionOgre.Concat(new []{pawn.X, pawn.Y}).ToArray();
                    }
                    else
                    {
                        positionschild.Add(new int[]{pawn.X, pawn.Y});
                    }

                    foreach (int[] position in positionschild)
                    {
                        if (position == positionOgre)
                        {
                            IPawn res = Model.GetPawn(position[0], position[1])[0];
                            if (!res.IsOgre)
                            {
                                res.Die();
                            }
                        }
                        
                    }
                    
                }
                
                 View.Show();
                 Model.Live();
                 System.Threading.Thread.Sleep(1000);
                
            }
        }
    }
}
