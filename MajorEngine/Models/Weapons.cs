using MajorEngine.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MajorEngine.Models
{
    public class Weapon : GameItem
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
        public Weapon(int itemTypeID, string name, int price, int minDamage, int maxDamage, string description)
            : base(itemTypeID, name, price, description)
        {
            MinimumDamage = minDamage;
            MaximumDamage = maxDamage;
        }
        public new Weapon Clone()
        {
            return new Weapon(ItemTypeID, Name, Price, MinimumDamage, MaximumDamage, Description);
        }
    }
}