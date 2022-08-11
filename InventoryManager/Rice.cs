using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManeger
{
    public class Rice
    {
        public List<TypeOfRice> typeOfRice;
        public List<TypeOfWheats> typeOfWheats;
        public List<TypeOfPulses> typeOfPulses;
    }
    public class TypeOfRice
    {
        public string name;
        public int weight;
        public int price;
    }

    public class TypeOfWheats
    {
        public string name;
        public int weight;
        public int price;
    }
    public class TypeOfPulses
    {
        public string name;
        public int weight;
        public int price;
    }
}
