using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6
{
    class CurrentBooking : Ticket
    {
        private int price;

        public CurrentBooking() : base()
        {
            price = 75;
        }

        public CurrentBooking(int NextTicketNumber) : base(NextTicketNumber)
        {
            price = 75;
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
