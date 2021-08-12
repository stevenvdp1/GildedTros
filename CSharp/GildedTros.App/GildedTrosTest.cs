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
        //Good Wine TESTS:
        //Quality increases
        //Quality not more than 50
        //Quality increases x2 when date has passed
        [InlineData("Good Wine", 2, 2, 1, 3)]
        [InlineData("Good Wine", 2, 50, 1, 50)]
        [InlineData("Good Wine", -1, 10, -2, 12)]
        //B-DAWG Keychain TESTS:
        //never changes???
        [InlineData("B-DAWG Keychain", 10, 80, 10, 80)]
        //Backstage passes TESTS:
        //Quality increases by 1 when there are 10 days or more
        //Quality increases by 2 when there are 10 days or less
        //Quality increases by 3 when there are 5 days or less
        //Quality drops to 0 after the conference
        [InlineData("Backstage passes for HAXX", 15, 10, 14, 11)]
        [InlineData("Backstage passes for HAXX", 10, 10, 9, 12)]
        [InlineData("Backstage passes for HAXX", 5, 10, 4, 13)]
        [InlineData("Backstage passes for HAXX", 0, 10, -1, 0)]
        //Smelly items TESTS:
        //degrade in Quality twice as fast as normal items
        [InlineData("Duplicate Code", 10, 10, 9, 8)]
        [InlineData("Duplicate Code", 0, 10, -1, 4)]
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