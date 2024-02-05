using Avalonia.Media;
using Bhvtools.OrderingClient.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Bhvtools.OrderingClient.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty] private EditOrderViewModel editOrderViewModel = new(new CatalogViewModel(new Catalog([
        new CatalogCategory("Frisdrank",
            Brushes.LightBlue,
            Brushes.Indigo,
            [
                new CatalogItem("Coca Cola", 1.5m),
                new CatalogItem("Fanta", 1.5m),
                new CatalogItem("Sprite", 1.5m)
            ]),
        new CatalogCategory("Warme dranken",
            Brushes.LightYellow,
            Brushes.Indigo,
            [
                new CatalogItem("Koffie", 2m),
                new CatalogItem("Thee", 1.5m)
            ]),
        new CatalogCategory("Wijn/aperitief",
            Brushes.AliceBlue,
            Brushes.Indigo,
            [
                new CatalogItem("Rode wijn", 3m),
                new CatalogItem("Witte wijn", 3m),
                new CatalogItem("Cava", 3m)
            ]),
        new CatalogCategory("Wijn/aperitief",
            Brushes.AliceBlue,
            Brushes.Indigo,
            [
                new CatalogItem("Rode wijn", 3m),
                new CatalogItem("Witte wijn", 3m),
                new CatalogItem("Cava", 3m)
            ]),
        new CatalogCategory("Wijn/aperitief",
            Brushes.AliceBlue,
            Brushes.Indigo,
            [
                new CatalogItem("Rode wijn", 3m),
                new CatalogItem("Witte wijn", 3m),
                new CatalogItem("Cava", 3m)
            ]),
    ])));
}