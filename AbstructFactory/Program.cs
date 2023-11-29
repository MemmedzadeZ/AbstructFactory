namespace AbstructFactory;


class Program
{
    static void Main()
    {
        // Client uses Art Deco furniture factory
        AbstractFurnitureFactory artDecoFactory = new ArtDecoFactory();
        Client artDecoClient = new Client(artDecoFactory);
        artDecoClient.Run();

        // Client uses Victorian furniture factory
        AbstractFurnitureFactory victorianFactory = new VictorianFactory();
        Client victorianClient = new Client(victorianFactory);
        victorianClient.Run();

        // Client uses Modern furniture factory
        AbstractFurnitureFactory modernFactory = new ModernFactory();
        Client modernClient = new Client(modernFactory);
        modernClient.Run();
    }
}
