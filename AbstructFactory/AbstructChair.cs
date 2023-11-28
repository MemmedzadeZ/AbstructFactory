namespace AbstructFactory;

abstract class AbstructChair{}

class ArtDecoChair:AbstructChair { }
class VictorianChair : AbstructChair { }
class ModernChair : AbstructChair { }


abstract class AbstructSofa { }
class ArtDecoSofa:AbstructSofa { }
class VictorianSofa : AbstructSofa { }
class ModernSofa : AbstructSofa { }

abstract class AbstructCoffeeTable { }
class ArtDecoCoffeeTable:AbstructCoffeeTable { }
class VictorianCoffeeTable:AbstructCoffeeTable { }
class ModernCoffeeTable : AbstructCoffeeTable { }


/////////////////////////////////////////////////////


abstract class AbstructFactorys
{
    public abstract AbstructChair CreateChair();
    public abstract AbstructSofa CreateSofa();
    public abstract AbstructCoffeeTable CreateCoffeeTable();
  

}


class ArtDecoFactorys:AbstructFactorys
{
    public override AbstructChair CreateChair()
    {
        return new ArtDecoChair();
    }

    public override AbstructSofa CreateSofa()
    {
      return new ArtDecoSofa();
    }


    public override AbstructCoffeeTable CreateCoffeeTable()
    {
        return new ArtDecoCoffeeTable();
    }
}



class VictorianFactory : AbstructFactorys
{
    public override AbstructChair CreateChair()
    {
        return new VictorianChair();
    }

    public override AbstructCoffeeTable CreateCoffeeTable()
    {
        return new VictorianCoffeeTable();
    }

    public override AbstructSofa CreateSofa()
    {
       return new VictorianSofa();
    }
}


class ModernFactory : AbstructFactorys
{
    public override AbstructChair CreateChair()
    {
        return new ModernChair();
    }

    public override AbstructCoffeeTable CreateCoffeeTable()
    {
       return new ModernCoffeeTable();
    }

    public override AbstructSofa CreateSofa()
    {
       return new ModernSofa();
    }
}



class Client
{ 
    private readonly AbstructChair _Chair = null;
    private readonly AbstructCoffeeTable _CoffeeTable = null;
    private readonly AbstructSofa _Sofa = null;

    public Client(AbstructFactorys abstructFactorys)
    {
        _Chair = abstructFactorys.CreateChair();
        _Sofa = abstructFactorys.CreateSofa();
        _CoffeeTable = abstructFactorys.CreateCoffeeTable();
    }

   
}
