using System;
using System.Collections;
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
                if (line.StartsWith("Country"))
                {
                    headers = line.Split(',');
                }
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
        }

        private void bindListbox1()
        {
            listBox1.DataSource = new BindingSource(countries, null);
            listBox1.ValueMember = "Key";
            countriesCountLbl.Text = countries.Count.ToString();
            updateView();
            
            /*
            List<Countries> sortedList = countries.OrderBy(x => x.Name).ToList();
            countries = new BindingList<Countries>(sortedList);

            listBox1.DataSource = countries;
            listBox1.DisplayMember = "Name";
            countriesCountLbl.Text = listBox1.Items.Count.ToString();
            partnersCountLbl.Text = listBox2.Items.Count.ToString();
            */
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            /*
            countries.RemoveAt(listBox1.SelectedIndex);
            updateView();
            */
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateView();
        }

        private void updateView()
        {
            if (countries.ContainsKey(listBox1.SelectedValue.ToString()))
            {
                selectedCountry = countries[listBox1.SelectedValue.ToString()];
                listBox2.DataSource = selectedCountry.TradingPartners;
                partnersCountLbl.Text = listBox2.Items.Count.ToString();
                gdpBox.Text = selectedCountry.GdpGrowth.ToString();
                inflationBox.Text = selectedCountry.Inflation.ToString();
                tradeBalanceBox.Text = selectedCountry.TradeBalance.ToString();
                hdiBox.Text = selectedCountry.HdiRank.ToString();
            } 
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
            /*
            AddCountry ac = new AddCountry();
            ac.FormClosed += new FormClosedEventHandler(acClosed);
            ac.Show();
            */
        }

        void acClosed(object sender, FormClosedEventArgs e)
        {
            /*
            if(Program.newCountryName != "")
            {
                countries.Add(new Countries
                {
                    Name = Program.newCountryName,
                    GdpGrowth = 0,
                    Inflation = 0,
                    TradeBalance = 0,
                    HdiRank = 0,
                    TradePartners = "[none]"
                });

                Program.newCountryName = null;
                resortListbox1();
            }
            */
        }

        private void tradePAddBtn_Click(object sender, EventArgs e)
        {
            /*
            AddTradingPartner ap = new AddTradingPartner();
            ap.FormClosed += new FormClosedEventHandler(apClosed);
            ap.Show();
            */
        }

        void apClosed(object sender, FormClosedEventArgs e)
        {
            /*
            if(Program.newPartnerName != "" && Program.newPartnerName != null)
            {
                countries[listBox1.SelectedIndex].TradingPartners.Add(Program.newPartnerName);
                Program.newPartnerName = null;
                listBox2.DataSource = null;
                listBox2.DataSource = countries[listBox1.SelectedIndex].TradingPartners;
                partnersCountLbl.Text = listBox2.Items.Count.ToString();
            }
            */ 
        }

        private void tradePRemBtn_Click(object sender, EventArgs e)
        {
            /*
            if(listBox2.SelectedIndex != -1)
            {
                countries[listBox1.SelectedIndex].TradingPartners.RemoveAt(listBox2.SelectedIndex);
                listBox2.DataSource = null;
                listBox2.DataSource = countries[listBox1.SelectedIndex].TradingPartners;
                partnersCountLbl.Text = listBox2.Items.Count.ToString();
            }
            */
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
