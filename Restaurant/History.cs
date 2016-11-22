using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant.Entities;
using Restaurant.Enumerators;
using Restaurant.Interfaces;
using Restaurant.Classes;

namespace Restaurant
{
    public partial class History : Form
    {
        List<DBEntities.Order> orders = new List<DBEntities.Order>();
        List<DBEntities.Pizza> pizzas = new List<DBEntities.Pizza>();
        List<DBEntities.Dish> dishes = new List<DBEntities.Dish>();
        List<DBEntities.Soup> soups = new List<DBEntities.Soup>();
        List<DBEntities.Drink> drinks = new List<DBEntities.Drink>();
        List<DBEntities.PizzaAdd> pizzaAdds = new List<DBEntities.PizzaAdd>();
        List<DBEntities.DishAdd> dishAdds = new List<DBEntities.DishAdd>();
        

        public History()
        {
            InitializeComponent();
            LoadHistory();
        }

        private void LoadHistory()
        {
            using (var context = new DBEntities.OrderDBContext())
            {
                
                var ResultOrder = from all in context.Orders select all;
                orders.AddRange(ResultOrder.ToList<DBEntities.Order>());
                
                var ResultPizza = from all in context.Pizzas select all;
                pizzas.AddRange(ResultPizza.ToList<DBEntities.Pizza>());
                
                var ResultDish = from all in context.Dishes select all;
                dishes.AddRange(ResultDish.ToList<DBEntities.Dish>());
                
                var ResultSoup = from all in context.Soups select all;
                soups.AddRange(ResultSoup.ToList<DBEntities.Soup>());
                
                var ResultDrink = from all in context.Drinks select all;
                drinks.AddRange(ResultDrink.ToList<DBEntities.Drink>());

                var ResultPizzaAdd = from all in context.PizzaAdds select all;
                pizzaAdds.AddRange(ResultPizzaAdd.ToList<DBEntities.PizzaAdd>());

                var ResultDishAdd = from all in context.DishAdds select all;
                dishAdds.AddRange(ResultDishAdd.ToList<DBEntities.DishAdd>());

                cmbOrder.DataSource = orders;
                
            }
        }

        private void cmbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBEntities.Order order = (DBEntities.Order)cmbOrder.SelectedItem;
            string sHistoryText = GetHistory(order);
            txtHistoryData.Text = sHistoryText;
        }

        private string GetHistory(DBEntities.Order order)
        {
            string sOutputText = string.Empty;

            sOutputText += string.Format("Zamówienie nr {0}", order.Id);
            sOutputText += Environment.NewLine;
            sOutputText += Environment.NewLine;

            sOutputText += "PIZZA";
            sOutputText += Environment.NewLine;

            sOutputText += Classes.Common.GetPizzaHistory(pizzas.Where(x => x.OrderId == order.Id).ToList());

            sOutputText += Environment.NewLine;
           

            sOutputText += "DANIE OBIADOWE";
            sOutputText += Environment.NewLine;

            sOutputText += Classes.Common.GetDishHistory(dishes.Where(x => x.OrderId == order.Id).ToList());

            sOutputText += Environment.NewLine;


            sOutputText += "ZUPA";
            sOutputText += Environment.NewLine;

            sOutputText += Classes.Common.GetSoupHistory(soups.Where(x => x.OrderId == order.Id).ToList());
            
            sOutputText += Environment.NewLine;


            sOutputText += "NAPOJE";
            sOutputText += Environment.NewLine;

            sOutputText += Classes.Common.GetDrinkHistory(drinks.Where(x => x.OrderId == order.Id).ToList());
            
            sOutputText += Environment.NewLine;


            sOutputText += string.Format("Koszt zamównienia: {0} zł.", order.TotalPrice);

          
            return sOutputText;
        }
    }
}
