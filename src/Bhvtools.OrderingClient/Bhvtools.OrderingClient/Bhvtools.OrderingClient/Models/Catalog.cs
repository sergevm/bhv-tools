using System.Collections.Generic;
using System.Linq;
using Avalonia.Media;

namespace Bhvtools.OrderingClient.Models;

public record Catalog(CatalogCategory[] Categories);

public record CatalogCategory(string Name, IBrush BackgroundBrush, IBrush ForegroundBrush, CatalogItem[] Items);

public record CatalogItem(string Name, decimal UnitPrice);

public class OrderItem
{
    public CatalogItem CatalogItem { get; set; } = null!;
    public int Count { get; set; }
}

public class Order
{
    public List<OrderItem> Items { get; private set; } = [];

    public decimal Add(CatalogItem item, int count)
    {
        var existing = Items.SingleOrDefault(i => i.CatalogItem == item);
        if (existing != null)
        {
            existing.Count += count;
        }
        else
        {
            Items.Add(new OrderItem { CatalogItem = item, Count = count });
        }

        return CalculateTotal();
    }

    public decimal Remove(CatalogItem item)
    {
        var existing = Items.SingleOrDefault(i => i.CatalogItem == item);
        if (existing != null)
        {
            if (existing.Count > 1)
            {
                existing.Count--;
            }
            else
            {
                Items.Remove(existing);
            }
        }

        return CalculateTotal();
    }

    private decimal CalculateTotal()
    {
        return Items.Sum(i => i.CatalogItem.UnitPrice * i.Count);
    }
}