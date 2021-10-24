using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceSummery
    {
        //Decalring variables
        public int numberOfRides;
        public double totalFare;
        public double averageFare;

        //Parameterized Constructor
        public InvoiceSummery(int numberOfRides, double totalFare)
        {
            this.numberOfRides = numberOfRides;
            this.totalFare = totalFare;
            this.averageFare = totalFare / numberOfRides;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is InvoiceSummery))
            {
                return false;
            }
            InvoiceSummery inputobject = (InvoiceSummery)obj;
            return this.numberOfRides == inputobject.numberOfRides && this.totalFare == inputobject.totalFare && this.averageFare == inputobject.averageFare;
        }
    }
}