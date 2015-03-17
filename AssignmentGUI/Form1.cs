using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AssignmentGUI
{
    public partial class Form1 : Form
    {
        static string[] headers = new string[6];
        SortedDictionary<string, Countries> countries = new SortedDictionary<string, Countries>();
        Countries selectedCountry = new Countries();

        public Form1()
        {
            InitializeComponent();

            const int MAX_LINES_FILE = 50000;
            string[] AllLines = new string[MAX_LINES_FILE];
            AllLines = File.ReadAllLines("countries.csv");

            foreach (string line in AllLines)
            {
                if (line.StartsWith("Country")) headers = line.Split(',');
                else
                {
                    string[] columns = line.Split(',');
                    countries.Add(columns[0], new Countries
                    {
                        GdpGrowth = Convert.ToDouble(columns[1]),
                        Inflation = Convert.ToDouble(columns[2]),
                        TradeBalance = Convert.ToDouble(columns[3]),
                        HdiRank = Int32.Parse(columns[4]),
                        TradePartners = columns[5]
                    });
                }
            }
            bindListbox1();
            //findTradePotential();
        }

        private void refreshListBox1()
        {
            listBox1.DataSource = new BindingSource(countries, null);
            listBox1.ValueMember = "Key";
        }

        private void bindListbox1()
        {
            refreshListBox1();
            updateView();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            countries.Remove(listBox1.SelectedValue.ToString());
            refreshListBox1();
            updateView();
        }

        private void updateView(object sender, EventArgs e)
        {
            if (countries.ContainsKey(listBox1.SelectedValue.ToString()))
                selectedCountry = countries[listBox1.SelectedValue.ToString()];

            listBox2.DataSource = selectedCountry.TradingPartners;
            partnersCountLbl.Text = listBox2.Items.Count.ToString();
            gdpBox.Text = selectedCountry.GdpGrowth.ToString();
            inflationBox.Text = selectedCountry.Inflation.ToString();
            tradeBalanceBox.Text = selectedCountry.TradeBalance.ToString();
            hdiBox.Text = selectedCountry.HdiRank.ToString();
            countriesCountLbl.Text = countries.Count.ToString();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            selectedCountry.GdpGrowth = Convert.ToDouble(gdpBox.Text);
            selectedCountry.Inflation = Convert.ToDouble(inflationBox.Text);
            selectedCountry.TradeBalance = Convert.ToDouble(tradeBalanceBox.Text);
            selectedCountry.HdiRank = Convert.ToInt32(hdiBox.Text);

            if (countries.ContainsKey(listBox1.SelectedValue.ToString()))
                countries[listBox1.SelectedValue.ToString()] = selectedCountry;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddCountry ac = new AddCountry();
            ac.FormClosed += new FormClosedEventHandler(acClosed);
            ac.Show();
        }

        void acClosed(object sender, FormClosedEventArgs e)
        {
            if (Program.newCountryName != null)
            {
                Program.newCountryName = Program.newCountryName.First().ToString().ToUpper() + String.Join("", Program.newCountryName.Skip(1));

                countries.Add(Program.newCountryName, new Countries
                {
                    GdpGrowth = 0,
                    Inflation = 0,
                    TradeBalance = 0,
                    HdiRank = 0,
                    TradePartners = "[none]"
                });

                Program.newCountryName = null;
                refreshListBox1();
            }
        }

        private void tradePAddBtn_Click(object sender, EventArgs e)
        {
            AddTradingPartner ap = new AddTradingPartner();
            ap.FormClosed += new FormClosedEventHandler(apClosed);
            ap.Show();
        }

        void apClosed(object sender, FormClosedEventArgs e)
        {
            if(Program.newPartnerName != "" && Program.newPartnerName != null)
            {
                selectedCountry.TradingPartners.Add(Program.newPartnerName);
                Program.newPartnerName = null;

                if (countries.ContainsKey(listBox1.SelectedValue.ToString()))
                    countries[listBox1.SelectedValue.ToString()] = selectedCountry;

                listBox2.DataSource = null;
                listBox2.DataSource = selectedCountry.TradingPartners;
                partnersCountLbl.Text = listBox2.Items.Count.ToString();
            }
        }

        private void tradePRemBtn_Click(object sender, EventArgs e)
        {
            if(listBox2.SelectedIndex != -1)
            {
                selectedCountry.TradingPartners.RemoveAt(listBox2.SelectedIndex);

                if (countries.ContainsKey(listBox1.SelectedValue.ToString()))
                    countries[listBox1.SelectedValue.ToString()] = selectedCountry;

                listBox2.DataSource = null;
                listBox2.DataSource = selectedCountry.TradingPartners;
                partnersCountLbl.Text = listBox2.Items.Count.ToString();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text != "")
            {
                if (searchBox.Text.Length == 1)
                {
                    searchBox.Text = searchBox.Text.ToString().ToUpper();
                    searchBox.Select(searchBox.Text.Length, 0);
                }

                var filtered = countries.Where(d => d.Key.Contains(searchBox.Text)).ToDictionary(d => d.Key, d => d.Value);

                if (filtered.Count > 0)
                {
                    listBox1.DataSource = new BindingSource(filtered, null);
                    listBox1.ValueMember = "Key";
                    noResultLbl.Visible = false;
                    resultsLbl.Visible = true;

                    if (filtered.Count == 1) resultsLbl.Text = filtered.Count + " match";
                    else resultsLbl.Text = filtered.Count + " matches";
                }
                else
                {
                    noResultLbl.Visible = true;
                    resultsLbl.Visible = false;
                }
            }
            else
            {
                refreshListBox1();
                resultsLbl.Visible = noResultLbl.Visible = false;                
            }
        }

        private void updateView()
        {

        }

        private void tpSearch_Click(object sender, EventArgs e)
        {
            string s = tpSearchBox.Text;
            BindingList<String> results = new BindingList<string>();

            foreach (var entry in countries)
                if (entry.Value.TradingPartners.Contains(s))
                    results.Add(entry.Key);

            if (results.Count == 0) results.Add("No matches");            

            tpResultBox.DataSource = results;
        }

        private void tpSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (tpSearchBox.Text.Length == 1)
            {
                tpSearchBox.Text = tpSearchBox.Text.ToString().ToUpper();
                tpSearchBox.Select(tpSearchBox.Text.Length, 0);
            }
        }

        private void findTradePotential()
        {
            double bestPotential = 0, tempPotential = 0;
            string bestCountry = "";
            Countries tempCountry = new Countries();            

            foreach(var entry1 in countries)
            {
                foreach(var entry2 in entry1.Value.TradingPartners)
                {   
                    if(countries.ContainsKey(entry2))
                    tempCountry = countries[entry2];

                    tempPotential += tempCountry.GdpGrowth;
                    if (tempPotential > bestPotential)
                    {
                        bestPotential = tempPotential;
                        bestCountry = entry1.Key;
                    }
                }
                tempPotential = 0;
            }

            potentialResLbl.Text = bestCountry;
        }

        private void refreshPotential_Click(object sender, EventArgs e)
        {
            findTradePotential();
        }
    }
}
