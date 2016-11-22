using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Interfaces;
using Restaurant.Enumerators;
using Restaurant.Classes;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Restaurant.Entities
{
    class DBEntities
    {

        public class Pizza : IMeal
        {
            public int Id { get; set; }
            public EPizza Type {get; set;}
            public  double Price
            {
                get
                {
                    return Common.GetPrice(Type);             
                }
           
            }
            public int Amount { get; set; }

            public int? OrderId { get; set; }
            public virtual Order Order { get; set; }

            public virtual List<PizzaAdd> Adds { get; set; }

            public override string ToString()
            {
                return Common.GetDescription(Type);
            }

        }

        public class PizzaAdd : IAdditionalMeal
        {
            public int Id { get; set; }
            public EPizzaAdds Type { get; set; }
            public  double Price
            {
                get
                {
                    return Common.GetPrice(this.Type);                    
                }
           
            }

            public int? PizzaId { get; set; }
            public virtual Pizza Pizza { get; set; }
            
            public override string ToString()
            {
                return Common.GetDescription(Type);
            }
        }



        public class Dish : IMeal
        {
            public int Id { get; set; }
            public EDish Type {get;set;}
            public  double Price
            {
                get
                {
                    return Common.GetPrice(this.Type);                    
                }
           
            }

            public int? OrderId { get; set; }
            public virtual Order Order { get; set; }

            public virtual List<DishAdd> Adds { get; set; }

            public int Amount { get; set; }
            public override string ToString()
            {
                return Common.GetDescription(Type);
            }
        }

        public class DishAdd : IAdditionalMeal
        {
            public int Id { get; set; }
            public EDishAdds Type {get; set;}
            public  double Price
            {
                get
                {
                    return Common.GetPrice(this.Type);                    
                }
           
            }

            public int? DishId { get; set; }
            public virtual Dish Dish { get; set; }
            
            public override string ToString()
            {
                return Common.GetDescription(Type);
            }
        }


        public class Soup : IMeal
        {
            public int Id { get; set; }
            public ESoup Type { get; set; }
            public  double Price
            {
                get
                {
                    return Common.GetPrice(this.Type);                    
                }
           
            }

            public int? OrderId { get; set; }
            public virtual Order Order { get; set; }

            public int Amount { get; set; }
            public override string ToString()
            {
                return Common.GetDescription(Type);
            }
        }


        public class Drink : IMeal
        {
            public int Id { get; set; }
            public EDrink Type { get; set; }
            public  double Price
            {
                get
                {
                    return Common.GetPrice(this.Type);                    
                }
           
            }

            public int? OrderId { get; set; }
            public virtual Order Order { get; set; }

            public int Amount { get; set; }
            public override string ToString()
            {
                return Common.GetDescription(Type);
            }

        }


        public class Order
        {
            public int Id { get; set; }
            public ETable TableNO { get; set; }
            public virtual List<IMeal> Meals {get; set;}
            public double TotalPrice { get; set; }
            public string Description { get; set; }
            public override string ToString()
            {
                return Id.ToString();
            }
        }


        public class OrderDBContext : DbContext
        {
            public DbSet<Order> Orders { get; set; }
            public DbSet<Pizza> Pizzas { get; set; }
            public DbSet<Dish> Dishes { get; set; }
            public DbSet<Soup> Soups { get; set; }
            public DbSet<Drink> Drinks { get; set; }
            public DbSet<PizzaAdd> PizzaAdds { get; set; }
            public DbSet<DishAdd> DishAdds { get; set; }
        }
 
    }
 
}
