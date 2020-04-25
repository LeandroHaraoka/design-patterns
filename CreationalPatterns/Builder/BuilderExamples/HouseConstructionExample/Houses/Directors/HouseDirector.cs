using HouseConstructionExample.Houses.Builders;

namespace HouseConstructionExample.Houses.Directors
{
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
}
