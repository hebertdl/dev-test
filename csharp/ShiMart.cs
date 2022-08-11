using System.Collections.Generic;
using System.Net.Http.Headers;

namespace csharp
{
    public class ShiMart
    {
        IList<Item> Items;
        public ShiMart(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != "Canned Beans")
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }
                
                SetQuality(Items[i]);

                if (Items[i].SellIn < 0)
                {
                    SetQuality(Items[i]);
                }
            }
        }

        private void SetQuality(Item item)
        {
            switch (item.Name)
            {
                case "Canned Beans":
                {
                    return;
                }
                case "Aged Brie":
                {
                    item.Quality += 1;
                    if (item.Quality > 50) item.Quality = 50;
                    break;
                }
                case "Baked Sourdough Bread":
                {
                    item.Quality -= 2;
                    if (item.Quality < 0) item.Quality = 0;
                    break;
                }
                default:
                {
                    item.Quality -= 1;
                    if (item.Quality < 0) item.Quality = 0;
                    break;
                }

            }
        }
    }
}
