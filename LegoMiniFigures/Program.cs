using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMiniFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var lego1 = new Lego
            {
                Hair = "purple",
                Head = "big",
                Torso = "tiny",
                Legs = "5",
                Accessories = "a machete"
            };

            lego1.DescribeLego();

            Console.WriteLine("Type in jump, double jump, attack, special attack or look to see what happens!");
            var input = Console.ReadLine();
            var userInput = input.ToLower();

            if (userInput == "jump")
            {
                lego1.Jump();
                lego1.Shoes();
            }
            if(userInput == "double jump")
            {
                lego1.DoubleJump();
            }
            if(userInput == "attack")
            {
                lego1.Attack();
            }
            if(userInput == "special attack")
            {
                lego1.SpecialAttack();
                lego1.LegoUnlocked();
            }
            if(userInput == "look")
            {
                lego1.Look();
            }

            Console.ReadKey();
        }  
    }    
}
