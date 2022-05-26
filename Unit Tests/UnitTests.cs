using Xunit;
using Shauns_Cleaning_Service_Assignment;
using System;
using static Shauns_Cleaning_Service_Assignment.Enums;

namespace Unit_Tests
{
    public class UnitTests
    {
        [Fact]
        public void BuildingUnitTests()
        {
            Customer TestCustomer = new Customer("Jack", "Hine");

            Building TestBuilder = new Building("69 Avenue", Nature.DOMESTIC, TestCustomer);
            string TestString = TestBuilder.ToString();

            Assert.Equal($"Building Type: {Nature.DOMESTIC}  Address: 69 Avenue  Customer: Jack Hine", TestString);
        }
        [Fact]
        public void PurchaseUnitTests()
        {
            Cleaning TestCleaner = new Cleaning("Simon", "Minter", "Simone123", "Password123");

            Purchase TestPurchase = new Purchase("Test Description", 20, TestCleaner);
            string TestString = TestPurchase.ToString();

            Assert.Equal($"Test Description  Created By: Simon Minter at {DateTime.Now}  Cost: 20", TestString);
        }
        [Fact]
        public void AdminUnitTest()
        {
            Admin TestAdmin = new Admin("Ben", "Pople", "Jam23", "BooBoo69");
            string TestString = TestAdmin.ToString();

            Assert.Equal($"Ben Pople", TestString);
        }
        [Fact]
        public void BookingUNitTest()
        {
            Booking TestBooking = new Booking("Lig", "Ma", "Ha", "Got'em");
            string TestString = TestBooking.ToString();

            Assert.Equal($"Lig Ma", TestString);
        }
        [Fact]
        public void MaintenanceUNitTest()
        {
            Booking TestBooking = new Booking("Lig", "Ma", "Ha", "Got'em");
            string TestString = TestBooking.ToString();

            Assert.Equal($"Lig Ma", TestString);
        }

    }
}