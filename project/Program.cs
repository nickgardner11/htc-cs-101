using System;
using System.Collections.Generic;
namespace Oregon_Trail
{
    class Program
    {
        static void Main(string[] args)

        {
            List<string> PassengerList = new List<string>();
            string ui1;
            string ui2;
            string ui3;
            string ui4;
            string ui5;
            int ch01;
            int money = 0;
            int oxen;
            int food;
            int weapons;
            int wagparts;
            int wagpartsprice = 15;
            int oxenprice = 20;
            double foodprice = .25;
            int weaponsprice = 15;


            Console.WriteLine("The Oregon Trail");
            System.Threading.Thread.Sleep(2500);

            Console.WriteLine("You May:");
            System.Threading.Thread.Sleep(1500);

            Console.WriteLine("1. Travel The Trail");

            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("2. Learn About The Trail");

            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("3. See the Oregon Top 10");

            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("4. End");

            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("What Is Your Choice?");

            ui1 = Console.ReadLine();
            ch01 = Convert.ToInt32(ui1);

            if (ch01 == 1)
                Console.WriteLine("You chose to travel the trail! What is the name of the wagon leader Name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hi! " + name + "!");
            Console.WriteLine("who will be in your wagon with you? enter four people!");
            for (int pasnum = 0; pasnum < 4; pasnum++)
            {
                string psngrs = Console.ReadLine();
                PassengerList.Add(psngrs);
            }
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Now you must pick an occupation!");
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Here are your options:");

            Console.WriteLine("Banker");
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Doctor");
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Merchant");
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Blacksmith");
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Farmer");
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Teacher");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("");
            Console.WriteLine("What is your choice? ");
            string occupation = Console.ReadLine();

            if (occupation == "Banker" || occupation == "banker")
            {
                money = 1600;
            }
            if (occupation == "Doctor" || occupation == "doctor")
            {
                money = 1200;
            }

            if (occupation == "Merchant" || occupation == "merchant")
            {
                money = 1200;
            }
            if (occupation == "Blacksmith" || occupation == "blacksmith")
            {
                money = 800;
            }

            if (occupation == "Farmer" || occupation == "farmer")
            {
                money = 400;
            }
            if (occupation == "Teacher" || occupation == "teacher")
            {
                money = 400;
            }
            System.Threading.Thread.Sleep(500);

            Console.WriteLine(name + ", you chose " + occupation + ", you have " + money + " dollars!");

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("In order to survive, you will need to purchase supplies! Check out the store catalog and purchase items based on the ammount of money you have if you want to know your balance, type balance!");

            Console.WriteLine("Oxen - $20 per ox - max 20");
            System.Threading.Thread.Sleep(500);

            Console.WriteLine("Food - .25 per pound - max 2000 LBS ");
            System.Threading.Thread.Sleep(500);

            Console.WriteLine("weapons - $15 each - max 20");
            System.Threading.Thread.Sleep(500);

            Console.WriteLine("Box of wagon parts - $30 each - max 10 boxes");
            System.Threading.Thread.Sleep(500);

            Console.WriteLine("Now it is time to purchase your items!");
            System.Threading.Thread.Sleep(500);

            Console.WriteLine("How many oxen would you like to purchase?");
            ui2 = Console.ReadLine();
            oxen = Convert.ToInt32(ui2);

            if (oxen > 20)
                Console.WriteLine("The trail is low on grass, if you have more that 20 oxen they will die of starvation! Go back and purchase a different amomunt to continue!");

            Console.WriteLine("How many pounds of food would you like to purchase?");
            ui3 = Console.ReadLine();
            food = Convert.ToInt32(ui3);

            if (food > 2000)
                Console.WriteLine("Your Wagon is too heavy, you wont be able to move! lower the ammount of food you are purchasing to continue!");


            Console.WriteLine("How many weapons would you like to purchase?");
            ui4 = Console.ReadLine();
            weapons = Convert.ToInt32(ui4);

            if (weapons > 15)
                Console.WriteLine("Having over 15 weapons is illegal, lower the ammount of weapons your are purchasing to continue");


            Console.WriteLine("How many boxes of wagon parts would you like to purchase?");
            ui5 = Console.ReadLine();
            wagparts = Convert.ToInt32(ui5);

            if (wagparts > 20)
                Console.WriteLine("There are too many wagon parts in your wagon, you will not use all of them before they rot! Decrease the ammount of wagon parts you are purchaing to continue!");

            double foodfinal = food * foodprice;
            int oxenfinal = oxen * oxenprice;
            int wagpartsfinal = wagparts * wagpartsprice;
            int weaponsfinal = weaponsprice * weapons;
            double finalprices = weaponsfinal +


            Console.WriteLine("Here is your receipt!");
            Console.WriteLine("Oxen " + oxenfinal);
            Console.WriteLine("Wagon Parts " + wagpartsfinal);
            Console.WriteLine("Weapons " + weaponsfinal);
            Console.WriteLine("Food " + foodfinal);
            Console.WriteLine("Total = ")




Console.WriteLine(foodfinal);














        }
    }
}



