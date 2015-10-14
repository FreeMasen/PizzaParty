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

        List<List<string>> Pizzas = new List<List<string>>();

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

        private void updateLst()
        {
            lstPizzaType.Items.Clear();
            foreach (var pizza in Pizzas)
            {
                lstPizzaType.Items.Add(string.Format("{0} {1}", pizza[0], pizza[1]));
            }
        }


        private String getNotes()
        {

            string notes = txtNotes.Text;
            string toppings = "Toppings: ";
            foreach (var ctrl in grpToppings.Controls.OfType<CheckBox>().Where(t => t.Checked))
            {
                notes += ctrl.Text;

            }
            notes += " ";
            notes += toppings;

            return notes;

        }

        private bool isValid()
        {
            bool isIt = true;
            if (cboPizzaType.SelectedIndex <= -1)
            {
                
                isIt = false;
            }
            if (cboPizzaSize.SelectedIndex <= -1)
            {
                isIt = false;
            }
            if (cboSlices.SelectedIndex <= -1)
            {
                isIt = false;
            }
            return isIt;
        }

        private decimal subTotal;

        private void checkbos(object sender, EventArgs e)
        {

            CheckBox checkbos = (CheckBox) sender;
            if (checkbos.Checked)
            {
                subTotal += .50m;
            }
            else
            {
                {
                    subTotal -=.50m;
                }
            }
            lblPizzaCost.Text = string.Format("{0:C}",subTotal);
        }

        private void updatTotal()
        {

            decimal Total = 0;
            foreach (var Pizza in Pizzas)
            {
                decimal subTotal;
                decimal.TryParse(Pizza[4], out subTotal);
                Total += subTotal;
            }
            lblTotal.Text = string.Format("{0:C}", Total);
        }

        private void brnAdd_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
            
            decimal price;
            string sPrice = lblPizzaCost.Text.Substring(1);
                if (decimal.TryParse(sPrice, out price))
                {
                    addPizza(cboPizzaSize.Text, cboPizzaType.Text, cboSlices.Text, getNotes(),
                        9.99m);
                    updateLst();
                    updatTotal();
                }

            }

    else
            {
            
               MessageBox.Show("Plese make sure that you have selected something from each dropdown", this.Text);
        }

        //TODO calculate cost of this pizza


        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //create a new for and pass the list of pizzas and 
            //this for to it via the constructor
            Report form2 = new Report(Pizzas, this);

            //show the new form
            form2.Show();

            //hide this form
            this.Visible = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstPizzaType.SelectedIndex > -1)
            {
                Pizzas.RemoveAt(lstPizzaType.SelectedIndex);
            updateLst();
            }

        }

        private void lstPizzaType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check that something is selected
            if (lstPizzaType.SelectedIndex > -1)
            {
                List<string> pizza = Pizzas[lstPizzaType.SelectedIndex];
                txtDisplayNotes.Text = pizza[3];
            }
        }

        private void cboPizzaSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            subTotal = 9.99m;
            lblPizzaCost.Text = string.Format("{0:C}", subTotal.ToString());
        }
    }
}
