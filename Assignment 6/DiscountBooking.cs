using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6
{
    class DiscountBooking : Ticket
    {
        private int price;

        public DiscountBooking() : base()
        {
            price = 10;
        }

        public DiscountBooking(int NextTicketNumber, int numDaysUntilGame) : base(NextTicketNumber)
        {
            if(numDaysUntilGame > 0)
            {
                price = 10;
            }
            else
            {
                price = 75;
            }
        }

        public override int getPrice()
        {
            return price;
        }

        public override string ToString()
        {
            return base.ToString() + " | Price: " + price;
        }
    }
}
