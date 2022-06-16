using System;

namespace Deliverable2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string drink;
            
            int wat = 0;
            Console.WriteLine("Hi! Welcome to our Buffet.  All you can eat for $9.99! We only charge extra" +
                " for redbull.  How many humans are in your group?  Please, parties of 6 or lower.");
            int party = int.Parse(Console.ReadLine()); //didnt have the time to go back and change to a string initially but can try if score <80?  
            if (party <= 6)
            {
                Console.WriteLine("A table for " + party + "!  Please follow me and take a seat.");
                Console.WriteLine("Let's get everyone started with some drinks.  We've got water or redbull.");
                int p = party;
                int bull = 0;
                int p1 = 0;
                decimal pbuffet = 9.99m;
                decimal pbull = 2.49m;
                decimal ppbuffet = pbuffet * party;
                
                do
                {


                    p1++;
                    Console.WriteLine("Alright, person number {0} ", p1 + ", water or Redbull?");
                    drink = Console.ReadLine();
                    if (drink.Equals("redbull"))
                    {
                        Console.WriteLine("Redbull for the human whose about to get wings, good choice!");
                        bull++;
                    }
                    if (drink.Equals("water"))
                    {
                        Console.WriteLine("Water for the Human whose already 60% water, good choice!");
                        wat++;
                    }
                    if (drink != ("redbull") && drink != ("water"))
                    {
                        Console.WriteLine("We don't have that.  No drink for you!");
                    }

                } while (p1 < party);
                decimal ppbull = bull * pbull;
                decimal bill = ppbuffet + ppbull;
                
                Console.WriteLine("Okay, so that's {0} redbulls and", (bull));
                Console.Write("{0} waters ", (wat)); //hit a wall on making this one line with a + but it works from my view.
                Console.WriteLine("I'll be right back.  Feel free to grab your food!");
                Console.WriteLine("Here's your bill! Total price: ${0}", bill);
            }else { Console.WriteLine("Sorry, can only seat parties up to 6.  Have a nice day."); }
        }
    }
}
