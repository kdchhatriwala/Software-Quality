using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopDiscount.nunitTests
{
    public class EmployeeDiscountTests
    {
        [Test]
        public void CalculateDiscountedPrice_PartialLoad_5PercentDiscount()
        {
            var discount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.PartialLoad,
                Price = 100 // Example price
            };

            decimal discountedPrice = discount.CalculateDiscountedPrice();
            Assert.AreEqual(95, discountedPrice); // 5% discount expected
        }



        [Test]
        public void CalculateDiscountedPrice_FullTime_10PercentDiscount()
        {
            var discount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.FullTime,
                Price = 100 // Example price
            };

            decimal discountedPrice = discount.CalculateDiscountedPrice();
            Assert.AreEqual(90, discountedPrice); // 10% discount expected
        }


        [Test]
        public void CalculateDiscountedPrice_CompanyPurchasing_20PercentDiscount()
        {
            var discount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.CompanyPurchasing,
                Price = 100 // Example price
            };

            decimal discountedPrice = discount.CalculateDiscountedPrice();
            Assert.AreEqual(80, discountedPrice); // 20% discount expected
        }

        [Test]
        public void CalculateDiscountedPrice_NegativePrice_InvalidInput()
        {
            var discount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.FullTime,
                Price = -50 // Example negative price
            };

            decimal discountedPrice = discount.CalculateDiscountedPrice();
            Assert.AreEqual(-50, discountedPrice); // No discount expected (invalid input)
        }


        [Test]
        public void CalculateDiscountedPrice_ExtremelyHighPrice_InvalidInput()
        {
            var discount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.CompanyPurchasing,
                Price = 1000000 // Example extremely high price
            };

            decimal discountedPrice = discount.CalculateDiscountedPrice();
            Assert.AreEqual(1000000, discountedPrice); // No discount expected (invalid input)
        }
    }
}
