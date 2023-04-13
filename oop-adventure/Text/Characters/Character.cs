using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_adventure.Text.Characters
{
    public abstract class Character
    {
        public string Name { get; set; }

        public Character(string name)
        {
            Name = name;
        }
    }
}
