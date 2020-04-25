using System;
using System.Collections.Generic;
using System.Text;

namespace HouseConstructionExample.Houses.Builders
{
    public interface IHouseBuilder
    {
        IHouseBuilder BuildWalls(int wallsNumber);
        IHouseBuilder BuildRoof();
        IHouseBuilder BuildDoors(int doorsNumbers);
        IHouseBuilder BuildWindows(int windowsNumber);
        IHouseBuilder MakeGarden();
        IHouseBuilder BuildPetHouse();
        IHouseBuilder BuildBBQGrill();
        House Build();
        void Reset();
    }
}
