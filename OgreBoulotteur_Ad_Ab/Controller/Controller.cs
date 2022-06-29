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

            ProxyChild boy1 = new Instrument(new Hat(new Boy(new ProxyChild(new BasicChild(10,10)))));
            ProxyChild w = new Sword(new Instrument(new Hat(new Girl(new ProxyChild(new BasicChild(1, 1))))));

            Model.AddPawn(boy1);
            Model.AddPawn(w);
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
