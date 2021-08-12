using System.Collections.Generic;
using Xunit;

namespace GildedTros.App
{
    public class GildedTrosTest
    {
        [Fact]
        public void QualityAndSellInnDecrease()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 10, Quality = 10 } };
            GildedTros app = new GildedTros(Items);
            app.UpdateQuality();
            Assert.Equal("foo", Items[0].Name);
            Assert.Equal(9, Items[0].Quality);
            Assert.Equal(9, Items[0].SellIn);
        }

        [Fact]
        public void SellInnDecreasesQualityCannotBeNegative()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedTros app = new GildedTros(Items);
            app.UpdateQuality();
            Assert.Equal("foo", Items[0].Name);
            Assert.Equal(-1, Items[0].SellIn);
            Assert.Equal(0, Items[0].Quality);
        }
    }
}