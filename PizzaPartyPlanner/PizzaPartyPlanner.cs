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

        private void brnAdd_Click(object sender, EventArgs e)
        {
            //TODO add data validation
            addPizza(cboPizzaSize.SelectedText, cboPizzaType.SelectedText, cboSlices.SelectedText, getNotes(), Decimal.Parse(lblPizzaCost.Text));
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

        
    }
}
