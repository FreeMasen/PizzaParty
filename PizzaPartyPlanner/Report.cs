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
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Text (*.txt)|*.txt";
                saveFile.ShowDialog();
                string path = saveFile.FileName;
                File.WriteAllText(path, txtReport.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Name);
            }
            
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
                string nl = System.Environment.NewLine;
                foreach (List<string> za in Pizzas)
                {
                    string name = string.Format("{0} {1} {2}", za[0], za[1], nl);
                    string notes = string.Format("    {0} slices {1}    {2} {3}      {4:C}", za[2], nl, za[3], nl, za[4]);
                    txtReport.Text += name;
                    txtReport.Text += notes + nl;
                    totalCost += decimal.Parse(za[4]);
                }
                txtReport.Text += nl + "Total" + nl + "-----------" + nl;
                txtReport.Text += string.Format("{0:C}", totalCost.ToString());
            }
            catch (NullReferenceException)
            {
                txtReport.Text = "No Pizzas in this Plan";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Name);
            }
        }
    }
}
