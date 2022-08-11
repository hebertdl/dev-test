using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using csharp;

namespace ShiMartTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UpdateQuality_WhenProduceSellInIs1_ReturnQuality0()
        {
            IList<Item> items = new List<Item>
            {
                new Item { Name = "Bananas", SellIn = 1, Quality = 1 }
            };

            var app = new ShiMart(items);

            app.UpdateQuality();

            Assert.AreEqual(0, items.First().SellIn);
            Assert.AreEqual(0, items.First().Quality);
        }
        [TestMethod]
        public void UpdateQuality_WhenCannedSellInIs1_ReturnQuality1()
        {
            IList<Item> items = new List<Item>
            {
                new Item { Name = "Canned Beans", SellIn = 1, Quality = 1 }
            };

            var app = new ShiMart(items);

            app.UpdateQuality();

            Assert.AreEqual(1, items.First().SellIn);
            Assert.AreEqual(1, items.First().Quality);
        }
        [TestMethod]
        public void UpdateQuality_WhenAgedSellInIs1_ReturnQuality2()
        {
            IList<Item> items = new List<Item>
            {
                new Item { Name = "Aged Brie", SellIn = 1, Quality = 1 }
            };

            var app = new ShiMart(items);

            app.UpdateQuality();

            Assert.AreEqual(0, items.First().SellIn);
            Assert.AreEqual(2, items.First().Quality);
        }
        [TestMethod]
        public void UpdateQuality_WhenBakedSellInIs1_ReturnQuality0()
        {
            IList<Item> items = new List<Item>
            {
                new Item { Name = "Baked Sourdough Bread", SellIn = 1, Quality = 2 }
            };

            var app = new ShiMart(items);

            app.UpdateQuality();

            Assert.AreEqual(0, items.First().SellIn);
            Assert.AreEqual(0, items.First().Quality);
        }
    }
}
