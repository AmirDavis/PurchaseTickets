using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6
{
    class AdvanceBooking : Ticket
    {
        private int price;

        public AdvanceBooking() : base()
        {
            price = 50;
        }

        public AdvanceBooking(int NextTicketNumber, int numDaysUntilGame) : base(NextTicketNumber)
        {
            if (numDaysUntilGame >= 15)
            {
                price = 25;
            }
            else price = 50;
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
