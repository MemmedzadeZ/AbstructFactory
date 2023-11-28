namespace AbstructFactory;

internal class Program
{
    static void Main()
    {
        Client client;

        client = new Client(new ArtDecoFactorys());
        client = new Client(new VictorianFactory());
        client = new Client(new ModernFactory());
    }
}
