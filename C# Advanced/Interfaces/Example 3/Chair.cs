using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacezes
{
    class Chair : Furniture, IDestroyable
    {
        public string DestructionSound { get; set; }

        public List<IDestroyable> DestroyablesNearby;

        public Chair(string color, string material)
        {
            this.Color = color;
            this.Material = material;
            DestructionSound = "ChairExplosionSound.mp3";
        }

        public void Destroy()
        {
            Console.WriteLine($"The {Color} chair was destroyed");
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Spawning Chair parts");
        }
    }
}
