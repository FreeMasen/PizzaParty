using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaPartyPlanner
{
    public partial class Report : Form
    {
        public Report(List<List<string>> Pizzas, Form form1)
        {
            if (Pizzas != null)
            {
                this.Pizzas = Pizzas;
            }
            main = form1;
            InitializeComponent();
        }

        private List<List<string>> Pizzas;
        private Form main;

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            File.WriteAllText(path, txtReport.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Close();
            
        }

        private void Report_Load(object sender, EventArgs e)
        {
            try
            {
                decimal totalCost = 0;

                foreach (List<string> za in Pizzas)
                {
                    string name = string.Format("{0} {1} \n", za[1], za[2]);
                    string notes = string.Format("{0} slices \n {1} \n {2:C}", za[3], za[4], za[5]);
                    txtReport.Text += name;
                    txtReport.Text += notes;
                    totalCost += decimal.Parse(za[5]);
                }
                txtReport.Text += string.Format("\n {0:C}", totalCost.ToString());
            }
            catch (Exception)
            {
                txtReport.Text = "No Pizzas in this Plan";
            }
        }
    }
}
