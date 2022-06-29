using OgreBoulotteur_Ad_Ab.Model.Square;

namespace OgreBoulotteur_Ad_Ab.Model.Pawn.Ogre;

public class MandatoryOgre : IPawn
{
    public Ogre ogre { get; }

    public MandatoryOgre(Ogre ogre)
    {
        this.ogre = ogre;
    }
    
    public int X => ogre.X;

    public int Y => ogre.Y;
    
    public IForest Forest
    {
        get => ogre.Forest;
        set => ogre.Forest = value;
    }

    public ISprite Sprite => ogre.Sprite;

    public bool Throughable => ogre.Throughable;

    public void Die()
    {
        return;
    }

    public virtual ISprite GetSprite(int num)
    {
        return ogre.GetSprite(num);
    }
    public void  SetSprite(int num, ISprite sprite)
    {
        ogre.SetSprite(num, sprite);
    }

    public void Live()
    {
        ogre.Live();
    }
    
    public virtual ISprite GetSpriteExtended(int num)
    {
        return ogre.GetSpriteExtended(num);
    }
}