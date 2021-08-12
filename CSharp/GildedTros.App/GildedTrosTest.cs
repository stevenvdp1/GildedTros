using System.Collections.Generic;
using Xunit;

namespace GildedTros.App
{
    public class GildedTrosTest
    {
        [Theory]
        [InlineData("foo", 10, 10,9 ,9)]
        [InlineData("foo", 0, 0, -1,0)]
        [InlineData("foo", -1, 10, -2,8)]
        public void UpdateQuality(string name,int sellIn, int quality, int expectedSellIn, int expectedQuality)
        {
            IList<Item> Items = new List<Item> { new Item { Name = name, SellIn = sellIn, Quality = quality }  };
            GildedTros app = new GildedTros(Items);
            app.UpdateQuality();
            Assert.Equal(name, Items[0].Name);
            Assert.Equal(expectedSellIn, Items[0].SellIn);
            Assert.Equal(expectedQuality, Items[0].Quality);
        }
    }
}