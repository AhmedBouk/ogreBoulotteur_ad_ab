using OgreBoulotteur_Ad_Ab.Model.Square;

namespace OgreBoulotteur_Ad_Ab.Model.Pawn.Ogre;

public class StandardOgre : Ogre
{
    private static readonly Sprite sprite = new('G');

    public StandardOgre(int x, int y) : base(x, y)
    {
        this.SetSprite(0, sprite);
        this.SetSprite(1, sprite);
        this.SetSprite(2, sprite);
        this.SetSprite(3, sprite);
    }
    public override ISprite GetSpriteExtended(int num)
    {
        return null;
    }
}