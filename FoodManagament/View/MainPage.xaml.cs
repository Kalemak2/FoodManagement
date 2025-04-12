using FoodManagament.ViewModel;

namespace FoodManagament
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel(new Service.DataService(), Navigation);
        }
    }

}
