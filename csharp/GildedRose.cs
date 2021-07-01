using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        Quality quality = new Quality();
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    quality.DecreaseQuality(item);
                }
                else
                {
                    quality.IncreaseQuality(item);
                }
                if (item.Name != "Sulfuras, Hand of Ragnaros")
                {
                    item.SellIn = item.SellIn - 1;
                }
                if (item.SellIn < 0)
                {
                    if (quality.QualityIsLow(item))
                    {
                        item.Quality = item.Quality + 1;
                        return;
                    }
                    if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert")
                    {
                        quality.DecreaseQuality(item);
                    }
                    else
                    {
                        item.Quality = item.Quality - item.Quality;
                    }
                }
            }
        }
    }
}
