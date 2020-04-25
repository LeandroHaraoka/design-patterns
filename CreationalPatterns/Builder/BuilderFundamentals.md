# Builder

Builder is a design pattern that allows the creation of differents types and representations of an object reusing the same construction code. It makes easy to create objects that contain many and nested properties as it provides a step-by-step construction, a composition mechanism.

## Problem

Suppose someone needs to construct a house. There are several steps for getting the house done. Consider we have these mandatory steps: BuildWalls, BuildRoof, BuildDoors and BuildWindows. You can also have these optional steps: MakeGarden, BuildPetHouse and InstallBBQGrill.

## Example

The Builder Pattern suggests the following rules for creating a new product.

 - List all data that each builder must generate.
```
public class House
{
    public int WallsBuilt { get; set; }
    public int DoorsBuilt { get; set; }
    public int WindowsBuilt { get; set; }
    public bool HasRoof { get; set; }
    public bool HasGarden { get; set; }
    public bool HasPetHouse { get; set; }
    public bool HasBBQGrill { get; set; }
}
```

 - Builder Pattern Diagram:

![Builder Pattern Diagram ](Images/BuilderPattern.jpg)

 - Extracts the product construction code to a new class named **builders**. Products ocassionally have variants in their construction, for example, a house can be constructed from wood as well as stone and each step of the construction process can differ according to the material. In these cases, specific builder can be created for each variant of the product construction. A builder defines and keep track (at the object field inside builder) of the created representation. Also, create an abstract interface of these builders.

```
public interface IHouseBuilder
{
    void BuildWalls(int wallsNumber);
    void BuildRoof();
    void BuildDoors(int doorsNumbers);
    void BuildWindows(int windowsNumber);
    void MakeGarden();
    void BuildPetHouse();
    void BuildBBQGrill();
}
```
```
public class StoneHouseBuilder : IHouseBuilder
{
    private House _stoneHouse;

    public IHouseBuilder BuildBBQGrill()
    {
        _stoneHouse.HasBBQGrill = true;
        return this;
    }

    public IHouseBuilder BuildDoors(int doorsNumbers)
    {
        // Doors for stone house
        _stoneHouse.DoorsBuilt = doorsNumbers;
        return this;
    }

    public IHouseBuilder BuildPetHouse()
    {
        _stoneHouse.HasPetHouse = true;
        return this;
    }

    public IHouseBuilder BuildRoof()
    {
        _stoneHouse.HasRoof = true;
        return this;
    }

    public IHouseBuilder BuildWalls(int wallsNumber)
    {
        // Doors for stone house
        _stoneHouse.WallsBuilt = wallsNumber;
        return this;
    }

    public IHouseBuilder BuildWindows(int windowsNumber)
    {
        // Doors for stone house
        _stoneHouse.WindowsBuilt = windowsNumber;
        return this;
    }

    public IHouseBuilder MakeGarden()
    {
        _stoneHouse.HasGarden = true;
        return this;
    }

    public House Build()
    {
        House stoneHouse = _stoneHouse;
        Reset();
        stoneHouse.Material = HouseMaterial.Stone;
        return stoneHouse;
    }

    public void Reset()
    {
        _stoneHouse = new House();
    }
}
```
```
public class WoodHouseBuilder : IHouseBuilder
{
    private House _woodHouse;

    public IHouseBuilder BuildBBQGrill()
    {
        _woodHouse.HasBBQGrill = true;
        return this;
    }

    public IHouseBuilder BuildDoors(int doorsNumbers)
    {
        // Doors for wood house
        _woodHouse.DoorsBuilt = doorsNumbers;
        return this;
    }

    public IHouseBuilder BuildPetHouse()
    {
        _woodHouse.HasPetHouse = true;
        return this;
    }

    public IHouseBuilder BuildRoof()
    {
        _woodHouse.HasRoof = true;
        return this;
    }

    public IHouseBuilder BuildWalls(int wallsNumber)
    {
        // Walls for wood house
        _woodHouse.WallsBuilt = wallsNumber;
        return this;
    }

    public IHouseBuilder BuildWindows(int windowsNumber)
    {
        // Windows for wood house
        _woodHouse.WindowsBuilt = windowsNumber;
        return this;
    }

    public IHouseBuilder MakeGarden()
    {
        _woodHouse.HasGarden = true;
        return this;
    }

    public House Build()
    {
        House woodHouse = _woodHouse;
        Reset();
        woodHouse.Material = HouseMaterial.Wood;
        return woodHouse;
    }

    public void Reset()
    {
        _woodHouse = new House();
    }
}
```

- Frequently, builder methods are called recurrently in the same order and with the same parameter values. To avoid replicating builder invocations code, you can use **Directors**. A Director is a class that defines the order in which to execute the building steps. It also hides the construction implementation from the client.

```
public class HouseDirector
{
    private IHouseBuilder _houseBuilder;

    public void SetBuilder(IHouseBuilder houseBuilder)
    {
        houseBuilder.Reset();
        _houseBuilder = houseBuilder;
    }

    public IHouseBuilder BuildSimpleHouse()
    {
        return _houseBuilder
            .BuildWalls(4)
            .BuildDoors(1)
            .BuildWindows(1)
            .BuildRoof();
    }

    public IHouseBuilder BuildNiceHouse()
    {
        return _houseBuilder
            .BuildWalls(16)
            .BuildDoors(4)
            .BuildWindows(6)
            .BuildRoof()
            .MakeGarden()
            .BuildPetHouse()
            .BuildBBQGrill();
    }
}
```

- Finally, the client can use the Director class to create a Product without worrying about construction implementation. The Director defines the order and parameters of the execution and the builder executes it. In this example, the client can create a simple stone house as follows.

```
var houseDirector = new HouseDirector();
var stoneHouseBuilder = new StoneHouseBuilder();

houseDirector.SetBuilder(stoneHouseBuilder);
houseDirector.BuildSimpleHouse();

var simpleStoneHouse = stoneHouseBuilder.Build();
```

![Builder Pattern Example Diagram ](Images/BuilderPatternExample.jpg)

## Use cases

Use a Builder when:

You need to construct multiple representations of an object.
The client should be independent of the parts that make an object.

## Advantages

Provides construction of differents object representations.
Hides product construction details.
The construction code of each object part is written once and is reused by different builders.

## Tips

No abstract class is necessary for products. As the representations differs from each other, there is no relevant gain in creating abstractions.

The difference of Builder and Abstract Factory is that the first one focus in complex objects step-by-step construction while the second emphasize in constructing family related products (simple or complex).

## References

https://refactoring.guru/design-patterns/builder

https://refactoring.guru/design-patterns/builder/csharp/example