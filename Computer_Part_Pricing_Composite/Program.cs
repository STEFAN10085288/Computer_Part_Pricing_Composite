using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Part_Pricing_Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var hardDrive = new Leaf("Hard Drive", 2000, 2);
            var ram = new Leaf("RAM", 1000, 2);
            var cpu = new Leaf("CPU", 3000, 1);
            var mouse = new Leaf("Mouse", 1500, 4);
            var keyboard = new Leaf("Keyboard", 1700, 4);


            Composite motherboard = new Composite("Motherboard", 5000, 1);
            Composite cabinet = new Composite("Cabinet", 2000, 1);
            Composite periherals = new Composite("Periherals", 0, 0);
            Composite computer = new Composite("Computer", 0, 0);

            motherboard.AddItem(ram);
            motherboard.AddItem(cpu);

            cabinet.AddItem(hardDrive);
            cabinet.AddItem(motherboard);

            periherals.AddItem(keyboard);
            periherals.AddItem(mouse);

            computer.AddItem(cabinet);
            computer.AddItem(periherals);

            Console.WriteLine("Total price is:" + computer.CalculateTotalPrice());

            Console.ReadLine();


        }
    }
}
