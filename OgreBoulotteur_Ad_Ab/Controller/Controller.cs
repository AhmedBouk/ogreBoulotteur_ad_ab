namespace OgreBoulotteur_Ad_Ab.Controller {
    using OgreBoulotteur_Ad_Ab.Model;
    using OgreBoulotteur_Ad_Ab.View;
    using OgreBoulotteur_Ad_Ab.Model.Pawn.Child;

    public class Controller : IController {
        private IModel Model { get; set; }
        private IView View { get; set; }

        public Controller() {
            Model = new Model();
            View = new View(Model);

            MandatoryChild firstBoy = new ChildWithInstrument(new ChildWithHat(new Boy(new MandatoryChild(new StandarChild(10,10)))));
            MandatoryChild firstGirl = new ChildWithHat(new ChildWithInstrument(new ChildWithHat(new Girl(new MandatoryChild(new StandarChild(1, 1))))));

            Model.AddPawn(firstBoy);
            Model.AddPawn(firstGirl);
        }

        public void GameLoop() {
            for (;;) {
                View.Show();
                Model.Live();
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
