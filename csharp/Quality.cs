using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
	class Quality
	{
        public bool QualityIsLow(Item item)
        {
            return item.Quality < 50;
        }

        public void IncreaseQuality(Item item)
        {
            if (QualityIsLow(item))
            {
                item.Quality = item.Quality + 1;

                if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (item.SellIn < 11 && item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                    if (item.SellIn < 6 && item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }
            }
        }

        public void DecreaseQuality(Item item)
        {
            if (item.Quality > 0 && item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.Quality = item.Quality - 1;
            }
        }
    }
}

