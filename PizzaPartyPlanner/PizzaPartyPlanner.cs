using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaPartyPlanner
{
    public partial class frmPizzaParty : Form
    {
        public frmPizzaParty()
        {
            InitializeComponent();
        }


        /// <summary>
        /// This stores a list of lists
        /// the inner list is strings which will represent our pizza
        /// </summary>
        List<List<string>> Pizzas = new List<List<string>>();

        /// <summary>
        /// This method adds a pizza to the list of strings
        /// </summary>
        /// <param name="size"></param>
        /// <param name="type"></param>
        /// <param name="slices"></param>
        /// <param name="notes"></param>
        /// <param name="price"></param>
        private void addPizza(string size, string type, string slices, string notes, decimal price)
        {
            List<string> pizza = new List<string>();
            pizza.Add(size);
            pizza.Add(type);
            pizza.Add(slices);
            pizza.Add(notes);
            pizza.Add(price.ToString());
            Pizzas.Add(pizza);
        }

        /// <summary>
        /// This method updates our listbox and total cost of added pizzas
        /// </summary>
        private void updateVisual()
        {
            lstPizzaType.Items.Clear();
            foreach (List<string> pizza in Pizzas)
            {
                lstPizzaType.Items.Add(string.Format("{0} {1}", pizza[0], pizza[1]));
            }
            decimal totalCost = 0m;
            foreach (List<string> za in Pizzas)
            {
                totalCost += Decimal.Parse(za[4]);
            }
            lblTotal.Text = totalCost.ToString();
        }

        /// <summary>
        /// this method returns a string
        /// information about our pizza
        /// it combines the toppings selected
        /// by the user with any notes that were entered
        /// </summary>
        /// <returns></returns>
        private String getNotes()
        {
            string nl = System.Environment.NewLine;
            string notes = "Notes:" + nl + "    " + txtNotes.Text + nl;
            string toppings = "Toppings:" ;
            int counter = 0;
            foreach (var ctrl in grpToppings.Controls.OfType<CheckBox>().Where(t => t.Checked))
            {
                toppings += nl + "   " + ctrl.Text;
                counter += 1;
            }
            if (counter > 0)
            {
                notes += toppings;
            }
            return notes;

        }

        /// <summary>
        /// this method returns a integer that 
        /// is equal to the number of selected toppings
        /// </summary>
        /// <returns></returns>
        private int getNumTops()
        {
            int numTops = 0;
            foreach (var ctrl in grpToppings.Controls.OfType<CheckBox>().Where(t => t.Checked))
            {
                numTops += 1;
            }
            return numTops;
        }

        /// <summary>
        /// this method returns the price of a pizza
        /// it checks the size and pizza type before calculating
        /// this method calls the getNumTops method
        /// </summary>
        /// <returns></returns>
        private decimal calculatePrice()
        {
            decimal total = 0.00m;
            decimal toppingCost = 0m;
            decimal basePrice = 0m;
            int numTops = getNumTops();
          
            int pizza = cboPizzaType.SelectedIndex;
            int size = cboPizzaSize.SelectedIndex;

            switch (size)
            {
                case 0:
                    toppingCost = 0.25m;
                    basePrice = 16.99m;
                    break;
                case 1:
                    toppingCost = 0.50m;
                    basePrice = 18.99m;
                    break;
                case 2:
                    toppingCost = 0.75m;
                    basePrice = 21.99m;
                    break;
         }
            switch (pizza)
            {
                case 0: //Build Your Own

                    total = basePrice + (toppingCost * numTops);
                    
                    break;
                default: //Speciality Pizzas
                    total = basePrice + 2 + (toppingCost * numTops);
                    break;


            }
            return total;
        }

        /// <summary>
        /// this method acts as event handler for anytime
        /// a topping is added or removed as well as when
        /// the pizza type or size is changed.
        /// It updates the cost the pizza that has not yet
        /// been added to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeCost(object sender, EventArgs e)
        {
            lblPizzaCost.Text = calculatePrice().ToString();
        }


        private void brnAdd_Click(object sender, EventArgs e)
        {
            addPizza(cboPizzaSize.SelectedItem.ToString(), cboPizzaType.SelectedItem.ToString(), cboSlices.SelectedItem.ToString(), getNotes(), Decimal.Parse(lblPizzaCost.Text));
            cboPizzaType.SelectedIndex = 0;
            cboPizzaSize.SelectedIndex = 0;
            cboSlices.SelectedIndex = 0;
            txtNotes.Text = "";
            foreach (var ctrl in grpToppings.Controls.OfType<CheckBox>().Where(t=>t.Checked))
            {
                ctrl.Checked = false;
            }
            updateVisual();


        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            
            Report form2 = new Report(Pizzas, this);
            form2.Show();
            this.Visible = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstPizzaType.SelectedIndex > -1)
            {
            Pizzas.RemoveAt(lstPizzaType.SelectedIndex);
            }
            updateVisual();
        }

        private void lstPizzaType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check that something is selected
            if (lstPizzaType.SelectedIndex > -1)
            {
                txtDisplayNotes.Clear();
                List<string> pizza = Pizzas[lstPizzaType.SelectedIndex];
                txtDisplayNotes.Text += "Number of Slices:" + System.Environment.NewLine + pizza[2] + System.Environment.NewLine;
                txtDisplayNotes.Text += pizza[3];
            }
        }

        private void frmPizzaParty_Load(object sender, EventArgs e)
        {
            //ensure that these 3 text boxes cannot be empty
            cboPizzaType.SelectedIndex = 0;
            cboPizzaSize.SelectedIndex = 0;
            cboSlices.SelectedIndex = 0;
            updateVisual();
        }
    }
}
