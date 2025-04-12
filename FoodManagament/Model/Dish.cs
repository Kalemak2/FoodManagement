using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace FoodManagament.Model
{
    public class Dish : INotifyPropertyChanged
    {
        private string _name;
        private string _type;
        private string _description;
        private double _price;
        private ObservableCollection<string> _ingredients;

        public int Id { get; set; }

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public string Type
        {
            get => _type;
            set => SetProperty(ref _type, value);
        }

        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        public double Price
        {
            get => _price;
            set => SetProperty(ref _price, value);
        }

        public string ImageUrl { get; set; }

        public ObservableCollection<string> Ingredients
        {
            get => _ingredients;
            set => SetProperty(ref _ingredients, value);
        }

        public void AddIngredients(string ingredient)
        {
            Ingredients.Add(ingredient);
            OnPropertyChanged(nameof(Ingredients));
        }

        public void SaveData(string name, string type, string description, double price, ObservableCollection<string> ingredients)
        {
            Name = name;
            Type = type;
            Description = description;
            Price = price;
            Ingredients = ingredients;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T field, T value, string? propertyName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName ?? string.Empty);
            return true;
        }
    }
}
