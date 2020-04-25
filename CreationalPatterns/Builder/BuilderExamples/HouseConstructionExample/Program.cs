using HouseConstructionExample.Houses;
using HouseConstructionExample.Houses.Builders;
using HouseConstructionExample.Houses.Directors;
using System;

namespace HouseConstructionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Builder");
            Console.WriteLine("House Construction Example");

            var houseDirector = new HouseDirector();

            var stoneHouseBuilder = new StoneHouseBuilder();
            houseDirector.SetBuilder(stoneHouseBuilder);

            Console.WriteLine("\n[Simple Stone House]");
            houseDirector.BuildSimpleHouse();
            var simpleStoneHouse = stoneHouseBuilder.Build();
            PrintResult(simpleStoneHouse);

            Console.WriteLine("\n[Nice Stone House]");
            houseDirector.BuildNiceHouse();
            var niceStoneHouse = stoneHouseBuilder.Build();
            PrintResult(niceStoneHouse);

            Console.WriteLine("\n[Simple Wood House]");
            var woodHouseBuilder = new WoodHouseBuilder();
            houseDirector.SetBuilder(woodHouseBuilder);

            houseDirector.BuildSimpleHouse();
            var simpleWoodHouse = woodHouseBuilder.Build();
            PrintResult(simpleWoodHouse);

            Console.WriteLine("\n[Nice Wood House]");
            houseDirector.BuildNiceHouse();
            var niceWoodHouse = woodHouseBuilder.Build();
            PrintResult(niceWoodHouse);
        }

        private static void PrintResult(House house)
        {
            Console.WriteLine($"House Material: {house.Material}");
            var houseType = house.HasGarden && house.HasPetHouse && house.HasBBQGrill ? "Nice House" : "Simple House";
            Console.WriteLine($"House Type: {houseType}");
        }
    }
}
