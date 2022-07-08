using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6
{
    public abstract class Ticket
    {
        private int NextTicketNumber = 1;
        private int ticketNumber;
        
        public Ticket()
        {
            ticketNumber = NextTicketNumber;
            //this.NextTicketNumber = NextTicketNumber;
        }

        public Ticket(int NextTicketNumber)
        {
            this.NextTicketNumber = NextTicketNumber;
            ticketNumber = NextTicketNumber;
        }

        public abstract int getPrice();

        public void IncrementNextTicketNumber()
        {
            NextTicketNumber++;
        }

        public override string ToString()
        {
            return (this.GetType().Name + " | Ticket Number: " + ticketNumber);
        }

    }
}
