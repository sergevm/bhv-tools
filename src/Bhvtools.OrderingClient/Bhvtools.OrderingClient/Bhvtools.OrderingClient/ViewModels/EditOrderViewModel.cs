using Bhvtools.OrderingClient.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Bhvtools.OrderingClient.ViewModels;

public partial class EditOrderViewModel(Order order, OrderCategoriesViewModel orderCategories)
    : ObservableObject
{
    public OrderCategoriesViewModel OrderCategories { get; } = orderCategories;

    [RelayCommand]
    private void AddItem(OrderCatalogItemViewModel catalogitem)
    {
        var orderItem = order.Add(catalogitem.CatalogItem);
        catalogitem.Count = orderItem.Count;
    }

    [RelayCommand]
    private void RemoveItem(OrderCatalogItemViewModel catalogItem)
    {
        var orderItem = order.Remove(catalogItem.CatalogItem);
        catalogItem.Count = orderItem?.Count ?? 0;
    }
}