using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.Models
{
    public class Character
    {
        public int ID { get; set; }
        public string Name { get; set; } = "Anduin";
        public int HP { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Priest;
    }
}