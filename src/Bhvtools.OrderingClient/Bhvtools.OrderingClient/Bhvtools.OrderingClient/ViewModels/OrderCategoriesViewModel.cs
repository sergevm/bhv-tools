using System.Collections.ObjectModel;
using System.Linq;
using Bhvtools.OrderingClient.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Bhvtools.OrderingClient.ViewModels;

public partial class OrderCategoriesViewModel : ObservableObject
{
   [ObservableProperty] private ReadOnlyObservableCollection<OrderCategoryViewModel> categories;
   [ObservableProperty] private OrderCategoryViewModel? selectedCategory;

   public OrderCategoriesViewModel(Catalog catalog)
   {
      categories = new ReadOnlyObservableCollection<OrderCategoryViewModel>(
         new ObservableCollection<OrderCategoryViewModel>(
            catalog.Categories.Select(cat => 
               new OrderCategoryViewModel(cat))));
   }
}