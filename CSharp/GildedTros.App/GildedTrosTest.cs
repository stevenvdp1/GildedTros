using System.Collections.Generic;
using Xunit;

namespace GildedTros.App
{
    public class GildedTrosTest
    {
        [Theory]
        //GENERAL TESTS:
        //The Quality of an item is never negative
        //Once the sell by date has passed, Quality degrades twice as fast
        [InlineData("foo", 10, 10, 9, 9)]
        [InlineData("foo", 0, 0, -1, 0)]
        [InlineData("foo", -1, 10, -2, 8)]
        //Good Wine TESTS
        //Quality increases
        //Quality not more than 50
        //Quality increases x2 when date has passed
        [InlineData("Good Wine", 2, 2, 1, 3)]
        [InlineData("Good Wine", 2, 50, 1, 50)]
        [InlineData("Good Wine", -1, 10, -2, 12)]
        public void UpdateQuality(string name, int sellIn, int quality, int expectedSellIn, int expectedQuality)
        {
            IList<Item> Items = new List<Item> { new Item { Name = name, SellIn = sellIn, Quality = quality } };
            GildedTros app = new GildedTros(Items);
            app.UpdateQuality();
            Assert.Equal(name, Items[0].Name);
            Assert.Equal(expectedSellIn, Items[0].SellIn);
            Assert.Equal(expectedQuality, Items[0].Quality);
        }
    }
}