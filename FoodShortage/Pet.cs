using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage
{
    public class Pet : IBirthable
    {
        public Pet(string name, string birthday)
        {
            Name = name;
            Birthdate = birthday;
        }

        public string Name { get; private set; }
        public string Birthdate { get; private set; }
    }
}
