using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace HarryPottah
{
    internal class Character
    {     
        public string Name { get; private set; }
        public string House { get; private set; }
              
        public List<Pet> Pets { get; set; }
        public List<Wand> Wands { get; set; }

        public Character()
        {

        }
        public Character(string name, string house)
        {
            Name = name;
            House = house;
            Pets = new List<Pet>();
            Wands = new List<Wand>();
        }
      
        public void LeaveHogwarts(MagicShop shop)
        {
            EnterMagicShop(shop);
        }
        public void LeaveStore()
        {
            GoToHogwarts();
        }
        public void GoToHogwarts()
        {

        }
        public void Introduction()
        {
            Console.WriteLine($"Hi, my name is {Name}, i belong to {House}");
            PrintPets();
        }

        public void Introduction(string ownDefinedString)
        {
            Console.WriteLine($"Hi, my name is {Name}, i belong to {House} {ownDefinedString}");
            PrintPets();
        }

        private void PrintPets()
        {
            foreach(var pet in Pets)
            {
                Console.WriteLine("i have a " + pet.PetType);
            }
        }
        public void EnterMagicShop(MagicShop shop)
        {
            var item = shop.ShopDisplay();
            BuyItem(item);
        }
        public void BuyItem(Item item)
        {
            // put item i inventory

            LeaveStore();
        }
        public void PerfomMagic()
        {

        }
    }
}
