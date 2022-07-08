using System;
using System.Collections;

namespace Assignment_6
{
    class PurchaseTickets
    {
        static void Main(string[] args)
        {
            int userChoice = 0;
            int daysInAdvance;
            int NextTicketNum = 1;
            char userYN = ' ';
            ArrayList userTickets = new ArrayList();
            Menu menu = new Menu();
            
            while(userChoice != 5)
            {
                menu.printMenu();   
                userChoice = Int32.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        Console.Write("How many days is the game away? ");
                            daysInAdvance = Int32.Parse(Console.ReadLine());
                        AdvanceBooking advancedBookedTicket = new AdvanceBooking(NextTicketNum, daysInAdvance);
                        Console.WriteLine("Cost: " + advancedBookedTicket.getPrice());
                        Console.WriteLine("Would you like to add ticket to cart(Y/N)?");
                            userYN = char.Parse(Console.ReadLine());
                        if(char.ToUpper(userYN) == 'Y')
                        {
                            userTickets.Add(advancedBookedTicket.ToString());
                        }
                        break;

                    case 2:
                        CurrentBooking regularTicket = new CurrentBooking(NextTicketNum);
                        Console.WriteLine("Cost: " + regularTicket.getPrice());
                        Console.WriteLine("Would you like to add ticket to cart(Y/N)?");
                            userYN = char.Parse(Console.ReadLine());
                        if (char.ToUpper(userYN) == 'Y')
                        {
                            userTickets.Add(regularTicket.ToString());
                        }
                        break;

                    case 3:
                        Console.Write("How many days is the game away? ");
                            daysInAdvance = Int32.Parse(Console.ReadLine());
                        DiscountBooking discountedTicket = new DiscountBooking(NextTicketNum, daysInAdvance);
                        Console.WriteLine("Cost: " + discountedTicket.getPrice());
                        Console.Write("Would you like to add ticket to cart(Y/N)?");
                            userYN = char.Parse(Console.ReadLine());
                        if (char.ToUpper(userYN) == 'Y')
                        {
                            userTickets.Add(discountedTicket.ToString());
                        }
                        break;

                    case 4:
                        for(int i = 0; i < userTickets.Count; i++)
                        {
                            Console.WriteLine(userTickets[i]);
                        }
                        break;

                    case 5:
                        break;
                }
                NextTicketNum++;
            }
        }
    }
}
