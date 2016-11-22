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
using Restaurant.Interfaces;
using Restaurant.Enumerators;
using Restaurant.Configuration;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Net.Mail;
using System.Collections;

namespace Restaurant
{
    public partial class Restaurant : Form
    {
        List<DBEntities.Pizza> pizzaList = new List<DBEntities.Pizza>();
        List<DBEntities.Dish> dishList = new List<DBEntities.Dish>();
        List<DBEntities.Soup> soupList = new List<DBEntities.Soup>();
        List<DBEntities.Drink> drinkList = new List<DBEntities.Drink>();

        List<Email> emailList = new List<Email>();

        public Restaurant()
        {
            InitializeComponent();
            BindingOnLoad();
        }

        private void BindingOnLoad()
        {
            txtTotalPrice.Text = (0.0).ToString();
            
            cmbPizza.DataSource = Enum.GetValues(typeof(EPizza))
                 .Cast<Enum>()
                 .Select(value => new
                 {
                     (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                     value
                 })
                 .OrderBy(item => item.value)
                 .ToList();
            cmbPizza.DisplayMember = "Description";
            cmbPizza.ValueMember = "value";

            
            cblPizzaAdds.DataSource = Enum.GetValues(typeof(EPizzaAdds))
                 .Cast<Enum>()
                 .Select(value => new
                 {
                     (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                     value
                 })
                 .OrderBy(item => item.value)
                 .ToList();
            cblPizzaAdds.DisplayMember = "Description";
            cblPizzaAdds.ValueMember = "value";

            
            cmbDish.DataSource = Enum.GetValues(typeof(EDish))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
            cmbDish.DisplayMember = "Description";
            cmbDish.ValueMember = "value";


            
            cblDishAdds.DataSource = Enum.GetValues(typeof(EDishAdds))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
            cblDishAdds.DisplayMember = "Description";
            cblDishAdds.ValueMember = "value";


            
            cmbSoup.DataSource = Enum.GetValues(typeof(ESoup))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
            cmbSoup.DisplayMember = "Description";
            cmbSoup.ValueMember = "value";


            
            cmbDrink.DataSource = Enum.GetValues(typeof(EDrink))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
            cmbDrink.DisplayMember = "Description";
            cmbDrink.ValueMember = "value";


            
            cmbSelectTable.DataSource = Enum.GetValues(typeof(ETable))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
            cmbSelectTable.DisplayMember = "Description";
            cmbSelectTable.ValueMember = "value";

            ReadEmailConfiguration();
            EnableMeals();
        }

        private void ReadEmailConfiguration()
        {            
            try
            {
                using (var reader = new StreamReader(@"Configuration\MailConfiguration.xml"))
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(List<Email>),
                        new XmlRootAttribute("Emails"));
                    emailList = (List<Email>)deserializer.Deserialize(reader);
                }

                cmbEmailFrom.DataSource = emailList.ToList();
                cmbEmailTo.DataSource = emailList.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd odczytu konfiguracji email", "Odczyt konfiguracji email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void cbxPizza_CheckedChanged(object sender, EventArgs e)
        {
            EnableMeals();
        }    

        private void cbxPizzaAdds_CheckedChanged(object sender, EventArgs e)
        {
            EnableMeals();
        }

        private void cbxDish_CheckedChanged(object sender, EventArgs e)
        {
            EnableMeals();
        }

        private void cbxDishAdds_CheckedChanged(object sender, EventArgs e)
        {
            EnableMeals();
        }

        private void cbxSoup_CheckedChanged(object sender, EventArgs e)
        {
            EnableMeals();
        }

        private void cbxDrink_CheckedChanged(object sender, EventArgs e)
        {
            EnableMeals();
        }

        private void EnableMeals()
        {
            if (cbxPizza.Checked)
            {
                cmbPizza.Enabled = true;
                cbxPizzaAdds.Enabled = true;
                cblPizzaAdds.Enabled = true;
                numPizza.Enabled = true;                
                btnAddPizza.Enabled = true;
            }
            else
            {
                cmbPizza.Enabled = false;
                cbxPizzaAdds.Enabled = false;
                cbxPizzaAdds.Checked = false;
                cblPizzaAdds.Enabled = false;
                numPizza.Enabled = false;
                btnAddPizza.Enabled = false;
            }

            if (cbxPizzaAdds.Checked)
            {
                cblPizzaAdds.Enabled = true;
                
            }
            else
            {
                cblPizzaAdds.Enabled = false;
                

            }

            if (cbxDish.Checked)
            {
                cmbDish.Enabled = true;
                cbxDishAdds.Enabled = true;
                cblDishAdds.Enabled = true;
                numDish.Enabled = true;
                btnAddDish.Enabled = true;
            }
            else
            {
                cmbDish.Enabled = false;
                cbxDishAdds.Enabled = false;
                cbxDishAdds.Checked = false;
                cblDishAdds.Enabled = false;
                numDish.Enabled = false;                
                btnAddDish.Enabled = false;
            }

            if (cbxDishAdds.Checked)
            {
                cblDishAdds.Enabled = true;
            }
            else
            {
                cblDishAdds.Enabled = false;                
            }

            if (cbxSoup.Checked)
            {
                cmbSoup.Enabled = true;
                numSoup.Enabled = true;
                btnAddSoup.Enabled = true;
            }
            else
            {
                cmbSoup.Enabled = false;
                numSoup.Enabled = false;
                btnAddSoup.Enabled = false;
            }

            if (cbxDrink.Checked)
            {
                cmbDrink.Enabled = true;
                numDrink.Enabled = true;
                btnAddDrink.Enabled = true;
            }
            else
            {
                cmbDrink.Enabled = false;
                numDrink.Enabled = false;
                btnAddDrink.Enabled = false;
            }

        }

        private void btnAddPizza_Click(object sender, EventArgs e)
        {
            DBEntities.Pizza pizza = new DBEntities.Pizza();

            pizza.Amount = (int)numPizza.Value;
            pizza.Type = (EPizza)cmbPizza.SelectedValue;
            pizza.Adds = new List<DBEntities.PizzaAdd>();


            if (cbxPizzaAdds.Checked)
            {
                DBEntities.PizzaAdd pizzaAdds = new DBEntities.PizzaAdd();
                foreach (var item in cblPizzaAdds.CheckedIndices)
                {
                    pizzaAdds = new DBEntities.PizzaAdd();
                    pizzaAdds.Type = (EPizzaAdds)(item);
                    pizza.Adds.Add(pizzaAdds);
                }
            }

            pizzaList.Add(pizza);
            var dsList = pizzaList
                         .Select(item => new { Ilość=item.Amount,
                                                Rodzaj = item, 
                                                Cena = item.Price * item.Amount,                                                
                                                Rodzaj_dodatków = item.Adds.Count() == 0 ? string.Empty: string.Join(", ", item.Adds),
                                               Cena_dodatków = item.Adds.Count() == 0 ? 0 : item.Adds.Sum(x => x.Price * item.Amount)
                         }
                                );
            dgvPizza.DataSource = dsList.ToList(); ;
            CalculateTotalPrice();
        }

        private void CalculateTotalPrice()
        {
            double dTotal = 0.0;
            foreach(DBEntities.Pizza pizza in pizzaList)
            {
                dTotal += pizza.Price * pizza.Amount;
                foreach (DBEntities.PizzaAdd pizzaAdd in pizza.Adds)
                {
                    dTotal += pizzaAdd.Price * pizza.Amount;
                }
            }

            foreach (DBEntities.Dish dish in dishList)
            {
                dTotal += dish.Price * dish.Amount;
                foreach (DBEntities.DishAdd dishAdd in dish.Adds)
                {
                    dTotal += dishAdd.Price * dish.Amount;
                }
            }

            foreach (DBEntities.Soup soup in soupList)
            {
                dTotal += soup.Price * soup.Amount;
            }

            foreach (DBEntities.Drink drink in drinkList)
            {
                dTotal += drink.Price * drink.Amount;
            }

            txtTotalPrice.Text = dTotal.ToString();
        }

        private void btnAddDish_Click(object sender, EventArgs e)
        {
            DBEntities.Dish dish = new DBEntities.Dish();

            dish.Amount = (int)numDish.Value;
            dish.Type = (EDish)cmbDish.SelectedValue;
            dish.Adds = new List<DBEntities.DishAdd>();

            if (cbxDishAdds.Checked)
            {
                DBEntities.DishAdd dishAdds = new DBEntities.DishAdd();

                foreach (var item in cblDishAdds.CheckedIndices)
                {
                    dishAdds = new DBEntities.DishAdd();
                    dishAdds.Type = (EDishAdds)item;
                    dish.Adds.Add(dishAdds);
                }
            }

            dishList.Add(dish);
            var dsList = dishList
                         .Select(item => new
                         {
                             Ilość = item.Amount,
                             Rodzaj = item,
                             Cena = item.Price * item.Amount,
                             Rodzaj_dodatków = item.Adds.Count() == 0 ? string.Empty : string.Join(", ", item.Adds),
                             Cena_dodatków = item.Adds.Count() == 0 ? 0 : item.Adds.Sum(x => x.Price * item.Amount)
                         }
                                );
            dgvDish.DataSource = dsList.ToList(); ;
            CalculateTotalPrice();
        }

        private void btnAddSoup_Click(object sender, EventArgs e)
        {
            DBEntities.Soup soup = new DBEntities.Soup();

            soup.Amount = (int)numSoup.Value;
            soup.Type = (ESoup)cmbSoup.SelectedValue;            


            soupList.Add(soup);
            var dsList = soupList
                         .Select(item => new
                         {
                             Ilość = item.Amount,
                             Rodzaj = item,
                             Cena = item.Price * item.Amount
                         }
                                );
            dgvSoup.DataSource = dsList.ToList(); ;
            CalculateTotalPrice();
        }

        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            DBEntities.Drink drink = new DBEntities.Drink();

            drink.Amount = (int)numDrink.Value;
            drink.Type = (EDrink)cmbDrink.SelectedValue;


            drinkList.Add(drink);
            var dsList = drinkList
                         .Select(item => new
                         {
                             Ilość = item.Amount,
                             Rodzaj = item,
                             Cena = item.Price * item.Amount
                         }
                                );
            dgvDrink.DataSource = dsList.ToList(); ;
            CalculateTotalPrice();
        }

        private void dgvPizza_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPizza.Columns[e.ColumnIndex].Name == "PizzaDeleteRow")
            {
                
                pizzaList.RemoveAt(e.RowIndex);
            }
            
            var dsList = pizzaList
             .Select(item => new
             {
                 Ilość = item.Amount,
                 Rodzaj = item.Type,
                 Cena = item.Price * item.Amount,
                 Rodzaj_dodatków = item.Adds.Count() == 0 ? string.Empty : string.Join(", ", item.Adds),
                 Cena_dodatków = item.Adds.Count() == 0 ? 0 : item.Adds.Sum(x => x.Price * item.Amount)

             }
                    );

            dgvPizza.DataSource = dsList.ToList();
            CalculateTotalPrice();

        }

        private void dgvDish_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDish.Columns[e.ColumnIndex].Name == "DishDeleteRow")
            {

                dishList.RemoveAt(e.RowIndex);
            }

            var dsList = dishList
             .Select(item => new
             {
                 Ilość = item.Amount,
                 Rodzaj = item.Type,
                 Cena = item.Price * item.Amount,
                 Rodzaj_dodatków = item.Adds.Count() == 0 ? string.Empty : string.Join(", ", item.Adds),
                 Cena_dodatków = item.Adds.Count() == 0 ? 0 : item.Adds.Sum(x => x.Price * item.Amount)
             }
                    );

            dgvDish.DataSource = dsList.ToList();
            CalculateTotalPrice();

        }

        private void dgvSoup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSoup.Columns[e.ColumnIndex].Name == "SoupDeleteRow")
            {

                soupList.RemoveAt(e.RowIndex);
            }

            var dsList = soupList
             .Select(item => new
             {
                 Ilość = item.Amount,
                 Rodzaj = item.Type,
                 Cena = item.Price
             }
                    );

            dgvSoup.DataSource = dsList.ToList();
            CalculateTotalPrice();

        }

        private void dgvDrink_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDrink.Columns[e.ColumnIndex].Name == "DrinkDeleteRow")
            {

                drinkList.RemoveAt(e.RowIndex);
            }

            var dsList = drinkList
             .Select(item => new
             {
                 Ilość = item.Amount,
                 Rodzaj = item.Type,
                 Cena = item.Price
             }
                    );

            dgvDrink.DataSource = dsList.ToList();
            CalculateTotalPrice();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            pizzaList.Clear();
            dishList.Clear();
            soupList.Clear();
            drinkList.Clear();


            dgvPizza.DataSource = null;
            dgvDish.DataSource = null;
            dgvSoup.DataSource = null;
            dgvDrink.DataSource = null;

            cbxPizza.Checked = false;
            cbxDish.Checked = false;
            cbxSoup.Checked = false;
            cbxDrink.Checked = false;
            EnableMeals();

            txtTotalPrice.Text = (0.0).ToString();
        }

        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            int? OrderId;
            SendToDatabase(out OrderId);
            SendEmail(OrderId);            
            MessageBox.Show("Zamównienie zostało wysłane", "Wysyłanie zamówienia", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void SendToDatabase(out int? OrderId)
        {
            OrderId = null;
            try
            {
                
                using ( var db = new DBEntities.OrderDBContext())
                {
                    var order  = new DBEntities.Order();
                    order.TableNO = (ETable)cmbSelectTable.SelectedValue;
                    order.TotalPrice = double.Parse(txtTotalPrice.Text);
                    order.Description = txtDescription.Text;

                    order.Meals = new List<IMeal>();

                    foreach (DBEntities.Pizza pizza in pizzaList)
                    {                            
                        order.Meals.Add(pizza);
                        pizza.Order = order;
                        db.Pizzas.Add(pizza);
                    }

                    foreach (DBEntities.Dish dish in dishList)
                    {
                        order.Meals.Add(dish);
                        dish.Order = order;
                        db.Dishes.Add(dish);
                    }

                    foreach (DBEntities.Soup soup in soupList)
                    {
                        order.Meals.Add(soup);
                        soup.Order = order;
                        db.Soups.Add(soup);
                    }

                    foreach (DBEntities.Drink drink in drinkList)
                    {
                        order.Meals.Add(drink);
                        drink.Order = order;
                        db.Drinks.Add(drink);
                    }



                    db.Orders.Add(order);
           
                    db.SaveChanges();

                    OrderId = order.Id;

                }                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd zapisu do bazy danych", "Zapis do bazy danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendEmail(int? OrderId)
        {
            try
            {
                string sUserName = ((Email)cmbEmailFrom.SelectedItem).UserName;
                string sUserNameTo = ((Email)cmbEmailTo.SelectedItem).UserName;
                string sPassword = ((Email)cmbEmailFrom.SelectedItem).Password;
                string sHost = ((Email)cmbEmailFrom.SelectedItem).Host;
                int iPort = ((Email)cmbEmailFrom.SelectedItem).Port;
                int iTimeout = ((Email)cmbEmailFrom.SelectedItem).Timeout;

                string sSubject = string.Format("Zamównienie dla: {0}", cmbSelectTable.Text);
                string sBody = GetEmailBody(OrderId);
                SmtpClient client = new SmtpClient
                {
                    Host = sHost,
                    Port = iPort,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new System.Net.NetworkCredential(sUserName, sPassword),
                    Timeout = iTimeout,
                };
                MailMessage mm = new MailMessage(sUserName, sUserNameTo, sSubject, sBody);
                client.Send(mm);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd przy wysyłaniu emaila z zamówieniem", "Wysyłanie email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetEmailBody(int? OrderId)
        {
            string sBody = string.Empty;
            if (OrderId != null)
            {
                sBody += string.Format("Zamówienie o Id: {0}", OrderId.ToString());
                sBody += Environment.NewLine;
            }
            sBody += string.Format("Zamówienie dla: {0} {1}", cmbSelectTable.Text, Environment.NewLine);
            sBody += Environment.NewLine;

            sBody += "PIZZA";
            sBody += Environment.NewLine;
            foreach (DBEntities.Pizza pizza in pizzaList)
            {
                sBody += string.Format("Pizza: {0}, Ilość: {1} ", pizza.ToString(), pizza.Amount);
                if (pizza.Adds.Count() != 0)
                {
                    sBody += string.Format("Dodatki do pizzy: {0} ", string.Join(", ", pizza.Adds));
                }
                sBody += Environment.NewLine;
            }
            sBody += Environment.NewLine;
            sBody += Environment.NewLine;

            sBody += "DANIE OBIADOWE";
            sBody += Environment.NewLine;
            foreach (DBEntities.Dish dish in dishList)
            {
                sBody += string.Format("Danie: {0}, Ilość: {1} ", dish.ToString(), dish.Amount);
                if (dish.Adds.Count() != 0)
                {
                    sBody += string.Format("Dodatki do dań obiadowych: {0} ", string.Join(", ", dish.Adds));
                }
                sBody += Environment.NewLine;
            }
            sBody += Environment.NewLine;
            sBody += Environment.NewLine;

            sBody += "ZUPA";
            sBody += Environment.NewLine;
            foreach (DBEntities.Soup soup in soupList)
            {
                sBody += string.Format("Zupa: {0}, Ilość: {1} ", soup.ToString(), soup.Amount);
                sBody += Environment.NewLine;
            }
            sBody += Environment.NewLine;
            sBody += Environment.NewLine;

            sBody += "NAPOJE";
            sBody += Environment.NewLine;
            foreach (DBEntities.Drink drink in drinkList)
            {
                sBody += string.Format("Napój: {0}, Ilość: {1} ", drink.ToString(), drink.Amount);
                sBody += Environment.NewLine;
            }
            sBody += Environment.NewLine;
            sBody += Environment.NewLine;

            sBody += string.Format("Koszt zamównienia: {0}", txtTotalPrice.Text);
            
            return sBody;            
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.ShowDialog();
        }




    }
}
