using System.Collections.ObjectModel;
using Bhvtools.OrderingClient.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Bhvtools.OrderingClient.ViewModels;

public partial class EditOrderViewModel(CatalogViewModel catalog, ObservableCollection<OrderItem>? items = null)
    : ObservableObject
{
    public CatalogViewModel Catalog { get; } = catalog;
    [ObservableProperty] private ObservableCollection<OrderItem> items = items ?? [];
    [ObservableProperty] private CatalogCategoryViewModel? selectedCategory;
}