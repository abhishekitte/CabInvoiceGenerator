using CabInvoiceGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MStestforCabInvoice
{
    [TestClass]
    public class UnitTest1
    {
        //UC1 Given total distance and time should calculate and return total fare (NORMAL) of the journey 
        [TestMethod]
        [TestCategory("Fare")]
        public void GivenDistanceAndTimeShouldReturnNormalFare()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 3.0;
            int time = 5;
            //Calculating Fair
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 35;
            Assert.AreEqual(expected, fare);
        }

        //Uc2 calculate total fare for multiple ride
        //Given number of rides should return total invoice summery
        [TestMethod]
        [TestCategory("Fare")]
        public void GivenMultipleRidesShouldReturnInvoiceSummary()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Ride[] ride = { new Ride(3.0, 5), new Ride(0.1, 1) };
            InvoiceSummery actual = invoiceGenerator.CalculateFare(ride);
            InvoiceSummery expected = new InvoiceSummery(2, 40.0);
            Assert.AreEqual(expected, actual);
        }

        //Uc3 given multiple rides should show total no of rides, total fare, average fare per ride
        //Uc3 given multiple rides should return average fare
        [TestMethod]
        public void Return_AverageFare()
        {
            InvoiceGenerator invoice = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(3.0, 5), new Ride(0.1, 1) };
            InvoiceSummery summary = new InvoiceSummery(2, 40.0);
            InvoiceSummery expected = invoice.CalculateFare(rides);
            Assert.AreEqual(summary.averageFare, expected.averageFare);
        }
        //Uc3 given multiple rides should returns number of rides 
        [TestMethod]
        public void Return_NumofRides()
        {
            InvoiceGenerator invoice = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(3.0, 5), new Ride(0.1, 1) };

            InvoiceSummery summary = new InvoiceSummery(2, 40.0);
            InvoiceSummery expected = invoice.CalculateFare(rides);
            Assert.AreEqual(summary.numberOfRides, expected.numberOfRides);
        }

        //Uc3 given multiple rides should returns Total fare
        [TestMethod]
        public void Return_TotalFare()
        {
            InvoiceGenerator invoice = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(3.0, 5), new Ride(0.1, 1) };

            InvoiceSummery summary = new InvoiceSummery(2, 40.0);
            InvoiceSummery expected = invoice.CalculateFare(rides);
            Assert.AreEqual(summary.totalFare, expected.totalFare);
        }
    }
}