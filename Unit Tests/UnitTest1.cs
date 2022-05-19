using Xunit;
using Shauns_Cleaning_Service_Assignment;

namespace Unit_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void PurchaseUnitTest()
        {
            Cleaning TestCleaner = new Cleaning("Simon", "Minter", "Simone123", "Password123");

            Purchase TestPurchase = new Purchase("Test Description", 20, TestCleaner);
            string TestString = TestPurchase.ToString();

            Assert.Equal("Test Description   Created By: Simon Minter   ", TestString);
        }
    }
}