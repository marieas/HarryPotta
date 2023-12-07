using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPottah
{
    internal class Wand : Item
    {
        public string WandType { get; set; }

        public Wand(string wandType) : base(wandType)
        {
            WandType = wandType;
        }
    }
}
