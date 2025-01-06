namespace FactoryMethod;

public class WindowsPlayerCreator : PlayerCreator 
{
    public override  Player CreatePlayer()
    {
        return new WindowPlayer();
    } 
}