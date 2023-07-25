using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype
{
    public class Character
    {
        private int health;
        private int strength;
        private int defence;

        public int Health { get => health; set => health = value; }
        public int Strength { get => strength; set => strength = value; }
        public int Defence { get => defence; set => defence = value; }

        public Character Clone() {
            return (Character)this.MemberwiseClone();
        } 
        public override string ToString()
        {
            return $"health {health}, Strength {strength}, defence {defence}";
        }
    }
}
