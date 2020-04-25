using HouseConstructionExample.Houses.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseConstructionExample.Houses.Builders
{
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
}
