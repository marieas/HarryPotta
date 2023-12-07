using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HarryPottah
{
    internal class Pet : Item
    {
        public string PetType { get; set; }
        public Pet(string petType) : base(petType)
        {
            PetType = petType;
        }
    }
}
