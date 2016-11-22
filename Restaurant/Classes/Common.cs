using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Enumerators;
using Restaurant.Interfaces;
using Restaurant.Entities;

namespace Restaurant.Classes
{
    public class Common
    {
        
        public static double GetPrice(object type)
        {
            
            if (type is EPizza)
            {
                switch ((EPizza)type)
                {
                    case EPizza.Margeritta:
                        return 20.0;
                    case EPizza.Vegetariana:
                        return 22.0;
                    case EPizza.Tosca:
                    case EPizza.Venecia:
                        return 25.0;
                }

            }
            else if (type is EPizzaAdds)
            {
                return 2.0;
            }
            else if (type is EDish)
            {
                switch ((EDish)type)
                {
                    case EDish.Porkchop :
                        return 30.0;
                    case EDish.Fish :
                        return 28.0;
                    case EDish.Pie:
                        return 27.0;
                }
            }
            else if (type is EDishAdds)
            {
                switch ((EDishAdds)type)
                {
                    case EDishAdds.Salad :
                        return 5.0;
                    case EDishAdds.Sauce:
                        return 6.0;
                }
            }
            else if (type is ESoup)
            {
                switch ((ESoup)type)
                {
                    case ESoup.TomatoSoup:
                        return 12.0;
                    case ESoup.Broth:
                        return 10.0;
                }
            }
            else if (type is EDrink)
            {
                return 5.0;
            }

            return 0;
        }

        public static string GetDescription(object type)
        {
            if (type is EPizza)
            {
                switch ((EPizza)type)
                {
                    case EPizza.Margeritta:
                        return "Margeritta";
                    case EPizza.Vegetariana:
                        return "Vegetariana";
                    case EPizza.Tosca:
                        return "Tosca";
                    case EPizza.Venecia:
                        return "Venecia";
                }

            }
            else if (type is EPizzaAdds)
            {
                switch ((EPizzaAdds)type)
                {
                    case EPizzaAdds.DoubleCheese:
                        return "Podwójny ser";
                    case EPizzaAdds.Salami:
                        return "Salami";
                    case EPizzaAdds.Ham:
                        return "Szynka";
                    case EPizzaAdds.Mushrooms:
                        return "Pieczarki";
                }
            }
            else if (type is EDish)
            {
                switch ((EDish)type)
                {
                    case EDish.Porkchop:
                        return "Schabowy z frytkami, ryżem lub ziemniakami";
                    case EDish.Fish:
                        return "Ryba z frytkami";
                    case EDish.Pie:
                        return "Placek po węgiersku";
                }
            }
            else if (type is EDishAdds)
            {
                switch ((EDishAdds)type)
                {
                    case EDishAdds.Salad:
                        return "Bar sałatkowy";
                    case EDishAdds.Sauce:
                        return "Zestaw sosów";
                }
            }
            else if (type is ESoup)
            {
                switch ((ESoup)type)
                {
                    case ESoup.TomatoSoup:
                        return "Zupa pomidorowa";
                    case ESoup.Broth:
                        return "Rosół";
                }
            }
            else if (type is EDrink)
            {
                switch ((EDrink)type)
                {
                    case EDrink.Coffee:
                        return "Kawa";
                    case EDrink.Tea:
                        return "Herbata";
                    case EDrink.Cola:
                        return "Cola";
                }
            }
            return string.Empty;
        }


        internal static string GetPizzaHistory(List<DBEntities.Pizza> list)
        {
            string sOutPutText = string.Empty;
            if (list == null || list.Count() == 0)
            {
                sOutPutText += "Brak";
                sOutPutText += Environment.NewLine;
            }
            else
            {
                foreach (DBEntities.Pizza pizza in list)
                {
                    sOutPutText += string.Format("Pizza: {0}, ilość: {1}, dodatki: ", pizza, pizza.Amount);
                    List<DBEntities.PizzaAdd> pizzaAdds = pizza.Adds;
                    if (pizzaAdds == null || pizzaAdds.Count() == 0)
                    {
                        sOutPutText += "Brak";
                    }
                    else
                    {
                        sOutPutText += string.Join(", ", pizzaAdds);
                    }
                    sOutPutText += Environment.NewLine;

                }
            }

            return sOutPutText;
        }

        internal static string GetDishHistory(List<DBEntities.Dish> list)
        {
            string sOutPutText = string.Empty;
            if (list == null || list.Count() == 0)
            {
                sOutPutText += "Brak";
                sOutPutText += Environment.NewLine;
            }
            else
            {
                foreach (DBEntities.Dish dish in list)
                {
                    sOutPutText += string.Format("Danie obiadowe: {0}, ilość: {1}, dodatki: ", dish, dish.Amount);
                    List<DBEntities.DishAdd> dishAdds = dish.Adds;
                    if (dishAdds == null || dishAdds.Count() == 0)
                    {
                        sOutPutText += "Brak";
                    }
                    else
                    {
                        sOutPutText += string.Join(", ", dishAdds);
                    }
                    sOutPutText += Environment.NewLine;

                }
            }

            return sOutPutText;
        }

        internal static string GetSoupHistory(List<DBEntities.Soup> list)
        {
            string sOutPutText = string.Empty;
            if (list == null || list.Count() == 0)
            {
                sOutPutText += "Brak";
                sOutPutText += Environment.NewLine;
            }
            else
            {
                foreach (DBEntities.Soup soup in list)
                {
                    sOutPutText += string.Format("Zupa: {0}, ilość: {1}", soup, soup.Amount);
                    sOutPutText += Environment.NewLine;
                }
            }
            return sOutPutText;
        }

        internal static string GetDrinkHistory(List<DBEntities.Drink> list)
        {
            string sOutPutText = string.Empty;
            if(list == null || list.Count() == 0)
            {
                sOutPutText +="Brak";
                sOutPutText += Environment.NewLine;
            }
            else
            {
                foreach (DBEntities.Drink drink in list)
                {
                    sOutPutText += string.Format("Napój: {0}, ilość: {1}", drink, drink.Amount);
                    sOutPutText += Environment.NewLine;
                }
            }
            return sOutPutText;
        }
    }
}
