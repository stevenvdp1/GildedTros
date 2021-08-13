using System.Collections.Generic;

namespace GildedTros.App
{
    public class GildedTros
    {

        private const string GOOD_WINE = "Good Wine";
        private const string KEYCHAIN = "B-DAWG Keychain";
        private static readonly IList<string> BACKSTAGE_PASSES = new List<string> { "Backstage passes for Re:factor", "Backstage passes for HAXX" };
        private static readonly IList<string> SMELLY_ITEMS = new List<string> { "Duplicate Code", "Long Methods", "Ugly Variable Names" };

        IList<Item> Items;
        public GildedTros(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (Item item in Items)
            {
                UpdateItem(item);
            }
        }


        private void UpdateItem(Item item)
        {
            bool doesItemDegrade = !item.Name.Equals(GOOD_WINE) && !item.Name.Equals(KEYCHAIN) && !BACKSTAGE_PASSES.Contains(item.Name);
            bool isItemExpired = item.SellIn < 1;
            bool doesSellInDecrease = !item.Name.Equals(KEYCHAIN);
            bool isSmelly = SMELLY_ITEMS.Contains(item.Name);

            if (doesItemDegrade)
            {
                int degradeRate = isSmelly ? -2 : -1;
                if (isItemExpired)
                {
                    updateItemQuality(item, 2*degradeRate);
                }
                else
                {
                    updateItemQuality(item, degradeRate);
                }
            }

            else if(item.Name == GOOD_WINE)
            {
                if (isItemExpired) updateItemQuality(item,2);
                else updateItemQuality(item,1);
            }

            else if (BACKSTAGE_PASSES.Contains(item.Name))
            {
                updateItemQuality(item, 1);
                if (item.SellIn < 11)
                {
                    updateItemQuality(item, 1);
                }
                if (item.SellIn < 6)
                {
                    updateItemQuality(item, 1);
                }
                if (isItemExpired)
                {
                    item.Quality = 0;
                }
            }

            if (doesSellInDecrease)
            {
                item.SellIn--;
            }
        }

        private void updateItemQuality(Item item, int adjustment)
        {
            item.Quality = item.Quality + adjustment;
            if (item.Quality > 50) item.Quality = 50;
            if (item.Quality < 0) item.Quality = 0;
        }

    }
}
