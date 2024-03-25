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
    public class Food : GameItem
    {
        public int addedHp{ get; set; }

        public Food(int itemTypeID, string name, int price, int AddedHP , string description)
            : base(itemTypeID, name, price, description)
        {
            AddedHP = addedHp;
        }
        public new Food Clone()
        {
            return new Food(ItemTypeID, Name, Price,addedHp, Description);
        }
    }
}