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

namespace AssignmentGUI
{
    public partial class Form1 : Form
    {
        static string[] headers = new string[6];
        BindingList<Countries> countries = new BindingList<Countries>();

        public Form1()
        {
            InitializeComponent();

            const int MAX_LINES_FILE = 50000;
            string[] AllLines = new string[MAX_LINES_FILE];

            AllLines = File.ReadAllLines("countries.csv");

            foreach (string line in AllLines)
            {
                if (line.StartsWith("Country"))
                {
                    headers = line.Split(',');
                }
                else
                {
                    string[] columns = line.Split(',');
                    countries.Add(new Countries
                    {
                        Name = columns[0],
                        GdpGrowth = Convert.ToDouble(columns[1]),
                        Inflation = Convert.ToDouble(columns[2]),
                        TradeBalance = Convert.ToDouble(columns[3]),
                        HdiRank = Int32.Parse(columns[4]),
                        TradePartners = columns[5]
                    });
                }
            }

            listBox1.DataSource = countries;
            listBox1.ValueMember = "Name";
            listBox1.DisplayMember = "Name";

            this.listBox1.DataBindings.Add("Name", countries, "Name", true,
                DataSourceUpdateMode.OnPropertyChanged);
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            countries.RemoveAt(listBox1.SelectedIndex);
            updateView();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateView();
        }

        private void updateView()
        {
            gdpSelected.Text = countries[listBox1.SelectedIndex].GdpGrowth.ToString();
            inflationSelected.Text = countries[listBox1.SelectedIndex].Inflation.ToString();
            tradeSelected.Text = countries[listBox1.SelectedIndex].TradeBalance.ToString();
            hdiSelected.Text = countries[listBox1.SelectedIndex].HdiRank.ToString();
            listBox2.DataSource = countries[listBox1.SelectedIndex].TradingPartners;
        }

        
    }
}
