using HouseConstructionExample.Houses.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseConstructionExample.Houses.Builders
{
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
}
