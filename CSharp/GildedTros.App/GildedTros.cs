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
                UpdateItemQuality(item);
            }
        }


        public void UpdateItemQuality(Item item)
        {
            bool doesItemDegrade = !item.Name.Equals(GOOD_WINE) && !item.Name.Equals(KEYCHAIN) && !BACKSTAGE_PASSES.Contains(item.Name);
            bool isItemExpired = item.SellIn < 1;
            bool decreaseSellIn = !item.Name.Equals(KEYCHAIN);

            if (doesItemDegrade)
            {
                if (isItemExpired)
                {
                    item.Quality = item.Quality - 2;
                }
                else
                {
                    item.Quality = item.Quality - 1;
                }

                if (item.Quality < 0) item.Quality = 0;
            }

            if(item.Name == GOOD_WINE)
            {
                if (isItemExpired) item.Quality = item.Quality + 2;
                else item.Quality = item.Quality + 1;

                if (item.Quality > 50) item.Quality = 50; 
            }

            if (BACKSTAGE_PASSES.Contains(item.Name))
            {
                if (isItemExpired)
                {
                    item.Quality = 0;
                }
                else
                {
                    item.Quality = item.Quality + 1;
                    if (item.SellIn < 11)
                    {
                        item.Quality = item.Quality + 1;
                    }
                    if (item.SellIn < 6)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }
            }

            if (decreaseSellIn)
            {
                item.SellIn--;
            }
        }
    }
}
