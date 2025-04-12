using FoodManagament.Model;
using System.Collections.ObjectModel;

namespace FoodManagament.Service
{
    public class DataService
    {
        public ObservableCollection<Dish> Dishes { get; set; }
        public Dish SelectedDish { get; set; }

        public DataService()
        {
            Dishes = new()
            {
               new Dish
               {
                    Name = "Pizza Margherita",
                    Price = 20.50,
                    Description = "Klasyczna pizza z pomidorami, mozzarellą i bazylią.",
                    Type = "Pizza",
                    Ingredients = new ObservableCollection<string> { "Ciasto", "Sos pomidorowy", "Mozzarella", "Bazylia" },
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/a/a3/Eq_it-na_pizza-margherita_sep2005_sml.jpg"
                },
                new Dish
                {
                    Name = "Spaghetti Carbonara",
                    Price = 18.00,
                    Description = "Pyszne spaghetti z sosem jajecznym, boczkiem i parmezanem.",
                    Type = "Pasta",
                    Ingredients = new ObservableCollection<string> { "Spaghetti", "Boczek", "Jajka", "Parmezan" },
                    ImageUrl = "https://static01.nyt.com/images/2021/02/14/dining/carbonara-horizontal/carbonara-horizontal-mediumSquareAt3X-v2.jpg"
                },
                new Dish
                {
                    Name = "Lasagne",
                    Price = 22.00,
                    Description = "Lasagne z mięsem mielonym, serem i sosem pomidorowym.",
                    Type = "Pasta",
                    Ingredients = new ObservableCollection<string> { "Makaron", "Mięso mielone", "Ser", "Sos pomidorowy" },
                    ImageUrl = "https://staticsmaker.iplsc.com/smaker_production_2023_01_25/f7ecd17cbc17b7234143fa5b3a293872-content.jpg"
                },
                new Dish
                {
                    Name = "Zupa Pomidorowa",
                    Price = 10.50,
                    Description = "Tradycyjna polska zupa pomidorowa z ryżem.",
                    Type = "Zupa",
                    Ingredients = new ObservableCollection<string> { "Pomidor", "Ryż", "Bulion", "Śmietana" },
                    ImageUrl = "https://img.wprost.pl/img/wysmienita-zupa-pomidorowa-ze-swiezych-pomidorow-z-tego-przepisu-przygotowywala-ja-moja-babcia/1f/1a/c69122a80c37084cbe83608f4120.webp"
                }
            };
        }

    }
}
