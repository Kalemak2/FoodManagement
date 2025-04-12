using FoodManagament.Model;
using FoodManagament.Service;
using FoodManagament.View;
using System.Collections.ObjectModel;

namespace FoodManagament.ViewModel
{
    internal class MainViewModel
    {
        public ObservableCollection<Dish> Dishes { get; set; }
        public Command ShowDetailedCmd { get; }

        private readonly INavigation _navigation;
        private readonly DataService _dataService;
        public MainViewModel(DataService dataService, INavigation navigation)
        {
            _navigation = navigation;
            _dataService = dataService;
            Dishes = _dataService.Dishes;
            ShowDetailedCmd = new Command<Dish>(ShowDetails);
        }
        private async void ShowDetails(Dish dish)
        {
            if (dish != null)
                await _navigation.PushAsync(new EditPage(dish, _navigation));
        }
    }
}
