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
    public partial class txtNotes : Form
    {
        public txtNotes()
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

        private void brnAdd_Click(object sender, EventArgs e)
        {
            //TODO capture pizza infomration and add it to our gridview
            addPizza(cboPizzaSize.SelectedText, cboPizzaType.SelectedText, cboSlices, );
            //TODO calculate cost of this pizza
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //TODO create a form window that will pop-up when thsi is ckicked
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstPizzaType.SelectedIndex >-1)
            {
            
            lstPizzaType.Items.RemoveAt(lstPizzaType.SelectedIndex);
            }

        }

        private void lstPizzaType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check that something is selected
            if (lstPizzaType.SelectedIndex > -1)
            {
                //TODO update the txtbox to reflect the 
            }
        }
    }
}
