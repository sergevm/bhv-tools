using System.Collections.ObjectModel;
using System.Linq;
using Avalonia.Media;
using Bhvtools.OrderingClient.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Bhvtools.OrderingClient.ViewModels;

public partial class OrderCategoryViewModel(CatalogCategory category) : ObservableObject
{
   [ObservableProperty] private string name = category.Name;
   [ObservableProperty] private IBrush background = category.BackgroundBrush;
   [ObservableProperty] private IBrush foreground = category.ForegroundBrush;
   [ObservableProperty] private ReadOnlyObservableCollection<OrderCatalogItemViewModel> items = 
       new(new ObservableCollection<OrderCatalogItemViewModel>(category.Items.Select(
           item => new OrderCatalogItemViewModel(item, category.BackgroundBrush, category.ForegroundBrush))));
}