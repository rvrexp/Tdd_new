﻿using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tdd_new;

namespace TddNUnittest
{
    [TestFixture]
    public class ProductNUnitTests
    {
        [Test]
        public void GetProductPrice_PlatinumCustomer_ReturnPriceWith20Discount()
        {
            Product product = new Product() { Price = 50 };
            var result = product.GetPrice(new Customer() { IsPlatinum = true });
            Assert.That(result, Is.EqualTo(40));
        }
       
    }
}