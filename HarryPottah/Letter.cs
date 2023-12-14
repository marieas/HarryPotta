using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPottah
{
    internal class Letter
    {
        public string Message { get; set; }
        public Character Recipient { get; set; }
        public Letter(string msg, Character character)
        {
            Message = msg;
            Recipient = character;
        }
    }
}
