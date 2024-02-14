using System.Collections.Generic;
using System.Linq;
using Avalonia.Media;

namespace Bhvtools.OrderingClient.Models;

public record Catalog(CatalogCategory[] Categories);

public record CatalogCategory(string Name, IBrush BackgroundBrush, IBrush ForegroundBrush, CatalogItem[] Items);

public record CatalogItem(string Name, decimal UnitPrice);

public class OrderItem(CatalogItem catalogItem)
{
    public CatalogItem CatalogItem { get; init; } = catalogItem;
    public int Count { get; set; }
}

public class Order
{
    public List<OrderItem> Items { get; } = [];

    public OrderItem Add(CatalogItem item, int? count = null)
    {
        var orderItem = Items.SingleOrDefault(i => i.CatalogItem == item);
        if (orderItem != null)
        {
            orderItem.Count += count ?? 1;
        }
        else
        {
            orderItem = new OrderItem(item) { Count = count ?? 1 };
            Items.Add(orderItem);
        }

        return orderItem;
    }

    public OrderItem? Remove(CatalogItem item)
    {
        var orderItem = Items.SingleOrDefault(i => i.CatalogItem == item);
        if (orderItem == null)
        {
            orderItem = new OrderItem(item) { Count = 0 };
            Items.Add(orderItem);
        }

        if (orderItem.Count > 0)
        {
            orderItem.Count--;
        }
        else
        {
            Items.Remove(orderItem);
        }

        return orderItem;
    }
}