using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMiniFigures
{
    class Lego
    {
        public string Hair { get; set; }
        public string Head { get; set; }
        public string Torso { get; set; }
        public string Legs { get; set; }
        public string Accessories { get; set; }

        public void DescribeLego()
        {
            Console.WriteLine($"CONGRATS! Your figurine has {Hair} hair, a {Head} head, a {Torso} torso and {Legs} legs. Your accessories include: {Accessories}!");
        }

        public void LegoUnlocked()
        {
            Console.WriteLine("YOU'VE UNLOCKED A NEW LEGO!");

            var lego2 = new Lego
            {
                Hair = "blue",
                Head = "happy",
                Torso = "space top",
                Legs = "space bottom",
                Accessories = "bubbles the chimp"
            };

            lego2.DescribeLego();
        }

        public void Jump()
        {
            Console.WriteLine("Your figurine jumped!!");
        }

        public void DoubleJump()
        {
            Console.WriteLine("What a double jump!");
        }

        public void Attack()
        {
            Console.WriteLine("Your figurine attacked!!!");
        }

        public void SpecialAttack()
        {
            Console.WriteLine("Your figurine uppercut the fuck out of you!");
        }

        public void Look()
        {
            Console.WriteLine("Your figurine likes to look around");
        }

        public void Shoes()
        {
            Console.WriteLine("YOU'VE UNLOCKED SHOES!");
        }
    }
}
