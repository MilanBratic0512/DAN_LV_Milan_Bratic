using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak_1.Model;

namespace Zadatak_1.ViewModel
{
    class MainWindowViewModel : ViewModelBase
    {

        public List<PizzaIngredient> AddedIngredients { get; set; }


        private Pizza pizza;
        public Pizza Pizza
        {
            get { return pizza; }
            set
            {
                if (pizza != value)
                {
                    pizza = value;
                    OnPropertyChanged("Pizza");
                }
            }
        }

        private PizzaIngredient pizzaIngredient;

        public PizzaIngredient PizzaIngredient
        {
            get { return pizzaIngredient; }
            set
            {
                if (pizzaIngredient != value)
                {
                    pizzaIngredient = value;
                    OnPropertyChanged("PizzaIngredient");
                }
            }
        }
        public MainWindowViewModel()
        {
            Pizza = new Pizza();
            AddedIngredients = new List<PizzaIngredient>();
            Pizza.PizzaIngredients = new List<PizzaIngredient>();
            Pizza.Size = new Dictionary<string, int>();
            FillPizzaIngredients();
            FillSize();
            
        }

        internal void AddIngredient(PizzaIngredient ingredient)
        {
            Pizza.TotalPrice += ingredient.Price;
            AddedIngredients.Add(ingredient);
        }

        public void FillPizzaIngredients()
        {
            Pizza.PizzaIngredients.Add(new PizzaIngredient { Name = "salami", Price = 120});
            Pizza.PizzaIngredients.Add(new PizzaIngredient { Name = "ham", Price = 250});
            Pizza.PizzaIngredients.Add(new PizzaIngredient { Name = "kulen", Price = 180});
            Pizza.PizzaIngredients.Add(new PizzaIngredient { Name = "ketchup", Price = 80});
            Pizza.PizzaIngredients.Add(new PizzaIngredient { Name = "mayonnaise", Price =70 });
            Pizza.PizzaIngredients.Add(new PizzaIngredient { Name = "cayenne pepper", Price =110 });
            Pizza.PizzaIngredients.Add(new PizzaIngredient { Name = "oregano", Price = 40});
            Pizza.PizzaIngredients.Add(new PizzaIngredient { Name = "olives", Price =160 });
            Pizza.PizzaIngredients.Add(new PizzaIngredient { Name = "sesame", Price =30 });
            Pizza.PizzaIngredients.Add(new PizzaIngredient { Name = "cheese", Price = 100});
        }
        public void FillSize()
        {
            Pizza.Size.Add("small", 200);
            Pizza.Size.Add("medium", 400);
            Pizza.Size.Add("large", 700);
        }
        
    }
}
