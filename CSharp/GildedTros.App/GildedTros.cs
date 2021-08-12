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
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != GOOD_WINE && !BACKSTAGE_PASSES.Contains(Items[i].Name))
                {
                    if (Items[i].Quality > 0)
                    {
                        if (Items[i].Name != KEYCHAIN)
                        {
                            Items[i].Quality = Items[i].Quality - 1;
                        }
                    }
                }
                else
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;

                        if (BACKSTAGE_PASSES.Contains(Items[i].Name))
                        {
                            if (Items[i].SellIn < 11)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }

                            if (Items[i].SellIn < 6)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }
                        }
                    }
                }

                if (Items[i].Name != KEYCHAIN)
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }

                if (Items[i].SellIn < 0)
                {
                    if (Items[i].Name != GOOD_WINE)
                    {
                        if (!BACKSTAGE_PASSES.Contains(Items[i].Name))
                        {
                            if (Items[i].Quality > 0)
                            {
                                if (Items[i].Name != KEYCHAIN)
                                {
                                    Items[i].Quality = Items[i].Quality - 1;
                                }
                            }
                        }
                        else
                        {
                            Items[i].Quality = Items[i].Quality - Items[i].Quality;
                        }
                    }
                    else
                    {
                        if (Items[i].Quality < 50)
                        {
                            Items[i].Quality = Items[i].Quality + 1;
                        }
                    }
                }
            }
        }
    }
}
