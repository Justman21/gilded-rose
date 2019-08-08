using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality() // isskaidyt i kelis metodus
        {
            foreach (Item item in Items)
            {
                if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert") 
                {
                    if (item.Quality > 0 && item.Name != "Sulfuras, Hand of Ragnaros") // Sulfuras ir 0<item.Quality<50 galima butu iskelt?? 
                    {
                        item.Quality--;
                    }
                    if (item.Quality > 0 && item.Name == "Conjured Mana Cake")
                    {
                        item.Quality--;
                    }
                }
                else
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;

                        if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (item.SellIn < 11 && item.Quality < 50)
                            {
                                item.Quality++;
                            }

                            if (item.SellIn < 6 && item.Quality < 50)
                            {
                                item.Quality++; 
                            }
                        }
                    }
                }

                if (item.Name != "Sulfuras, Hand of Ragnaros") 
                {
                    item.SellIn--;
                }

                if (item.SellIn < 0) 
                {
                    if (item.Name != "Aged Brie")
                    {
                        if (item.Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (item.Quality > 0 && item.Name != "Sulfuras, Hand of Ragnaros")
                            {                 
                                item.Quality--;
                            }
                            if (item.Quality > 0 && item.Name == "Conjured Mana Cake")
                            {
                                item.Quality--; 
                            }
                        }
                        else
                        {
                            item.Quality = 0;
                        }
                    }
                    else
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality++;
                        }
                    }
                }
            }
        }
    }
}
