using System;

// Abstract Product A
abstract class AbstractChair
{
    public abstract void Create();
}

// Concrete Product A1
class ArtDecoChair : AbstractChair
{
    public override void Create()
    {
        Console.WriteLine("Art Deco Chair created.");
    }
}

// Concrete Product A2
class VictorianChair : AbstractChair
{
    public override void Create()
    {
        Console.WriteLine("Victorian Chair created.");
    }
}

// Concrete Product A3
class ModernChair : AbstractChair
{
    public override void Create()
    {
        Console.WriteLine("Modern Chair created.");
    }
}

// Abstract Product B
abstract class AbstractSofa
{
    public abstract void Create();
}

// Concrete Product B1
class ArtDecoSofa : AbstractSofa
{
    public override void Create()
    {
        Console.WriteLine("Art Deco Sofa created.");
    }
}

// Concrete Product B2
class VictorianSofa : AbstractSofa
{
    public override void Create()
    {
        Console.WriteLine("Victorian Sofa created.");
    }
}

// Concrete Product B3
class ModernSofa : AbstractSofa
{
    public override void Create()
    {
        Console.WriteLine("Modern Sofa created.");
    }
}

// Abstract Product C
abstract class AbstractCoffeeTable
{
    public abstract void Create();
}

// Concrete Product C1
class ArtDecoCoffeeTable : AbstractCoffeeTable
{
    public override void Create()
    {
        Console.WriteLine("Art Deco Coffee Table created.");
    }
}

// Concrete Product C2
class VictorianCoffeeTable : AbstractCoffeeTable
{
    public override void Create()
    {
        Console.WriteLine("Victorian Coffee Table created.");
    }
}

// Concrete Product C3
class ModernCoffeeTable : AbstractCoffeeTable
{
    public override void Create()
    {
        Console.WriteLine("Modern Coffee Table created.");
    }
}

// Abstract Factory
abstract class AbstractFurnitureFactory
{
    public abstract AbstractChair CreateChair();
    public abstract AbstractSofa CreateSofa();
    public abstract AbstractCoffeeTable CreateCoffeeTable();
}

// Concrete Factory 1
class ArtDecoFactory : AbstractFurnitureFactory
{
    public override AbstractChair CreateChair()
    {
        return new ArtDecoChair();
    }

    public override AbstractSofa CreateSofa()
    {
        return new ArtDecoSofa();
    }

    public override AbstractCoffeeTable CreateCoffeeTable()
    {
        return new ArtDecoCoffeeTable();
    }
}

// Concrete Factory 2
class VictorianFactory : AbstractFurnitureFactory
{
    public override AbstractChair CreateChair()
    {
        return new VictorianChair();
    }

    public override AbstractSofa CreateSofa()
    {
        return new VictorianSofa();
    }

    public override AbstractCoffeeTable CreateCoffeeTable()
    {
        return new VictorianCoffeeTable();
    }
}

// Concrete Factory 3
class ModernFactory : AbstractFurnitureFactory
{
    public override AbstractChair CreateChair()
    {
        return new ModernChair();
    }

    public override AbstractSofa CreateSofa()
    {
        return new ModernSofa();
    }

    public override AbstractCoffeeTable CreateCoffeeTable()
    {
        return new ModernCoffeeTable();
    }
}

class Client
{
    private readonly AbstractChair _chair;
    private readonly AbstractCoffeeTable _coffeeTable;
    private readonly AbstractSofa _sofa;

    public Client(AbstractFurnitureFactory furnitureFactory)
    {
        _chair = furnitureFactory.CreateChair();
        _sofa = furnitureFactory.CreateSofa();
        _coffeeTable = furnitureFactory.CreateCoffeeTable();
    }

    public void Run()
    {
        _chair.Create();
        _sofa.Create();
        _coffeeTable.Create();
    }
}
