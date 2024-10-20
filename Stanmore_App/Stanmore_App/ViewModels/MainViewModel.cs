using Stanmore_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Stanmore_App.ViewModels
{ 
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            Orders = new ObservableCollection<Foods>();
            Foods = GetFoods();
        }

        public int OrderCount => Orders.Count;
        public float TotalPrice => Orders.Sum(x => x.Price);

        private ObservableCollection<Foods> foods;
        public ObservableCollection<Foods> Foods
        {
            get { return foods; }
            set
            {
                foods = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Foods> orders;
        public ObservableCollection<Foods> Orders
        {
            get { return orders; }
            set
            {
                orders = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(OrderCount));
                OnPropertyChanged(nameof(TotalPrice));
            }
        }


        private ObservableCollection<Foods> GetFoods()
        {
            return new ObservableCollection<Foods>
        {
            new Foods{ Name = "Burger", Image = "cheeseburger", Price = 3.00f, Description = "A flame-grilled plant-based burger, topped with tomatoes, fresh cut lettuce, vegan mayo, pickles, a swirl of ketchup, and sliced onions on a soft sesame seed bun."},
            new Foods{ Name = "French Fries", Image = "chips", Price = 1.50f, Description = "Thick cut salted French Fries."},
            new Foods{ Name = "Lasagna", Image = "lasagna", Price = 3.00f, Description = "Traditional Bolognese sauce, bechamel\r\nsauce, mozzarella and cheese"},
            new Foods{ Name = "Pizza", Image = "pizza", Price = 3.00f, Description = "Tomato and mozzarella."},
            new Foods{ Name = "Chilli Paneer", Image = "chilli_paneer", Price = 4.50f, Description = "Sliced cottage cheese and mushrooms tossed in hot, spicy chilli and soy sauce, peppers and onions garnished with spring onions."},

            new Foods{ Name = "Coke", Image = "Coke", Price = 1.50f, Description = "A classic, since 1886. Enjoy it with a meal or on its own as a refreshing drink."},
            new Foods{ Name = "Sprite", Image = "sprite", Price = 1.50f, Description = "Love the refreshing fizziness of delicious Sprite."},
            new Foods{ Name = "Sparkling Water", Image = "sparkling_water_bottle", Price = 1.25f, Description = "Carbonated Natural Mineral Water."},
            new Foods{ Name = "Water", Image = "water", Price = 1.00f, Description = "Still Spring Water."},
            new Foods{ Name = "Iced Tea", Image = "iced_tea", Price = 1.50f, Description = "Still soft drink with tea extract and peach juice with sugar and sweetener."},
        };
        }


        public void AddOrder(Foods item)
        {
            if (item != null)
            {
                Orders.Add(item);
                OnPropertyChanged(nameof(OrderCount));
                OnPropertyChanged(nameof(TotalPrice));
            }
        }
    }
}