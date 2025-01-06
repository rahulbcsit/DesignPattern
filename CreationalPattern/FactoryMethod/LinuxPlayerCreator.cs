namespace FactoryMethod;

public class LinuxPlayerCreator : PlayerCreator
{
    public override Player CreatePlayer()
    {
        return new LinuxPlayer();
    }
}