using Avalonia.Media;
using Bhvtools.OrderingClient.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Bhvtools.OrderingClient.ViewModels;

public partial class CatalogItemViewModel(CatalogItem catalogItem, IBrush background, IBrush foreground) : ObservableObject
{
    
    [ObservableProperty] private string name = catalogItem.Name;
    [ObservableProperty] private decimal unitPrice = catalogItem.UnitPrice;
    public IBrush Background => background;
    public IBrush Foreground => foreground;
    public CatalogItem CatalogItem => catalogItem;
}