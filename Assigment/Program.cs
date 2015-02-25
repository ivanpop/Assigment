using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileReadExample
{
    class Program
    {      
        static string[] headers = new string[6];	//column	headers

        static void Main(string[] args)
        {
            const int MAX_LINES_FILE = 50000;
            string[] AllLines = new string[MAX_LINES_FILE];
            List<Countries> countries = new List<Countries>();

            //reads	from	bin/DEBUG	subdirectory	of	project	directory
            AllLines = File.ReadAllLines("countries.csv");

            

            foreach (string line in AllLines)
            {
                if (line.StartsWith("Country"))	//found	first	line	- headers	
                {
                    headers = line.Split(',');
                }
                else
                {
                    string[] columns = line.Split(',');
                    countries.Add(new Countries { Name = columns[0], GdpGrowth = Convert.ToDouble(columns[1]), 
                        Inflation = Convert.ToDouble(columns[2]), TradeBalance = Convert.ToDouble(columns[3]), 
                        HdiRank = Int32.Parse(columns[4]), TradePartners = columns[5] });
                }
            }
            Console.ReadKey();
        }
    }
}