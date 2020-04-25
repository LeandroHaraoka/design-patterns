using HouseConstructionExample.Houses.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseConstructionExample.Houses
{
    public class House
    {
        public HouseMaterial Material { get; set; }
        public int WallsBuilt { get; set; }
        public int DoorsBuilt { get; set; }
        public int WindowsBuilt { get; set; }
        public bool HasRoof { get; set; }
        public bool HasGarden { get; set; }
        public bool HasPetHouse { get; set; }
        public bool HasBBQGrill { get; set; }
    }
}
