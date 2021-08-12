using System.Collections.Generic;

namespace GildedTros.App
{
    public class GildedTros
    {

        private const string GOOD_WINE = "Good Wine";
        private const string KEYCHAIN = "B-DAWG Keychain";
        private static readonly IList<string> BACKSTAGE_PASSES = new List<string>{"Backstage passes for Re:factor", "Backstage passes for HAXX" };
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
                if (item.Name != GOOD_WINE && !BACKSTAGE_PASSES.Contains(item.Name))
                {
                    if (item.Quality > 0)
                    {
                        if (item.Name != KEYCHAIN)
                        {
                            item.Quality = item.Quality - 1;
                        }
                    }
                }
                else
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;

                        if (BACKSTAGE_PASSES.Contains(item.Name))
                        {
                            if (item.SellIn < 11)
                            {
                                if (item.Quality < 50)
                                {
                                    item.Quality = item.Quality + 1;
                                }
                            }

                            if (item.SellIn < 6)
                            {
                                if (item.Quality < 50)
                                {
                                    item.Quality = item.Quality + 1;
                                }
                            }
                        }
                    }
                }

                if (item.Name != KEYCHAIN)
                {
                    item.SellIn = item.SellIn - 1;
                }

                if (item.SellIn < 0)
                {
                    if (item.Name != GOOD_WINE)
                    {
                        if (!BACKSTAGE_PASSES.Contains(item.Name))
                        {
                            if (item.Quality > 0)
                            {
                                if (item.Name != KEYCHAIN)
                                {
                                    item.Quality = item.Quality - 1;
                                }
                            }
                        }
                        else
                        {
                            item.Quality = item.Quality - item.Quality;
                        }
                    }
                    else
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }
                    }
                }
            }
        }
    }
}
