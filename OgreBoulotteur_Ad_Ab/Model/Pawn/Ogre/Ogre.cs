
namespace OgreBoulotteur_Ad_Ab.Model.Pawn.Ogre;

public abstract class Ogre : Pawn
{
    public Ogre(int x, int y) : base(x, y)
    {
        
    }

    public override void Die()
    {
    }

    public override void Live()
    {
        int newX = X;
        int newY = Y;
        switch (GetRandomDirection())
        {
            case 0:
                newY = Y == 0 ? 0 : Y - 1;
                break;
            case 1:
                newX = X == World.Width ? World.Width : X + 1;
                break;
            case 2:
                newY = Y == World.Height ? World.Height : Y + 1;
                break;
            case 3:
                newX = X == 0 ? 0 : X - 1;
                break;
        }
        if (World.GetSquare(newX, newY).Throughable)
        {
            X = newX;
            Y = newY;
        }
    }

    
    private int GetRandomDirection()
    {
        Random random = new();
        return random.Next(0, 4);
    }
}