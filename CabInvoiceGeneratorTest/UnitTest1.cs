using CabInvoiceGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CabInvoiceGeneratorTest
{
    [TestClass]
    public class UnitTest1
    {
        //UC1 Given total distance and time should calculate and return total fare of the journey 
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
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.PREMIUM);
            Ride[] ride = { new Ride(2.0, 5), new Ride(0.1, 1) };
            InvoiceSummery actual = invoiceGenerator.CalculateFare(ride);
            InvoiceSummery expected = new InvoiceSummery(2, 60.0);
            Assert.AreEqual(expected, actual);
        }
    }
}